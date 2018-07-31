using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBC.ShopLib
{
    public static class Common
    {
        public static List<OrderClass> CurrentOrder;
        public static V83.COMConnector con;
        public static dynamic Base;

        public static void AddItem(this List<OrderClass> Order, string Code, string Title, decimal Price)
        {
            OrderClass o = Order.Find(x => x.Code == Code);
            if (o != null)
            {
                o.Quantity += 1;
            }
            else
            {
                Order.Add(new OrderClass { Code = Code, Title = Title, Quantity = 1, Price = Price });
            }
        }

        public static void MinusItem(this List<OrderClass> Order, string Code)
        {
            OrderClass o = Order.Find(x => x.Code == Code);
            if (o != null)
            {
                o.Quantity -= 1;
                if (o.Quantity <= 0)
                    Order.Remove(o);
            }
        }

        public static void DelAllItem(this List<OrderClass> Order, string Code)
        {
            OrderClass o = Order.Find(x => x.Code == Code);
            if (o != null)
            {
                Order.Remove(o);
            }
        }

        public static decimal OrderTotal(this List<OrderClass> Order)
        {
            decimal summ = 0m;
            foreach (OrderClass o in Order)
            {
                summ += o.Quantity * o.Price;
            }
            return summ;
        }

        public static decimal GetDiscount(string code)
        {
            decimal Discount = 0m;
            dynamic q = Base.NewObject("Query");
            q.Text =
                "select	ЕСТЬNULL(sum(ПроцентСкидкиНаценки), 0) as Discount " +
                "from РегистрСведений.СкидкиНаценкиНоменклатуры.СрезПоследних " +
                $"where Номенклатура.Код = \"{code}\" " +
                "and Активность ";
            dynamic r = q.Execute().Select();
            if (r.next())
            {
                Discount = Convert.ToDecimal(r.Discount);
            }
            return Discount;
        }

        public static List<OrderClass> NewOrder()
        {
            return new List<OrderClass>();
        }

        public static Image PictureFromBase64(string mainImage)
        {
            if ((mainImage != string.Empty) && (mainImage != null))
            {
                byte[] mb = Convert.FromBase64String(mainImage);
                using (MemoryStream ms = new MemoryStream(mb))
                {
                    try
                    {
                        return new Bitmap(Image.FromStream(ms));
                    }
                    catch (Exception) { }
                }
            }
            return null;
        }

        public static void Connect1C(string cs)
        {
            try
            {
                con = new V83.COMConnector
                {
                    PoolCapacity = 10,
                    PoolTimeout = 60,
                    MaxConnections = 2
                };
                Base = con.Connect(cs);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }
        }

        public static string FindCodeByBarcode(string barcode)
        {
            dynamic q = Base.NewObject("Query");
            q.Text =
                "select Barcode.Владелец.Код as Code " +
                "from InformationRegister.Штрихкоды КАК Barcode " +
                $"where Barcode.Штрихкод = \"{barcode}\" and not Barcode.Владелец.ЭтоГруппа ";
            dynamic r = q.Execute().Select();
            if (r.next())
                return r.Code;
            else
                return string.Empty;
        }

        public static List<Goods> FindGoods(string GroupCode)
        {
            string T = (GroupCode == string.Empty) ? "Родитель   = Значение(Catalog.Номенклатура.ПустаяСсылка) " : $"Родитель.Код  = \"{GroupCode}\" ";
            string T1 = (GroupCode == string.Empty) ? " " : $" and N.ЭтоГруппа or N.ОсновноеИзображение <> Значение(Catalog.ХранилищеДополнительнойИнформации.EmptyRef) ";
            try
            {
                List<Goods> G = new List<Goods>();
                dynamic q = Base.NewObject("Query");
                q.Text =
                "select " + Environment.NewLine +
                " N.Код as Code, " + Environment.NewLine +
                " N.Наименование as Title, " + Environment.NewLine +
                " N.ЭтоГруппа as Grp, " + Environment.NewLine +
                //" N.ОсновноеИзображение as MainImage, " +Environment.NewLine+
                " N.ДополнительноеОписаниеНоменклатуры as Description, " + Environment.NewLine +
                " N.Родитель.Родитель.Код as GrandParent, " + Environment.NewLine +
                " N.Родитель.Код as Parent " + Environment.NewLine +
                "into Y " + Environment.NewLine +
                "from Catalog.Номенклатура as N " + Environment.NewLine +
                $"where N.{T} {T1}" + Environment.NewLine +
                "and not N.DeletionMark; " + Environment.NewLine +

                "select " + Environment.NewLine +
                " N.Номенклатура.Код as Code, " + Environment.NewLine +
                " N.Цена as Price " + Environment.NewLine +
                "into P " + Environment.NewLine +
                "from РегистрСведений.ЦеныНоменклатуры.СрезПоследних as N " + Environment.NewLine +
                $"where N.Номенклатура.{T} and " + Environment.NewLine +
                "N.ТипЦен.Наименование = \"Розничная\"; " + Environment.NewLine +

                "select " + Environment.NewLine +
                "  N.Номенклатура.Код as Code, " + Environment.NewLine +
                "  sum(N.Количество) as Quantity " + Environment.NewLine +
                "into Q " + Environment.NewLine +
                "from РегистрНакопления.ТоварыНаСкладах as N " + Environment.NewLine +
                $"where N.Номенклатура.{T} " + Environment.NewLine +
                "group by N.Номенклатура.Код; " + Environment.NewLine +

                "select " + Environment.NewLine +
                " Y.*, " + Environment.NewLine +
                " ЕСТЬNULL(Q.Quantity, 0) as Quantity, " + Environment.NewLine +
                " ЕСТЬNULL(P.Price, 0) as Price " + Environment.NewLine +
                "from Y " + Environment.NewLine +
                "left join P " + Environment.NewLine +
                "on Y.Code = P.Code " + Environment.NewLine +
                "left join Q " + Environment.NewLine +
                "on P.Code = Q.Code " + Environment.NewLine +
                "where Y.Grp or ( " + Environment.NewLine +
                //"where Y.Grp or (Y.MainImage <> Значение(Catalog.ХранилищеДополнительнойИнформации.EmptyRef) " +Environment.NewLine+
                //"and " +Environment.NewLine+
                "P.Price <> 0 and Q.Quantity > 0) " + Environment.NewLine +
                "order by Y.Grp desc, Y.Code";

                dynamic r = q.Execute().Select();
                while (r.next())
                {
                    if (!r.Grp)
                    {
                        //string Image = Get1cMainPicture(r.MainImage);
                        G.Add(new Goods($"{r.Code}", r.Grp, $"{r.Title}", $"{r.Parent}", $"{r.GrandParent}", string.Empty/*Image*/,
                            r.Description, Convert.ToDecimal(r.Price), Convert.ToDecimal(r.Quantity)));
                    }
                    else
                    {
                        G.Add(new Goods($"{r.Code}", r.Grp, $"{r.Title}", $"{r.Parent}", $"{r.GrandParent}"));
                    }
                }
                return G;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return null;
            }
        }

        /// <summary>
        /// Получить основное изображение в виде массива base64
        /// </summary>
        /// <param name="mainImage">хранилище</param>
        /// <returns>изображение в массиве base64</returns>
        public static string Get1cMainPicture(dynamic mainImage)
        {
            var X0 = mainImage.Хранилище.Get();

            if (X0 != null)
            {
                return Base.Base64String(X0.GetBinaryData());
            }
            return string.Empty;
        }

        public static string GetImageMain(string code)
        {
            dynamic q = Base.Catalogs.Номенклатура.FindByCode(code).ОсновноеИзображение.Хранилище.Get();
            if (q != null)
            {
                return Base.Base64String(q.GetBinaryData());
            }
            return null;
        }
    }
}

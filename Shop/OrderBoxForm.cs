using HBC.ShopLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TenTec.Windows.iGridLib;

namespace Shop
{
    public partial class OrderBoxForm : Form
    {
        Wait W;

        public OrderBoxForm()
        {
            InitializeComponent();
            label1.Text = $"{0:C2}";
        }

        private void CalcTotal()
        {
            label1.Text = $"{Common.CurrentOrder.OrderTotal():C2}";
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (iGrid1.CurRow != null)
            {
                Common.CurrentOrder.AddItem(iGrid1.CurRow.Key, iGrid1.CurRow.Cells["Title"].ToString(), Convert.ToDecimal(iGrid1.CurRow.Cells["Price"].Value));
                iGrid1.CurRow.Cells["Quantity"].Value = Convert.ToDecimal(iGrid1.CurRow.Cells["Quantity"].Value) + 1;
                CalcSum(iGrid1.CurRow);
                CalcTotal();
            }
        }

        private void CalcSum(iGRow curRow)
        {
            if (curRow != null)
                curRow.Cells["Summ"].Value = Convert.ToDecimal(curRow.Cells["Quantity"].Value) * Convert.ToDecimal(curRow.Cells["Price"].Value);
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (iGrid1.CurRow != null)
            {
                Common.CurrentOrder.MinusItem(iGrid1.CurRow.Key);
                iGrid1.CurRow.Cells["Quantity"].Value = Convert.ToDecimal(iGrid1.CurRow.Cells["Quantity"].Value) - 1;
                if (Convert.ToDecimal(iGrid1.CurRow.Cells["Quantity"].Value) <= 0)
                {
                    iGrid1.Rows.RemoveAt(iGrid1.CurRow.Index);
                }
                else
                    CalcSum(iGrid1.CurRow);
                if (Common.CurrentOrder.Count == 0)
                {
                    Common.CurrentOrder = null;
                    DialogResult = DialogResult.Abort;
                }
                else
                    CalcTotal();
            }
        }

        private void All_Click(object sender, EventArgs e)
        {
            Common.CurrentOrder.DelAllItem(iGrid1.CurRow.Key);
            CalcTotal();
        }

        private void PayBTN_Click(object sender, EventArgs e)
        {
            // [todo] печать чека с генерацией штрихкода
            // [todo] электронная очередь

            // ввод номера телефона покупателя
            string Phone = string.Empty;
            phone F = new phone() { StartPosition = FormStartPosition.CenterParent };
            if (F.ShowDialog() == DialogResult.OK)
            {
                Bw2Params par = new Bw2Params()
                {
                    Base = Common.Base,
                    con = Common.con,
                    Phone = $"{F.Tag}",
                    GoodsList = Common.CurrentOrder
                };
                W = new Wait() { TopMost = true, StartPosition = FormStartPosition.CenterScreen };
                W.Show();
                backgroundWorker2.RunWorkerAsync(par);
            }
        }

        private string Make1COrder(dynamic Base, List<OrderClass> GoodsList, string Phone)
        {
            dynamic G11;

            dynamic org = Base.Catalogs.Организации.FindByDescription(Properties.Settings.Default.Organisation);
            dynamic Warehouse = Base.Catalogs.Склады.FindByDescription(Properties.Settings.Default.Warehouse);
            dynamic Cur = Base.Catalogs.Валюты.FindByDescription(Properties.Settings.Default.Currency).Ref;

            #region Контрагент
            dynamic counterparty = null;
            dynamic DC = null;
            string DocCode = string.Empty;

            if (Phone != string.Empty)
            {
                // поиск покупателя с таким телефоном
                counterparty = Base.Catalogs.Контрагенты.FindByDescription(Phone);
                if (counterparty == Base.Catalogs.Контрагенты.EmptyRef)
                {
                    try
                    {
                        counterparty = Base.Catalogs.Контрагенты.CreateItem();
                        counterparty.Наименование = Phone;
                        counterparty.Покупатель = true;
                        counterparty.Комментарий = Properties.Settings.Default.CounterpartyName;
                        counterparty.ЮрФизЛицо = Base.Enums.ЮрФизЛицо.ФизЛицо;
                        counterparty.Write();

                        dynamic rc1 = Base.InformationRegisters.КонтактнаяИнформация.CreateRecordManager();

                        rc1.Объект = counterparty.Ref;
                        rc1.Тип = Base.Enums.ТипыКонтактнойИнформации.Телефон;
                        rc1.Вид = Base.Catalogs.ВидыКонтактнойИнформации.FindByDescription(Properties.Settings.Default.CounterpartyPhone);
                        rc1.Представление = Phone;

                        rc1.Write();
                    }
                    catch (Exception err)
                    {
                        throw new Exception(err.Message);
                    }
                    #endregion
                }

                #region Договор с покупателем
                DC = Base.Catalogs.ДоговорыКонтрагентов.CreateItem();
                DC.Владелец = counterparty.Ref;
                DC.Организация = org.Ref;
                DC.Наименование = Properties.Settings.Default.Bill;
                DC.ВалютаВзаиморасчетов = Cur.Ref;
                DC.ВидДоговора = Base.Enums.ВидыДоговоровКонтрагентов.СПокупателем;
                DC.ВедениеВзаиморасчетов = Base.Enums.ВедениеВзаиморасчетовПоДоговорам.ПоЗаказам;

                DC.Write();
                #endregion
                //else
                //{
                //    DC = Base.Catalogs.ДоговорыКонтрагентов.FindByAttribute("Владелец",
                //        Base.NewObject("Structure", "ВидДоговора,  Организация", Base.Enums.ВидыДоговоровКонтрагентов.СПокупателем, org.Ref), counterparty);
                //}

                dynamic r1 = Base.Документы.ЗаказПокупателя.CreateDocument();
                r1.Комментарий = Properties.Settings.Default.Comment;
                r1.Дата = DateTime.Now;
                r1.Организация = org.Ref;
                r1.ВалютаДокумента = Cur.Ref;
                r1.СтруктурнаяЕдиница = org.ОсновнойБанковскийСчет;
                r1.СкладГруппа = Warehouse.Ref;
                r1.Контрагент = counterparty.Ref;
                r1.ДоговорКонтрагента = DC.Ref;
                r1.КратностьВзаиморасчетов = 1;
                r1.КурсВзаиморасчетов = 1m;

                #region Табличная часть (товары)
                try
                {
                    int max = GoodsList.Count;
                    int count = 10;
                    foreach (OrderClass G in GoodsList)
                    {
                        G11 = Base.Catalogs.Номенклатура.FindByDescription(G.Title);

                        dynamic r2 = r1.Товары.Add();

                        r2.Номенклатура = G11.Ref;
                        r2.Количество = 1;
                        r2.ЕдиницаИзмерения = Base.Catalogs.ЕдиницыИзмерения.FindByDescription(Properties.Settings.Default.Unit).Ref;
                        r2.Коэффициент = 1;
                        r2.Цена = 10.5;
                        r2.Цена = Base.InformationRegisters.ЦеныНоменклатуры.GetLast(DateTime.Now, Base.NewObject("Structure", "Номенклатура, ТипЦен", G11.Ref, Base.Catalogs.ТипыЦенНоменклатуры.FindByDescription(Properties.Settings.Default.PriceType))).Цена;
                        r2.Сумма = r2.Количество * r2.Цена;
                        backgroundWorker2.ReportProgress((int)(100 * (count++) / max));
                    }

                    r1.Write();
                    return r1.Номер;
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
                #endregion
            }
            return string.Empty;
        }

        private void BackgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            Bw2Params par = (Bw2Params)e.Argument;

            e.Result = Make1COrder(par.Base, par.GoodsList, par.Phone);
        }

        private void BackgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                DialogResult = DialogResult.Cancel;
                //backgroundWorker2.ReportProgress(0);
            }
            else
            {
                //backgroundWorker2.ReportProgress(100);
                W?.Close();
#if DEBUG
                // открываем временное окно 
                DebugResultWindow Df = new DebugResultWindow(e.Result.ToString()) { StartPosition = FormStartPosition.CenterScreen };
                if (Df.ShowDialog() == DialogResult.OK)
                {

                }
#endif
                DialogResult = DialogResult.OK;
            }
        }

        private void OrderBoxForm_Load(object sender, EventArgs e)
        {
            if (Common.CurrentOrder != null)
            {
                iGrid1.BeginUpdate();
                iGrid1.Cols[0].Width = (int)((iGrid1.Width - iGrid1.Margin.Left - iGrid1.Margin.Right) * 0.5);
                iGrid1.Cols[1].Width = (int)((iGrid1.Width - iGrid1.Margin.Left - iGrid1.Margin.Right) * 0.2);
                iGrid1.Cols[2].Width = (int)((iGrid1.Width - iGrid1.Margin.Left - iGrid1.Margin.Right) * 0.15);
                iGrid1.Cols[3].Width = (int)((iGrid1.Width - iGrid1.Margin.Left - iGrid1.Margin.Right) * 0.15);
                foreach (OrderClass o in Common.CurrentOrder)
                {
                    iGRow r = iGrid1.Rows.Add();
                    r.Key = o.Code;
                    r.Cells["Title"].Value = o.Title;
                    r.Cells["Price"].Value = o.Price;
                    r.Cells["Quantity"].Value = o.Quantity;
                    CalcSum(r);
                }
                iGrid1.Refresh();
                iGrid1.EndUpdate();
                CalcTotal();

            }
            else
            {
                DialogResult = DialogResult.Abort;
            }
        }

        private void ContinueShoping_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Retry;
        }

        private void DropOrder_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        struct Bw2Params
        {
            public V83.COMConnector con;
            public dynamic Base;
            public string Phone;
            public List<OrderClass> GoodsList;
        }

        private void BackgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }
    }
}

using HBC.ShopLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class OneGood : Form
    {
        Goods G;
        dynamic Base;

        public OneGood(Goods g, dynamic @base) : this()
        {
            G = g;
            Base = @base;
        }

        public OneGood()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            ControlBox = false;
            WindowState = FormWindowState.Maximized;
            Price.Text = string.Empty;
            Title.Text = string.Empty;
            Description.Text = string.Empty;
        }

        private void OneGood_Load(object sender, EventArgs e)
        {
            Order.Visible = (Common.CurrentOrder != null);
            string Filename = $"{Properties.Settings.Default.Cache}{G.Code}.M.jpg";
            if (File.Exists(Filename))
            {
                pictureBox1.Image = Image.FromFile(Filename);
            }
            //pictureBox1.Image = Common.PictureFromBase64(G.MainImage);
            Title.Text = G.Title;
            Description.Text = G.Description;
            //Description.Text = GetDescription(Base, G.Code);
            Price.Text = G.Price.ToString("C2");
            //Price.Text = GetPrice(Base, G.Code).ToString("C2");
            Cursor = Cursors.WaitCursor;
            flowLayoutPanel1.Visible = false;
            List<Image> p = GetAllPicturesforGoods(Base, G.Code);
            if (p.Count > 0)
            {
                int PWidth = flowLayoutPanel1.Width;
                int PHeight = flowLayoutPanel1.Height / p.Count;
                foreach (Image i in p)
                {
                    PictureBox pb = new PictureBox
                    {
                        Width = PWidth,
                        Height = PHeight,
                        Margin = new Padding(0, 0, 0, 0),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Image = i
                    };

                    pb.Click += Pb_Click;

                    flowLayoutPanel1.Controls.Add(pb);
                }
                flowLayoutPanel1.Visible = true;

            }
            Cursor = Cursors.Default;
        }

        private void Pb_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (sender as PictureBox).Image;
        }

        private List<Image> GetAllPicturesforGoods(dynamic @base, string code)
        {
            List<Image> ret = new List<Image>();
            try
            {
                if (!Directory.Exists(Properties.Settings.Default.Cache + code))
                {
                    Directory.CreateDirectory(Properties.Settings.Default.Cache + code);
                    dynamic q = @base.NewObject("Query");
                    q.Text =
                        "select " +
                        "X.Хранилище " +
                        "from Справочник.ХранилищеДополнительнойИнформации КАК X " +
                        "where  X.Объект.Код = &Code   and not X.DeletionMark ";
                    q.УстановитьПараметр("Code", code);
                    dynamic r = q.Выполнить().Выбрать();
                    int count = 0;
                    while (r.next())
                    {
                        dynamic rr = r.Хранилище.Get();
                        if (rr != null)
                        {
                            Image I = Common.PictureFromBase64(@base.Base64String(rr.GetBinaryData()));
                            string Filename = Properties.Settings.Default.Cache + code  + "\\" + $"{count++}.jpg";
                            I.Save(Filename);
                            ret.Add(I);
                        }
                    }
            }
                else
                {
                foreach (string s in Directory.GetFiles(Properties.Settings.Default.Cache + code))
                {
                    ret.Add(Image.FromFile(s));
                }
            }
        }
            catch (Exception err)
            {
                MessageBox.Show($"{err.Message}");
            }
            return ret;
        }

        private void Dismith_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }

        private void ToBox_Click(object sender, EventArgs e)
        {
            if (Common.CurrentOrder == null)
            {
                Common.CurrentOrder = Common.NewOrder();
            }
            Common.CurrentOrder.AddItem(G.Code, G.Title, G.Price);
            Order.Visible = (Common.CurrentOrder != null);

            DialogResult = DialogResult.Abort;
        }

        private void Order_Click(object sender, EventArgs e)
        {
            Hide();
            OrderBoxForm f = new OrderBoxForm() { WindowState = FormWindowState.Maximized/*, MdiParent = MdiParent*/ };
            DialogResult Result = f.ShowDialog();
            //switch (Result)
            //{
            //    case DialogResult.OK:
            //        MessageBox.Show("Печать чека? передача в 1С");
            //        Common.CurrentOrder = null;
            //        break;
            //    case DialogResult.Cancel:
            //        Common.CurrentOrder = null;
            //        break;
            //    case DialogResult.Retry:
            //        break;
            //    default:
            //        break;
            //}
            Order.Visible = (Common.CurrentOrder != null);
            DialogResult = Result;
        }
    }
}

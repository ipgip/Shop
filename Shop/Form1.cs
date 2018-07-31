using HBC.ShopLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Form1 : Form
    {
        List<Goods> GoodsList = null;
        private StringBuilder buf = new StringBuilder();
        Splash SplashForm = null;

        public Form1()
        {
            SplashForm = new Splash { StartPosition = FormStartPosition.CenterScreen, TopMost = true };
            if (Properties.Settings.Default.Splash)
                SplashForm.Show();

            InitializeComponent();
            goodsPanel1.PicturePath = Properties.Settings.Default.Cache;
        }

        private List<Goods> GetGoods(string GroupCode)
        {
            Cursor = Cursors.WaitCursor;
            List<Goods> G = Common.FindGoods(GroupCode);

            Cursor = Cursors.Default;

            return G;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            goodsPanel1.Visible = false;
            Common.Connect1C(Properties.Settings.Default.CS);

            GoodsList = GetGoods(string.Empty);
            goodsPanel1.SetGoodsList(GoodsList);
            goodsPanel1.Visible = true;
            button1.Focus();
            SplashForm?.Hide(); //закрытие Splash
        }

        private void GoodsPanel1_GetGroup(object sender, StringEventArgs e)
        {
            if (Properties.Settings.Default.Splash)
                SplashForm.Show();
            goodsPanel1.Visible = false;
            GoodsList = GetGoods(e.Value);
            goodsPanel1.SetGoodsList(GoodsList);
            goodsPanel1.Visible = true;
            SplashForm?.Hide(); //закрытие Splash
        }

        private void GoodsPanel1_DisplayGoods(object sender, StringEventArgs e)
        {
            goodsPanel1.Visible = false;
            DisplayOneGoods(GoodsList?.Find(x => x.Code == e.Value));
            goodsPanel1.Visible = true;
        }

        private void DisplayOneGoods(Goods G)
        {
            if (G != null)
            {
                goodsPanel1.Visible = false;
                OneGood f = new OneGood(G, Common.Base) { WindowState = FormWindowState.Maximized/*, MdiParent = this*/ };

                DialogResult Result = f.ShowDialog();
                ProcessingResult(Result);
                goodsPanel1.Visible = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Marshal.ReleaseComObject(Common.Base);
            Marshal.ReleaseComObject(Common.con);
            GC.Collect();
        }

        public void GoodsPanel1_OrderBoxEvt(object sender, EventArgs e)
        {
            //Cursor = Cursors.WaitCursor;
            goodsPanel1.Visible = false;
            OrderBoxForm f = new OrderBoxForm() { WindowState = FormWindowState.Maximized/*, MdiParent = this*/ };

            DialogResult Result = f.ShowDialog();
            ProcessingResult(Result);
            goodsPanel1.Visible = true;
            //Cursor = Cursors.Default;
        }

        private void ProcessingResult(DialogResult Result)
        {
            switch (Result)
            {
                case DialogResult.OK:
                    //MessageBox.Show("Печать чека? передача в 1С");
                    Common.CurrentOrder = null;
                    GoodsList = GetGoods(string.Empty);
                    goodsPanel1.SetGoodsList(GoodsList);
                    break;
                case DialogResult.Cancel:
                    Common.CurrentOrder = null;
                    GoodsList = GetGoods(string.Empty);
                    goodsPanel1.SetGoodsList(GoodsList);
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.None:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
            button1.Focus();
        }

        private void GoodsPanel1_KeyPressed(object sender, StringEventArgs e)
        {
            if (e.Value.Length > 0)
            {
                if ((e.Value[0] == (char)Keys.Enter || (e.Value[0] == (char)Keys.Return)) && (buf.Length > 0))
                {
                    DisplayGoodsByBarcode(buf.ToString());

                    buf = new StringBuilder();
                }
                else
                {
                    if (char.IsDigit(e.Value[0]))
                    {
                        buf.Append(e.Value.ToString());
                    }
                }
            }
        }

        public void DisplayGoodsByBarcode(string Barcode)
        {
            string Code = Common.FindCodeByBarcode(Barcode);
            if (Code != string.Empty)
            {
                List<Goods> G = Common.FindGoods(Code);
                if (G.Count() > 0)
                    DisplayOneGoods(G.First());
            }
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            GoodsPanel1_KeyPressed(sender, new StringEventArgs(((char)e.KeyCode).ToString()));
        }
    }
}

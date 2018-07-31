using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace HBC.ShopLib
{
    public partial class Calculator : UserControl
    {
        private event EventHandler<Info> _AddInfo;
        public decimal Rest;
        private bool KKT = false;
        private decimal _Total;

        [Category("IGP"), Description("Признак парльного ввода")]
        public bool Password { get; set; } = false;

        [Category("IGP"), Description("Максимальная сумма")]
        public decimal Total
        {
            get { return _Total; }
            set
            {
                _Total = value;
                IsTotal();
            }
        }

        [Category("IGP"), Description("Нажатие на кнопку переноса")]
        public event EventHandler<Info> AddInfo
        {
            add => _AddInfo += value;
            remove => _AddInfo -= value;
        }

        private void OnAddInfo(string Info)
        {
            _AddInfo?.Invoke(this, new Info(((Info == String.Empty) || (Info == ".")) ? 0 : Decimal.Parse(Info)));
        }

        public Calculator()
        {
            InitializeComponent();
            button2.Text = Application.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            KKT = false;
            //label1.Text = String.Empty;
            //label2.Text = String.Empty;
            //label3.Text = String.Empty;
            button1.Enabled = true;
        }

        //public Calculator(decimal T) : this()
        //{
        //    label1.Visible = true;
        //    label2.Visible = true;
        //    label3.Visible = true;
        //    _Total = T;
        //    KKT = true;
        //    label2.Text = _Total.ToString("C");
        //    Rest = _Total;// -Decimal.Parse(label1.Text);
        //    label3.ForeColor = (Rest >= 0) ? Color.FromArgb(255, 128, 0) : Color.Green;
        //    label3.Text = Rest.ToString("C");
        //    Avaible_AddInfo();
        //}

        public void IsTotal()
        {
            label1.Visible = true;
            label2.Visible = (_Total != 0);
            label3.Visible = (_Total != 0);
            KKT = true;
            label2.Text = _Total.ToString("C");
            Rest = _Total;// -Decimal.Parse(label1.Text);
            label3.ForeColor = (Rest >= 0) ? Color.FromArgb(255, 128, 0) : Color.Green;
            label3.Text = Rest.ToString("C");
            Avaible_AddInfo();
        }

        private void BTNOne_Click(object sender, EventArgs e)
        {
            label1.Text += (sender as Button).Text;
            if (Password)
                label2.Text += "*";
            if (KKT)
            {
                label2.Text = _Total.ToString("C");
                Rest = _Total - Decimal.Parse((label1.Text == ".") ? "0." : label1.Text, NumberStyles.Float);
                label3.ForeColor = (Rest >= 0) ? Color.FromArgb(255, 128, 0) : Color.Green;
                label3.Text = Rest.ToString("C");
            }
            Avaible_AddInfo();
            label1.Focus();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OnAddInfo(label1.Text);
            Clear();
            label1.Focus();
        }

        public void Clear()
        {
            label1.Text = String.Empty;
            label2.Text = (!Password) ? (_Total != 0) ? _Total.ToString("C") : String.Empty : String.Empty;
            label3.Text = String.Empty;
            if (KKT)
            {
                Rest = 0;
                label2.Text = String.Empty;
                label3.Text = String.Empty;
                //button1.Enabled = (Rest > 0);
            }
            Avaible_AddInfo();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string s = label1.Text.Substring(0, (label1.Text.Length > 0) ? label1.Text.Length - 1 : 0);
            label1.Text = s;
            if (Password)
                label2.Text = label2.Text.Substring(0, (label2.Text.Length > 0) ? label2.Text.Length - 1 : 0);
            if (KKT)
            {
                label2.Text = _Total.ToString("C");
                Rest = _Total - Decimal.Parse((label1.Text == String.Empty) ? "0" : label1.Text);
                label3.Text = Rest.ToString("C");
                //button1.Enabled = (Rest > 0);
            }
            Avaible_AddInfo();
            label1.Focus();
        }

        private void Avaible_AddInfo()
        {
            if (!Password)
            {
                if (label1.Text != String.Empty)
                    button1.Enabled = true;// (Decimal.Parse(label1.Text) > 0) && (Rest <= 0);//!(Rest > 0);
                else
                    button1.Enabled = false;
            }
            else
            {
                button1.Enabled = (label1.Text.Length > 0);
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                label1.Text = String.Empty;
                label2.Text = String.Empty;
                label3.Text = String.Empty;
                if (Password)
                {
                    label2.Text = String.Empty;
                    button1.Text = "OK";
                    KKT = false;
                    label1.Visible = false;
                    label2.Visible = true;
                    label3.Visible = false;
                }
                //else
                //{
                //    label1.Visible = true;
                //    label2.Text = string.Empty;
                //    label2.Visible = true;
                //    label3.Visible = true;
                //    label3.Text = string.Empty;
                //}
            }
        }
    }

    public class Info : EventArgs
    {
        public decimal Value { get; }

        public Info(decimal p)
        {
            this.Value = p;
        }
    }

}

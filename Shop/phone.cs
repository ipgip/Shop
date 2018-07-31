using HBC.ShopLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shop
{
    public partial class phone : Form
    {
        public string ClientsPhone = string.Empty;

        public phone()
        {
            InitializeComponent();
        }

        private void Calculator1_AddInfo(object sender, Info e)
        {
            string p = e.Value.ToString();
            if (p.Length < 11)
            {
                MessageBox.Show("Введите, пожалуйста телефон в формате 7СССXXXXXXX");
                calculator1.Clear();
            }
            else
            {
                Tag = e.Value.ToString();
                DialogResult = DialogResult.OK;
            }
        }
    }
}

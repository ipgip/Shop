using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HBC.ShopLib
{
    public partial class PB : UserControl
    {
        #region События
        [Category("HBC")]
        public event EventHandler<HBC.ShopLib.StringEventArgs> KeyPressed;

        [Category("HBC")]
        public new event EventHandler<HBC.ShopLib.StringEventArgs> Click;
        #endregion

        #region Свойства
        private bool _Grp = false;

        [Category("HBC")]
        public Image Image
        {
            set => picture.Image = value ?? Properties.Resources.bazby;
            get => picture.Image;
        }

        [Category("HBC")]
        public string Title { set => Caption.Text = value; get => Caption.Text; }

        [Category("HBC")]
        public bool Grp
        {
            set
            {
                _Grp = value;
                picture.Image = (_Grp) ? Properties.Resources.Folder : Image;
            }
            get { return _Grp; }
        }
        #endregion

        public PB()
        {
            InitializeComponent();
            //Dock = DockStyle.Fill;
        }

        private void PictureButton_Load(object sender, EventArgs e)
        {
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            Click?.Invoke(this, new HBC.ShopLib.StringEventArgs(Tag.ToString()));
        }

        private void Caption_Click(object sender, EventArgs e)
        {
            Click?.Invoke(this, new HBC.ShopLib.StringEventArgs(Tag.ToString()));
        }

        private void Picture_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            KeyPressed?.Invoke(this, new StringEventArgs(e.KeyCode.ToString()));
        }
    }
}

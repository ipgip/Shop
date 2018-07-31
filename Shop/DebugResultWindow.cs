using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.Rendering;

namespace Shop
{
    public partial class DebugResultWindow : Form
    {
        string Code;

        public DebugResultWindow(string code) : this()
        {
            Code = code;
        }

        public DebugResultWindow()
        {
            InitializeComponent();
        }

        private void DebugResultWindow_Load(object sender, EventArgs e)
        {
            if (Code != string.Empty)
            {
                try
                {
                    var writer = new BarcodeWriter
                    {
                        Format = BarcodeFormat.EAN_13,
                        Options = new EncodingOptions
                        {
                            Height = pictureBox1.Height,
                            Width = pictureBox1.Width
                        },
                        Renderer = (IBarcodeRenderer<Bitmap>)Activator.CreateInstance(typeof(BitmapRenderer))
                    };
                    pictureBox1.Image = writer.Write("000" + Code.Substring(2));
                }
                catch (Exception exc)
                {
                    MessageBox.Show(this, exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}

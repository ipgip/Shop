namespace Shop
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.goodsPanel1 = new HBC.ShopLib.GoodsPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            // 
            // goodsPanel1
            // 
            this.goodsPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goodsPanel1.ColumnCount = 4;
            this.goodsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goodsPanel1.Location = new System.Drawing.Point(0, 0);
            this.goodsPanel1.Name = "goodsPanel1";
            this.goodsPanel1.PicturePath = "pictures";
            this.goodsPanel1.RowCount = 3;
            this.goodsPanel1.Size = new System.Drawing.Size(828, 377);
            this.goodsPanel1.TabIndex = 0;
            this.goodsPanel1.KeyPressed += new System.EventHandler<HBC.ShopLib.StringEventArgs>(this.GoodsPanel1_KeyPressed);
            this.goodsPanel1.DisplayGoods += new System.EventHandler<HBC.ShopLib.StringEventArgs>(this.GoodsPanel1_DisplayGoods);
            this.goodsPanel1.OrderBoxEvt += new System.EventHandler(this.GoodsPanel1_OrderBoxEvt);
            this.goodsPanel1.GetGroup += new System.EventHandler<HBC.ShopLib.StringEventArgs>(this.GoodsPanel1_GetGroup);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(828, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.goodsPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.ResumeLayout(false);

        }
        #endregion

        private HBC.ShopLib.GoodsPanel goodsPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}


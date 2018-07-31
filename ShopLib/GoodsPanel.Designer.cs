namespace HBC.ShopLib
{
    partial class GoodsPanel
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsPanel));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LeftBTN = new System.Windows.Forms.Button();
            this.RightBTN = new System.Windows.Forms.Button();
            this.UpBTN = new System.Windows.Forms.Button();
            this.OrderBoxBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 272);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TableLayoutPanel1_PreviewKeyDown);
            // 
            // LeftBTN
            // 
            this.LeftBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftBTN.BackColor = System.Drawing.SystemColors.Control;
            this.LeftBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftBTN.BackgroundImage")));
            this.LeftBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftBTN.FlatAppearance.BorderSize = 0;
            this.LeftBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftBTN.Location = new System.Drawing.Point(0, 278);
            this.LeftBTN.Margin = new System.Windows.Forms.Padding(0);
            this.LeftBTN.Name = "LeftBTN";
            this.LeftBTN.Size = new System.Drawing.Size(101, 71);
            this.LeftBTN.TabIndex = 1;
            this.LeftBTN.UseVisualStyleBackColor = false;
            this.LeftBTN.Click += new System.EventHandler(this.LeftBTN_Click);
            this.LeftBTN.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TableLayoutPanel1_PreviewKeyDown);
            // 
            // RightBTN
            // 
            this.RightBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RightBTN.BackColor = System.Drawing.SystemColors.Control;
            this.RightBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RightBTN.BackgroundImage")));
            this.RightBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RightBTN.FlatAppearance.BorderSize = 0;
            this.RightBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightBTN.Location = new System.Drawing.Point(380, 278);
            this.RightBTN.Margin = new System.Windows.Forms.Padding(0);
            this.RightBTN.Name = "RightBTN";
            this.RightBTN.Size = new System.Drawing.Size(104, 71);
            this.RightBTN.TabIndex = 2;
            this.RightBTN.UseVisualStyleBackColor = false;
            this.RightBTN.Click += new System.EventHandler(this.RightBTN_Click);
            this.RightBTN.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TableLayoutPanel1_PreviewKeyDown);
            // 
            // UpBTN
            // 
            this.UpBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpBTN.BackColor = System.Drawing.SystemColors.Control;
            this.UpBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpBTN.BackgroundImage")));
            this.UpBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpBTN.FlatAppearance.BorderSize = 0;
            this.UpBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpBTN.Location = new System.Drawing.Point(239, 278);
            this.UpBTN.Margin = new System.Windows.Forms.Padding(0);
            this.UpBTN.Name = "UpBTN";
            this.UpBTN.Size = new System.Drawing.Size(141, 71);
            this.UpBTN.TabIndex = 3;
            this.UpBTN.UseVisualStyleBackColor = false;
            this.UpBTN.Click += new System.EventHandler(this.UpBTN_Click);
            this.UpBTN.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TableLayoutPanel1_PreviewKeyDown);
            // 
            // OrderBoxBTN
            // 
            this.OrderBoxBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OrderBoxBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OrderBoxBTN.BackgroundImage")));
            this.OrderBoxBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OrderBoxBTN.FlatAppearance.BorderSize = 0;
            this.OrderBoxBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderBoxBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderBoxBTN.Location = new System.Drawing.Point(104, 278);
            this.OrderBoxBTN.Name = "OrderBoxBTN";
            this.OrderBoxBTN.Size = new System.Drawing.Size(132, 71);
            this.OrderBoxBTN.TabIndex = 4;
            this.OrderBoxBTN.UseVisualStyleBackColor = true;
            this.OrderBoxBTN.Click += new System.EventHandler(this.OrderBoxBTN_Click);
            this.OrderBoxBTN.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TableLayoutPanel1_PreviewKeyDown);
            // 
            // GoodsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OrderBoxBTN);
            this.Controls.Add(this.UpBTN);
            this.Controls.Add(this.RightBTN);
            this.Controls.Add(this.LeftBTN);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GoodsPanel";
            this.Size = new System.Drawing.Size(484, 349);
            this.Load += new System.EventHandler(this.GoodsPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button LeftBTN;
        private System.Windows.Forms.Button RightBTN;
        private System.Windows.Forms.Button UpBTN;
        private System.Windows.Forms.Button OrderBoxBTN;
    }
}

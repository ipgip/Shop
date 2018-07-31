namespace Shop
{
    partial class OrderBoxForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TenTec.Windows.iGridLib.iGColPattern iGColPattern1 = new TenTec.Windows.iGridLib.iGColPattern();
            TenTec.Windows.iGridLib.iGColPattern iGColPattern2 = new TenTec.Windows.iGridLib.iGColPattern();
            TenTec.Windows.iGridLib.iGColPattern iGColPattern3 = new TenTec.Windows.iGridLib.iGColPattern();
            TenTec.Windows.iGridLib.iGColPattern iGColPattern4 = new TenTec.Windows.iGridLib.iGColPattern();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderBoxForm));
            this.iGrid1Col1CellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
            this.iGrid1Col1ColHdrStyle = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
            this.iGrid1Col2CellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
            this.iGrid1Col2ColHdrStyle = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
            this.iGrid1Col3CellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
            this.iGrid1Col3ColHdrStyle = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
            this.iGrid1Col4CellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
            this.iGrid1Col4ColHdrStyle = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iGrid1 = new TenTec.Windows.iGridLib.iGrid();
            this.iGrid1DefaultCellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
            this.iGrid1DefaultColHdrStyle = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
            this.iGrid1RowTextColCellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
            this.Del = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.DropOrder = new System.Windows.Forms.Button();
            this.ContinueShoping = new System.Windows.Forms.Button();
            this.PayBTN = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // iGrid1Col1CellStyle
            // 
            this.iGrid1Col1CellStyle.TextAlign = TenTec.Windows.iGridLib.iGContentAlignment.MiddleLeft;
            this.iGrid1Col1CellStyle.TextFormatFlags = TenTec.Windows.iGridLib.iGStringFormatFlags.WordWrap;
            // 
            // iGrid1Col1ColHdrStyle
            // 
            this.iGrid1Col1ColHdrStyle.TextAlign = TenTec.Windows.iGridLib.iGContentAlignment.MiddleCenter;
            // 
            // iGrid1Col2CellStyle
            // 
            this.iGrid1Col2CellStyle.TextAlign = TenTec.Windows.iGridLib.iGContentAlignment.MiddleCenter;
            // 
            // iGrid1Col2ColHdrStyle
            // 
            this.iGrid1Col2ColHdrStyle.TextAlign = TenTec.Windows.iGridLib.iGContentAlignment.MiddleCenter;
            // 
            // iGrid1Col3CellStyle
            // 
            this.iGrid1Col3CellStyle.FormatString = "{0:C2}";
            this.iGrid1Col3CellStyle.TextAlign = TenTec.Windows.iGridLib.iGContentAlignment.MiddleRight;
            this.iGrid1Col3CellStyle.ValueType = typeof(decimal);
            // 
            // iGrid1Col3ColHdrStyle
            // 
            this.iGrid1Col3ColHdrStyle.TextAlign = TenTec.Windows.iGridLib.iGContentAlignment.MiddleCenter;
            // 
            // iGrid1Col4CellStyle
            // 
            this.iGrid1Col4CellStyle.FormatString = "{0:C2}";
            this.iGrid1Col4CellStyle.TextAlign = TenTec.Windows.iGridLib.iGContentAlignment.MiddleRight;
            this.iGrid1Col4CellStyle.ValueType = typeof(decimal);
            // 
            // iGrid1Col4ColHdrStyle
            // 
            this.iGrid1Col4ColHdrStyle.TextAlign = TenTec.Windows.iGridLib.iGContentAlignment.MiddleCenter;
            this.iGrid1Col4ColHdrStyle.TextFormatFlags = TenTec.Windows.iGridLib.iGStringFormatFlags.DirectionRightToLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.875F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.iGrid1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Del, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Plus, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DropOrder, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ContinueShoping, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.PayBTN, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.54363F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.45637F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 363);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(699, 84);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(565, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(556, 84);
            this.label2.TabIndex = 1;
            this.label2.Text = "Итого";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iGrid1
            // 
            iGColPattern1.CellStyle = this.iGrid1Col1CellStyle;
            iGColPattern1.ColHdrStyle = this.iGrid1Col1ColHdrStyle;
            iGColPattern1.Key = "Title";
            iGColPattern1.Text = "Наименование";
            iGColPattern1.Width = 238;
            iGColPattern2.CellStyle = this.iGrid1Col2CellStyle;
            iGColPattern2.ColHdrStyle = this.iGrid1Col2ColHdrStyle;
            iGColPattern2.Key = "Quantity";
            iGColPattern2.Text = "Количество";
            iGColPattern2.Width = 200;
            iGColPattern3.CellStyle = this.iGrid1Col3CellStyle;
            iGColPattern3.ColHdrStyle = this.iGrid1Col3ColHdrStyle;
            iGColPattern3.Key = "Price";
            iGColPattern3.Text = "Цена";
            iGColPattern3.Width = 116;
            iGColPattern4.CellStyle = this.iGrid1Col4CellStyle;
            iGColPattern4.ColHdrStyle = this.iGrid1Col4ColHdrStyle;
            iGColPattern4.Key = "Summ";
            iGColPattern4.Text = "Сумма";
            iGColPattern4.Width = 137;
            this.iGrid1.Cols.AddRange(new TenTec.Windows.iGridLib.iGColPattern[] {
            iGColPattern1,
            iGColPattern2,
            iGColPattern3,
            iGColPattern4});
            this.iGrid1.DefaultAutoGroupRow.Height = 22;
            this.iGrid1.DefaultCol.AllowGrouping = false;
            this.iGrid1.DefaultCol.AllowMoving = false;
            this.iGrid1.DefaultCol.AllowSizing = false;
            this.iGrid1.DefaultCol.CellStyle = this.iGrid1DefaultCellStyle;
            this.iGrid1.DefaultCol.ColHdrStyle = this.iGrid1DefaultColHdrStyle;
            this.iGrid1.DefaultRow.Height = 37;
            this.iGrid1.DefaultRow.NormalCellHeight = 37;
            this.iGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iGrid1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.iGrid1.Header.BackColor = System.Drawing.Color.Gainsboro;
            this.iGrid1.Header.DrawSystem = false;
            this.iGrid1.Header.Height = 34;
            this.iGrid1.Header.HGridLinesStyle = new TenTec.Windows.iGridLib.iGPenStyle(System.Drawing.SystemColors.ControlDarkDark, 1, System.Drawing.Drawing2D.DashStyle.Solid);
            this.iGrid1.Header.SeparatingLine = new TenTec.Windows.iGridLib.iGPenStyle(System.Drawing.SystemColors.ControlDarkDark, 1, System.Drawing.Drawing2D.DashStyle.Solid);
            this.iGrid1.Header.VGridLinesStyle = new TenTec.Windows.iGridLib.iGPenStyle(System.Drawing.SystemColors.ControlDarkDark, 1, System.Drawing.Drawing2D.DashStyle.Solid);
            this.iGrid1.Location = new System.Drawing.Point(3, 3);
            this.iGrid1.Name = "iGrid1";
            this.iGrid1.ReadOnly = true;
            this.iGrid1.RowMode = true;
            this.iGrid1.RowSelectionInCellMode = TenTec.Windows.iGridLib.iGRowSelectionInCellModeTypes.SingleRow;
            this.tableLayoutPanel1.SetRowSpan(this.iGrid1, 4);
            this.iGrid1.RowTextCol.CellStyle = this.iGrid1RowTextColCellStyle;
            this.iGrid1.Size = new System.Drawing.Size(699, 354);
            this.iGrid1.TabIndex = 0;
            this.iGrid1.TreeCol = null;
            this.iGrid1.TreeLines.Color = System.Drawing.SystemColors.WindowText;
            // 
            // iGrid1DefaultColHdrStyle
            // 
            this.iGrid1DefaultColHdrStyle.TextAlign = TenTec.Windows.iGridLib.iGContentAlignment.MiddleCenter;
            // 
            // Del
            // 
            this.Del.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Del.BackgroundImage")));
            this.Del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Del.FlatAppearance.BorderSize = 0;
            this.Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Del.Location = new System.Drawing.Point(705, 0);
            this.Del.Margin = new System.Windows.Forms.Padding(0);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(95, 90);
            this.Del.TabIndex = 2;
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Plus
            // 
            this.Plus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Plus.BackgroundImage")));
            this.Plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Plus.FlatAppearance.BorderSize = 0;
            this.Plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plus.Location = new System.Drawing.Point(705, 90);
            this.Plus.Margin = new System.Windows.Forms.Padding(0);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(95, 90);
            this.Plus.TabIndex = 4;
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // DropOrder
            // 
            this.DropOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DropOrder.BackgroundImage")));
            this.DropOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DropOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DropOrder.FlatAppearance.BorderSize = 0;
            this.DropOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropOrder.Location = new System.Drawing.Point(705, 180);
            this.DropOrder.Margin = new System.Windows.Forms.Padding(0);
            this.DropOrder.Name = "DropOrder";
            this.DropOrder.Size = new System.Drawing.Size(95, 90);
            this.DropOrder.TabIndex = 9;
            this.DropOrder.UseVisualStyleBackColor = true;
            this.DropOrder.Click += new System.EventHandler(this.DropOrder_Click);
            // 
            // ContinueShoping
            // 
            this.ContinueShoping.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ContinueShoping.BackgroundImage")));
            this.ContinueShoping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContinueShoping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContinueShoping.FlatAppearance.BorderSize = 0;
            this.ContinueShoping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContinueShoping.Location = new System.Drawing.Point(705, 270);
            this.ContinueShoping.Margin = new System.Windows.Forms.Padding(0);
            this.ContinueShoping.Name = "ContinueShoping";
            this.ContinueShoping.Size = new System.Drawing.Size(95, 90);
            this.ContinueShoping.TabIndex = 8;
            this.ContinueShoping.UseVisualStyleBackColor = true;
            this.ContinueShoping.Click += new System.EventHandler(this.ContinueShoping_Click);
            // 
            // PayBTN
            // 
            this.PayBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PayBTN.BackgroundImage")));
            this.PayBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PayBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PayBTN.FlatAppearance.BorderSize = 0;
            this.PayBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PayBTN.Location = new System.Drawing.Point(705, 360);
            this.PayBTN.Margin = new System.Windows.Forms.Padding(0);
            this.PayBTN.Name = "PayBTN";
            this.PayBTN.Size = new System.Drawing.Size(95, 90);
            this.PayBTN.TabIndex = 7;
            this.PayBTN.UseVisualStyleBackColor = true;
            this.PayBTN.Click += new System.EventHandler(this.PayBTN_Click);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker2_RunWorkerCompleted);
            // 
            // OrderBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderBoxForm";
            this.ShowInTaskbar = false;
            this.Text = "OrderBoxForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderBoxForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TenTec.Windows.iGridLib.iGrid iGrid1;
        private TenTec.Windows.iGridLib.iGCellStyle iGrid1DefaultCellStyle;
        private TenTec.Windows.iGridLib.iGColHdrStyle iGrid1DefaultColHdrStyle;
        private TenTec.Windows.iGridLib.iGCellStyle iGrid1RowTextColCellStyle;
        private TenTec.Windows.iGridLib.iGCellStyle iGrid1Col1CellStyle;
        private TenTec.Windows.iGridLib.iGColHdrStyle iGrid1Col1ColHdrStyle;
        private TenTec.Windows.iGridLib.iGCellStyle iGrid1Col2CellStyle;
        private TenTec.Windows.iGridLib.iGColHdrStyle iGrid1Col2ColHdrStyle;
        private TenTec.Windows.iGridLib.iGCellStyle iGrid1Col3CellStyle;
        private TenTec.Windows.iGridLib.iGColHdrStyle iGrid1Col3ColHdrStyle;
        private TenTec.Windows.iGridLib.iGCellStyle iGrid1Col4CellStyle;
        private TenTec.Windows.iGridLib.iGColHdrStyle iGrid1Col4ColHdrStyle;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PayBTN;
        private System.Windows.Forms.Button DropOrder;
        private System.Windows.Forms.Button ContinueShoping;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}
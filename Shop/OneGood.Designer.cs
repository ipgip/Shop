namespace Shop
{
    partial class OneGood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OneGood));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ToBox = new System.Windows.Forms.Button();
            this.Dismith = new System.Windows.Forms.Button();
            this.Order = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Title, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Price, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Description, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(799, 383);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 3);
            this.pictureBox1.Size = new System.Drawing.Size(313, 377);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(481, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(315, 69);
            this.Title.TabIndex = 1;
            this.Title.Text = "label1";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.Location = new System.Drawing.Point(481, 347);
            this.Price.Name = "Price";
            this.Price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Price.Size = new System.Drawing.Size(315, 36);
            this.Price.TabIndex = 2;
            this.Price.Text = "label1";
            this.Price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description.Location = new System.Drawing.Point(481, 69);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(315, 278);
            this.Description.TabIndex = 3;
            this.Description.Text = "label1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(322, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.tableLayoutPanel1.SetRowSpan(this.flowLayoutPanel1, 3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(153, 377);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // ToBox
            // 
            this.ToBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ToBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ToBox.BackgroundImage")));
            this.ToBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToBox.FlatAppearance.BorderSize = 0;
            this.ToBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToBox.Location = new System.Drawing.Point(0, 386);
            this.ToBox.Name = "ToBox";
            this.ToBox.Size = new System.Drawing.Size(92, 65);
            this.ToBox.TabIndex = 0;
            this.ToBox.UseVisualStyleBackColor = true;
            this.ToBox.Click += new System.EventHandler(this.ToBox_Click);
            // 
            // Dismith
            // 
            this.Dismith.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Dismith.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Dismith.BackgroundImage")));
            this.Dismith.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dismith.FlatAppearance.BorderSize = 0;
            this.Dismith.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dismith.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dismith.Location = new System.Drawing.Point(707, 386);
            this.Dismith.Name = "Dismith";
            this.Dismith.Size = new System.Drawing.Size(92, 65);
            this.Dismith.TabIndex = 1;
            this.Dismith.UseVisualStyleBackColor = true;
            this.Dismith.Click += new System.EventHandler(this.Dismith_Click);
            // 
            // Order
            // 
            this.Order.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Order.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Order.BackgroundImage")));
            this.Order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Order.FlatAppearance.BorderSize = 0;
            this.Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Order.Location = new System.Drawing.Point(355, 386);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(107, 65);
            this.Order.TabIndex = 2;
            this.Order.TabStop = false;
            this.Order.UseVisualStyleBackColor = true;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // OneGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.Dismith);
            this.Controls.Add(this.ToBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OneGood";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "OneGood";
            this.Load += new System.EventHandler(this.OneGood_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Button ToBox;
        private System.Windows.Forms.Button Dismith;
        private System.Windows.Forms.Button Order;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
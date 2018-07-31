namespace HBC.ShopLib
{
    partial class Calculator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.BTNZerro = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BTNSeven = new System.Windows.Forms.Button();
            this.BTNEight = new System.Windows.Forms.Button();
            this.BTNNine = new System.Windows.Forms.Button();
            this.BTNFour = new System.Windows.Forms.Button();
            this.BTNFive = new System.Windows.Forms.Button();
            this.BTNSix = new System.Windows.Forms.Button();
            this.BTNOne = new System.Windows.Forms.Button();
            this.BTNTwo = new System.Windows.Forms.Button();
            this.BTNThree = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(335, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 111);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.Text = "<<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BTNZerro
            // 
            this.BTNZerro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNZerro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNZerro.Location = new System.Drawing.Point(169, 348);
            this.BTNZerro.Name = "BTNZerro";
            this.BTNZerro.Size = new System.Drawing.Size(160, 111);
            this.BTNZerro.TabIndex = 2;
            this.BTNZerro.TabStop = false;
            this.BTNZerro.Text = "0";
            this.BTNZerro.UseVisualStyleBackColor = true;
            this.BTNZerro.Click += new System.EventHandler(this.BTNOne_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(3, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 111);
            this.button3.TabIndex = 4;
            this.button3.TabStop = false;
            this.button3.Text = "BS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.BTNSeven, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTNEight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BTNZerro, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BTNNine, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTNFour, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTNFive, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTNSix, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTNOne, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BTNTwo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BTNThree, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 462);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BTNSeven
            // 
            this.BTNSeven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNSeven.Location = new System.Drawing.Point(3, 3);
            this.BTNSeven.Name = "BTNSeven";
            this.BTNSeven.Size = new System.Drawing.Size(160, 109);
            this.BTNSeven.TabIndex = 0;
            this.BTNSeven.TabStop = false;
            this.BTNSeven.Text = "7";
            this.BTNSeven.UseVisualStyleBackColor = true;
            this.BTNSeven.Click += new System.EventHandler(this.BTNOne_Click);
            // 
            // BTNEight
            // 
            this.BTNEight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNEight.Location = new System.Drawing.Point(169, 3);
            this.BTNEight.Name = "BTNEight";
            this.BTNEight.Size = new System.Drawing.Size(160, 109);
            this.BTNEight.TabIndex = 1;
            this.BTNEight.TabStop = false;
            this.BTNEight.Text = "8";
            this.BTNEight.UseVisualStyleBackColor = true;
            this.BTNEight.Click += new System.EventHandler(this.BTNOne_Click);
            // 
            // BTNNine
            // 
            this.BTNNine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNNine.Location = new System.Drawing.Point(335, 3);
            this.BTNNine.Name = "BTNNine";
            this.BTNNine.Size = new System.Drawing.Size(162, 109);
            this.BTNNine.TabIndex = 2;
            this.BTNNine.TabStop = false;
            this.BTNNine.Text = "9";
            this.BTNNine.UseVisualStyleBackColor = true;
            this.BTNNine.Click += new System.EventHandler(this.BTNOne_Click);
            // 
            // BTNFour
            // 
            this.BTNFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNFour.Location = new System.Drawing.Point(3, 118);
            this.BTNFour.Name = "BTNFour";
            this.BTNFour.Size = new System.Drawing.Size(160, 109);
            this.BTNFour.TabIndex = 3;
            this.BTNFour.TabStop = false;
            this.BTNFour.Text = "4";
            this.BTNFour.UseVisualStyleBackColor = true;
            this.BTNFour.Click += new System.EventHandler(this.BTNOne_Click);
            // 
            // BTNFive
            // 
            this.BTNFive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNFive.Location = new System.Drawing.Point(169, 118);
            this.BTNFive.Name = "BTNFive";
            this.BTNFive.Size = new System.Drawing.Size(160, 109);
            this.BTNFive.TabIndex = 4;
            this.BTNFive.TabStop = false;
            this.BTNFive.Text = "5";
            this.BTNFive.UseVisualStyleBackColor = true;
            this.BTNFive.Click += new System.EventHandler(this.BTNOne_Click);
            // 
            // BTNSix
            // 
            this.BTNSix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNSix.Location = new System.Drawing.Point(335, 118);
            this.BTNSix.Name = "BTNSix";
            this.BTNSix.Size = new System.Drawing.Size(162, 109);
            this.BTNSix.TabIndex = 5;
            this.BTNSix.TabStop = false;
            this.BTNSix.Text = "6";
            this.BTNSix.UseVisualStyleBackColor = true;
            this.BTNSix.Click += new System.EventHandler(this.BTNOne_Click);
            // 
            // BTNOne
            // 
            this.BTNOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNOne.Location = new System.Drawing.Point(3, 233);
            this.BTNOne.Name = "BTNOne";
            this.BTNOne.Size = new System.Drawing.Size(160, 109);
            this.BTNOne.TabIndex = 6;
            this.BTNOne.TabStop = false;
            this.BTNOne.Text = "1";
            this.BTNOne.UseVisualStyleBackColor = true;
            this.BTNOne.Click += new System.EventHandler(this.BTNOne_Click);
            // 
            // BTNTwo
            // 
            this.BTNTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNTwo.Location = new System.Drawing.Point(169, 233);
            this.BTNTwo.Name = "BTNTwo";
            this.BTNTwo.Size = new System.Drawing.Size(160, 109);
            this.BTNTwo.TabIndex = 7;
            this.BTNTwo.TabStop = false;
            this.BTNTwo.Text = "2";
            this.BTNTwo.UseVisualStyleBackColor = true;
            this.BTNTwo.Click += new System.EventHandler(this.BTNOne_Click);
            // 
            // BTNThree
            // 
            this.BTNThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNThree.Location = new System.Drawing.Point(335, 233);
            this.BTNThree.Name = "BTNThree";
            this.BTNThree.Size = new System.Drawing.Size(162, 109);
            this.BTNThree.TabIndex = 8;
            this.BTNThree.TabStop = false;
            this.BTNThree.Text = "3";
            this.BTNThree.UseVisualStyleBackColor = true;
            this.BTNThree.Click += new System.EventHandler(this.BTNOne_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(0, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 88);
            this.button2.TabIndex = 3;
            this.button2.TabStop = false;
            this.button2.Text = ",";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(4, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Name = "Calculator";
            this.Size = new System.Drawing.Size(499, 496);
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BTNSeven;
        private System.Windows.Forms.Button BTNEight;
        private System.Windows.Forms.Button BTNNine;
        private System.Windows.Forms.Button BTNFour;
        private System.Windows.Forms.Button BTNFive;
        private System.Windows.Forms.Button BTNSix;
        private System.Windows.Forms.Button BTNOne;
        private System.Windows.Forms.Button BTNTwo;
        private System.Windows.Forms.Button BTNThree;
        private System.Windows.Forms.Button BTNZerro;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

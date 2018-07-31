using HBC.ShopLib;

namespace Shop
{
    partial class phone
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
            this.calculator1 = new HBC.ShopLib.Calculator();
            this.SuspendLayout();
            // 
            // calculator1
            // 
            this.calculator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculator1.Location = new System.Drawing.Point(0, 0);
            this.calculator1.Name = "calculator1";
            this.calculator1.Password = false;
            this.calculator1.Size = new System.Drawing.Size(475, 414);
            this.calculator1.TabIndex = 0;
            this.calculator1.Total = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.calculator1.AddInfo += new System.EventHandler<HBC.ShopLib.Info>(this.Calculator1_AddInfo);
            // 
            // phone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 414);
            this.ControlBox = false;
            this.Controls.Add(this.calculator1);
            this.Name = "phone";
            this.Text = "Номер телефона в формате 7СССХХХХХХХ";
            this.ResumeLayout(false);

        }

        #endregion

        private Calculator calculator1;
    }
}
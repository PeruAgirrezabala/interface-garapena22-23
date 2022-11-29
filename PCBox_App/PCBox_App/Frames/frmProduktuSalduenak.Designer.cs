namespace PCBox_App
{
    partial class frmProduktuSalduenak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduktuSalduenak));
            this.lblErabiltzailea = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gProduktuSalduenak1 = new DLLProduktuSalduenak.gProduktuSalduenak();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblErabiltzailea
            // 
            this.lblErabiltzailea.AutoSize = true;
            this.lblErabiltzailea.BackColor = System.Drawing.Color.LightGreen;
            this.lblErabiltzailea.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErabiltzailea.Location = new System.Drawing.Point(529, 68);
            this.lblErabiltzailea.Name = "lblErabiltzailea";
            this.lblErabiltzailea.Size = new System.Drawing.Size(0, 31);
            this.lblErabiltzailea.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PCBox_App.Properties.Resources.logoabeltza;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::PCBox_App.Properties.Resources.verdeclaritoPCBox;
            this.pictureBox2.Location = new System.Drawing.Point(316, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(415, 31);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // gProduktuSalduenak1
            // 
            this.gProduktuSalduenak1.Location = new System.Drawing.Point(29, 183);
            this.gProduktuSalduenak1.Name = "gProduktuSalduenak1";
            this.gProduktuSalduenak1.Size = new System.Drawing.Size(738, 450);
            this.gProduktuSalduenak1.TabIndex = 40;
            this.gProduktuSalduenak1.Load += new System.EventHandler(this.gProduktuSalduenak1_Load);
            // 
            // frmProduktuSalduenak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 660);
            this.Controls.Add(this.gProduktuSalduenak1);
            this.Controls.Add(this.lblErabiltzailea);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProduktuSalduenak";
            this.Text = "Produktu Salduenak";
            this.Load += new System.EventHandler(this.frmProduktuSalduenak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblErabiltzailea;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DLLProduktuSalduenak.gProduktuSalduenak gProduktuSalduenak1;
    }
}
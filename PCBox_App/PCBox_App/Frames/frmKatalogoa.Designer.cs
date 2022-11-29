namespace PCBox_App.Frames
{
    partial class frmKatalogoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKatalogoa));
            this.lblErabiltzailea = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgProduktuak = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduktuak)).BeginInit();
            this.SuspendLayout();
            // 
            // lblErabiltzailea
            // 
            this.lblErabiltzailea.AutoSize = true;
            this.lblErabiltzailea.BackColor = System.Drawing.Color.LightGreen;
            this.lblErabiltzailea.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErabiltzailea.Location = new System.Drawing.Point(591, 114);
            this.lblErabiltzailea.Name = "lblErabiltzailea";
            this.lblErabiltzailea.Size = new System.Drawing.Size(0, 31);
            this.lblErabiltzailea.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PCBox_App.Properties.Resources.logoabeltza;
            this.pictureBox1.Location = new System.Drawing.Point(62, 44);
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
            this.pictureBox2.Location = new System.Drawing.Point(378, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(415, 31);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgProduktuak);
            this.panel1.Location = new System.Drawing.Point(62, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 388);
            this.panel1.TabIndex = 40;
            // 
            // dgProduktuak
            // 
            this.dgProduktuak.BackgroundColor = System.Drawing.Color.White;
            this.dgProduktuak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduktuak.Location = new System.Drawing.Point(3, 3);
            this.dgProduktuak.Name = "dgProduktuak";
            this.dgProduktuak.Size = new System.Drawing.Size(725, 382);
            this.dgProduktuak.TabIndex = 0;
            // 
            // frmKatalogoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 688);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblErabiltzailea);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKatalogoa";
            this.Text = "Produktuen Katalogoa";
            this.Load += new System.EventHandler(this.frmKatalogoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduktuak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblErabiltzailea;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgProduktuak;
    }
}
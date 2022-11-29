namespace PCBox_App
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblOngiEtorri = new System.Windows.Forms.Label();
            this.lblErabiltzailea = new System.Windows.Forms.Label();
            this.lblPasahitza = new System.Windows.Forms.Label();
            this.txtErabiltzailea = new System.Windows.Forms.TextBox();
            this.txtPasahitza = new System.Windows.Forms.TextBox();
            //Pasahitzaren objektuan erabiltzaileak idatzitakoa * bezela agertzeko.
            this.txtPasahitza.PasswordChar = '*';

            this.btnHasiSaioa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOngiEtorri
            // 
            this.lblOngiEtorri.AutoSize = true;
            this.lblOngiEtorri.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOngiEtorri.Location = new System.Drawing.Point(150, 296);
            this.lblOngiEtorri.Name = "lblOngiEtorri";
            this.lblOngiEtorri.Size = new System.Drawing.Size(278, 55);
            this.lblOngiEtorri.TabIndex = 1;
            this.lblOngiEtorri.Text = "Ongi Etorri !";
            // 
            // lblErabiltzailea
            // 
            this.lblErabiltzailea.AutoSize = true;
            this.lblErabiltzailea.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErabiltzailea.Location = new System.Drawing.Point(182, 378);
            this.lblErabiltzailea.Name = "lblErabiltzailea";
            this.lblErabiltzailea.Size = new System.Drawing.Size(145, 29);
            this.lblErabiltzailea.TabIndex = 2;
            this.lblErabiltzailea.Text = "Erabiltzailea";
            // 
            // lblPasahitza
            // 
            this.lblPasahitza.AutoSize = true;
            this.lblPasahitza.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasahitza.Location = new System.Drawing.Point(182, 442);
            this.lblPasahitza.Name = "lblPasahitza";
            this.lblPasahitza.Size = new System.Drawing.Size(116, 29);
            this.lblPasahitza.TabIndex = 3;
            this.lblPasahitza.Text = "Pasahitza";
            // 
            // txtErabiltzailea
            // 
            this.txtErabiltzailea.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtErabiltzailea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErabiltzailea.Location = new System.Drawing.Point(186, 405);
            this.txtErabiltzailea.Name = "txtErabiltzailea";
            this.txtErabiltzailea.Size = new System.Drawing.Size(334, 29);
            this.txtErabiltzailea.TabIndex = 4;
            // 
            // txtPasahitza
            // 
            this.txtPasahitza.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPasahitza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasahitza.Location = new System.Drawing.Point(186, 469);
            this.txtPasahitza.Name = "txtPasahitza";
            this.txtPasahitza.Size = new System.Drawing.Size(334, 29);
            this.txtPasahitza.TabIndex = 5;
            // 
            // btnHasiSaioa
            // 
            this.btnHasiSaioa.BackColor = System.Drawing.Color.Transparent;
            this.btnHasiSaioa.BackgroundImage = global::PCBox_App.Properties.Resources.verdePCBox;
            this.btnHasiSaioa.Location = new System.Drawing.Point(186, 539);
            this.btnHasiSaioa.Name = "btnHasiSaioa";
            this.btnHasiSaioa.Size = new System.Drawing.Size(334, 36);
            this.btnHasiSaioa.TabIndex = 6;
            this.btnHasiSaioa.Text = "HASI SAIOA";
            this.btnHasiSaioa.UseVisualStyleBackColor = false;
            this.btnHasiSaioa.Click += new System.EventHandler(this.btnHasiSaioa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PCBox_App.Properties.Resources.logoabeltza;
            this.pictureBox1.Location = new System.Drawing.Point(160, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 651);
            this.Controls.Add(this.btnHasiSaioa);
            this.Controls.Add(this.txtPasahitza);
            this.Controls.Add(this.txtErabiltzailea);
            this.Controls.Add(this.lblPasahitza);
            this.Controls.Add(this.lblErabiltzailea);
            this.Controls.Add(this.lblOngiEtorri);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblOngiEtorri;
        private System.Windows.Forms.Label lblErabiltzailea;
        private System.Windows.Forms.Label lblPasahitza;
        private System.Windows.Forms.TextBox txtErabiltzailea;
        private System.Windows.Forms.TextBox txtPasahitza;
        private System.Windows.Forms.Button btnHasiSaioa;
    }
}


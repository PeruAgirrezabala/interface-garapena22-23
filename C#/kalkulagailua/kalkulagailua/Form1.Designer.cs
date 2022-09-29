namespace kalkulagailua
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtzenb2 = new System.Windows.Forms.TextBox();
            this.txtzenb1 = new System.Windows.Forms.TextBox();
            this.btng = new System.Windows.Forms.Button();
            this.btnz = new System.Windows.Forms.Button();
            this.btnb = new System.Windows.Forms.Button();
            this.btnk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtzenb2
            // 
            this.txtzenb2.Location = new System.Drawing.Point(551, 108);
            this.txtzenb2.Name = "txtzenb2";
            this.txtzenb2.Size = new System.Drawing.Size(187, 23);
            this.txtzenb2.TabIndex = 0;
            // 
            // txtzenb1
            // 
            this.txtzenb1.Location = new System.Drawing.Point(120, 108);
            this.txtzenb1.Name = "txtzenb1";
            this.txtzenb1.Size = new System.Drawing.Size(187, 23);
            this.txtzenb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtzenb1_KeyPress);
            // 
            // btng
            // 
            this.btng.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btng.Location = new System.Drawing.Point(139, 178);
            this.btng.Name = "btng";
            this.btng.Size = new System.Drawing.Size(104, 68);
            this.btng.TabIndex = 2;
            this.btng.Text = "+";
            this.btng.UseVisualStyleBackColor = true;
            this.btng.Click += new System.EventHandler(this.btng_Click);
            // 
            // btnz
            // 
            this.btnz.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnz.Location = new System.Drawing.Point(591, 325);
            this.btnz.Name = "btnz";
            this.btnz.Size = new System.Drawing.Size(104, 68);
            this.btnz.TabIndex = 3;
            this.btnz.Text = ":";
            this.btnz.UseVisualStyleBackColor = true;
            this.btnz.Click += new System.EventHandler(this.btnz_Click);
            // 
            // btnb
            // 
            this.btnb.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnb.Location = new System.Drawing.Point(139, 325);
            this.btnb.Name = "btnb";
            this.btnb.Size = new System.Drawing.Size(104, 68);
            this.btnb.TabIndex = 4;
            this.btnb.Text = "x";
            this.btnb.UseVisualStyleBackColor = true;
            this.btnb.Click += new System.EventHandler(this.btnb_Click);
            // 
            // btnk
            // 
            this.btnk.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnk.Location = new System.Drawing.Point(591, 178);
            this.btnk.Name = "btnk";
            this.btnk.Size = new System.Drawing.Size(104, 68);
            this.btnk.TabIndex = 5;
            this.btnk.Text = "-";
            this.btnk.UseVisualStyleBackColor = true;
            this.btnk.Click += new System.EventHandler(this.btnk_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(332, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "ITXI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnk);
            this.Controls.Add(this.btnb);
            this.Controls.Add(this.btnz);
            this.Controls.Add(this.btng);
            this.Controls.Add(this.txtzenb1);
            this.Controls.Add(this.txtzenb2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtzenb2;
        private TextBox txtzenb1;
        private Button btng;
        private Button btnz;
        private Button btnb;
        private Button btnk;
        private Button button1;
    }
}
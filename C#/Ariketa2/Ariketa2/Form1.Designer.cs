namespace Ariketa2
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
            this.buttonH = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.buttonG = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonH
            // 
            this.buttonH.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonH.Location = new System.Drawing.Point(38, 235);
            this.buttonH.Name = "buttonH";
            this.buttonH.Size = new System.Drawing.Size(189, 49);
            this.buttonH.TabIndex = 0;
            this.buttonH.Text = "Hurrengoa";
            this.buttonH.UseVisualStyleBackColor = true;
            this.buttonH.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonI
            // 
            this.buttonI.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonI.Location = new System.Drawing.Point(557, 235);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(189, 49);
            this.buttonI.TabIndex = 1;
            this.buttonI.Text = "Irten";
            this.buttonI.UseVisualStyleBackColor = true;
            this.buttonI.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonG
            // 
            this.buttonG.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonG.Location = new System.Drawing.Point(306, 235);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(189, 49);
            this.buttonG.TabIndex = 2;
            this.buttonG.Text = "Garbitu";
            this.buttonG.UseVisualStyleBackColor = true;
            this.buttonG.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(306, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 23);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(72, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "1.Zenbakia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 340);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonG);
            this.Controls.Add(this.buttonI);
            this.Controls.Add(this.buttonH);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonH;
        private Button buttonI;
        private Button buttonG;
        private TextBox textBox1;
        private Label label1;
    }
}
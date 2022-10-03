namespace Ariketa_3
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
            this.nanBox = new System.Windows.Forms.TextBox();
            this.soldataBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.emailaBox = new System.Windows.Forms.TextBox();
            this.abizenaBox = new System.Windows.Forms.TextBox();
            this.izenaBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // nanBox
            // 
            this.nanBox.Location = new System.Drawing.Point(177, 55);
            this.nanBox.Name = "nanBox";
            this.nanBox.Size = new System.Drawing.Size(100, 23);
            this.nanBox.TabIndex = 0;
            // 
            // soldataBox
            // 
            this.soldataBox.Location = new System.Drawing.Point(538, 308);
            this.soldataBox.Name = "soldataBox";
            this.soldataBox.Size = new System.Drawing.Size(100, 23);
            this.soldataBox.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(538, 358);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 2;
            // 
            // emailaBox
            // 
            this.emailaBox.Location = new System.Drawing.Point(177, 183);
            this.emailaBox.Name = "emailaBox";
            this.emailaBox.Size = new System.Drawing.Size(100, 23);
            this.emailaBox.TabIndex = 3;
            // 
            // abizenaBox
            // 
            this.abizenaBox.Location = new System.Drawing.Point(177, 136);
            this.abizenaBox.Name = "abizenaBox";
            this.abizenaBox.Size = new System.Drawing.Size(100, 23);
            this.abizenaBox.TabIndex = 4;
            // 
            // izenaBox
            // 
            this.izenaBox.Location = new System.Drawing.Point(177, 94);
            this.izenaBox.Name = "izenaBox";
            this.izenaBox.Size = new System.Drawing.Size(100, 23);
            this.izenaBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "NAN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "IZENA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "ABIZENA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "EMAILA";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(53, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 116);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.izenaBox);
            this.Controls.Add(this.abizenaBox);
            this.Controls.Add(this.emailaBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.soldataBox);
            this.Controls.Add(this.nanBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nanBox;
        private TextBox soldataBox;
        private TextBox textBox3;
        private TextBox emailaBox;
        private TextBox abizenaBox;
        private TextBox izenaBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckedListBox checkedListBox1;
        private ComboBox comboBox1;
        private Label label5;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
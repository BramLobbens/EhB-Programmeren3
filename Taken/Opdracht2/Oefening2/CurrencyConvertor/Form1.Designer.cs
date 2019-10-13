namespace CurrencyConvertor
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.usdField = new System.Windows.Forms.TextBox();
            this.gbpField = new System.Windows.Forms.TextBox();
            this.eurField = new System.Windows.Forms.TextBox();
            this.jpyField = new System.Windows.Forms.TextBox();
            this.inrField = new System.Windows.Forms.TextBox();
            this.chfField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "GBP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "EUR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "JPY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "INR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "CHF";
            // 
            // usdField
            // 
            this.usdField.Location = new System.Drawing.Point(110, 31);
            this.usdField.Name = "usdField";
            this.usdField.Size = new System.Drawing.Size(100, 20);
            this.usdField.TabIndex = 6;
            this.usdField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.usdField.TextChanged += new System.EventHandler(this.usdField_TextChanged);
            // 
            // gbpField
            // 
            this.gbpField.Location = new System.Drawing.Point(110, 57);
            this.gbpField.Name = "gbpField";
            this.gbpField.Size = new System.Drawing.Size(100, 20);
            this.gbpField.TabIndex = 7;
            this.gbpField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gbpField.TextChanged += new System.EventHandler(this.gbpField_TextChanged);
            // 
            // eurField
            // 
            this.eurField.Location = new System.Drawing.Point(110, 83);
            this.eurField.Name = "eurField";
            this.eurField.Size = new System.Drawing.Size(100, 20);
            this.eurField.TabIndex = 8;
            this.eurField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.eurField.TextChanged += new System.EventHandler(this.eurField_TextChanged);
            // 
            // jpyField
            // 
            this.jpyField.Location = new System.Drawing.Point(110, 109);
            this.jpyField.Name = "jpyField";
            this.jpyField.Size = new System.Drawing.Size(100, 20);
            this.jpyField.TabIndex = 9;
            this.jpyField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jpyField.TextChanged += new System.EventHandler(this.jpyField_TextChanged);
            // 
            // inrField
            // 
            this.inrField.Location = new System.Drawing.Point(110, 135);
            this.inrField.Name = "inrField";
            this.inrField.Size = new System.Drawing.Size(100, 20);
            this.inrField.TabIndex = 10;
            this.inrField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inrField.TextChanged += new System.EventHandler(this.inrField_TextChanged);
            // 
            // chfField
            // 
            this.chfField.Location = new System.Drawing.Point(110, 161);
            this.chfField.Name = "chfField";
            this.chfField.Size = new System.Drawing.Size(100, 20);
            this.chfField.TabIndex = 11;
            this.chfField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chfField.TextChanged += new System.EventHandler(this.chfField_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 213);
            this.Controls.Add(this.chfField);
            this.Controls.Add(this.inrField);
            this.Controls.Add(this.jpyField);
            this.Controls.Add(this.eurField);
            this.Controls.Add(this.gbpField);
            this.Controls.Add(this.usdField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CurrencyConvertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox usdField;
        private System.Windows.Forms.TextBox gbpField;
        private System.Windows.Forms.TextBox eurField;
        private System.Windows.Forms.TextBox jpyField;
        private System.Windows.Forms.TextBox inrField;
        private System.Windows.Forms.TextBox chfField;
    }
}


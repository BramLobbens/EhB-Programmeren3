namespace Oefening1
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
            this.int_Field = new System.Windows.Forms.TextBox();
            this.intStapel_ItemField = new System.Windows.Forms.TextBox();
            this.intStapel_Field = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.string_Field = new System.Windows.Forms.TextBox();
            this.stringStapel_ItemField = new System.Windows.Forms.TextBox();
            this.title_Field = new System.Windows.Forms.TextBox();
            this.bookStapel_ItemField = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date_Field = new System.Windows.Forms.TextBox();
            this.author_Field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stringStapel_Field = new System.Windows.Forms.TextBox();
            this.bookStapel_Field = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // int_Field
            // 
            this.int_Field.Location = new System.Drawing.Point(58, 12);
            this.int_Field.Name = "int_Field";
            this.int_Field.Size = new System.Drawing.Size(100, 20);
            this.int_Field.TabIndex = 0;
            // 
            // intStapel_ItemField
            // 
            this.intStapel_ItemField.Location = new System.Drawing.Point(170, 12);
            this.intStapel_ItemField.Name = "intStapel_ItemField";
            this.intStapel_ItemField.ReadOnly = true;
            this.intStapel_ItemField.Size = new System.Drawing.Size(189, 20);
            this.intStapel_ItemField.TabIndex = 99;
            this.intStapel_ItemField.TabStop = false;
            // 
            // intStapel_Field
            // 
            this.intStapel_Field.Location = new System.Drawing.Point(12, 202);
            this.intStapel_Field.Name = "intStapel_Field";
            this.intStapel_Field.ReadOnly = true;
            this.intStapel_Field.Size = new System.Drawing.Size(432, 20);
            this.intStapel_Field.TabIndex = 99;
            this.intStapel_Field.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Zet op stapel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Haal van stapel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // string_Field
            // 
            this.string_Field.Location = new System.Drawing.Point(58, 38);
            this.string_Field.Name = "string_Field";
            this.string_Field.Size = new System.Drawing.Size(100, 20);
            this.string_Field.TabIndex = 1;
            // 
            // stringStapel_ItemField
            // 
            this.stringStapel_ItemField.Location = new System.Drawing.Point(170, 38);
            this.stringStapel_ItemField.Name = "stringStapel_ItemField";
            this.stringStapel_ItemField.ReadOnly = true;
            this.stringStapel_ItemField.Size = new System.Drawing.Size(189, 20);
            this.stringStapel_ItemField.TabIndex = 99;
            this.stringStapel_ItemField.TabStop = false;
            // 
            // title_Field
            // 
            this.title_Field.Location = new System.Drawing.Point(52, 19);
            this.title_Field.Name = "title_Field";
            this.title_Field.Size = new System.Drawing.Size(100, 20);
            this.title_Field.TabIndex = 2;
            // 
            // bookStapel_ItemField
            // 
            this.bookStapel_ItemField.Location = new System.Drawing.Point(170, 83);
            this.bookStapel_ItemField.Multiline = true;
            this.bookStapel_ItemField.Name = "bookStapel_ItemField";
            this.bookStapel_ItemField.ReadOnly = true;
            this.bookStapel_ItemField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bookStapel_ItemField.Size = new System.Drawing.Size(274, 72);
            this.bookStapel_ItemField.TabIndex = 99;
            this.bookStapel_ItemField.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.date_Field);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.author_Field);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.title_Field);
            this.groupBox1.Location = new System.Drawing.Point(6, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 103);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boek";
            // 
            // date_Field
            // 
            this.date_Field.Location = new System.Drawing.Point(52, 71);
            this.date_Field.Name = "date_Field";
            this.date_Field.Size = new System.Drawing.Size(100, 20);
            this.date_Field.TabIndex = 4;
            // 
            // author_Field
            // 
            this.author_Field.Location = new System.Drawing.Point(52, 45);
            this.author_Field.Name = "author_Field";
            this.author_Field.Size = new System.Drawing.Size(100, 20);
            this.author_Field.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "int";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "string";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Titel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Auteur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Datum";
            // 
            // stringStapel_Field
            // 
            this.stringStapel_Field.Location = new System.Drawing.Point(12, 228);
            this.stringStapel_Field.Name = "stringStapel_Field";
            this.stringStapel_Field.ReadOnly = true;
            this.stringStapel_Field.Size = new System.Drawing.Size(432, 20);
            this.stringStapel_Field.TabIndex = 99;
            this.stringStapel_Field.TabStop = false;
            // 
            // bookStapel_Field
            // 
            this.bookStapel_Field.Location = new System.Drawing.Point(12, 254);
            this.bookStapel_Field.Name = "bookStapel_Field";
            this.bookStapel_Field.ReadOnly = true;
            this.bookStapel_Field.Size = new System.Drawing.Size(432, 20);
            this.bookStapel_Field.TabIndex = 99;
            this.bookStapel_Field.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 280);
            this.Controls.Add(this.bookStapel_Field);
            this.Controls.Add(this.stringStapel_Field);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bookStapel_ItemField);
            this.Controls.Add(this.stringStapel_ItemField);
            this.Controls.Add(this.string_Field);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.intStapel_Field);
            this.Controls.Add(this.intStapel_ItemField);
            this.Controls.Add(this.int_Field);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Opdracht3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox int_Field;
        private System.Windows.Forms.TextBox intStapel_ItemField;
        private System.Windows.Forms.TextBox intStapel_Field;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox string_Field;
        private System.Windows.Forms.TextBox stringStapel_ItemField;
        private System.Windows.Forms.TextBox title_Field;
        private System.Windows.Forms.TextBox bookStapel_ItemField;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox date_Field;
        private System.Windows.Forms.TextBox author_Field;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stringStapel_Field;
        private System.Windows.Forms.TextBox bookStapel_Field;
    }
}


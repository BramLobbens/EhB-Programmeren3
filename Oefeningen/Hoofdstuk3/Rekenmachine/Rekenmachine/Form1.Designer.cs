namespace Rekenmachine
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.inputX = new System.Windows.Forms.TextBox();
            this.inputY = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.inputX);
            this.flowLayoutPanel1.Controls.Add(this.inputY);
            this.flowLayoutPanel1.Controls.Add(this.output);
            this.flowLayoutPanel1.Controls.Add(this.add);
            this.flowLayoutPanel1.Controls.Add(this.sub);
            this.flowLayoutPanel1.Controls.Add(this.mult);
            this.flowLayoutPanel1.Controls.Add(this.div);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Controls.Add(this.clear);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(422, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // inputX
            // 
            this.inputX.Location = new System.Drawing.Point(3, 3);
            this.inputX.Name = "inputX";
            this.inputX.Size = new System.Drawing.Size(128, 20);
            this.inputX.TabIndex = 0;
            this.inputX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inputY
            // 
            this.inputY.Location = new System.Drawing.Point(3, 29);
            this.inputY.Name = "inputY";
            this.inputY.Size = new System.Drawing.Size(128, 20);
            this.inputY.TabIndex = 1;
            this.inputY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.Info;
            this.output.Location = new System.Drawing.Point(3, 55);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(128, 20);
            this.output.TabIndex = 2;
            this.output.Text = "0";
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(3, 81);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(128, 21);
            this.add.TabIndex = 3;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(3, 108);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(128, 21);
            this.sub.TabIndex = 4;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(3, 135);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(128, 21);
            this.mult.TabIndex = 5;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(3, 162);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(128, 21);
            this.div.TabIndex = 6;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 189);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 21);
            this.button5.TabIndex = 7;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 216);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 21);
            this.button6.TabIndex = 8;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 243);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(128, 21);
            this.button7.TabIndex = 9;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(3, 270);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(128, 21);
            this.button8.TabIndex = 10;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(3, 297);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(128, 21);
            this.clear.TabIndex = 11;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Rekenmachine";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox inputX;
        private System.Windows.Forms.TextBox inputY;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button clear;
    }
}


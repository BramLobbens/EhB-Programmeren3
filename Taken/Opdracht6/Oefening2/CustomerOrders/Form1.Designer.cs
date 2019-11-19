namespace CustomerOrders
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.customerButton = new System.Windows.Forms.Button();
            this.allOrdersButton = new System.Windows.Forms.Button();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.withCostsButton = new System.Windows.Forms.Button();
            this.greaterThanButton = new System.Windows.Forms.Button();
            this.greaterThanTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // resultListBox
            // 
            this.resultListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.Location = new System.Drawing.Point(189, 12);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(272, 108);
            this.resultListBox.TabIndex = 0;
            // 
            // customerButton
            // 
            this.customerButton.Location = new System.Drawing.Point(12, 72);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(92, 23);
            this.customerButton.TabIndex = 1;
            this.customerButton.Text = "Customer:";
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // allOrdersButton
            // 
            this.allOrdersButton.Location = new System.Drawing.Point(12, 14);
            this.allOrdersButton.Name = "allOrdersButton";
            this.allOrdersButton.Size = new System.Drawing.Size(92, 23);
            this.allOrdersButton.TabIndex = 2;
            this.allOrdersButton.Text = "All Orders";
            this.allOrdersButton.UseVisualStyleBackColor = true;
            this.allOrdersButton.Click += new System.EventHandler(this.allOrdersButton_Click);
            // 
            // customerComboBox
            // 
            this.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Items.AddRange(new object[] {
            "Alice",
            "Ben",
            "Carla"});
            this.customerComboBox.Location = new System.Drawing.Point(110, 73);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(63, 21);
            this.customerComboBox.TabIndex = 3;
            // 
            // withCostsButton
            // 
            this.withCostsButton.Location = new System.Drawing.Point(12, 43);
            this.withCostsButton.Name = "withCostsButton";
            this.withCostsButton.Size = new System.Drawing.Size(92, 23);
            this.withCostsButton.TabIndex = 4;
            this.withCostsButton.Text = "Order By Cost";
            this.withCostsButton.UseVisualStyleBackColor = true;
            this.withCostsButton.Click += new System.EventHandler(this.withCostsButton_Click);
            // 
            // greaterThanButton
            // 
            this.greaterThanButton.Location = new System.Drawing.Point(12, 101);
            this.greaterThanButton.Name = "greaterThanButton";
            this.greaterThanButton.Size = new System.Drawing.Size(92, 23);
            this.greaterThanButton.TabIndex = 5;
            this.greaterThanButton.Text = "Greater Than";
            this.greaterThanButton.UseVisualStyleBackColor = true;
            this.greaterThanButton.Click += new System.EventHandler(this.greaterThanButton_Click);
            // 
            // greaterThanTextBox
            // 
            this.greaterThanTextBox.Location = new System.Drawing.Point(110, 102);
            this.greaterThanTextBox.Name = "greaterThanTextBox";
            this.greaterThanTextBox.Size = new System.Drawing.Size(63, 20);
            this.greaterThanTextBox.TabIndex = 6;
            this.greaterThanTextBox.Text = "€ 9,99";
            this.greaterThanTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 133);
            this.Controls.Add(this.greaterThanTextBox);
            this.Controls.Add(this.greaterThanButton);
            this.Controls.Add(this.withCostsButton);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.allOrdersButton);
            this.Controls.Add(this.customerButton);
            this.Controls.Add(this.resultListBox);
            this.Name = "Form1";
            this.Text = "CustomerOrders";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button allOrdersButton;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.Button withCostsButton;
        private System.Windows.Forms.Button greaterThanButton;
        private System.Windows.Forms.TextBox greaterThanTextBox;
    }
}


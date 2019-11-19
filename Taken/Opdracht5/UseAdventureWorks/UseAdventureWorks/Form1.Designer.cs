namespace UseAdventureWorks
{
    partial class CurrencyLookupForm
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
            this.countrySelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currencyField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // countrySelection
            // 
            this.countrySelection.FormattingEnabled = true;
            this.countrySelection.Location = new System.Drawing.Point(116, 25);
            this.countrySelection.Name = "countrySelection";
            this.countrySelection.Size = new System.Drawing.Size(121, 21);
            this.countrySelection.TabIndex = 0;
            this.countrySelection.SelectedIndexChanged += new System.EventHandler(this.countrySelection_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Country:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Currency:";
            // 
            // currencyField
            // 
            this.currencyField.Location = new System.Drawing.Point(116, 71);
            this.currencyField.Name = "currencyField";
            this.currencyField.ReadOnly = true;
            this.currencyField.Size = new System.Drawing.Size(121, 20);
            this.currencyField.TabIndex = 3;
            // 
            // CurrencyLookupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 116);
            this.Controls.Add(this.currencyField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countrySelection);
            this.Name = "CurrencyLookupForm";
            this.Text = "UseAdventureWorks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox countrySelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox currencyField;
    }
}


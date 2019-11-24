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
            this.components = new System.ComponentModel.Container();
            this.countrySelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currencyField = new System.Windows.Forms.TextBox();
            this.adventureWorks2016CTP3DataSet = new UseAdventureWorks.AdventureWorks2016CTP3DataSet();
            this.countryRegionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryRegionTableAdapter = new UseAdventureWorks.AdventureWorks2016CTP3DataSetTableAdapters.CountryRegionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2016CTP3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionBindingSource)).BeginInit();
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
            // adventureWorks2016CTP3DataSet
            // 
            this.adventureWorks2016CTP3DataSet.DataSetName = "AdventureWorks2016CTP3DataSet";
            this.adventureWorks2016CTP3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countryRegionBindingSource
            // 
            this.countryRegionBindingSource.DataMember = "CountryRegion";
            this.countryRegionBindingSource.DataSource = this.adventureWorks2016CTP3DataSet;
            // 
            // countryRegionTableAdapter
            // 
            this.countryRegionTableAdapter.ClearBeforeFill = true;
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
            this.Load += new System.EventHandler(this.CurrencyLookupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2016CTP3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox countrySelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox currencyField;
        private AdventureWorks2016CTP3DataSet adventureWorks2016CTP3DataSet;
        private System.Windows.Forms.BindingSource countryRegionBindingSource;
        private AdventureWorks2016CTP3DataSetTableAdapters.CountryRegionTableAdapter countryRegionTableAdapter;
    }
}


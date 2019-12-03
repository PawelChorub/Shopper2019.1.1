namespace Shopper2019.UI
{
    partial class CurrencyRateUI
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
            this.currencyTable = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GetCurrencyRateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currencyTable
            // 
            this.currencyTable.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.currencyTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.currencyTable.Location = new System.Drawing.Point(12, 12);
            this.currencyTable.Name = "currencyTable";
            this.currencyTable.Size = new System.Drawing.Size(235, 133);
            this.currencyTable.TabIndex = 2;
            this.currencyTable.UseCompatibleStateImageBehavior = false;
            this.currencyTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Waluta";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Średni kurs";
            this.columnHeader2.Width = 100;
            // 
            // GetCurrencyRateBtn
            // 
            this.GetCurrencyRateBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GetCurrencyRateBtn.FlatAppearance.BorderSize = 0;
            this.GetCurrencyRateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetCurrencyRateBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.GetCurrencyRateBtn.Location = new System.Drawing.Point(12, 151);
            this.GetCurrencyRateBtn.Name = "GetCurrencyRateBtn";
            this.GetCurrencyRateBtn.Size = new System.Drawing.Size(235, 23);
            this.GetCurrencyRateBtn.TabIndex = 3;
            this.GetCurrencyRateBtn.Text = "Pobierz aktualne kursy walut\r\n";
            this.GetCurrencyRateBtn.UseVisualStyleBackColor = false;
            this.GetCurrencyRateBtn.Click += new System.EventHandler(this.GetCurrencyRateBtn_Click);
            // 
            // CurrencyRateUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(258, 187);
            this.Controls.Add(this.GetCurrencyRateBtn);
            this.Controls.Add(this.currencyTable);
            this.Name = "CurrencyRateUI";
            this.Text = "CurrencyRateUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView currencyTable;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button GetCurrencyRateBtn;
    }
}
namespace Shopper2019.UI
{
    partial class SaleUI
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
            this.itemSearchBtn = new System.Windows.Forms.Button();
            this.ItemSearchCodeTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saleListView = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.ItemSearchQuantityTb = new System.Windows.Forms.TextBox();
            this.TotalBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.totalGrossPriceLabel = new System.Windows.Forms.Label();
            this.InvoiceButton = new System.Windows.Forms.Button();
            this.ReceiptBtn = new System.Windows.Forms.Button();
            this.SaleCompleteBtn = new System.Windows.Forms.Button();
            this.BuyerNameTb = new System.Windows.Forms.TextBox();
            this.BuyerPostCodeTb = new System.Windows.Forms.TextBox();
            this.BuyerCityTb = new System.Windows.Forms.TextBox();
            this.BuyerStreetTb = new System.Windows.Forms.TextBox();
            this.BuyerStreetNumberTb = new System.Windows.Forms.TextBox();
            this.BuyerTaxNumber = new System.Windows.Forms.TextBox();
            this.BuyerDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.BuyerDetailsSaveBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewSaleButton = new System.Windows.Forms.Button();
            this.BuyerDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemSearchBtn
            // 
            this.itemSearchBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.itemSearchBtn.FlatAppearance.BorderSize = 0;
            this.itemSearchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.itemSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemSearchBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.itemSearchBtn.Location = new System.Drawing.Point(317, 13);
            this.itemSearchBtn.Name = "itemSearchBtn";
            this.itemSearchBtn.Size = new System.Drawing.Size(77, 46);
            this.itemSearchBtn.TabIndex = 0;
            this.itemSearchBtn.Text = "Znajdź";
            this.itemSearchBtn.UseVisualStyleBackColor = false;
            this.itemSearchBtn.Click += new System.EventHandler(this.ItemSearchBtn_Click);
            // 
            // ItemSearchCodeTb
            // 
            this.ItemSearchCodeTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemSearchCodeTb.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ItemSearchCodeTb.Location = new System.Drawing.Point(128, 13);
            this.ItemSearchCodeTb.Multiline = true;
            this.ItemSearchCodeTb.Name = "ItemSearchCodeTb";
            this.ItemSearchCodeTb.Size = new System.Drawing.Size(175, 20);
            this.ItemSearchCodeTb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kod\r\n";
            // 
            // saleListView
            // 
            this.saleListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.saleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader2,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader1});
            this.saleListView.FullRowSelect = true;
            this.saleListView.Location = new System.Drawing.Point(12, 76);
            this.saleListView.MultiSelect = false;
            this.saleListView.Name = "saleListView";
            this.saleListView.Size = new System.Drawing.Size(779, 181);
            this.saleListView.TabIndex = 3;
            this.saleListView.UseCompatibleStateImageBehavior = false;
            this.saleListView.View = System.Windows.Forms.View.Details;
            this.saleListView.SelectedIndexChanged += new System.EventHandler(this.SaleListView_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Lp.";
            this.columnHeader8.Width = 35;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kod";
            this.columnHeader3.Width = 136;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nazwa";
            this.columnHeader4.Width = 224;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ilość";
            this.columnHeader5.Width = 44;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "J.m.";
            this.columnHeader2.Width = 40;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Vat";
            this.columnHeader6.Width = 42;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Cena brutto";
            this.columnHeader7.Width = 118;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Wartość brutto";
            this.columnHeader1.Width = 136;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ilość";
            // 
            // ItemSearchQuantityTb
            // 
            this.ItemSearchQuantityTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemSearchQuantityTb.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ItemSearchQuantityTb.Location = new System.Drawing.Point(128, 39);
            this.ItemSearchQuantityTb.Multiline = true;
            this.ItemSearchQuantityTb.Name = "ItemSearchQuantityTb";
            this.ItemSearchQuantityTb.Size = new System.Drawing.Size(175, 20);
            this.ItemSearchQuantityTb.TabIndex = 6;
            // 
            // TotalBtn
            // 
            this.TotalBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TotalBtn.FlatAppearance.BorderSize = 0;
            this.TotalBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TotalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TotalBtn.Location = new System.Drawing.Point(651, 13);
            this.TotalBtn.Name = "TotalBtn";
            this.TotalBtn.Size = new System.Drawing.Size(140, 46);
            this.TotalBtn.TabIndex = 7;
            this.TotalBtn.Text = "R a z e m";
            this.TotalBtn.UseVisualStyleBackColor = false;
            this.TotalBtn.Click += new System.EventHandler(this.TotalBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteBtn.Location = new System.Drawing.Point(400, 13);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(77, 46);
            this.DeleteBtn.TabIndex = 8;
            this.DeleteBtn.Text = "Usuń";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // totalGrossPriceLabel
            // 
            this.totalGrossPriceLabel.BackColor = System.Drawing.Color.White;
            this.totalGrossPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalGrossPriceLabel.Location = new System.Drawing.Point(638, 256);
            this.totalGrossPriceLabel.Name = "totalGrossPriceLabel";
            this.totalGrossPriceLabel.Size = new System.Drawing.Size(153, 42);
            this.totalGrossPriceLabel.TabIndex = 9;
            this.totalGrossPriceLabel.Text = "0,00";
            this.totalGrossPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InvoiceButton
            // 
            this.InvoiceButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.InvoiceButton.FlatAppearance.BorderSize = 0;
            this.InvoiceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.InvoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InvoiceButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InvoiceButton.Location = new System.Drawing.Point(484, 13);
            this.InvoiceButton.Name = "InvoiceButton";
            this.InvoiceButton.Size = new System.Drawing.Size(77, 46);
            this.InvoiceButton.TabIndex = 11;
            this.InvoiceButton.Text = "Faktura";
            this.InvoiceButton.UseVisualStyleBackColor = false;
            this.InvoiceButton.Click += new System.EventHandler(this.InvoiceButton_Click);
            // 
            // ReceiptBtn
            // 
            this.ReceiptBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ReceiptBtn.FlatAppearance.BorderSize = 0;
            this.ReceiptBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ReceiptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReceiptBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReceiptBtn.Location = new System.Drawing.Point(567, 13);
            this.ReceiptBtn.Name = "ReceiptBtn";
            this.ReceiptBtn.Size = new System.Drawing.Size(77, 46);
            this.ReceiptBtn.TabIndex = 12;
            this.ReceiptBtn.Text = "Paragon";
            this.ReceiptBtn.UseVisualStyleBackColor = false;
            this.ReceiptBtn.Click += new System.EventHandler(this.ReceiptBtn_Click);
            // 
            // SaleCompleteBtn
            // 
            this.SaleCompleteBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SaleCompleteBtn.FlatAppearance.BorderSize = 0;
            this.SaleCompleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SaleCompleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaleCompleteBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaleCompleteBtn.Location = new System.Drawing.Point(638, 298);
            this.SaleCompleteBtn.Name = "SaleCompleteBtn";
            this.SaleCompleteBtn.Size = new System.Drawing.Size(153, 103);
            this.SaleCompleteBtn.TabIndex = 13;
            this.SaleCompleteBtn.Text = "Zakończ";
            this.SaleCompleteBtn.UseVisualStyleBackColor = false;
            this.SaleCompleteBtn.Click += new System.EventHandler(this.SaleCompleteBtn_Click);
            // 
            // BuyerNameTb
            // 
            this.BuyerNameTb.Location = new System.Drawing.Point(76, 34);
            this.BuyerNameTb.Name = "BuyerNameTb";
            this.BuyerNameTb.Size = new System.Drawing.Size(204, 20);
            this.BuyerNameTb.TabIndex = 14;
            this.BuyerNameTb.Text = "Firma Klienta";
            // 
            // BuyerPostCodeTb
            // 
            this.BuyerPostCodeTb.Location = new System.Drawing.Point(379, 62);
            this.BuyerPostCodeTb.Name = "BuyerPostCodeTb";
            this.BuyerPostCodeTb.Size = new System.Drawing.Size(67, 20);
            this.BuyerPostCodeTb.TabIndex = 14;
            this.BuyerPostCodeTb.Text = "42-200";
            // 
            // BuyerCityTb
            // 
            this.BuyerCityTb.Location = new System.Drawing.Point(107, 62);
            this.BuyerCityTb.Name = "BuyerCityTb";
            this.BuyerCityTb.Size = new System.Drawing.Size(173, 20);
            this.BuyerCityTb.TabIndex = 14;
            this.BuyerCityTb.Text = "Częstochowa";
            // 
            // BuyerStreetTb
            // 
            this.BuyerStreetTb.Location = new System.Drawing.Point(76, 91);
            this.BuyerStreetTb.Name = "BuyerStreetTb";
            this.BuyerStreetTb.Size = new System.Drawing.Size(204, 20);
            this.BuyerStreetTb.TabIndex = 14;
            this.BuyerStreetTb.Text = "Prosta";
            // 
            // BuyerStreetNumberTb
            // 
            this.BuyerStreetNumberTb.Location = new System.Drawing.Point(322, 91);
            this.BuyerStreetNumberTb.Name = "BuyerStreetNumberTb";
            this.BuyerStreetNumberTb.Size = new System.Drawing.Size(51, 20);
            this.BuyerStreetNumberTb.TabIndex = 14;
            this.BuyerStreetNumberTb.Text = "52";
            // 
            // BuyerTaxNumber
            // 
            this.BuyerTaxNumber.Location = new System.Drawing.Point(339, 36);
            this.BuyerTaxNumber.Name = "BuyerTaxNumber";
            this.BuyerTaxNumber.Size = new System.Drawing.Size(107, 20);
            this.BuyerTaxNumber.TabIndex = 14;
            this.BuyerTaxNumber.Text = "1234567899";
            // 
            // BuyerDetailsGroupBox
            // 
            this.BuyerDetailsGroupBox.Controls.Add(this.BuyerDetailsSaveBtn);
            this.BuyerDetailsGroupBox.Controls.Add(this.label8);
            this.BuyerDetailsGroupBox.Controls.Add(this.label7);
            this.BuyerDetailsGroupBox.Controls.Add(this.label6);
            this.BuyerDetailsGroupBox.Controls.Add(this.label5);
            this.BuyerDetailsGroupBox.Controls.Add(this.label4);
            this.BuyerDetailsGroupBox.Controls.Add(this.label3);
            this.BuyerDetailsGroupBox.Controls.Add(this.BuyerCityTb);
            this.BuyerDetailsGroupBox.Controls.Add(this.BuyerTaxNumber);
            this.BuyerDetailsGroupBox.Controls.Add(this.BuyerStreetNumberTb);
            this.BuyerDetailsGroupBox.Controls.Add(this.BuyerNameTb);
            this.BuyerDetailsGroupBox.Controls.Add(this.BuyerStreetTb);
            this.BuyerDetailsGroupBox.Controls.Add(this.BuyerPostCodeTb);
            this.BuyerDetailsGroupBox.Location = new System.Drawing.Point(12, 263);
            this.BuyerDetailsGroupBox.Name = "BuyerDetailsGroupBox";
            this.BuyerDetailsGroupBox.Size = new System.Drawing.Size(620, 138);
            this.BuyerDetailsGroupBox.TabIndex = 15;
            this.BuyerDetailsGroupBox.TabStop = false;
            this.BuyerDetailsGroupBox.Text = "Dane kontrahenta";
            this.BuyerDetailsGroupBox.Visible = false;
            // 
            // BuyerDetailsSaveBtn
            // 
            this.BuyerDetailsSaveBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BuyerDetailsSaveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BuyerDetailsSaveBtn.FlatAppearance.BorderSize = 3;
            this.BuyerDetailsSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyerDetailsSaveBtn.Location = new System.Drawing.Point(463, 35);
            this.BuyerDetailsSaveBtn.Name = "BuyerDetailsSaveBtn";
            this.BuyerDetailsSaveBtn.Size = new System.Drawing.Size(125, 44);
            this.BuyerDetailsSaveBtn.TabIndex = 16;
            this.BuyerDetailsSaveBtn.Text = "Zapisz kontrahenta";
            this.BuyerDetailsSaveBtn.UseVisualStyleBackColor = false;
            this.BuyerDetailsSaveBtn.Click += new System.EventHandler(this.BuyerDetailsSaveBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nr :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "NIP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Miejscowość :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Kod pocztowy :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ulica :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nazwa :";
            // 
            // NewSaleButton
            // 
            this.NewSaleButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NewSaleButton.FlatAppearance.BorderSize = 0;
            this.NewSaleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NewSaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewSaleButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewSaleButton.Location = new System.Drawing.Point(12, 13);
            this.NewSaleButton.Name = "NewSaleButton";
            this.NewSaleButton.Size = new System.Drawing.Size(77, 46);
            this.NewSaleButton.TabIndex = 16;
            this.NewSaleButton.Text = "Nowa sprzedaż";
            this.NewSaleButton.UseVisualStyleBackColor = false;
            this.NewSaleButton.Click += new System.EventHandler(this.NewSaleButton_Click);
            // 
            // SaleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(803, 425);
            this.Controls.Add(this.NewSaleButton);
            this.Controls.Add(this.BuyerDetailsGroupBox);
            this.Controls.Add(this.SaleCompleteBtn);
            this.Controls.Add(this.ReceiptBtn);
            this.Controls.Add(this.InvoiceButton);
            this.Controls.Add(this.totalGrossPriceLabel);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.TotalBtn);
            this.Controls.Add(this.ItemSearchQuantityTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saleListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemSearchCodeTb);
            this.Controls.Add(this.itemSearchBtn);
            this.Name = "SaleUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleUI";
            this.Load += new System.EventHandler(this.SaleUI_Load);
            this.BuyerDetailsGroupBox.ResumeLayout(false);
            this.BuyerDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button itemSearchBtn;
        private System.Windows.Forms.TextBox ItemSearchCodeTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView saleListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ItemSearchQuantityTb;
        private System.Windows.Forms.Button TotalBtn;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label totalGrossPriceLabel;
        private System.Windows.Forms.Button InvoiceButton;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button ReceiptBtn;
        private System.Windows.Forms.Button SaleCompleteBtn;
        private System.Windows.Forms.TextBox BuyerNameTb;
        private System.Windows.Forms.TextBox BuyerPostCodeTb;
        private System.Windows.Forms.TextBox BuyerCityTb;
        private System.Windows.Forms.TextBox BuyerStreetTb;
        private System.Windows.Forms.TextBox BuyerStreetNumberTb;
        private System.Windows.Forms.TextBox BuyerTaxNumber;
        private System.Windows.Forms.GroupBox BuyerDetailsGroupBox;
        private System.Windows.Forms.Button BuyerDetailsSaveBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NewSaleButton;
    }
}
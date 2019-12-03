namespace Shopper2019.Invoice
{
    partial class InvoiceForm
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
            this.InvoiceListView = new System.Windows.Forms.ListView();
            this.odrerNumberCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unityOfMeasurementCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.netPriceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vatTaxCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grossPriceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalGrossPriceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CityAndDateLbl = new System.Windows.Forms.Label();
            this.InvoiceNumberLbl = new System.Windows.Forms.Label();
            this.VendorTitleLbl = new System.Windows.Forms.Label();
            this.BuyerTitleLbl = new System.Windows.Forms.Label();
            this.VendorNameLbl = new System.Windows.Forms.Label();
            this.BuyerNameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BuyerTaxNumberLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BuyerAddressLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InvoiceListView
            // 
            this.InvoiceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.odrerNumberCol,
            this.codeCol,
            this.nameCol,
            this.quantityCol,
            this.unityOfMeasurementCol,
            this.netPriceCol,
            this.vatTaxCol,
            this.grossPriceCol,
            this.totalGrossPriceCol});
            this.InvoiceListView.Location = new System.Drawing.Point(3, 182);
            this.InvoiceListView.Name = "InvoiceListView";
            this.InvoiceListView.Size = new System.Drawing.Size(818, 336);
            this.InvoiceListView.TabIndex = 0;
            this.InvoiceListView.UseCompatibleStateImageBehavior = false;
            this.InvoiceListView.View = System.Windows.Forms.View.Details;
            // 
            // odrerNumberCol
            // 
            this.odrerNumberCol.Text = "Lp.";
            this.odrerNumberCol.Width = 30;
            // 
            // codeCol
            // 
            this.codeCol.Text = "Kod";
            this.codeCol.Width = 100;
            // 
            // nameCol
            // 
            this.nameCol.Text = "Nazwa towaru";
            this.nameCol.Width = 250;
            // 
            // quantityCol
            // 
            this.quantityCol.Text = "Ilość";
            // 
            // unityOfMeasurementCol
            // 
            this.unityOfMeasurementCol.Text = "J.m.";
            this.unityOfMeasurementCol.Width = 40;
            // 
            // netPriceCol
            // 
            this.netPriceCol.Text = "Cena netto";
            this.netPriceCol.Width = 80;
            // 
            // vatTaxCol
            // 
            this.vatTaxCol.Text = "VAT";
            this.vatTaxCol.Width = 40;
            // 
            // grossPriceCol
            // 
            this.grossPriceCol.Text = "Cena brutto";
            this.grossPriceCol.Width = 80;
            // 
            // totalGrossPriceCol
            // 
            this.totalGrossPriceCol.Text = "Wartość brutto";
            this.totalGrossPriceCol.Width = 132;
            // 
            // CityAndDateLbl
            // 
            this.CityAndDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CityAndDateLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CityAndDateLbl.Location = new System.Drawing.Point(598, 9);
            this.CityAndDateLbl.Name = "CityAndDateLbl";
            this.CityAndDateLbl.Size = new System.Drawing.Size(216, 23);
            this.CityAndDateLbl.TabIndex = 1;
            this.CityAndDateLbl.Text = "City, date";
            this.CityAndDateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InvoiceNumberLbl
            // 
            this.InvoiceNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InvoiceNumberLbl.Location = new System.Drawing.Point(12, 143);
            this.InvoiceNumberLbl.Name = "InvoiceNumberLbl";
            this.InvoiceNumberLbl.Size = new System.Drawing.Size(802, 23);
            this.InvoiceNumberLbl.TabIndex = 2;
            this.InvoiceNumberLbl.Text = "Invoice number";
            this.InvoiceNumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VendorTitleLbl
            // 
            this.VendorTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VendorTitleLbl.Location = new System.Drawing.Point(13, 36);
            this.VendorTitleLbl.Name = "VendorTitleLbl";
            this.VendorTitleLbl.Size = new System.Drawing.Size(374, 22);
            this.VendorTitleLbl.TabIndex = 3;
            this.VendorTitleLbl.Text = "Sprzedawca :";
            // 
            // BuyerTitleLbl
            // 
            this.BuyerTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BuyerTitleLbl.Location = new System.Drawing.Point(440, 36);
            this.BuyerTitleLbl.Name = "BuyerTitleLbl";
            this.BuyerTitleLbl.Size = new System.Drawing.Size(374, 22);
            this.BuyerTitleLbl.TabIndex = 4;
            this.BuyerTitleLbl.Text = "Nabywca :";
            // 
            // VendorNameLbl
            // 
            this.VendorNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VendorNameLbl.Location = new System.Drawing.Point(13, 57);
            this.VendorNameLbl.Name = "VendorNameLbl";
            this.VendorNameLbl.Size = new System.Drawing.Size(374, 22);
            this.VendorNameLbl.TabIndex = 5;
            this.VendorNameLbl.Text = "Kosmetolog Justyna Chorub";
            // 
            // BuyerNameLbl
            // 
            this.BuyerNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BuyerNameLbl.Location = new System.Drawing.Point(440, 57);
            this.BuyerNameLbl.Name = "BuyerNameLbl";
            this.BuyerNameLbl.Size = new System.Drawing.Size(374, 22);
            this.BuyerNameLbl.TabIndex = 6;
            this.BuyerNameLbl.Text = "Nazwa";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "NIP : 574-475-75-44";
            // 
            // BuyerTaxNumberLbl
            // 
            this.BuyerTaxNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BuyerTaxNumberLbl.Location = new System.Drawing.Point(440, 78);
            this.BuyerTaxNumberLbl.Name = "BuyerTaxNumberLbl";
            this.BuyerTaxNumberLbl.Size = new System.Drawing.Size(374, 22);
            this.BuyerTaxNumberLbl.TabIndex = 8;
            this.BuyerTaxNumberLbl.Text = "NIP :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "42-125 Kamyk, Biała, ul.Częstochowska 28";
            // 
            // BuyerAddressLbl
            // 
            this.BuyerAddressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BuyerAddressLbl.Location = new System.Drawing.Point(440, 99);
            this.BuyerAddressLbl.Name = "BuyerAddressLbl";
            this.BuyerAddressLbl.Size = new System.Drawing.Size(374, 22);
            this.BuyerAddressLbl.TabIndex = 10;
            this.BuyerAddressLbl.Text = "Adres :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(691, 524);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 30);
            this.textBox1.TabIndex = 11;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 675);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BuyerAddressLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BuyerTaxNumberLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuyerNameLbl);
            this.Controls.Add(this.VendorNameLbl);
            this.Controls.Add(this.BuyerTitleLbl);
            this.Controls.Add(this.VendorTitleLbl);
            this.Controls.Add(this.InvoiceNumberLbl);
            this.Controls.Add(this.CityAndDateLbl);
            this.Controls.Add(this.InvoiceListView);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView InvoiceListView;
        private System.Windows.Forms.ColumnHeader odrerNumberCol;
        private System.Windows.Forms.ColumnHeader codeCol;
        private System.Windows.Forms.ColumnHeader nameCol;
        private System.Windows.Forms.ColumnHeader quantityCol;
        private System.Windows.Forms.ColumnHeader netPriceCol;
        private System.Windows.Forms.ColumnHeader vatTaxCol;
        private System.Windows.Forms.ColumnHeader grossPriceCol;
        private System.Windows.Forms.ColumnHeader totalGrossPriceCol;
        private System.Windows.Forms.ColumnHeader unityOfMeasurementCol;
        private System.Windows.Forms.Label CityAndDateLbl;
        private System.Windows.Forms.Label InvoiceNumberLbl;
        private System.Windows.Forms.Label VendorTitleLbl;
        private System.Windows.Forms.Label BuyerTitleLbl;
        private System.Windows.Forms.Label VendorNameLbl;
        private System.Windows.Forms.Label BuyerNameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BuyerTaxNumberLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BuyerAddressLbl;
        private System.Windows.Forms.TextBox textBox1;
    }
}
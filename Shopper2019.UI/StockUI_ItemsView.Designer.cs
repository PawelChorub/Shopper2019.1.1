namespace Shopper2019.UI
{
    partial class StockUI_ItemsView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shopper2019StockTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopper2019DbDataSet = new Shopper2019.UI.Shopper2019DbDataSet();
            this.shopper2019StockTableTableAdapter = new Shopper2019.UI.Shopper2019DbDataSetTableAdapters.Shopper2019StockTableTableAdapter();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitOfMeasurementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vatTaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopper2019StockTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopper2019DbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitOfMeasurementDataGridViewTextBoxColumn,
            this.netPriceDataGridViewTextBoxColumn,
            this.vatTaxDataGridViewTextBoxColumn,
            this.grossPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shopper2019StockTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(984, 561);
            this.dataGridView1.TabIndex = 0;
            // 
            // shopper2019StockTableBindingSource
            // 
            this.shopper2019StockTableBindingSource.DataMember = "Shopper2019StockTable";
            this.shopper2019StockTableBindingSource.DataSource = this.shopper2019DbDataSet;
            // 
            // shopper2019DbDataSet
            // 
            this.shopper2019DbDataSet.DataSetName = "Shopper2019DbDataSet";
            this.shopper2019DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shopper2019StockTableTableAdapter
            // 
            this.shopper2019StockTableTableAdapter.ClearBeforeFill = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Kod";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 300;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Ilość";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitOfMeasurementDataGridViewTextBoxColumn
            // 
            this.unitOfMeasurementDataGridViewTextBoxColumn.DataPropertyName = "unitOfMeasurement";
            this.unitOfMeasurementDataGridViewTextBoxColumn.HeaderText = "J.m.";
            this.unitOfMeasurementDataGridViewTextBoxColumn.Name = "unitOfMeasurementDataGridViewTextBoxColumn";
            this.unitOfMeasurementDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitOfMeasurementDataGridViewTextBoxColumn.Width = 50;
            // 
            // netPriceDataGridViewTextBoxColumn
            // 
            this.netPriceDataGridViewTextBoxColumn.DataPropertyName = "netPrice";
            this.netPriceDataGridViewTextBoxColumn.HeaderText = "Cena netto";
            this.netPriceDataGridViewTextBoxColumn.Name = "netPriceDataGridViewTextBoxColumn";
            this.netPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vatTaxDataGridViewTextBoxColumn
            // 
            this.vatTaxDataGridViewTextBoxColumn.DataPropertyName = "vatTax";
            this.vatTaxDataGridViewTextBoxColumn.HeaderText = "VAT %";
            this.vatTaxDataGridViewTextBoxColumn.Name = "vatTaxDataGridViewTextBoxColumn";
            this.vatTaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.vatTaxDataGridViewTextBoxColumn.Width = 50;
            // 
            // grossPriceDataGridViewTextBoxColumn
            // 
            this.grossPriceDataGridViewTextBoxColumn.DataPropertyName = "grossPrice";
            this.grossPriceDataGridViewTextBoxColumn.HeaderText = "Cena brutto";
            this.grossPriceDataGridViewTextBoxColumn.Name = "grossPriceDataGridViewTextBoxColumn";
            this.grossPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.grossPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // StockUI_ItemsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 561);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StockUI_ItemsView";
            this.Text = "StockUI_ItemsView";
            this.Load += new System.EventHandler(this.StockUI_ItemsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopper2019StockTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopper2019DbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Shopper2019DbDataSet shopper2019DbDataSet;
        private System.Windows.Forms.BindingSource shopper2019StockTableBindingSource;
        private Shopper2019DbDataSetTableAdapters.Shopper2019StockTableTableAdapter shopper2019StockTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitOfMeasurementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossPriceDataGridViewTextBoxColumn;
    }
}
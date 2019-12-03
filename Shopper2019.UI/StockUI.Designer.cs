namespace Shopper2019.UI
{
    partial class StockUI
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.codeTb = new System.Windows.Forms.TextBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.quantityTb = new System.Windows.Forms.TextBox();
            this.netPriceTb = new System.Windows.Forms.TextBox();
            this.vatTaxTb = new System.Windows.Forms.TextBox();
            this.grossPriceTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddItemBtn = new System.Windows.Forms.Button();
            this.lpHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codeHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.netPriceHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vatTaxHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grossPriceHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockListView = new System.Windows.Forms.ListView();
            this.unityOfMeasureHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveToDbBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.logBoxTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.indexTb = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.NewItemBtn = new System.Windows.Forms.Button();
            this.AddEditChangesBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unitOfMeasurementCbox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeTb
            // 
            this.codeTb.Location = new System.Drawing.Point(234, 16);
            this.codeTb.Name = "codeTb";
            this.codeTb.Size = new System.Drawing.Size(266, 20);
            this.codeTb.TabIndex = 0;
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(64, 44);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(436, 20);
            this.nameTb.TabIndex = 0;
            this.nameTb.Text = "produkt";
            // 
            // quantityTb
            // 
            this.quantityTb.Location = new System.Drawing.Point(64, 72);
            this.quantityTb.Name = "quantityTb";
            this.quantityTb.Size = new System.Drawing.Size(111, 20);
            this.quantityTb.TabIndex = 0;
            this.quantityTb.Text = "100,36";
            // 
            // netPriceTb
            // 
            this.netPriceTb.Location = new System.Drawing.Point(595, 16);
            this.netPriceTb.Name = "netPriceTb";
            this.netPriceTb.Size = new System.Drawing.Size(100, 20);
            this.netPriceTb.TabIndex = 0;
            this.netPriceTb.Text = "10,58";
            // 
            // vatTaxTb
            // 
            this.vatTaxTb.Location = new System.Drawing.Point(595, 44);
            this.vatTaxTb.Name = "vatTaxTb";
            this.vatTaxTb.Size = new System.Drawing.Size(100, 20);
            this.vatTaxTb.TabIndex = 0;
            this.vatTaxTb.Text = "23";
            // 
            // grossPriceTb
            // 
            this.grossPriceTb.Location = new System.Drawing.Point(595, 72);
            this.grossPriceTb.Name = "grossPriceTb";
            this.grossPriceTb.ReadOnly = true;
            this.grossPriceTb.Size = new System.Drawing.Size(100, 20);
            this.grossPriceTb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kod :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ilość :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cena netto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Vat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(526, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cena Brutto";
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddItemBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddItemBtn.Location = new System.Drawing.Point(529, 105);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(166, 27);
            this.AddItemBtn.TabIndex = 2;
            this.AddItemBtn.Text = "Dodaj";
            this.AddItemBtn.UseVisualStyleBackColor = false;
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // lpHdr
            // 
            this.lpHdr.Text = "Lp.";
            this.lpHdr.Width = 32;
            // 
            // codeHdr
            // 
            this.codeHdr.Text = "Kod";
            this.codeHdr.Width = 158;
            // 
            // nameHdr
            // 
            this.nameHdr.Text = "Nazwa";
            this.nameHdr.Width = 169;
            // 
            // quantityHdr
            // 
            this.quantityHdr.Text = "Ilość";
            this.quantityHdr.Width = 51;
            // 
            // netPriceHdr
            // 
            this.netPriceHdr.Text = "Cena netto";
            this.netPriceHdr.Width = 86;
            // 
            // vatTaxHdr
            // 
            this.vatTaxHdr.Text = "Vat";
            this.vatTaxHdr.Width = 35;
            // 
            // grossPriceHdr
            // 
            this.grossPriceHdr.Text = "Cena brutto";
            this.grossPriceHdr.Width = 112;
            // 
            // stockListView
            // 
            this.stockListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lpHdr,
            this.codeHdr,
            this.nameHdr,
            this.quantityHdr,
            this.unityOfMeasureHdr,
            this.netPriceHdr,
            this.vatTaxHdr,
            this.grossPriceHdr});
            this.stockListView.FullRowSelect = true;
            this.stockListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.stockListView.Location = new System.Drawing.Point(47, 219);
            this.stockListView.MultiSelect = false;
            this.stockListView.Name = "stockListView";
            this.stockListView.Size = new System.Drawing.Size(707, 242);
            this.stockListView.TabIndex = 3;
            this.stockListView.UseCompatibleStateImageBehavior = false;
            this.stockListView.View = System.Windows.Forms.View.Details;
            this.stockListView.SelectedIndexChanged += new System.EventHandler(this.stockListView_SelectedIndexChanged);
            // 
            // unityOfMeasureHdr
            // 
            this.unityOfMeasureHdr.Text = "J.m.";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DeleteBtn.Enabled = false;
            this.DeleteBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteBtn.Location = new System.Drawing.Point(13, 105);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(166, 27);
            this.DeleteBtn.TabIndex = 8;
            this.DeleteBtn.Text = "Usuń";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtnClick);
            // 
            // SaveToDbBtn
            // 
            this.SaveToDbBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SaveToDbBtn.FlatAppearance.BorderSize = 0;
            this.SaveToDbBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveToDbBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveToDbBtn.Location = new System.Drawing.Point(459, 5);
            this.SaveToDbBtn.Name = "SaveToDbBtn";
            this.SaveToDbBtn.Size = new System.Drawing.Size(145, 45);
            this.SaveToDbBtn.TabIndex = 9;
            this.SaveToDbBtn.Text = "Zapisz dostawę";
            this.SaveToDbBtn.UseVisualStyleBackColor = false;
            this.SaveToDbBtn.Click += new System.EventHandler(this.SaveToDbBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.EditBtn.Enabled = false;
            this.EditBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditBtn.Location = new System.Drawing.Point(185, 105);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(166, 27);
            this.EditBtn.TabIndex = 10;
            this.EditBtn.Text = "Edytuj zaznaczenie";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // logBoxTb
            // 
            this.logBoxTb.Location = new System.Drawing.Point(47, 467);
            this.logBoxTb.Multiline = true;
            this.logBoxTb.Name = "logBoxTb";
            this.logBoxTb.Size = new System.Drawing.Size(707, 84);
            this.logBoxTb.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Lp.";
            // 
            // indexTb
            // 
            this.indexTb.Location = new System.Drawing.Point(64, 16);
            this.indexTb.Name = "indexTb";
            this.indexTb.ReadOnly = true;
            this.indexTb.Size = new System.Drawing.Size(111, 20);
            this.indexTb.TabIndex = 17;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitBtn.Location = new System.Drawing.Point(610, 5);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(145, 45);
            this.ExitBtn.TabIndex = 19;
            this.ExitBtn.Text = "Wyjście";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Jednostka miary :";
            // 
            // NewItemBtn
            // 
            this.NewItemBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NewItemBtn.FlatAppearance.BorderSize = 0;
            this.NewItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewItemBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewItemBtn.Location = new System.Drawing.Point(47, 5);
            this.NewItemBtn.Name = "NewItemBtn";
            this.NewItemBtn.Size = new System.Drawing.Size(145, 45);
            this.NewItemBtn.TabIndex = 22;
            this.NewItemBtn.Text = "Nowy towar";
            this.NewItemBtn.UseVisualStyleBackColor = false;
            this.NewItemBtn.Click += new System.EventHandler(this.NewItemBtn_Click);
            // 
            // AddEditChangesBtn
            // 
            this.AddEditChangesBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddEditChangesBtn.Enabled = false;
            this.AddEditChangesBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddEditChangesBtn.Location = new System.Drawing.Point(357, 105);
            this.AddEditChangesBtn.Name = "AddEditChangesBtn";
            this.AddEditChangesBtn.Size = new System.Drawing.Size(166, 27);
            this.AddEditChangesBtn.TabIndex = 23;
            this.AddEditChangesBtn.Text = "Zapisz zmiany";
            this.AddEditChangesBtn.UseVisualStyleBackColor = false;
            this.AddEditChangesBtn.Click += new System.EventHandler(this.AddEditChangesBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.unitOfMeasurementCbox);
            this.groupBox1.Controls.Add(this.codeTb);
            this.groupBox1.Controls.Add(this.AddEditChangesBtn);
            this.groupBox1.Controls.Add(this.nameTb);
            this.groupBox1.Controls.Add(this.netPriceTb);
            this.groupBox1.Controls.Add(this.quantityTb);
            this.groupBox1.Controls.Add(this.vatTaxTb);
            this.groupBox1.Controls.Add(this.EditBtn);
            this.groupBox1.Controls.Add(this.DeleteBtn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.grossPriceTb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.indexTb);
            this.groupBox1.Controls.Add(this.AddItemBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(47, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 145);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // unitOfMeasurementCbox
            // 
            this.unitOfMeasurementCbox.FormattingEnabled = true;
            this.unitOfMeasurementCbox.Items.AddRange(new object[] {
            "szt.",
            "kg.",
            "L."});
            this.unitOfMeasurementCbox.Location = new System.Drawing.Point(305, 72);
            this.unitOfMeasurementCbox.Name = "unitOfMeasurementCbox";
            this.unitOfMeasurementCbox.Size = new System.Drawing.Size(121, 21);
            this.unitOfMeasurementCbox.TabIndex = 24;
            this.unitOfMeasurementCbox.Text = "wybierz...";
            // 
            // StockUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NewItemBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.logBoxTb);
            this.Controls.Add(this.SaveToDbBtn);
            this.Controls.Add(this.stockListView);
            this.Name = "StockUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codeTb;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox quantityTb;
        private System.Windows.Forms.TextBox netPriceTb;
        private System.Windows.Forms.TextBox vatTaxTb;
        private System.Windows.Forms.TextBox grossPriceTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddItemBtn;
        private System.Windows.Forms.ColumnHeader lpHdr;
        private System.Windows.Forms.ColumnHeader codeHdr;
        private System.Windows.Forms.ColumnHeader nameHdr;
        private System.Windows.Forms.ColumnHeader quantityHdr;
        private System.Windows.Forms.ColumnHeader netPriceHdr;
        private System.Windows.Forms.ColumnHeader vatTaxHdr;
        private System.Windows.Forms.ColumnHeader grossPriceHdr;
        private System.Windows.Forms.ListView stockListView;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SaveToDbBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.TextBox logBoxTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox indexTb;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader unityOfMeasureHdr;
        private System.Windows.Forms.Button NewItemBtn;
        private System.Windows.Forms.Button AddEditChangesBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox unitOfMeasurementCbox;
    }
}
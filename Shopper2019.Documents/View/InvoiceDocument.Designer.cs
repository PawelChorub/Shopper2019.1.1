namespace Shopper2019.Documents.View
{
    partial class InvoiceDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceDocument));
            this.printDialogInvoice = new System.Windows.Forms.PrintDialog();
            this.printDocumentInvoice = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogInvoice = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printDialogInvoice
            // 
            this.printDialogInvoice.UseEXDialog = true;
            // 
            // printDocumentInvoice
            // 
            this.printDocumentInvoice.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocumentInvoice_PrintPage);
            // 
            // printPreviewDialogInvoice
            // 
            this.printPreviewDialogInvoice.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogInvoice.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogInvoice.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogInvoice.Enabled = true;
            this.printPreviewDialogInvoice.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogInvoice.Icon")));
            this.printPreviewDialogInvoice.Name = "printPreviewDialogInvoice";
            this.printPreviewDialogInvoice.Visible = false;
            this.printPreviewDialogInvoice.Load += new System.EventHandler(this.PrintPreviewDialogInvoice_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Drukuj fakturę";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // InvoiceDocumentNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 69);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvoiceDocumentNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceDocument";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PrintDialog printDialogInvoice;
        private System.Drawing.Printing.PrintDocument printDocumentInvoice;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogInvoice;
        private System.Windows.Forms.Button button1;
    }
}
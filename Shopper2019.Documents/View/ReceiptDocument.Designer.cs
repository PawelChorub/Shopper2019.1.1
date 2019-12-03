﻿namespace Shopper2019.Documents
{
    partial class ReceiptDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptDocument));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printDialogReceipt = new System.Windows.Forms.PrintDialog();
            this.printDocumentReceipt = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogReceipt = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 505);
            this.label1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 103);
            this.button1.TabIndex = 2;
            this.button1.Text = "Drukuj...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDialogReceipt
            // 
            this.printDialogReceipt.Document = this.printDocumentReceipt;
            this.printDialogReceipt.UseEXDialog = true;
            // 
            // printDocumentReceipt
            // 
            this.printDocumentReceipt.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentReceipt_PrintPage);
            // 
            // printPreviewDialogReceipt
            // 
            this.printPreviewDialogReceipt.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogReceipt.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogReceipt.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogReceipt.Enabled = true;
            this.printPreviewDialogReceipt.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogReceipt.Icon")));
            this.printPreviewDialogReceipt.Name = "printPreviewDialogReceipt";
            this.printPreviewDialogReceipt.Visible = false;
            this.printPreviewDialogReceipt.Load += new System.EventHandler(this.printPreviewDialogReceipt_Load);
            // 
            // ReceiptDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ReceiptDocument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceiptDocument";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintDialog printDialogReceipt;
        private System.Drawing.Printing.PrintDocument printDocumentReceipt;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogReceipt;
    }
}
namespace Shopper2019.UI
{
    partial class Form1
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
            this.StockButton = new System.Windows.Forms.Button();
            this.SaleButton = new System.Windows.Forms.Button();
            this.StockItemsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StockButton
            // 
            this.StockButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.StockButton.FlatAppearance.BorderSize = 0;
            this.StockButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StockButton.Location = new System.Drawing.Point(274, 32);
            this.StockButton.Name = "StockButton";
            this.StockButton.Size = new System.Drawing.Size(147, 42);
            this.StockButton.TabIndex = 11;
            this.StockButton.Text = "Magazyn";
            this.StockButton.UseVisualStyleBackColor = false;
            this.StockButton.Click += new System.EventHandler(this.StockButton_Click);
            // 
            // SaleButton
            // 
            this.SaleButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SaleButton.FlatAppearance.BorderSize = 0;
            this.SaleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaleButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaleButton.Location = new System.Drawing.Point(427, 32);
            this.SaleButton.Name = "SaleButton";
            this.SaleButton.Size = new System.Drawing.Size(152, 42);
            this.SaleButton.TabIndex = 12;
            this.SaleButton.Text = "Sklep";
            this.SaleButton.UseVisualStyleBackColor = false;
            this.SaleButton.Click += new System.EventHandler(this.SaleButton_Click);
            // 
            // StockItemsBtn
            // 
            this.StockItemsBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.StockItemsBtn.FlatAppearance.BorderSize = 0;
            this.StockItemsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StockItemsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockItemsBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StockItemsBtn.Location = new System.Drawing.Point(121, 32);
            this.StockItemsBtn.Name = "StockItemsBtn";
            this.StockItemsBtn.Size = new System.Drawing.Size(147, 42);
            this.StockItemsBtn.TabIndex = 13;
            this.StockItemsBtn.Text = "Stan magazynu";
            this.StockItemsBtn.UseVisualStyleBackColor = false;
            this.StockItemsBtn.Click += new System.EventHandler(this.StockItemsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(713, 111);
            this.Controls.Add(this.StockItemsBtn);
            this.Controls.Add(this.SaleButton);
            this.Controls.Add(this.StockButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StockButton;
        private System.Windows.Forms.Button SaleButton;
        private System.Windows.Forms.Button StockItemsBtn;
    }
}


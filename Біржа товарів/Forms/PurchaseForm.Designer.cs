namespace Біржа_товарів.Forms
{
    partial class PurchaseForm
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
            ReturnLabel = new Label();
            PurchaseFormLabel = new Label();
            BuyButton = new Button();
            PriceLabel = new Label();
            TotalPriceLabel = new Label();
            ProductNameLabel = new Label();
            ProductAmount = new Label();
            numericUpDown1 = new NumericUpDown();
            ProductName = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // ReturnLabel
            // 
            ReturnLabel.AutoSize = true;
            ReturnLabel.Cursor = Cursors.Hand;
            ReturnLabel.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ReturnLabel.Location = new Point(12, 9);
            ReturnLabel.Name = "ReturnLabel";
            ReturnLabel.Size = new Size(33, 29);
            ReturnLabel.TabIndex = 2;
            ReturnLabel.Text = "<";
            // 
            // PurchaseFormLabel
            // 
            PurchaseFormLabel.AutoSize = true;
            PurchaseFormLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            PurchaseFormLabel.Location = new Point(205, 44);
            PurchaseFormLabel.Name = "PurchaseFormLabel";
            PurchaseFormLabel.Size = new Size(290, 50);
            PurchaseFormLabel.TabIndex = 3;
            PurchaseFormLabel.Text = "Покупка товару";
            // 
            // BuyButton
            // 
            BuyButton.Cursor = Cursors.Hand;
            BuyButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BuyButton.Location = new Point(260, 331);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(180, 45);
            BuyButton.TabIndex = 4;
            BuyButton.Text = "Купити";
            BuyButton.UseVisualStyleBackColor = true;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PriceLabel.Location = new Point(35, 280);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(246, 25);
            PriceLabel.TabIndex = 5;
            PriceLabel.Text = "Загальна вартість покупки:";
            // 
            // TotalPriceLabel
            // 
            TotalPriceLabel.AutoSize = true;
            TotalPriceLabel.Enabled = false;
            TotalPriceLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            TotalPriceLabel.Location = new Point(287, 280);
            TotalPriceLabel.Name = "TotalPriceLabel";
            TotalPriceLabel.Size = new Size(22, 25);
            TotalPriceLabel.TabIndex = 7;
            TotalPriceLabel.Text = "  ";
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ProductNameLabel.Location = new Point(35, 141);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(131, 25);
            ProductNameLabel.TabIndex = 8;
            ProductNameLabel.Text = "Назва товару:";
            // 
            // ProductAmount
            // 
            ProductAmount.AutoSize = true;
            ProductAmount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ProductAmount.Location = new Point(35, 186);
            ProductAmount.Name = "ProductAmount";
            ProductAmount.Size = new Size(93, 25);
            ProductAmount.TabIndex = 9;
            ProductAmount.Text = "Кількість:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Cursor = Cursors.Hand;
            numericUpDown1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(134, 186);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(53, 27);
            numericUpDown1.TabIndex = 10;
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.Enabled = false;
            ProductName.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            ProductName.Location = new Point(172, 141);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(22, 25);
            ProductName.TabIndex = 11;
            ProductName.Text = "  ";
            // 
            // PurchaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 401);
            Controls.Add(ProductName);
            Controls.Add(numericUpDown1);
            Controls.Add(ProductAmount);
            Controls.Add(ProductNameLabel);
            Controls.Add(TotalPriceLabel);
            Controls.Add(PriceLabel);
            Controls.Add(BuyButton);
            Controls.Add(PurchaseFormLabel);
            Controls.Add(ReturnLabel);
            Name = "PurchaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Біржа товарів";
            FormClosing += PurchaseForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ReturnLabel;
        private Label PurchaseFormLabel;
        private Button BuyButton;
        private Label PriceLabel;
        private Label TotalPriceLabel;
        private Label ProductNameLabel;
        private Label ProductAmount;
        private NumericUpDown numericUpDown1;
        private Label ProductName;
    }
}
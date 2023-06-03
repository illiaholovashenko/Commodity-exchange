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
            ProductNameLabel = new Label();
            ProductAmount = new Label();
            Amount = new NumericUpDown();
            ProductName = new Label();
            TotalPrice = new Label();
            AmountError = new Label();
            ((System.ComponentModel.ISupportInitialize)Amount).BeginInit();
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
            ReturnLabel.Click += ReturnLabel_Click;
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
            BuyButton.Click += BuyButton_Click;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PriceLabel.Location = new Point(35, 280);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(170, 25);
            PriceLabel.TabIndex = 5;
            PriceLabel.Text = "Загальна вартість:";
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
            // Amount
            // 
            Amount.Cursor = Cursors.Hand;
            Amount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Amount.Location = new Point(134, 186);
            Amount.Name = "Amount";
            Amount.Size = new Size(53, 27);
            Amount.TabIndex = 10;
            Amount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            Amount.ValueChanged += Amount_ValueChanged;
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            ProductName.Location = new Point(172, 141);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(0, 25);
            ProductName.TabIndex = 11;
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSize = true;
            TotalPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            TotalPrice.Location = new Point(211, 280);
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Size = new Size(0, 25);
            TotalPrice.TabIndex = 12;
            // 
            // AmountError
            // 
            AmountError.AutoSize = true;
            AmountError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AmountError.ForeColor = Color.Red;
            AmountError.Location = new Point(35, 211);
            AmountError.Name = "AmountError";
            AmountError.Size = new Size(0, 15);
            AmountError.TabIndex = 44;
            // 
            // PurchaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 401);
            Controls.Add(AmountError);
            Controls.Add(TotalPrice);
            Controls.Add(ProductName);
            Controls.Add(Amount);
            Controls.Add(ProductAmount);
            Controls.Add(ProductNameLabel);
            Controls.Add(PriceLabel);
            Controls.Add(BuyButton);
            Controls.Add(PurchaseFormLabel);
            Controls.Add(ReturnLabel);
            Name = "PurchaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Біржа товарів";
            FormClosing += PurchaseForm_FormClosing;
            Load += PurchaseForm_Load;
            ((System.ComponentModel.ISupportInitialize)Amount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ReturnLabel;
        private Label PurchaseFormLabel;
        private Button BuyButton;
        private Label PriceLabel;
        private Label ProductNameLabel;
        private Label ProductAmount;
        private NumericUpDown Amount;
        private Label ProductName;
        private Label TotalPrice;
        private Label AmountError;
    }
}
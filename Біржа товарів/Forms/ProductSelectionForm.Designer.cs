namespace Біржа_товарів.Forms
{
    partial class ProductSelectionForm
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
            foundProductList = new ListBox();
            ReturnLabel = new Label();
            MainLabel = new Label();
            PurchaseButton = new Button();
            PurchaseError = new Label();
            SuspendLayout();
            // 
            // foundProductList
            // 
            foundProductList.FormattingEnabled = true;
            foundProductList.ItemHeight = 15;
            foundProductList.Location = new Point(39, 77);
            foundProductList.Name = "foundProductList";
            foundProductList.Size = new Size(350, 469);
            foundProductList.TabIndex = 0;
            // 
            // ReturnLabel
            // 
            ReturnLabel.AutoSize = true;
            ReturnLabel.Cursor = Cursors.Hand;
            ReturnLabel.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ReturnLabel.Location = new Point(12, 9);
            ReturnLabel.Name = "ReturnLabel";
            ReturnLabel.Size = new Size(33, 29);
            ReturnLabel.TabIndex = 37;
            ReturnLabel.Text = "<";
            ReturnLabel.Click += ReturnLabel_Click;
            // 
            // MainLabel
            // 
            MainLabel.AutoSize = true;
            MainLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            MainLabel.Location = new Point(93, 9);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(263, 45);
            MainLabel.TabIndex = 38;
            MainLabel.Text = "Знайдені товари";
            // 
            // PurchaseButton
            // 
            PurchaseButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PurchaseButton.Location = new Point(107, 591);
            PurchaseButton.Name = "PurchaseButton";
            PurchaseButton.Size = new Size(236, 48);
            PurchaseButton.TabIndex = 39;
            PurchaseButton.Text = "Купити";
            PurchaseButton.UseVisualStyleBackColor = true;
            PurchaseButton.Click += PurchaseButton_Click;
            // 
            // PurchaseError
            // 
            PurchaseError.AutoSize = true;
            PurchaseError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PurchaseError.ForeColor = Color.Red;
            PurchaseError.Location = new Point(107, 573);
            PurchaseError.Name = "PurchaseError";
            PurchaseError.Size = new Size(0, 15);
            PurchaseError.TabIndex = 40;
            // 
            // ProductSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 651);
            Controls.Add(PurchaseError);
            Controls.Add(PurchaseButton);
            Controls.Add(MainLabel);
            Controls.Add(ReturnLabel);
            Controls.Add(foundProductList);
            Name = "ProductSelectionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductSelectionForm";
            FormClosing += ProductSelectionForm_FormClosing;
            Load += ProductSelectionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox foundProductList;
        private Label ReturnLabel;
        private Label MainLabel;
        private Button PurchaseButton;
        private Label PurchaseError;
    }
}
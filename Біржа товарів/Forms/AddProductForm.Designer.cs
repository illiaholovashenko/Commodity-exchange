namespace Біржа_товарів.Forms
{
    partial class AddProductForm
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
            AddProductLable = new Label();
            UnitPriceLabel = new Label();
            ProductAmount = new Label();
            ProductAmountField = new TextBox();
            AddProductButton = new Button();
            SuspendLayout();
            // 
            // AddProductLable
            // 
            AddProductLable.AutoSize = true;
            AddProductLable.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            AddProductLable.Location = new Point(102, 20);
            AddProductLable.Name = "AddProductLable";
            AddProductLable.Size = new Size(255, 45);
            AddProductLable.TabIndex = 19;
            AddProductLable.Text = "Додання товару";
            // 
            // UnitPriceLabel
            // 
            UnitPriceLabel.AutoSize = true;
            UnitPriceLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            UnitPriceLabel.Location = new Point(35, 168);
            UnitPriceLabel.Name = "UnitPriceLabel";
            UnitPriceLabel.Size = new Size(178, 30);
            UnitPriceLabel.TabIndex = 20;
            UnitPriceLabel.Text = "Ціна за одиницю";
            // 
            // ProductAmount
            // 
            ProductAmount.AutoSize = true;
            ProductAmount.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ProductAmount.Location = new Point(294, 168);
            ProductAmount.Name = "ProductAmount";
            ProductAmount.Size = new Size(130, 30);
            ProductAmount.TabIndex = 21;
            ProductAmount.Text = "Обсяг партії";
            // 
            // ProductAmountField
            // 
            ProductAmountField.Location = new Point(294, 201);
            ProductAmountField.MaxLength = 5;
            ProductAmountField.Name = "ProductAmountField";
            ProductAmountField.Size = new Size(115, 23);
            ProductAmountField.TabIndex = 22;
            // 
            // AddProductButton
            // 
            AddProductButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AddProductButton.Location = new Point(142, 524);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(200, 55);
            AddProductButton.TabIndex = 23;
            AddProductButton.Text = "Додати товар";
            AddProductButton.UseVisualStyleBackColor = true;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 591);
            Controls.Add(AddProductButton);
            Controls.Add(ProductAmountField);
            Controls.Add(ProductAmount);
            Controls.Add(UnitPriceLabel);
            Controls.Add(AddProductLable);
            Name = "AddProductForm";
            Text = "Біржа товарів";
            Controls.SetChildIndex(AddProductLable, 0);
            Controls.SetChildIndex(UnitPriceLabel, 0);
            Controls.SetChildIndex(ProductAmount, 0);
            Controls.SetChildIndex(ProductAmountField, 0);
            Controls.SetChildIndex(AddProductButton, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddProductLable;
        private Label UnitPriceLabel;
        private Label ProductAmount;
        private TextBox ProductAmountField;
        private Button AddProductButton;
    }
}
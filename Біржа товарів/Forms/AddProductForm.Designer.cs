﻿namespace Біржа_товарів.Forms
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
            DeliveryConditionBox = new ComboBox();
            PaymentFormBox = new ComboBox();
            NotesField = new TextBox();
            NotesLabel = new Label();
            DeliveryConditionLabel = new Label();
            AdressField = new TextBox();
            AdressLabel = new Label();
            PaymentFormLabel = new Label();
            ProductPriceField = new TextBox();
            ProductNameField = new TextBox();
            ProductNameLabel = new Label();
            ReturnLabel = new Label();
            ProductNameError = new Label();
            ProductPriceError = new Label();
            AdressError = new Label();
            PaymentFormError = new Label();
            DeliveryConditionError = new Label();
            NotesError = new Label();
            AmountError = new Label();
            MainError = new Label();
            SuspendLayout();
            // 
            // AddProductLable
            // 
            AddProductLable.Anchor = AnchorStyles.Top;
            AddProductLable.AutoSize = true;
            AddProductLable.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            AddProductLable.Location = new Point(95, 20);
            AddProductLable.Name = "AddProductLable";
            AddProductLable.Size = new Size(255, 45);
            AddProductLable.TabIndex = 19;
            AddProductLable.Text = "Додання товару";
            // 
            // UnitPriceLabel
            // 
            UnitPriceLabel.Anchor = AnchorStyles.Left;
            UnitPriceLabel.AutoSize = true;
            UnitPriceLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            UnitPriceLabel.Location = new Point(35, 161);
            UnitPriceLabel.Name = "UnitPriceLabel";
            UnitPriceLabel.Size = new Size(178, 30);
            UnitPriceLabel.TabIndex = 20;
            UnitPriceLabel.Text = "Ціна за одиницю";
            // 
            // ProductAmount
            // 
            ProductAmount.Anchor = AnchorStyles.Left;
            ProductAmount.AutoSize = true;
            ProductAmount.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ProductAmount.Location = new Point(294, 161);
            ProductAmount.Name = "ProductAmount";
            ProductAmount.Size = new Size(130, 30);
            ProductAmount.TabIndex = 21;
            ProductAmount.Text = "Обсяг партії";
            // 
            // ProductAmountField
            // 
            ProductAmountField.Anchor = AnchorStyles.Left;
            ProductAmountField.Location = new Point(294, 194);
            ProductAmountField.MaxLength = 6;
            ProductAmountField.Name = "ProductAmountField";
            ProductAmountField.Size = new Size(115, 23);
            ProductAmountField.TabIndex = 22;
            ProductAmountField.TabStop = false;
            ProductAmountField.Validating += ProductAmountField_Validating;
            ProductAmountField.Validated += ProductAmountField_Validated;
            // 
            // AddProductButton
            // 
            AddProductButton.Anchor = AnchorStyles.Bottom;
            AddProductButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AddProductButton.Location = new Point(126, 569);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(200, 55);
            AddProductButton.TabIndex = 23;
            AddProductButton.Text = "Додати товар";
            AddProductButton.UseVisualStyleBackColor = true;
            AddProductButton.Click += AddProductButton_Click;
            // 
            // DeliveryConditionBox
            // 
            DeliveryConditionBox.AccessibleRole = AccessibleRole.None;
            DeliveryConditionBox.Anchor = AnchorStyles.Left;
            DeliveryConditionBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeliveryConditionBox.Items.AddRange(new object[] { "Вся Україна", "Вся Європа", "Весь світ" });
            DeliveryConditionBox.Location = new Point(35, 400);
            DeliveryConditionBox.Name = "DeliveryConditionBox";
            DeliveryConditionBox.Size = new Size(215, 23);
            DeliveryConditionBox.TabIndex = 34;
            // 
            // PaymentFormBox
            // 
            PaymentFormBox.AccessibleRole = AccessibleRole.None;
            PaymentFormBox.Anchor = AnchorStyles.Left;
            PaymentFormBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PaymentFormBox.Items.AddRange(new object[] { "Готівка", "Картка Visa", "Картка MasterCard" });
            PaymentFormBox.Location = new Point(35, 261);
            PaymentFormBox.Name = "PaymentFormBox";
            PaymentFormBox.Size = new Size(215, 23);
            PaymentFormBox.TabIndex = 33;
            // 
            // NotesField
            // 
            NotesField.Anchor = AnchorStyles.Left;
            NotesField.Location = new Point(35, 467);
            NotesField.MaxLength = 100;
            NotesField.Multiline = true;
            NotesField.Name = "NotesField";
            NotesField.Size = new Size(215, 60);
            NotesField.TabIndex = 32;
            NotesField.Validating += NotesField_Validating;
            NotesField.Validated += NotesField_Validated;
            // 
            // NotesLabel
            // 
            NotesLabel.Anchor = AnchorStyles.Left;
            NotesLabel.AutoSize = true;
            NotesLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            NotesLabel.Location = new Point(35, 434);
            NotesLabel.Name = "NotesLabel";
            NotesLabel.Size = new Size(103, 30);
            NotesLabel.TabIndex = 31;
            NotesLabel.Text = "Примітки";
            // 
            // DeliveryConditionLabel
            // 
            DeliveryConditionLabel.Anchor = AnchorStyles.Left;
            DeliveryConditionLabel.AutoSize = true;
            DeliveryConditionLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            DeliveryConditionLabel.Location = new Point(35, 367);
            DeliveryConditionLabel.Name = "DeliveryConditionLabel";
            DeliveryConditionLabel.Size = new Size(166, 30);
            DeliveryConditionLabel.TabIndex = 30;
            DeliveryConditionLabel.Text = "Умова доставки";
            // 
            // AdressField
            // 
            AdressField.Anchor = AnchorStyles.Left;
            AdressField.Location = new Point(35, 332);
            AdressField.MaxLength = 100;
            AdressField.Name = "AdressField";
            AdressField.PlaceholderText = "Країна, Місто, Вулиця Номер";
            AdressField.Size = new Size(215, 23);
            AdressField.TabIndex = 29;
            AdressField.Validating += AdressField_Validating;
            AdressField.Validated += AdressField_Validated;
            // 
            // AdressLabel
            // 
            AdressLabel.Anchor = AnchorStyles.Left;
            AdressLabel.AutoSize = true;
            AdressLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AdressLabel.Location = new Point(35, 299);
            AdressLabel.Name = "AdressLabel";
            AdressLabel.Size = new Size(240, 30);
            AdressLabel.TabIndex = 28;
            AdressLabel.Text = "Адреса для самовивозу";
            // 
            // PaymentFormLabel
            // 
            PaymentFormLabel.Anchor = AnchorStyles.Left;
            PaymentFormLabel.AutoSize = true;
            PaymentFormLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PaymentFormLabel.Location = new Point(35, 228);
            PaymentFormLabel.Name = "PaymentFormLabel";
            PaymentFormLabel.Size = new Size(151, 30);
            PaymentFormLabel.TabIndex = 27;
            PaymentFormLabel.Text = "Форма оплати";
            // 
            // ProductPriceField
            // 
            ProductPriceField.Anchor = AnchorStyles.Left;
            ProductPriceField.Location = new Point(35, 194);
            ProductPriceField.MaxLength = 9;
            ProductPriceField.Name = "ProductPriceField";
            ProductPriceField.Size = new Size(215, 23);
            ProductPriceField.TabIndex = 26;
            ProductPriceField.Validating += ProductPriceField_Validating;
            ProductPriceField.Validated += ProductPriceField_Validated;
            // 
            // ProductNameField
            // 
            ProductNameField.Anchor = AnchorStyles.Left;
            ProductNameField.Location = new Point(35, 126);
            ProductNameField.MaxLength = 100;
            ProductNameField.Name = "ProductNameField";
            ProductNameField.Size = new Size(215, 23);
            ProductNameField.TabIndex = 25;
            ProductNameField.Validating += ProductNameField_Validating;
            ProductNameField.Validated += ProductNameField_Validated;
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.Anchor = AnchorStyles.Left;
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ProductNameLabel.Location = new Point(35, 93);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(141, 30);
            ProductNameLabel.TabIndex = 24;
            ProductNameLabel.Text = "Назва товару";
            // 
            // ReturnLabel
            // 
            ReturnLabel.AutoSize = true;
            ReturnLabel.Cursor = Cursors.Hand;
            ReturnLabel.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ReturnLabel.Location = new Point(12, 9);
            ReturnLabel.Name = "ReturnLabel";
            ReturnLabel.Size = new Size(33, 29);
            ReturnLabel.TabIndex = 35;
            ReturnLabel.Text = "<";
            ReturnLabel.Click += ReturnLabel_Click;
            // 
            // ProductNameError
            // 
            ProductNameError.Anchor = AnchorStyles.Left;
            ProductNameError.AutoSize = true;
            ProductNameError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ProductNameError.ForeColor = Color.Red;
            ProductNameError.Location = new Point(35, 152);
            ProductNameError.Name = "ProductNameError";
            ProductNameError.Size = new Size(0, 15);
            ProductNameError.TabIndex = 38;
            // 
            // ProductPriceError
            // 
            ProductPriceError.Anchor = AnchorStyles.Left;
            ProductPriceError.AutoSize = true;
            ProductPriceError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ProductPriceError.ForeColor = Color.Red;
            ProductPriceError.Location = new Point(35, 220);
            ProductPriceError.Name = "ProductPriceError";
            ProductPriceError.Size = new Size(0, 15);
            ProductPriceError.TabIndex = 39;
            // 
            // AdressError
            // 
            AdressError.Anchor = AnchorStyles.Left;
            AdressError.AutoSize = true;
            AdressError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AdressError.ForeColor = Color.Red;
            AdressError.Location = new Point(35, 358);
            AdressError.Name = "AdressError";
            AdressError.Size = new Size(0, 15);
            AdressError.TabIndex = 41;
            // 
            // PaymentFormError
            // 
            PaymentFormError.Anchor = AnchorStyles.Left;
            PaymentFormError.AutoSize = true;
            PaymentFormError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PaymentFormError.ForeColor = Color.Red;
            PaymentFormError.Location = new Point(35, 287);
            PaymentFormError.Name = "PaymentFormError";
            PaymentFormError.Size = new Size(0, 15);
            PaymentFormError.TabIndex = 42;
            // 
            // DeliveryConditionError
            // 
            DeliveryConditionError.Anchor = AnchorStyles.Left;
            DeliveryConditionError.AutoSize = true;
            DeliveryConditionError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DeliveryConditionError.ForeColor = Color.Red;
            DeliveryConditionError.Location = new Point(35, 426);
            DeliveryConditionError.Name = "DeliveryConditionError";
            DeliveryConditionError.Size = new Size(0, 15);
            DeliveryConditionError.TabIndex = 43;
            // 
            // NotesError
            // 
            NotesError.Anchor = AnchorStyles.Left;
            NotesError.AutoSize = true;
            NotesError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NotesError.ForeColor = Color.Red;
            NotesError.Location = new Point(35, 530);
            NotesError.Name = "NotesError";
            NotesError.Size = new Size(0, 15);
            NotesError.TabIndex = 44;
            // 
            // AmountError
            // 
            AmountError.Anchor = AnchorStyles.Left;
            AmountError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AmountError.ForeColor = Color.Red;
            AmountError.Location = new Point(294, 220);
            AmountError.Name = "AmountError";
            AmountError.Size = new Size(163, 38);
            AmountError.TabIndex = 45;
            // 
            // MainError
            // 
            MainError.Anchor = AnchorStyles.Bottom;
            MainError.AutoSize = true;
            MainError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MainError.ForeColor = Color.Red;
            MainError.Location = new Point(77, 550);
            MainError.Name = "MainError";
            MainError.Size = new Size(0, 15);
            MainError.TabIndex = 46;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 636);
            Controls.Add(MainError);
            Controls.Add(AmountError);
            Controls.Add(NotesError);
            Controls.Add(DeliveryConditionError);
            Controls.Add(PaymentFormError);
            Controls.Add(AdressError);
            Controls.Add(ProductPriceError);
            Controls.Add(ProductNameError);
            Controls.Add(ReturnLabel);
            Controls.Add(DeliveryConditionBox);
            Controls.Add(PaymentFormBox);
            Controls.Add(NotesField);
            Controls.Add(NotesLabel);
            Controls.Add(DeliveryConditionLabel);
            Controls.Add(AdressField);
            Controls.Add(AdressLabel);
            Controls.Add(PaymentFormLabel);
            Controls.Add(ProductPriceField);
            Controls.Add(ProductNameField);
            Controls.Add(ProductNameLabel);
            Controls.Add(AddProductButton);
            Controls.Add(ProductAmountField);
            Controls.Add(ProductAmount);
            Controls.Add(UnitPriceLabel);
            Controls.Add(AddProductLable);
            MaximumSize = new Size(800, 920);
            MinimumSize = new Size(450, 660);
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Біржа товарів";
            FormClosing += AddProductForm_FormClosing;
            Load += AddProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddProductLable;
        private Label UnitPriceLabel;
        private Label ProductAmount;
        private TextBox ProductAmountField;
        private Button AddProductButton;
        private ComboBox DeliveryConditionBox;
        private ComboBox PaymentFormBox;
        private TextBox NotesField;
        private Label NotesLabel;
        private Label DeliveryConditionLabel;
        private TextBox AdressField;
        private Label AdressLabel;
        private Label PaymentFormLabel;
        private TextBox ProductPriceField;
        private TextBox ProductNameField;
        private Label ProductNameLabel;
        private Label ReturnLabel;
        private Label ProductNameError;
        private Label ProductPriceError;
        private Label AdressError;
        private Label PaymentFormError;
        private Label DeliveryConditionError;
        private Label NotesError;
        private Label AmountError;
        private Label MainError;
    }
}
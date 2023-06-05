namespace Біржа_товарів.Forms
{
    partial class SearchProductForm
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
            SearcProductLabel = new Label();
            label1 = new Label();
            SearchProductButton = new Button();
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
            PaymentFormError = new Label();
            AdressError = new Label();
            DeliveryConditionError = new Label();
            NotesError = new Label();
            MainError = new Label();
            SuspendLayout();
            // 
            // SearcProductLabel
            // 
            SearcProductLabel.AutoSize = true;
            SearcProductLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            SearcProductLabel.Location = new Point(112, 22);
            SearcProductLabel.Name = "SearcProductLabel";
            SearcProductLabel.Size = new Size(227, 45);
            SearcProductLabel.TabIndex = 20;
            SearcProductLabel.Text = "Пошук товару";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 173);
            label1.Name = "label1";
            label1.Size = new Size(133, 30);
            label1.TabIndex = 21;
            label1.Text = "Бажана ціна";
            // 
            // SearchProductButton
            // 
            SearchProductButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SearchProductButton.Location = new Point(112, 581);
            SearchProductButton.Name = "SearchProductButton";
            SearchProductButton.Size = new Size(200, 55);
            SearchProductButton.TabIndex = 24;
            SearchProductButton.Text = "Знайти товар";
            SearchProductButton.UseVisualStyleBackColor = true;
            SearchProductButton.Click += SearchProductButton_Click;
            // 
            // DeliveryConditionBox
            // 
            DeliveryConditionBox.AccessibleRole = AccessibleRole.None;
            DeliveryConditionBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeliveryConditionBox.Items.AddRange(new object[] { "Вся Україна", "Вся Європа (крім рф та Білорусії)", "Весь світ (крім рф та Білорусії)" });
            DeliveryConditionBox.Location = new Point(35, 407);
            DeliveryConditionBox.Name = "DeliveryConditionBox";
            DeliveryConditionBox.Size = new Size(215, 23);
            DeliveryConditionBox.TabIndex = 35;
            // 
            // PaymentFormBox
            // 
            PaymentFormBox.AccessibleRole = AccessibleRole.None;
            PaymentFormBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PaymentFormBox.Items.AddRange(new object[] { "Готівка", "Картка Visa", "Картка MasterCard" });
            PaymentFormBox.Location = new Point(35, 273);
            PaymentFormBox.Name = "PaymentFormBox";
            PaymentFormBox.Size = new Size(215, 23);
            PaymentFormBox.TabIndex = 34;
            // 
            // NotesField
            // 
            NotesField.Location = new Point(35, 474);
            NotesField.MaxLength = 100;
            NotesField.Multiline = true;
            NotesField.Name = "NotesField";
            NotesField.Size = new Size(215, 60);
            NotesField.TabIndex = 33;
            NotesField.Validating += NotesField_Validating;
            NotesField.Validated += NotesField_Validated;
            // 
            // NotesLabel
            // 
            NotesLabel.AutoSize = true;
            NotesLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            NotesLabel.Location = new Point(35, 441);
            NotesLabel.Name = "NotesLabel";
            NotesLabel.Size = new Size(103, 30);
            NotesLabel.TabIndex = 32;
            NotesLabel.Text = "Примітки";
            // 
            // DeliveryConditionLabel
            // 
            DeliveryConditionLabel.AutoSize = true;
            DeliveryConditionLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            DeliveryConditionLabel.Location = new Point(35, 374);
            DeliveryConditionLabel.Name = "DeliveryConditionLabel";
            DeliveryConditionLabel.Size = new Size(166, 30);
            DeliveryConditionLabel.TabIndex = 31;
            DeliveryConditionLabel.Text = "Умова доставки";
            // 
            // AdressField
            // 
            AdressField.Location = new Point(35, 339);
            AdressField.MaxLength = 100;
            AdressField.Name = "AdressField";
            AdressField.PlaceholderText = "Країна, Індекс, Місто, Вулиця Номер";
            AdressField.Size = new Size(215, 23);
            AdressField.TabIndex = 30;
            AdressField.Validating += AdressField_Validating;
            AdressField.Validated += AdressField_Validated;
            // 
            // AdressLabel
            // 
            AdressLabel.AutoSize = true;
            AdressLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AdressLabel.Location = new Point(35, 306);
            AdressLabel.Name = "AdressLabel";
            AdressLabel.Size = new Size(240, 30);
            AdressLabel.TabIndex = 29;
            AdressLabel.Text = "Адреса для самовивозу";
            // 
            // PaymentFormLabel
            // 
            PaymentFormLabel.AutoSize = true;
            PaymentFormLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PaymentFormLabel.Location = new Point(35, 240);
            PaymentFormLabel.Name = "PaymentFormLabel";
            PaymentFormLabel.Size = new Size(151, 30);
            PaymentFormLabel.TabIndex = 28;
            PaymentFormLabel.Text = "Форма оплати";
            // 
            // ProductPriceField
            // 
            ProductPriceField.Location = new Point(35, 206);
            ProductPriceField.MaxLength = 9;
            ProductPriceField.Name = "ProductPriceField";
            ProductPriceField.Size = new Size(215, 23);
            ProductPriceField.TabIndex = 27;
            ProductPriceField.Validating += ProductPriceField_Validating;
            ProductPriceField.Validated += ProductPriceField_Validated;
            // 
            // ProductNameField
            // 
            ProductNameField.Location = new Point(35, 138);
            ProductNameField.MaxLength = 100;
            ProductNameField.Name = "ProductNameField";
            ProductNameField.Size = new Size(215, 23);
            ProductNameField.TabIndex = 26;
            ProductNameField.Validating += ProductNameField_Validating;
            ProductNameField.Validated += ProductNameField_Validated;
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ProductNameLabel.Location = new Point(35, 105);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(141, 30);
            ProductNameLabel.TabIndex = 25;
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
            ReturnLabel.TabIndex = 36;
            ReturnLabel.Text = "<";
            ReturnLabel.Click += ReturnLabel_Click;
            // 
            // ProductNameError
            // 
            ProductNameError.AutoSize = true;
            ProductNameError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ProductNameError.ForeColor = Color.Red;
            ProductNameError.Location = new Point(35, 164);
            ProductNameError.Name = "ProductNameError";
            ProductNameError.Size = new Size(0, 15);
            ProductNameError.TabIndex = 37;
            // 
            // ProductPriceError
            // 
            ProductPriceError.AutoSize = true;
            ProductPriceError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ProductPriceError.ForeColor = Color.Red;
            ProductPriceError.Location = new Point(35, 232);
            ProductPriceError.Name = "ProductPriceError";
            ProductPriceError.Size = new Size(0, 15);
            ProductPriceError.TabIndex = 38;
            // 
            // PaymentFormError
            // 
            PaymentFormError.AutoSize = true;
            PaymentFormError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PaymentFormError.ForeColor = Color.Red;
            PaymentFormError.Location = new Point(35, 299);
            PaymentFormError.Name = "PaymentFormError";
            PaymentFormError.Size = new Size(0, 15);
            PaymentFormError.TabIndex = 39;
            // 
            // AdressError
            // 
            AdressError.AutoSize = true;
            AdressError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AdressError.ForeColor = Color.Red;
            AdressError.Location = new Point(35, 365);
            AdressError.Name = "AdressError";
            AdressError.Size = new Size(0, 15);
            AdressError.TabIndex = 40;
            // 
            // DeliveryConditionError
            // 
            DeliveryConditionError.AutoSize = true;
            DeliveryConditionError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DeliveryConditionError.ForeColor = Color.Red;
            DeliveryConditionError.Location = new Point(35, 433);
            DeliveryConditionError.Name = "DeliveryConditionError";
            DeliveryConditionError.Size = new Size(0, 15);
            DeliveryConditionError.TabIndex = 41;
            // 
            // NotesError
            // 
            NotesError.AutoSize = true;
            NotesError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NotesError.ForeColor = Color.Red;
            NotesError.Location = new Point(35, 537);
            NotesError.Name = "NotesError";
            NotesError.Size = new Size(0, 15);
            NotesError.TabIndex = 42;
            // 
            // MainError
            // 
            MainError.AutoSize = true;
            MainError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MainError.ForeColor = Color.Red;
            MainError.Location = new Point(74, 563);
            MainError.Name = "MainError";
            MainError.Size = new Size(0, 15);
            MainError.TabIndex = 43;
            // 
            // SearchProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 651);
            Controls.Add(MainError);
            Controls.Add(NotesError);
            Controls.Add(DeliveryConditionError);
            Controls.Add(AdressError);
            Controls.Add(PaymentFormError);
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
            Controls.Add(SearchProductButton);
            Controls.Add(label1);
            Controls.Add(SearcProductLabel);
            Name = "SearchProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Біржа товарів";
            FormClosing += SearchProductForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SearcProductLabel;
        private Label label1;
        private Button SearchProductButton;
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
        private Label PaymentFormError;
        private Label AdressError;
        private Label DeliveryConditionError;
        private Label NotesError;
        private Label MainError;
    }
}
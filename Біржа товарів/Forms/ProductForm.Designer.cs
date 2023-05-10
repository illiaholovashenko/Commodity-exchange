namespace Біржа_товарів.Forms
{
    partial class ProductForm
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
            ProductNameLabel = new Label();
            ProductNameField = new TextBox();
            PaymentFormLabel = new Label();
            ProductPriceField = new TextBox();
            NotesField = new TextBox();
            NotesLabel = new Label();
            DeliveryConditionLabel = new Label();
            AdressField = new TextBox();
            AdressLabel = new Label();
            PaymentFormBox = new ComboBox();
            DeliveryConditionBox = new ComboBox();
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
            ReturnLabel.TabIndex = 1;
            ReturnLabel.Text = "<";
            ReturnLabel.Click += ReturnLabel_Click;
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ProductNameLabel.Location = new Point(35, 100);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(141, 30);
            ProductNameLabel.TabIndex = 2;
            ProductNameLabel.Text = "Назва товару";
            // 
            // ProductNameField
            // 
            ProductNameField.Location = new Point(35, 133);
            ProductNameField.MaxLength = 100;
            ProductNameField.Name = "ProductNameField";
            ProductNameField.Size = new Size(215, 23);
            ProductNameField.TabIndex = 3;
            // 
            // PaymentFormLabel
            // 
            PaymentFormLabel.AutoSize = true;
            PaymentFormLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PaymentFormLabel.Location = new Point(35, 235);
            PaymentFormLabel.Name = "PaymentFormLabel";
            PaymentFormLabel.Size = new Size(151, 30);
            PaymentFormLabel.TabIndex = 8;
            PaymentFormLabel.Text = "Форма оплати";
            // 
            // ProductPriceField
            // 
            ProductPriceField.Location = new Point(35, 201);
            ProductPriceField.MaxLength = 100;
            ProductPriceField.Name = "ProductPriceField";
            ProductPriceField.Size = new Size(215, 23);
            ProductPriceField.TabIndex = 7;
            // 
            // NotesField
            // 
            NotesField.Location = new Point(35, 474);
            NotesField.MaxLength = 100;
            NotesField.Name = "NotesField";
            NotesField.Size = new Size(215, 23);
            NotesField.TabIndex = 15;
            // 
            // NotesLabel
            // 
            NotesLabel.AutoSize = true;
            NotesLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            NotesLabel.Location = new Point(35, 441);
            NotesLabel.Name = "NotesLabel";
            NotesLabel.Size = new Size(103, 30);
            NotesLabel.TabIndex = 14;
            NotesLabel.Text = "Примітки";
            // 
            // DeliveryConditionLabel
            // 
            DeliveryConditionLabel.AutoSize = true;
            DeliveryConditionLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            DeliveryConditionLabel.Location = new Point(35, 374);
            DeliveryConditionLabel.Name = "DeliveryConditionLabel";
            DeliveryConditionLabel.Size = new Size(166, 30);
            DeliveryConditionLabel.TabIndex = 12;
            DeliveryConditionLabel.Text = "Умова доставки";
            // 
            // AdressField
            // 
            AdressField.Location = new Point(35, 339);
            AdressField.MaxLength = 100;
            AdressField.Name = "AdressField";
            AdressField.Size = new Size(215, 23);
            AdressField.TabIndex = 11;
            // 
            // AdressLabel
            // 
            AdressLabel.AutoSize = true;
            AdressLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AdressLabel.Location = new Point(35, 306);
            AdressLabel.Name = "AdressLabel";
            AdressLabel.Size = new Size(240, 30);
            AdressLabel.TabIndex = 10;
            AdressLabel.Text = "Адреса для самовивозу";
            // 
            // PaymentFormBox
            // 
            PaymentFormBox.AccessibleRole = AccessibleRole.None;
            PaymentFormBox.Items.AddRange(new object[] { "Готівка", "Картка Visa", "Картка MasterCard" });
            PaymentFormBox.Location = new Point(35, 268);
            PaymentFormBox.Name = "PaymentFormBox";
            PaymentFormBox.Size = new Size(215, 23);
            PaymentFormBox.TabIndex = 17;
            // 
            // DeliveryConditionBox
            // 
            DeliveryConditionBox.AccessibleRole = AccessibleRole.None;
            DeliveryConditionBox.Items.AddRange(new object[] { "Вся Україна", "Вся Європа (крім рф та Білорусії)", "Весь світ (крім рф та Білорусії)" });
            DeliveryConditionBox.Location = new Point(35, 407);
            DeliveryConditionBox.Name = "DeliveryConditionBox";
            DeliveryConditionBox.Size = new Size(215, 23);
            DeliveryConditionBox.TabIndex = 18;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 561);
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
            Controls.Add(ReturnLabel);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Біржа товарів";
            FormClosing += ProductForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ReturnLabel;
        private Label ProductNameLabel;
        private TextBox ProductNameField;
        private Label PaymentFormLabel;
        private TextBox ProductPriceField;
        private TextBox NotesField;
        private Label NotesLabel;
        private Label DeliveryConditionLabel;
        private TextBox AdressField;
        private Label AdressLabel;
        private ComboBox PaymentFormBox;
        private ComboBox DeliveryConditionBox;
    }
}
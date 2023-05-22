namespace Біржа_товарів.Forms
{
    partial class RegistrationForm
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
            RagistrationLabel = new Label();
            SalesMan = new RadioButton();
            Buyer = new RadioButton();
            NameLabel = new Label();
            NameField = new TextBox();
            SurnameLable = new Label();
            PhoneNumberLabel = new Label();
            LoginLable = new Label();
            PasswordLabel = new Label();
            SurnameField = new TextBox();
            PhoneField = new TextBox();
            LoginField = new TextBox();
            PasswordField = new TextBox();
            RegistrationButton = new Button();
            ToAuthorizationFormLink = new LinkLabel();
            NameError = new Label();
            SurnameError = new Label();
            PhoneError = new Label();
            LoginError = new Label();
            PasswordError = new Label();
            MainError = new Label();
            SuspendLayout();
            // 
            // RagistrationLabel
            // 
            RagistrationLabel.AutoSize = true;
            RagistrationLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            RagistrationLabel.Location = new Point(35, 40);
            RagistrationLabel.Name = "RagistrationLabel";
            RagistrationLabel.Size = new Size(202, 50);
            RagistrationLabel.TabIndex = 0;
            RagistrationLabel.Text = "Реєстрація";
            // 
            // SalesMan
            // 
            SalesMan.AutoSize = true;
            SalesMan.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SalesMan.Location = new Point(98, 142);
            SalesMan.Name = "SalesMan";
            SalesMan.Size = new Size(127, 29);
            SalesMan.TabIndex = 1;
            SalesMan.TabStop = true;
            SalesMan.Text = "Продавець";
            SalesMan.UseVisualStyleBackColor = true;
            // 
            // Buyer
            // 
            Buyer.AutoSize = true;
            Buyer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Buyer.Location = new Point(256, 142);
            Buyer.Name = "Buyer";
            Buyer.Size = new Size(115, 29);
            Buyer.TabIndex = 2;
            Buyer.TabStop = true;
            Buyer.Text = "Покупець";
            Buyer.UseVisualStyleBackColor = true;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(35, 183);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(50, 30);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Ім'я";
            // 
            // NameField
            // 
            NameField.Location = new Point(35, 216);
            NameField.MaxLength = 100;
            NameField.Name = "NameField";
            NameField.Size = new Size(215, 23);
            NameField.TabIndex = 4;
            NameField.Validating += NameField_Validating;
            NameField.Validated += NameField_Validated;
            // 
            // SurnameLable
            // 
            SurnameLable.AutoSize = true;
            SurnameLable.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SurnameLable.Location = new Point(35, 253);
            SurnameLable.Name = "SurnameLable";
            SurnameLable.Size = new Size(105, 30);
            SurnameLable.TabIndex = 5;
            SurnameLable.Text = "Прізвище";
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumberLabel.Location = new Point(35, 322);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(174, 30);
            PhoneNumberLabel.TabIndex = 6;
            PhoneNumberLabel.Text = "Номер телефону";
            // 
            // LoginLable
            // 
            LoginLable.AutoSize = true;
            LoginLable.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LoginLable.Location = new Point(35, 395);
            LoginLable.Name = "LoginLable";
            LoginLable.Size = new Size(64, 30);
            LoginLable.TabIndex = 7;
            LoginLable.Text = "Логін";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(35, 463);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(85, 30);
            PasswordLabel.TabIndex = 8;
            PasswordLabel.Text = "Пароль";
            // 
            // SurnameField
            // 
            SurnameField.Location = new Point(35, 286);
            SurnameField.MaxLength = 100;
            SurnameField.Name = "SurnameField";
            SurnameField.Size = new Size(215, 23);
            SurnameField.TabIndex = 9;
            SurnameField.Validating += SurnameField_Validating;
            SurnameField.Validated += SurnameField_Validated;
            // 
            // PhoneField
            // 
            PhoneField.Location = new Point(35, 355);
            PhoneField.MaxLength = 16;
            PhoneField.Name = "PhoneField";
            PhoneField.PlaceholderText = "+380-__-___-____";
            PhoneField.Size = new Size(215, 23);
            PhoneField.TabIndex = 10;
            PhoneField.Validating += PhoneField_Validating;
            PhoneField.Validated += PhoneField_Validated;
            // 
            // LoginField
            // 
            LoginField.Location = new Point(35, 428);
            LoginField.MaxLength = 100;
            LoginField.Name = "LoginField";
            LoginField.Size = new Size(215, 23);
            LoginField.TabIndex = 11;
            LoginField.Validating += LoginField_Validating;
            LoginField.Validated += LoginField_Validated;
            // 
            // PasswordField
            // 
            PasswordField.Location = new Point(35, 496);
            PasswordField.MaxLength = 100;
            PasswordField.Name = "PasswordField";
            PasswordField.PasswordChar = '*';
            PasswordField.Size = new Size(215, 23);
            PasswordField.TabIndex = 12;
            PasswordField.UseSystemPasswordChar = true;
            PasswordField.Validating += PasswordField_Validating;
            PasswordField.Validated += PasswordField_Validated;
            // 
            // RegistrationButton
            // 
            RegistrationButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            RegistrationButton.Location = new Point(127, 555);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(236, 48);
            RegistrationButton.TabIndex = 13;
            RegistrationButton.Text = "Зареєструватись";
            RegistrationButton.UseVisualStyleBackColor = true;
            RegistrationButton.Click += RegistrationButton_Click;
            // 
            // ToAuthorizationFormLink
            // 
            ToAuthorizationFormLink.AutoSize = true;
            ToAuthorizationFormLink.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ToAuthorizationFormLink.Location = new Point(189, 606);
            ToAuthorizationFormLink.Name = "ToAuthorizationFormLink";
            ToAuthorizationFormLink.Size = new Size(102, 21);
            ToAuthorizationFormLink.TabIndex = 14;
            ToAuthorizationFormLink.TabStop = true;
            ToAuthorizationFormLink.Text = "Вже є акаунт";
            ToAuthorizationFormLink.LinkClicked += ToAuthorizationFormLink_LinkClicked;
            // 
            // NameError
            // 
            NameError.AutoSize = true;
            NameError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameError.ForeColor = Color.Red;
            NameError.Location = new Point(35, 242);
            NameError.Name = "NameError";
            NameError.Size = new Size(0, 15);
            NameError.TabIndex = 15;
            // 
            // SurnameError
            // 
            SurnameError.AutoSize = true;
            SurnameError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SurnameError.ForeColor = Color.Red;
            SurnameError.Location = new Point(35, 312);
            SurnameError.Name = "SurnameError";
            SurnameError.Size = new Size(0, 15);
            SurnameError.TabIndex = 16;
            // 
            // PhoneError
            // 
            PhoneError.AutoSize = true;
            PhoneError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneError.ForeColor = Color.Red;
            PhoneError.Location = new Point(35, 380);
            PhoneError.Name = "PhoneError";
            PhoneError.Size = new Size(0, 15);
            PhoneError.TabIndex = 17;
            // 
            // LoginError
            // 
            LoginError.AutoSize = true;
            LoginError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LoginError.ForeColor = Color.Red;
            LoginError.Location = new Point(35, 454);
            LoginError.Name = "LoginError";
            LoginError.Size = new Size(0, 15);
            LoginError.TabIndex = 18;
            // 
            // PasswordError
            // 
            PasswordError.AutoSize = true;
            PasswordError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordError.ForeColor = Color.Red;
            PasswordError.Location = new Point(35, 522);
            PasswordError.Name = "PasswordError";
            PasswordError.Size = new Size(0, 15);
            PasswordError.TabIndex = 19;
            // 
            // MainError
            // 
            MainError.AutoSize = true;
            MainError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MainError.ForeColor = Color.Red;
            MainError.Location = new Point(157, 537);
            MainError.Name = "MainError";
            MainError.Size = new Size(0, 15);
            MainError.TabIndex = 20;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 652);
            Controls.Add(MainError);
            Controls.Add(PasswordError);
            Controls.Add(LoginError);
            Controls.Add(PhoneError);
            Controls.Add(SurnameError);
            Controls.Add(NameError);
            Controls.Add(ToAuthorizationFormLink);
            Controls.Add(RegistrationButton);
            Controls.Add(PasswordField);
            Controls.Add(LoginField);
            Controls.Add(PhoneField);
            Controls.Add(SurnameField);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLable);
            Controls.Add(PhoneNumberLabel);
            Controls.Add(SurnameLable);
            Controls.Add(NameField);
            Controls.Add(NameLabel);
            Controls.Add(Buyer);
            Controls.Add(SalesMan);
            Controls.Add(RagistrationLabel);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Біржа товарів";
            FormClosing += RegistrationForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RagistrationLabel;
        private RadioButton SalesMan;
        private RadioButton Buyer;
        private Label NameLabel;
        private TextBox NameField;
        private Label SurnameLable;
        private Label PhoneNumberLabel;
        private Label LoginLable;
        private Label PasswordLabel;
        private TextBox SurnameField;
        private TextBox PhoneField;
        private TextBox LoginField;
        private TextBox PasswordField;
        private Button RegistrationButton;
        private LinkLabel ToAuthorizationFormLink;
        private Label NameError;
        private Label SurnameError;
        private Label PhoneError;
        private Label LoginError;
        private Label PasswordError;
        private Label MainError;
    }
}
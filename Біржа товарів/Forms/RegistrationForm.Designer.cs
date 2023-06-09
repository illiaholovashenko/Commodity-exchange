﻿namespace Біржа_товарів.Forms
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
            SalesMan.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SalesMan.AutoSize = true;
            SalesMan.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SalesMan.Location = new Point(98, 137);
            SalesMan.Name = "SalesMan";
            SalesMan.Size = new Size(127, 29);
            SalesMan.TabIndex = 1;
            SalesMan.TabStop = true;
            SalesMan.Text = "Продавець";
            SalesMan.UseVisualStyleBackColor = true;
            // 
            // Buyer
            // 
            Buyer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Buyer.AutoSize = true;
            Buyer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Buyer.Location = new Point(256, 137);
            Buyer.Name = "Buyer";
            Buyer.Size = new Size(115, 29);
            Buyer.TabIndex = 2;
            Buyer.TabStop = true;
            Buyer.Text = "Покупець";
            Buyer.UseVisualStyleBackColor = true;
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.Left;
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(35, 178);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(50, 30);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Ім'я";
            // 
            // NameField
            // 
            NameField.Anchor = AnchorStyles.Left;
            NameField.Location = new Point(35, 211);
            NameField.MaxLength = 100;
            NameField.Name = "NameField";
            NameField.Size = new Size(215, 23);
            NameField.TabIndex = 4;
            NameField.Validating += NameField_Validating;
            NameField.Validated += NameField_Validated;
            // 
            // SurnameLable
            // 
            SurnameLable.Anchor = AnchorStyles.Left;
            SurnameLable.AutoSize = true;
            SurnameLable.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SurnameLable.Location = new Point(35, 248);
            SurnameLable.Name = "SurnameLable";
            SurnameLable.Size = new Size(105, 30);
            SurnameLable.TabIndex = 5;
            SurnameLable.Text = "Прізвище";
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.Anchor = AnchorStyles.Left;
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumberLabel.Location = new Point(35, 317);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(174, 30);
            PhoneNumberLabel.TabIndex = 6;
            PhoneNumberLabel.Text = "Номер телефону";
            // 
            // LoginLable
            // 
            LoginLable.Anchor = AnchorStyles.Left;
            LoginLable.AutoSize = true;
            LoginLable.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LoginLable.Location = new Point(35, 390);
            LoginLable.Name = "LoginLable";
            LoginLable.Size = new Size(64, 30);
            LoginLable.TabIndex = 7;
            LoginLable.Text = "Логін";
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = AnchorStyles.Left;
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(35, 458);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(85, 30);
            PasswordLabel.TabIndex = 8;
            PasswordLabel.Text = "Пароль";
            // 
            // SurnameField
            // 
            SurnameField.Anchor = AnchorStyles.Left;
            SurnameField.Location = new Point(35, 281);
            SurnameField.MaxLength = 100;
            SurnameField.Name = "SurnameField";
            SurnameField.Size = new Size(215, 23);
            SurnameField.TabIndex = 9;
            SurnameField.Validating += SurnameField_Validating;
            SurnameField.Validated += SurnameField_Validated;
            // 
            // PhoneField
            // 
            PhoneField.Anchor = AnchorStyles.Left;
            PhoneField.Location = new Point(35, 350);
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
            LoginField.Anchor = AnchorStyles.Left;
            LoginField.Location = new Point(35, 423);
            LoginField.MaxLength = 100;
            LoginField.Name = "LoginField";
            LoginField.Size = new Size(215, 23);
            LoginField.TabIndex = 11;
            LoginField.Validating += LoginField_Validating;
            LoginField.Validated += LoginField_Validated;
            // 
            // PasswordField
            // 
            PasswordField.Anchor = AnchorStyles.Left;
            PasswordField.Location = new Point(35, 491);
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
            RegistrationButton.Anchor = AnchorStyles.Bottom;
            RegistrationButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            RegistrationButton.Location = new Point(105, 545);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(236, 48);
            RegistrationButton.TabIndex = 13;
            RegistrationButton.Text = "Зареєструватись";
            RegistrationButton.UseVisualStyleBackColor = true;
            RegistrationButton.Click += RegistrationButton_Click;
            // 
            // ToAuthorizationFormLink
            // 
            ToAuthorizationFormLink.Anchor = AnchorStyles.Bottom;
            ToAuthorizationFormLink.AutoSize = true;
            ToAuthorizationFormLink.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ToAuthorizationFormLink.Location = new Point(171, 596);
            ToAuthorizationFormLink.Name = "ToAuthorizationFormLink";
            ToAuthorizationFormLink.Size = new Size(102, 21);
            ToAuthorizationFormLink.TabIndex = 14;
            ToAuthorizationFormLink.TabStop = true;
            ToAuthorizationFormLink.Text = "Вже є акаунт";
            ToAuthorizationFormLink.LinkClicked += ToAuthorizationFormLink_LinkClicked;
            // 
            // NameError
            // 
            NameError.Anchor = AnchorStyles.Left;
            NameError.AutoSize = true;
            NameError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameError.ForeColor = Color.Red;
            NameError.Location = new Point(35, 237);
            NameError.Name = "NameError";
            NameError.Size = new Size(0, 15);
            NameError.TabIndex = 15;
            // 
            // SurnameError
            // 
            SurnameError.Anchor = AnchorStyles.Left;
            SurnameError.AutoSize = true;
            SurnameError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SurnameError.ForeColor = Color.Red;
            SurnameError.Location = new Point(35, 307);
            SurnameError.Name = "SurnameError";
            SurnameError.Size = new Size(0, 15);
            SurnameError.TabIndex = 16;
            // 
            // PhoneError
            // 
            PhoneError.Anchor = AnchorStyles.Left;
            PhoneError.AutoSize = true;
            PhoneError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneError.ForeColor = Color.Red;
            PhoneError.Location = new Point(35, 375);
            PhoneError.Name = "PhoneError";
            PhoneError.Size = new Size(0, 15);
            PhoneError.TabIndex = 17;
            // 
            // LoginError
            // 
            LoginError.Anchor = AnchorStyles.Left;
            LoginError.AutoSize = true;
            LoginError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LoginError.ForeColor = Color.Red;
            LoginError.Location = new Point(35, 449);
            LoginError.Name = "LoginError";
            LoginError.Size = new Size(0, 15);
            LoginError.TabIndex = 18;
            // 
            // PasswordError
            // 
            PasswordError.Anchor = AnchorStyles.Left;
            PasswordError.AutoSize = true;
            PasswordError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordError.ForeColor = Color.Red;
            PasswordError.Location = new Point(35, 517);
            PasswordError.Name = "PasswordError";
            PasswordError.Size = new Size(0, 15);
            PasswordError.TabIndex = 19;
            // 
            // MainError
            // 
            MainError.Anchor = AnchorStyles.Bottom;
            MainError.AutoSize = true;
            MainError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MainError.ForeColor = Color.Red;
            MainError.Location = new Point(147, 527);
            MainError.Name = "MainError";
            MainError.Size = new Size(0, 15);
            MainError.TabIndex = 20;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 642);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
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
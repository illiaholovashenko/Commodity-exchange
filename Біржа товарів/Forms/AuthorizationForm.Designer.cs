namespace Біржа_товарів
{
    partial class AuthorizationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            WindowName = new Label();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            AuthorizationButton = new Button();
            ToRegisterWindow = new LinkLabel();
            LoginField = new TextBox();
            PasswordField = new TextBox();
            LoginError = new Label();
            PasswordError = new Label();
            MainError = new Label();
            SuspendLayout();
            // 
            // WindowName
            // 
            WindowName.AutoSize = true;
            WindowName.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            WindowName.Location = new Point(35, 58);
            WindowName.Name = "WindowName";
            WindowName.Size = new Size(89, 50);
            WindowName.TabIndex = 0;
            WindowName.Text = "Вхід";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LoginLabel.Location = new Point(35, 143);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(64, 30);
            LoginLabel.TabIndex = 1;
            LoginLabel.Text = "Логін";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(35, 234);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(85, 30);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Пароль";
            // 
            // AuthorizationButton
            // 
            AuthorizationButton.Cursor = Cursors.Hand;
            AuthorizationButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AuthorizationButton.Location = new Point(127, 360);
            AuthorizationButton.Name = "AuthorizationButton";
            AuthorizationButton.Size = new Size(236, 48);
            AuthorizationButton.TabIndex = 3;
            AuthorizationButton.Text = "Увійти";
            AuthorizationButton.UseVisualStyleBackColor = true;
            AuthorizationButton.Click += AuthorizationButton_Click;
            // 
            // ToRegisterWindow
            // 
            ToRegisterWindow.AutoSize = true;
            ToRegisterWindow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ToRegisterWindow.LinkColor = Color.FromArgb(0, 0, 192);
            ToRegisterWindow.Location = new Point(185, 411);
            ToRegisterWindow.Name = "ToRegisterWindow";
            ToRegisterWindow.Size = new Size(120, 21);
            ToRegisterWindow.TabIndex = 4;
            ToRegisterWindow.TabStop = true;
            ToRegisterWindow.Text = "Зареєстуватись";
            ToRegisterWindow.LinkClicked += ToRegisterWindow_LinkClicked;
            // 
            // LoginField
            // 
            LoginField.Location = new Point(35, 186);
            LoginField.MaxLength = 100;
            LoginField.Name = "LoginField";
            LoginField.Size = new Size(215, 23);
            LoginField.TabIndex = 5;
            LoginField.Validating += LoginField_Validating;
            LoginField.Validated += LoginField_Validated;
            // 
            // PasswordField
            // 
            PasswordField.Location = new Point(35, 280);
            PasswordField.MaxLength = 100;
            PasswordField.Name = "PasswordField";
            PasswordField.Size = new Size(215, 23);
            PasswordField.TabIndex = 6;
            PasswordField.Validating += PasswordField_Validating;
            PasswordField.Validated += PasswordField_Validated;
            // 
            // LoginError
            // 
            LoginError.AutoSize = true;
            LoginError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LoginError.ForeColor = Color.Red;
            LoginError.Location = new Point(35, 212);
            LoginError.Name = "LoginError";
            LoginError.Size = new Size(0, 15);
            LoginError.TabIndex = 16;
            // 
            // PasswordError
            // 
            PasswordError.AutoSize = true;
            PasswordError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordError.ForeColor = Color.Red;
            PasswordError.Location = new Point(35, 306);
            PasswordError.Name = "PasswordError";
            PasswordError.Size = new Size(0, 15);
            PasswordError.TabIndex = 17;
            // 
            // MainError
            // 
            MainError.AutoSize = true;
            MainError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MainError.ForeColor = Color.Red;
            MainError.Location = new Point(156, 342);
            MainError.Name = "MainError";
            MainError.Size = new Size(0, 15);
            MainError.TabIndex = 18;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 451);
            Controls.Add(MainError);
            Controls.Add(PasswordError);
            Controls.Add(LoginError);
            Controls.Add(PasswordField);
            Controls.Add(LoginField);
            Controls.Add(ToRegisterWindow);
            Controls.Add(AuthorizationButton);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(WindowName);
            Name = "AuthorizationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Біржа товарів";
            FormClosing += AuthorizationForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WindowName;
        private Label LoginLabel;
        private Label PasswordLabel;
        private Button AuthorizationButton;
        private LinkLabel ToRegisterWindow;
        private TextBox LoginField;
        private TextBox PasswordField;
        private Label LoginError;
        private Label PasswordError;
        private Label MainError;
    }
}
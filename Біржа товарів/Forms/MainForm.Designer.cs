namespace Біржа_товарів.Forms
{
    partial class MainForm
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
            MainFormLabel = new Label();
            FindProductButton = new Button();
            AddProductButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // MainFormLabel
            // 
            MainFormLabel.AutoSize = true;
            MainFormLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            MainFormLabel.Location = new Point(285, 85);
            MainFormLabel.Name = "MainFormLabel";
            MainFormLabel.Size = new Size(258, 50);
            MainFormLabel.TabIndex = 0;
            MainFormLabel.Text = "Біржа товарів";
            // 
            // FindProductButton
            // 
            FindProductButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            FindProductButton.Location = new Point(512, 230);
            FindProductButton.Name = "FindProductButton";
            FindProductButton.Size = new Size(200, 75);
            FindProductButton.TabIndex = 1;
            FindProductButton.Text = "Знайти товар";
            FindProductButton.UseVisualStyleBackColor = true;
            FindProductButton.Click += FindProductButton_Click;
            // 
            // AddProductButton
            // 
            AddProductButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AddProductButton.Location = new Point(104, 230);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(200, 75);
            AddProductButton.TabIndex = 2;
            AddProductButton.Text = "Додати товар";
            AddProductButton.UseVisualStyleBackColor = true;
            AddProductButton.Click += AddProductButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(713, 12);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Вийти";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(AddProductButton);
            Controls.Add(FindProductButton);
            Controls.Add(MainFormLabel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Біржа товарів";
            FormClosing += MainForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainFormLabel;
        private Button FindProductButton;
        private Button AddProductButton;
        private Button ExitButton;
    }
}
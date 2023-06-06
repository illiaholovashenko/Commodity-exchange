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
            RankLabel = new Label();
            RankText = new Label();
            MeetingLabel = new Label();
            Archive = new LinkLabel();
            SuspendLayout();
            // 
            // MainFormLabel
            // 
            MainFormLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
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
            FindProductButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            FindProductButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            FindProductButton.Location = new Point(576, 229);
            FindProductButton.MaximumSize = new Size(300, 140);
            FindProductButton.MinimumSize = new Size(159, 42);
            FindProductButton.Name = "FindProductButton";
            FindProductButton.Size = new Size(159, 76);
            FindProductButton.TabIndex = 1;
            FindProductButton.Text = "Знайти товар";
            FindProductButton.UseVisualStyleBackColor = true;
            FindProductButton.Click += FindProductButton_Click;
            // 
            // AddProductButton
            // 
            AddProductButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddProductButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AddProductButton.Location = new Point(83, 229);
            AddProductButton.MaximumSize = new Size(300, 140);
            AddProductButton.MinimumSize = new Size(159, 42);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(159, 76);
            AddProductButton.TabIndex = 2;
            AddProductButton.Text = "Додати товар";
            AddProductButton.UseVisualStyleBackColor = true;
            AddProductButton.Click += AddProductButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExitButton.Location = new Point(713, 29);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Вийти";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // RankLabel
            // 
            RankLabel.AutoSize = true;
            RankLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RankLabel.Location = new Point(16, 31);
            RankLabel.Name = "RankLabel";
            RankLabel.Size = new Size(64, 21);
            RankLabel.TabIndex = 4;
            RankLabel.Text = "Звання:";
            // 
            // RankText
            // 
            RankText.AutoSize = true;
            RankText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RankText.Location = new Point(86, 31);
            RankText.Name = "RankText";
            RankText.Size = new Size(0, 21);
            RankText.TabIndex = 5;
            // 
            // MeetingLabel
            // 
            MeetingLabel.Anchor = AnchorStyles.Top;
            MeetingLabel.AutoSize = true;
            MeetingLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MeetingLabel.Location = new Point(328, 31);
            MeetingLabel.Name = "MeetingLabel";
            MeetingLabel.Size = new Size(65, 21);
            MeetingLabel.TabIndex = 6;
            MeetingLabel.Text = "Привіт, ";
            // 
            // Archive
            // 
            Archive.Anchor = AnchorStyles.Bottom;
            Archive.AutoSize = true;
            Archive.Location = new Point(362, 412);
            Archive.Name = "Archive";
            Archive.Size = new Size(0, 15);
            Archive.TabIndex = 7;
            Archive.LinkClicked += Archive_LinkClicked;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 451);
            Controls.Add(Archive);
            Controls.Add(MeetingLabel);
            Controls.Add(RankText);
            Controls.Add(RankLabel);
            Controls.Add(ExitButton);
            Controls.Add(AddProductButton);
            Controls.Add(FindProductButton);
            Controls.Add(MainFormLabel);
            MaximumSize = new Size(1000, 600);
            MinimumSize = new Size(515, 435);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Біржа товарів";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainFormLabel;
        private Button FindProductButton;
        private Button AddProductButton;
        private Button ExitButton;
        private Label RankLabel;
        public Label RankText;
        public Label MeetingLabel;
        private LinkLabel Archive;
    }
}
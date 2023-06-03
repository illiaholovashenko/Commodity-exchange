namespace Біржа_товарів.Forms
{
    partial class ArchiveForm
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
            ArchiveLabel = new Label();
            ReturnLabel = new Label();
            ArchiveList = new ListBox();
            SuspendLayout();
            // 
            // ArchiveLabel
            // 
            ArchiveLabel.AutoSize = true;
            ArchiveLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ArchiveLabel.Location = new Point(91, 9);
            ArchiveLabel.Name = "ArchiveLabel";
            ArchiveLabel.Size = new Size(0, 45);
            ArchiveLabel.TabIndex = 41;
            // 
            // ReturnLabel
            // 
            ReturnLabel.AutoSize = true;
            ReturnLabel.Cursor = Cursors.Hand;
            ReturnLabel.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ReturnLabel.Location = new Point(12, 9);
            ReturnLabel.Name = "ReturnLabel";
            ReturnLabel.Size = new Size(33, 29);
            ReturnLabel.TabIndex = 40;
            ReturnLabel.Text = "<";
            ReturnLabel.Click += ReturnLabel_Click;
            // 
            // ArchiveList
            // 
            ArchiveList.FormattingEnabled = true;
            ArchiveList.ItemHeight = 15;
            ArchiveList.Location = new Point(40, 77);
            ArchiveList.Name = "ArchiveList";
            ArchiveList.Size = new Size(350, 469);
            ArchiveList.TabIndex = 39;
            // 
            // ArchiveForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 651);
            Controls.Add(ArchiveLabel);
            Controls.Add(ReturnLabel);
            Controls.Add(ArchiveList);
            Name = "ArchiveForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Біржа товарів";
            Load += ArchiveForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ArchiveLabel;
        private Label ReturnLabel;
        private ListBox ArchiveList;
    }
}
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
            label1.Location = new Point(35, 168);
            label1.Name = "label1";
            label1.Size = new Size(133, 30);
            label1.TabIndex = 21;
            label1.Text = "Бажана ціна";
            // 
            // SearchProductButton
            // 
            SearchProductButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SearchProductButton.Location = new Point(125, 515);
            SearchProductButton.Name = "SearchProductButton";
            SearchProductButton.Size = new Size(200, 55);
            SearchProductButton.TabIndex = 24;
            SearchProductButton.Text = "Знайти товар";
            SearchProductButton.UseVisualStyleBackColor = true;
            // 
            // SearchProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 591);
            Controls.Add(SearchProductButton);
            Controls.Add(label1);
            Controls.Add(SearcProductLabel);
            Name = "SearchProductForm";
            Text = "SearchProductForm";
            Controls.SetChildIndex(SearcProductLabel, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(SearchProductButton, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SearcProductLabel;
        private Label label1;
        private Button SearchProductButton;
    }
}
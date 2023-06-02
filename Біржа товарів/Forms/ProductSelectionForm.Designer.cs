namespace Біржа_товарів.Forms
{
    partial class ProductSelectionForm
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
            foundProductList = new ListBox();
            ReturnLabel = new Label();
            MainLabel = new Label();
            SuspendLayout();
            // 
            // foundProductList
            // 
            foundProductList.FormattingEnabled = true;
            foundProductList.ItemHeight = 15;
            foundProductList.Location = new Point(50, 73);
            foundProductList.Name = "foundProductList";
            foundProductList.Size = new Size(698, 334);
            foundProductList.TabIndex = 0;
            // 
            // ReturnLabel
            // 
            ReturnLabel.AutoSize = true;
            ReturnLabel.Cursor = Cursors.Hand;
            ReturnLabel.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ReturnLabel.Location = new Point(12, 9);
            ReturnLabel.Name = "ReturnLabel";
            ReturnLabel.Size = new Size(33, 29);
            ReturnLabel.TabIndex = 37;
            ReturnLabel.Text = "<";
            ReturnLabel.Click += ReturnLabel_Click;
            // 
            // MainLabel
            // 
            MainLabel.AutoSize = true;
            MainLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            MainLabel.Location = new Point(286, 9);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(263, 45);
            MainLabel.TabIndex = 38;
            MainLabel.Text = "Знайдені товари";
            // 
            // ProductSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainLabel);
            Controls.Add(ReturnLabel);
            Controls.Add(foundProductList);
            Name = "ProductSelectionForm";
            Text = "ProductSelectionForm";
            Load += ProductSelectionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox foundProductList;
        private Label ReturnLabel;
        private Label MainLabel;
    }
}
namespace LunchTimeApp
{
    partial class ViewForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ShopListBox = new System.Windows.Forms.ListBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ShopNameTextBox = new System.Windows.Forms.TextBox();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "現在登録されている店舗";
            // 
            // ShopListBox
            // 
            this.ShopListBox.FormattingEnabled = true;
            this.ShopListBox.ItemHeight = 12;
            this.ShopListBox.Location = new System.Drawing.Point(28, 42);
            this.ShopListBox.Name = "ShopListBox";
            this.ShopListBox.Size = new System.Drawing.Size(155, 112);
            this.ShopListBox.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(59, 160);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(124, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "選択した店舗を削除";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "店舗を新規追加";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "店舗名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "ジャンル";
            // 
            // ShopNameTextBox
            // 
            this.ShopNameTextBox.Location = new System.Drawing.Point(284, 49);
            this.ShopNameTextBox.Name = "ShopNameTextBox";
            this.ShopNameTextBox.Size = new System.Drawing.Size(159, 19);
            this.ShopNameTextBox.TabIndex = 6;
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(284, 78);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(159, 20);
            this.GenreComboBox.TabIndex = 7;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(368, 104);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 23);
            this.InsertButton.TabIndex = 8;
            this.InsertButton.Text = "店舗を登録";
            this.InsertButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(368, 196);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "戻る";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 231);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.GenreComboBox);
            this.Controls.Add(this.ShopNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ShopListBox);
            this.Controls.Add(this.label1);
            this.Name = "ViewForm";
            this.Text = "ランチ決めアプリ";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ShopListBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ShopNameTextBox;
        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button BackButton;
    }
}
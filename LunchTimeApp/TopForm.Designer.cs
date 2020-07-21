namespace LunchTimeApp
{
    partial class TopForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ChoiceFormButton = new System.Windows.Forms.Button();
            this.ViewFormButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "登録された店舗から自動で今日のランチを決めます！";
            // 
            // ChoiceFormButton
            // 
            this.ChoiceFormButton.Location = new System.Drawing.Point(86, 40);
            this.ChoiceFormButton.Name = "ChoiceFormButton";
            this.ChoiceFormButton.Size = new System.Drawing.Size(130, 23);
            this.ChoiceFormButton.TabIndex = 1;
            this.ChoiceFormButton.Text = "ランチを決める！";
            this.ChoiceFormButton.UseVisualStyleBackColor = true;
            // 
            // ViewFormButton
            // 
            this.ViewFormButton.Location = new System.Drawing.Point(213, 85);
            this.ViewFormButton.Name = "ViewFormButton";
            this.ViewFormButton.Size = new System.Drawing.Size(75, 23);
            this.ViewFormButton.TabIndex = 2;
            this.ViewFormButton.Text = "店舗ビュー";
            this.ViewFormButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(213, 114);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "終了";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // TopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 141);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ViewFormButton);
            this.Controls.Add(this.ChoiceFormButton);
            this.Controls.Add(this.label1);
            this.Name = "TopForm";
            this.Text = "ランチ決めアプリ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChoiceFormButton;
        private System.Windows.Forms.Button ViewFormButton;
        private System.Windows.Forms.Button CloseButton;
    }
}


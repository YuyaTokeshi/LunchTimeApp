namespace LunchTimeApp
{
    partial class ResultForm
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
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ChoiceFormButton = new System.Windows.Forms.Button();
            this.TopFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "今日のランチは……";
            // 
            // ResultLabel
            // 
            this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ResultLabel.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResultLabel.Location = new System.Drawing.Point(58, 36);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(200, 40);
            this.ResultLabel.TabIndex = 1;
            this.ResultLabel.Text = "介そば";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(119, 82);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "WEBで検索";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // ChoiceFormButton
            // 
            this.ChoiceFormButton.Location = new System.Drawing.Point(118, 110);
            this.ChoiceFormButton.Name = "ChoiceFormButton";
            this.ChoiceFormButton.Size = new System.Drawing.Size(75, 23);
            this.ChoiceFormButton.TabIndex = 3;
            this.ChoiceFormButton.Text = "もう一度";
            this.ChoiceFormButton.UseVisualStyleBackColor = true;
            // 
            // TopFormButton
            // 
            this.TopFormButton.Location = new System.Drawing.Point(226, 110);
            this.TopFormButton.Name = "TopFormButton";
            this.TopFormButton.Size = new System.Drawing.Size(75, 23);
            this.TopFormButton.TabIndex = 4;
            this.TopFormButton.Text = "TOP";
            this.TopFormButton.UseVisualStyleBackColor = true;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 141);
            this.Controls.Add(this.TopFormButton);
            this.Controls.Add(this.ChoiceFormButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label1);
            this.Name = "ResultForm";
            this.Text = "ランチ決めアプリ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ChoiceFormButton;
        private System.Windows.Forms.Button TopFormButton;
    }
}
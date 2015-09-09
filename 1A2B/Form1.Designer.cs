namespace _1A2B
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.GuessNumber = new System.Windows.Forms.TextBox();
            this.GuessButton = new System.Windows.Forms.Button();
            this.NewNumber = new System.Windows.Forms.Button();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.AnswerButton = new System.Windows.Forms.Button();
            this.ShowBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // GuessNumber
            // 
            this.GuessNumber.Location = new System.Drawing.Point(12, 42);
            this.GuessNumber.Name = "GuessNumber";
            this.GuessNumber.Size = new System.Drawing.Size(100, 22);
            this.GuessNumber.TabIndex = 0;
            // 
            // GuessButton
            // 
            this.GuessButton.Location = new System.Drawing.Point(118, 42);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(75, 23);
            this.GuessButton.TabIndex = 1;
            this.GuessButton.Text = "猜數字";
            this.GuessButton.UseVisualStyleBackColor = true;
            this.GuessButton.Click += new System.EventHandler(this.GuessButton_Click);
            // 
            // NewNumber
            // 
            this.NewNumber.Location = new System.Drawing.Point(13, 13);
            this.NewNumber.Name = "NewNumber";
            this.NewNumber.Size = new System.Drawing.Size(75, 23);
            this.NewNumber.TabIndex = 2;
            this.NewNumber.Text = "產生新數字";
            this.NewNumber.UseVisualStyleBackColor = true;
            this.NewNumber.Click += new System.EventHandler(this.NewNumber_Click);
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Font = new System.Drawing.Font("新細明體", 10F);
            this.AnswerLabel.Location = new System.Drawing.Point(175, 18);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(0, 14);
            this.AnswerLabel.TabIndex = 3;
            // 
            // AnswerButton
            // 
            this.AnswerButton.Location = new System.Drawing.Point(94, 13);
            this.AnswerButton.Name = "AnswerButton";
            this.AnswerButton.Size = new System.Drawing.Size(75, 23);
            this.AnswerButton.TabIndex = 4;
            this.AnswerButton.Text = "公布答案";
            this.AnswerButton.UseVisualStyleBackColor = true;
            this.AnswerButton.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // ShowBox
            // 
            this.ShowBox.FormattingEnabled = true;
            this.ShowBox.ItemHeight = 12;
            this.ShowBox.Location = new System.Drawing.Point(13, 71);
            this.ShowBox.Name = "ShowBox";
            this.ShowBox.Size = new System.Drawing.Size(250, 244);
            this.ShowBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 331);
            this.Controls.Add(this.ShowBox);
            this.Controls.Add(this.AnswerButton);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.NewNumber);
            this.Controls.Add(this.GuessButton);
            this.Controls.Add(this.GuessNumber);
            this.Name = "Form1";
            this.Text = "猜數字";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GuessNumber;
        private System.Windows.Forms.Button GuessButton;
        private System.Windows.Forms.Button NewNumber;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Button AnswerButton;
        private System.Windows.Forms.ListBox ShowBox;
    }
}


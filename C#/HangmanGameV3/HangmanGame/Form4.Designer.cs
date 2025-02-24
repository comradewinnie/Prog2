namespace HangmanGame
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            labelProfile = new Label();
            labelNickname = new Label();
            labelEarnedPts = new Label();
            labelSolvWords = new Label();
            buttonBack = new Button();
            labelNicknameValue = new Label();
            labelPtsValue = new Label();
            labelWordsValue = new Label();
            SuspendLayout();
            // 
            // labelProfile
            // 
            labelProfile.AutoSize = true;
            labelProfile.BackColor = Color.Transparent;
            labelProfile.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelProfile.ForeColor = Color.DarkRed;
            labelProfile.Location = new Point(28, 36);
            labelProfile.Name = "labelProfile";
            labelProfile.Size = new Size(216, 59);
            labelProfile.TabIndex = 2;
            labelProfile.Text = "Profile";
            labelProfile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNickname
            // 
            labelNickname.AutoSize = true;
            labelNickname.BackColor = Color.Transparent;
            labelNickname.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelNickname.ForeColor = SystemColors.Control;
            labelNickname.Location = new Point(28, 152);
            labelNickname.Name = "labelNickname";
            labelNickname.Size = new Size(203, 44);
            labelNickname.TabIndex = 3;
            labelNickname.Text = "Nickname:";
            labelNickname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelEarnedPts
            // 
            labelEarnedPts.AutoSize = true;
            labelEarnedPts.BackColor = Color.Transparent;
            labelEarnedPts.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelEarnedPts.ForeColor = SystemColors.Control;
            labelEarnedPts.Location = new Point(28, 211);
            labelEarnedPts.Name = "labelEarnedPts";
            labelEarnedPts.Size = new Size(276, 44);
            labelEarnedPts.TabIndex = 4;
            labelEarnedPts.Text = "Earned points:";
            labelEarnedPts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSolvWords
            // 
            labelSolvWords.AutoSize = true;
            labelSolvWords.BackColor = Color.Transparent;
            labelSolvWords.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelSolvWords.ForeColor = SystemColors.Control;
            labelSolvWords.Location = new Point(28, 270);
            labelSolvWords.Name = "labelSolvWords";
            labelSolvWords.Size = new Size(263, 44);
            labelSolvWords.TabIndex = 5;
            labelSolvWords.Text = "Solved words:";
            labelSolvWords.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = SystemColors.Control;
            buttonBack.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.ForeColor = SystemColors.ControlText;
            buttonBack.Location = new Point(178, 345);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(197, 51);
            buttonBack.TabIndex = 9;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            // 
            // labelNicknameValue
            // 
            labelNicknameValue.AutoSize = true;
            labelNicknameValue.BackColor = Color.Transparent;
            labelNicknameValue.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelNicknameValue.ForeColor = Color.DarkRed;
            labelNicknameValue.Location = new Point(303, 152);
            labelNicknameValue.Name = "labelNicknameValue";
            labelNicknameValue.Size = new Size(88, 44);
            labelNicknameValue.TabIndex = 10;
            labelNicknameValue.Text = "nnn";
            labelNicknameValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPtsValue
            // 
            labelPtsValue.AutoSize = true;
            labelPtsValue.BackColor = Color.Transparent;
            labelPtsValue.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelPtsValue.ForeColor = Color.DarkRed;
            labelPtsValue.Location = new Point(303, 211);
            labelPtsValue.Name = "labelPtsValue";
            labelPtsValue.Size = new Size(88, 44);
            labelPtsValue.TabIndex = 11;
            labelPtsValue.Text = "nnn";
            labelPtsValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelWordsValue
            // 
            labelWordsValue.AutoSize = true;
            labelWordsValue.BackColor = Color.Transparent;
            labelWordsValue.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelWordsValue.ForeColor = Color.DarkRed;
            labelWordsValue.Location = new Point(303, 270);
            labelWordsValue.Name = "labelWordsValue";
            labelWordsValue.Size = new Size(88, 44);
            labelWordsValue.TabIndex = 12;
            labelWordsValue.Text = "nnn";
            labelWordsValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(546, 427);
            Controls.Add(labelWordsValue);
            Controls.Add(labelPtsValue);
            Controls.Add(labelNicknameValue);
            Controls.Add(buttonBack);
            Controls.Add(labelSolvWords);
            Controls.Add(labelEarnedPts);
            Controls.Add(labelNickname);
            Controls.Add(labelProfile);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form4";
            Text = "The Hangman Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelProfile;
        private Label labelNickname;
        private Label labelEarnedPts;
        private Label labelSolvWords;
        private Button buttonBack;
        private Label labelNicknameValue;
        private Label labelPtsValue;
        private Label labelWordsValue;
    }
}
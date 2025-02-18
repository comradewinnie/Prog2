namespace HangmanGame
{
    partial class Form3
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
            labelWelcome = new Label();
            buttonLoginRegister = new Button();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.BackColor = Color.Transparent;
            labelWelcome.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelWelcome.ForeColor = SystemColors.Control;
            labelWelcome.Location = new Point(105, 19);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(149, 47);
            labelWelcome.TabIndex = 1;
            labelWelcome.Text = "Hello,";
            labelWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonLoginRegister
            // 
            buttonLoginRegister.BackColor = SystemColors.Control;
            buttonLoginRegister.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLoginRegister.ForeColor = SystemColors.ControlText;
            buttonLoginRegister.Location = new Point(206, 137);
            buttonLoginRegister.Margin = new Padding(3, 2, 3, 2);
            buttonLoginRegister.Name = "buttonLoginRegister";
            buttonLoginRegister.Size = new Size(245, 38);
            buttonLoginRegister.TabIndex = 8;
            buttonLoginRegister.Text = "My profile";
            buttonLoginRegister.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(206, 192);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(245, 38);
            button1.TabIndex = 9;
            button1.Text = "Start the game";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(206, 245);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(245, 38);
            button2.TabIndex = 10;
            button2.Text = "Leaderboard";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(245, 19);
            label1.Name = "label1";
            label1.Size = new Size(114, 47);
            label1.TabIndex = 2;
            label1.Text = "USER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_262244537_RjHfRBucxPyo7o6QetIAQYpd5O3h6cEN;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(478, 320);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonLoginRegister);
            Controls.Add(label1);
            Controls.Add(labelWelcome);
            Name = "Form3";
            Text = "The Hangman Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelWelcome;
        private Button buttonLoginRegister;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}
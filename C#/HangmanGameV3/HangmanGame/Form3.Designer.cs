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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
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
            labelWelcome.Location = new Point(24, 48);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(184, 59);
            labelWelcome.TabIndex = 1;
            labelWelcome.Text = "Hello,";
            labelWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonLoginRegister
            // 
            buttonLoginRegister.BackColor = SystemColors.Control;
            buttonLoginRegister.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLoginRegister.ForeColor = SystemColors.ControlText;
            buttonLoginRegister.Location = new Point(221, 158);
            buttonLoginRegister.Name = "buttonLoginRegister";
            buttonLoginRegister.Size = new Size(280, 51);
            buttonLoginRegister.TabIndex = 8;
            buttonLoginRegister.Text = "My profile";
            buttonLoginRegister.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(221, 231);
            button1.Name = "button1";
            button1.Size = new Size(280, 51);
            button1.TabIndex = 9;
            button1.Text = "Start the game";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(221, 302);
            button2.Name = "button2";
            button2.Size = new Size(280, 51);
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
            label1.Location = new Point(199, 48);
            label1.Name = "label1";
            label1.Size = new Size(264, 59);
            label1.TabIndex = 2;
            label1.Text = "username";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(546, 427);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonLoginRegister);
            Controls.Add(label1);
            Controls.Add(labelWelcome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
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
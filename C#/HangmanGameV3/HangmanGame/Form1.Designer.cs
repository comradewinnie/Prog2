namespace HangmanGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelWelcome = new Label();
            labelWelcome2 = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            labelLogin = new Label();
            labelPassword = new Label();
            buttonLoginRegister = new Button();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.BackColor = Color.Transparent;
            labelWelcome.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelWelcome.ForeColor = SystemColors.Control;
            labelWelcome.Location = new Point(109, 12);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(321, 59);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Welcome to\r";
            labelWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelWelcome2
            // 
            labelWelcome2.AutoSize = true;
            labelWelcome2.BackColor = Color.Transparent;
            labelWelcome2.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelWelcome2.ForeColor = Color.DarkRed;
            labelWelcome2.Location = new Point(19, 71);
            labelWelcome2.Name = "labelWelcome2";
            labelWelcome2.Size = new Size(507, 59);
            labelWelcome2.TabIndex = 1;
            labelWelcome2.Text = "the Hangman game!";
            labelWelcome2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.DarkRed;
            textBoxLogin.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.ForeColor = SystemColors.Control;
            textBoxLogin.Location = new Point(242, 185);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(281, 41);
            textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.DarkRed;
            textBoxPassword.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.ForeColor = SystemColors.Control;
            textBoxPassword.Location = new Point(242, 276);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(281, 41);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.TextChanged += textBox2_TextChanged;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.BackColor = Color.Transparent;
            labelLogin.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.ForeColor = SystemColors.Control;
            labelLogin.Location = new Point(242, 149);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(199, 26);
            labelLogin.TabIndex = 5;
            labelLogin.Text = "Enter your login";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.ForeColor = SystemColors.Control;
            labelPassword.Location = new Point(242, 241);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(188, 26);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Enter password";
            // 
            // buttonLoginRegister
            // 
            buttonLoginRegister.BackColor = SystemColors.Control;
            buttonLoginRegister.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLoginRegister.ForeColor = SystemColors.ControlText;
            buttonLoginRegister.Location = new Point(242, 340);
            buttonLoginRegister.Name = "buttonLoginRegister";
            buttonLoginRegister.Size = new Size(280, 51);
            buttonLoginRegister.TabIndex = 7;
            buttonLoginRegister.Text = "LOGIN / REGISTER";
            buttonLoginRegister.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(546, 427);
            Controls.Add(buttonLoginRegister);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(labelWelcome2);
            Controls.Add(labelWelcome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "The Hangman Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private Label labelWelcome2;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label labelLogin;
        private Label labelPassword;
        private Button buttonLoginRegister;
    }
}
namespace PizzaDeliverySystem
{
    partial class UserForm
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
            unameTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            passTxt = new TextBox();
            loginBtn = new Button();
            registerBtn = new Button();
            SuspendLayout();
            // 
            // unameTxt
            // 
            unameTxt.Location = new Point(48, 53);
            unameTxt.Name = "unameTxt";
            unameTxt.Size = new Size(321, 27);
            unameTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 30);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 1;
            label1.Text = "Lietotājvārds";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 105);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "Parole";
            // 
            // passTxt
            // 
            passTxt.Location = new Point(48, 128);
            passTxt.Name = "passTxt";
            passTxt.PasswordChar = '*';
            passTxt.Size = new Size(321, 27);
            passTxt.TabIndex = 2;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(93, 182);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(94, 29);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Pieslēgties";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(209, 182);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(94, 29);
            registerBtn.TabIndex = 7;
            registerBtn.Text = "Reģistrēties";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 248);
            Controls.Add(registerBtn);
            Controls.Add(loginBtn);
            Controls.Add(label2);
            Controls.Add(passTxt);
            Controls.Add(label1);
            Controls.Add(unameTxt);
            Name = "UserForm";
            Text = "UserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox unameTxt;
        private Label label1;
        private Label label2;
        private TextBox passTxt;
        private Button loginBtn;
        private Button registerBtn;
    }
}
namespace PizzaDeliverySystem
{
    partial class RegistrationForm
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
            pass2Txt = new TextBox();
            unameTxt = new TextBox();
            passTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            registerBtn = new Button();
            SuspendLayout();
            // 
            // pass2Txt
            // 
            pass2Txt.Location = new Point(48, 192);
            pass2Txt.Name = "pass2Txt";
            pass2Txt.PasswordChar = '*';
            pass2Txt.Size = new Size(321, 27);
            pass2Txt.TabIndex = 1;
            // 
            // unameTxt
            // 
            unameTxt.Location = new Point(48, 53);
            unameTxt.Name = "unameTxt";
            unameTxt.Size = new Size(321, 27);
            unameTxt.TabIndex = 1;
            // 
            // passTxt
            // 
            passTxt.Location = new Point(48, 122);
            passTxt.Name = "passTxt";
            passTxt.PasswordChar = '*';
            passTxt.Size = new Size(321, 27);
            passTxt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 30);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 3;
            label1.Text = "Lietotājvārds";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 99);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "Parole";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 169);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 5;
            label3.Text = "Parole atkārtoti";
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(162, 240);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(94, 29);
            registerBtn.TabIndex = 6;
            registerBtn.Text = "Reģistrēties";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 286);
            Controls.Add(registerBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passTxt);
            Controls.Add(unameTxt);
            Controls.Add(pass2Txt);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox pass2Txt;
        private TextBox unameTxt;
        private TextBox passTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button registerBtn;
    }
}
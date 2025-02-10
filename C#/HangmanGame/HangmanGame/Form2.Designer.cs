namespace HangmanGame
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            label2 = new Label();
            label3 = new Label();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(67, 340);
            button1.Name = "button1";
            button1.Size = new Size(192, 29);
            button1.TabIndex = 0;
            button1.Text = "Add new word";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(265, 340);
            button2.Name = "button2";
            button2.Size = new Size(180, 29);
            button2.TabIndex = 1;
            button2.Text = "Add new topic";
            button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(422, 9);
            button5.Name = "button5";
            button5.Size = new Size(95, 29);
            button5.TabIndex = 4;
            button5.Text = "Log out";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(67, 384);
            button6.Name = "button6";
            button6.Size = new Size(378, 29);
            button6.TabIndex = 5;
            button6.Text = "Edit leaderboard";
            button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 6;
            label1.Text = "You logged in as:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 43);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(509, 279);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(501, 246);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Words";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(539, 362);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Topics";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(501, 246);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Leaderboard";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 429);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 8;
            label2.Text = "Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 429);
            label3.Name = "label3";
            label3.Size = new Size(230, 20);
            label3.TabIndex = 9;
            label3.Text = "120 words    10 topics    100 users";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 461);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "The Hangman Game [ADMIN]";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button5;
        private Button button6;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label2;
        private Label label3;
    }
}
namespace PizzaDeliverySystem
{
    partial class AdminForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            descTxt = new TextBox();
            sizeTxt = new TextBox();
            priceTxt = new TextBox();
            addBtn = new Button();
            deleteBtn = new Button();
            selectBtn = new Button();
            pizzaList = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 89);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Apraksts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 122);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Izmērs";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 155);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 2;
            label3.Text = "Cena";
            // 
            // descTxt
            // 
            descTxt.Location = new Point(112, 82);
            descTxt.Name = "descTxt";
            descTxt.Size = new Size(287, 27);
            descTxt.TabIndex = 3;
            // 
            // sizeTxt
            // 
            sizeTxt.Location = new Point(112, 115);
            sizeTxt.Name = "sizeTxt";
            sizeTxt.Size = new Size(287, 27);
            sizeTxt.TabIndex = 4;
            // 
            // priceTxt
            // 
            priceTxt.Location = new Point(112, 148);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(287, 27);
            priceTxt.TabIndex = 5;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(39, 192);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 6;
            addBtn.Text = "Pievienot";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(143, 192);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 7;
            deleteBtn.Text = "Izdzēst";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // selectBtn
            // 
            selectBtn.Location = new Point(305, 33);
            selectBtn.Name = "selectBtn";
            selectBtn.Size = new Size(94, 29);
            selectBtn.TabIndex = 8;
            selectBtn.Text = "Izvēlēties";
            selectBtn.UseVisualStyleBackColor = true;
            selectBtn.Click += selectBtn_Click;
            // 
            // pizzaList
            // 
            pizzaList.FormattingEnabled = true;
            pizzaList.Location = new Point(39, 34);
            pizzaList.Name = "pizzaList";
            pizzaList.Size = new Size(260, 28);
            pizzaList.TabIndex = 9;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 249);
            Controls.Add(pizzaList);
            Controls.Add(selectBtn);
            Controls.Add(deleteBtn);
            Controls.Add(addBtn);
            Controls.Add(priceTxt);
            Controls.Add(sizeTxt);
            Controls.Add(descTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox descTxt;
        private TextBox sizeTxt;
        private TextBox priceTxt;
        private Button addBtn;
        private Button deleteBtn;
        private Button selectBtn;
        private ComboBox pizzaList;
    }
}
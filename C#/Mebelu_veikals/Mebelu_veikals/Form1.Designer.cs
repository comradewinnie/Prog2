namespace Mebelu_veikals
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
            labelChooseProduct = new Label();
            selectProductComboBox = new ComboBox();
            labelName = new Label();
            nameTextBox = new TextBox();
            priceTextBox = new TextBox();
            labelPrice = new Label();
            descTextBox = new TextBox();
            labelDesc = new Label();
            lTextBox = new TextBox();
            labelLength = new Label();
            wTextBox = new TextBox();
            labelWidth = new Label();
            hTextBox = new TextBox();
            labelHeight = new Label();
            selectBtn = new Button();
            addButton = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            SuspendLayout();
            // 
            // labelChooseProduct
            // 
            labelChooseProduct.AutoSize = true;
            labelChooseProduct.Location = new Point(38, 30);
            labelChooseProduct.Name = "labelChooseProduct";
            labelChooseProduct.Size = new Size(94, 20);
            labelChooseProduct.TabIndex = 0;
            labelChooseProduct.Text = "Izvēlies preci";
            // 
            // selectProductComboBox
            // 
            selectProductComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectProductComboBox.FormattingEnabled = true;
            selectProductComboBox.Location = new Point(38, 53);
            selectProductComboBox.Name = "selectProductComboBox";
            selectProductComboBox.Size = new Size(314, 28);
            selectProductComboBox.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(38, 103);
            labelName.Name = "labelName";
            labelName.Size = new Size(128, 20);
            labelName.TabIndex = 2;
            labelName.Text = "Preces nosaukums";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(38, 126);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(181, 27);
            nameTextBox.TabIndex = 3;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(38, 192);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(181, 27);
            priceTextBox.TabIndex = 5;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(38, 169);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(42, 20);
            labelPrice.TabIndex = 4;
            labelPrice.Text = "Cena";
            // 
            // descTextBox
            // 
            descTextBox.Location = new Point(38, 255);
            descTextBox.Name = "descTextBox";
            descTextBox.Size = new Size(181, 27);
            descTextBox.TabIndex = 7;
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Location = new Point(38, 232);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(65, 20);
            labelDesc.TabIndex = 6;
            labelDesc.Text = "Apraksts";
            // 
            // lTextBox
            // 
            lTextBox.Location = new Point(266, 255);
            lTextBox.Name = "lTextBox";
            lTextBox.Size = new Size(181, 27);
            lTextBox.TabIndex = 13;
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(266, 232);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(59, 20);
            labelLength.TabIndex = 12;
            labelLength.Text = "Garums";
            // 
            // wTextBox
            // 
            wTextBox.Location = new Point(266, 192);
            wTextBox.Name = "wTextBox";
            wTextBox.Size = new Size(181, 27);
            wTextBox.TabIndex = 11;
            // 
            // labelWidth
            // 
            labelWidth.AutoSize = true;
            labelWidth.Location = new Point(266, 169);
            labelWidth.Name = "labelWidth";
            labelWidth.Size = new Size(61, 20);
            labelWidth.TabIndex = 10;
            labelWidth.Text = "Platums";
            // 
            // hTextBox
            // 
            hTextBox.Location = new Point(266, 126);
            hTextBox.Name = "hTextBox";
            hTextBox.Size = new Size(181, 27);
            hTextBox.TabIndex = 9;
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Location = new Point(266, 103);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(74, 20);
            labelHeight.TabIndex = 8;
            labelHeight.Text = "Augstums";
            // 
            // selectBtn
            // 
            selectBtn.Location = new Point(358, 52);
            selectBtn.Name = "selectBtn";
            selectBtn.Size = new Size(89, 29);
            selectBtn.TabIndex = 14;
            selectBtn.Text = "Izvēlēties";
            selectBtn.UseVisualStyleBackColor = true;
            selectBtn.Click += selectBtn_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(88, 311);
            addButton.Name = "addButton";
            addButton.Size = new Size(89, 29);
            addButton.TabIndex = 15;
            addButton.Text = "Pievienot";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(195, 311);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(89, 29);
            editBtn.TabIndex = 16;
            editBtn.Text = "Rediģēt";
            editBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(301, 311);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(89, 29);
            deleteBtn.TabIndex = 17;
            deleteBtn.Text = "Dzēst";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(488, 378);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(addButton);
            Controls.Add(selectBtn);
            Controls.Add(lTextBox);
            Controls.Add(labelLength);
            Controls.Add(wTextBox);
            Controls.Add(labelWidth);
            Controls.Add(hTextBox);
            Controls.Add(labelHeight);
            Controls.Add(descTextBox);
            Controls.Add(labelDesc);
            Controls.Add(priceTextBox);
            Controls.Add(labelPrice);
            Controls.Add(nameTextBox);
            Controls.Add(labelName);
            Controls.Add(selectProductComboBox);
            Controls.Add(labelChooseProduct);
            Name = "Form1";
            Text = "Mēbeļu veikals";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelChooseProduct;
        private ComboBox selectProductComboBox;
        private Label labelName;
        private TextBox nameTextBox;
        private TextBox priceTextBox;
        private Label labelPrice;
        private TextBox descTextBox;
        private Label labelDesc;
        private TextBox lTextBox;
        private Label labelLength;
        private TextBox wTextBox;
        private Label labelWidth;
        private TextBox hTextBox;
        private Label labelHeight;
        private Button selectBtn;
        private Button addButton;
        private Button editBtn;
        private Button deleteBtn;
    }
}
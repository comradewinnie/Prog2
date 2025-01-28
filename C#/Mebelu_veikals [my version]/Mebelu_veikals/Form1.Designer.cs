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
            buttonExportCSV = new Button();
            buttonImportCSV = new Button();
            SuspendLayout();
            // 
            // labelChooseProduct
            // 
            labelChooseProduct.AutoSize = true;
            labelChooseProduct.Location = new Point(33, 22);
            labelChooseProduct.Name = "labelChooseProduct";
            labelChooseProduct.Size = new Size(73, 15);
            labelChooseProduct.TabIndex = 0;
            labelChooseProduct.Text = "Izvēlies preci";
            // 
            // selectProductComboBox
            // 
            selectProductComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectProductComboBox.FormattingEnabled = true;
            selectProductComboBox.Location = new Point(33, 40);
            selectProductComboBox.Margin = new Padding(3, 2, 3, 2);
            selectProductComboBox.Name = "selectProductComboBox";
            selectProductComboBox.Size = new Size(275, 23);
            selectProductComboBox.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(33, 77);
            labelName.Name = "labelName";
            labelName.Size = new Size(105, 15);
            labelName.TabIndex = 2;
            labelName.Text = "Preces nosaukums";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(33, 94);
            nameTextBox.Margin = new Padding(3, 2, 3, 2);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(159, 23);
            nameTextBox.TabIndex = 3;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(33, 144);
            priceTextBox.Margin = new Padding(3, 2, 3, 2);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(159, 23);
            priceTextBox.TabIndex = 5;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(33, 127);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(34, 15);
            labelPrice.TabIndex = 4;
            labelPrice.Text = "Cena";
            // 
            // descTextBox
            // 
            descTextBox.Location = new Point(33, 191);
            descTextBox.Margin = new Padding(3, 2, 3, 2);
            descTextBox.Name = "descTextBox";
            descTextBox.Size = new Size(159, 23);
            descTextBox.TabIndex = 7;
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Location = new Point(33, 174);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(52, 15);
            labelDesc.TabIndex = 6;
            labelDesc.Text = "Apraksts";
            // 
            // lTextBox
            // 
            lTextBox.Location = new Point(233, 191);
            lTextBox.Margin = new Padding(3, 2, 3, 2);
            lTextBox.Name = "lTextBox";
            lTextBox.Size = new Size(159, 23);
            lTextBox.TabIndex = 13;
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(233, 174);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(48, 15);
            labelLength.TabIndex = 12;
            labelLength.Text = "Garums";
            // 
            // wTextBox
            // 
            wTextBox.Location = new Point(233, 144);
            wTextBox.Margin = new Padding(3, 2, 3, 2);
            wTextBox.Name = "wTextBox";
            wTextBox.Size = new Size(159, 23);
            wTextBox.TabIndex = 11;
            // 
            // labelWidth
            // 
            labelWidth.AutoSize = true;
            labelWidth.Location = new Point(233, 127);
            labelWidth.Name = "labelWidth";
            labelWidth.Size = new Size(50, 15);
            labelWidth.TabIndex = 10;
            labelWidth.Text = "Platums";
            // 
            // hTextBox
            // 
            hTextBox.Location = new Point(233, 94);
            hTextBox.Margin = new Padding(3, 2, 3, 2);
            hTextBox.Name = "hTextBox";
            hTextBox.Size = new Size(159, 23);
            hTextBox.TabIndex = 9;
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Location = new Point(233, 77);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(61, 15);
            labelHeight.TabIndex = 8;
            labelHeight.Text = "Augstums";
            // 
            // selectBtn
            // 
            selectBtn.Location = new Point(313, 39);
            selectBtn.Margin = new Padding(3, 2, 3, 2);
            selectBtn.Name = "selectBtn";
            selectBtn.Size = new Size(78, 22);
            selectBtn.TabIndex = 14;
            selectBtn.Text = "Izvēlēties";
            selectBtn.UseVisualStyleBackColor = true;
            selectBtn.Click += selectBtn_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(77, 233);
            addButton.Margin = new Padding(3, 2, 3, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(78, 22);
            addButton.TabIndex = 15;
            addButton.Text = "Pievienot";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(171, 233);
            editBtn.Margin = new Padding(3, 2, 3, 2);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(78, 22);
            editBtn.TabIndex = 16;
            editBtn.Text = "Rediģēt";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(263, 233);
            deleteBtn.Margin = new Padding(3, 2, 3, 2);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(78, 22);
            deleteBtn.TabIndex = 17;
            deleteBtn.Text = "Dzēst";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // buttonExportCSV
            // 
            buttonExportCSV.Location = new Point(100, 266);
            buttonExportCSV.Margin = new Padding(3, 2, 3, 2);
            buttonExportCSV.Name = "buttonExportCSV";
            buttonExportCSV.Size = new Size(101, 22);
            buttonExportCSV.TabIndex = 18;
            buttonExportCSV.Text = "Eksportēt CSV";
            buttonExportCSV.UseVisualStyleBackColor = true;
            buttonExportCSV.Click += buttonExportCSV_Click;
            // 
            // buttonImportCSV
            // 
            buttonImportCSV.Location = new Point(216, 266);
            buttonImportCSV.Margin = new Padding(3, 2, 3, 2);
            buttonImportCSV.Name = "buttonImportCSV";
            buttonImportCSV.Size = new Size(101, 22);
            buttonImportCSV.TabIndex = 19;
            buttonImportCSV.Text = "Importēt CSV";
            buttonImportCSV.UseVisualStyleBackColor = true;
            buttonImportCSV.Click += buttonImportCSV_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(427, 298);
            Controls.Add(buttonImportCSV);
            Controls.Add(buttonExportCSV);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private Button buttonExportCSV;
        private Button buttonImportCSV;
    }
}
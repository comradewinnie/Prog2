namespace PC_Components
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
            tabControl1 = new TabControl();
            tabPageRegisterComponent = new TabPage();
            textBoxModel = new TextBox();
            textBoxPrice = new TextBox();
            buttonRegister = new Button();
            labelPrice = new Label();
            labelModel = new Label();
            comboBoxType = new ComboBox();
            labelType = new Label();
            tabPageViewComponent = new TabPage();
            textBoxModel2 = new TextBox();
            textBoxPrice2 = new TextBox();
            labelPrice2 = new Label();
            labelModel2 = new Label();
            comboBoxType2 = new ComboBox();
            labelType2 = new Label();
            groupBox1 = new GroupBox();
            buttonSaveText = new Button();
            buttonEditInfo = new Button();
            buttonViewInfo = new Button();
            tabControl1.SuspendLayout();
            tabPageRegisterComponent.SuspendLayout();
            tabPageViewComponent.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageRegisterComponent);
            tabControl1.Controls.Add(tabPageViewComponent);
            tabControl1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 388);
            tabControl1.TabIndex = 0;
            // 
            // tabPageRegisterComponent
            // 
            tabPageRegisterComponent.BackColor = Color.FromArgb(128, 255, 255);
            tabPageRegisterComponent.Controls.Add(textBoxModel);
            tabPageRegisterComponent.Controls.Add(textBoxPrice);
            tabPageRegisterComponent.Controls.Add(buttonRegister);
            tabPageRegisterComponent.Controls.Add(labelPrice);
            tabPageRegisterComponent.Controls.Add(labelModel);
            tabPageRegisterComponent.Controls.Add(comboBoxType);
            tabPageRegisterComponent.Controls.Add(labelType);
            tabPageRegisterComponent.Location = new Point(4, 33);
            tabPageRegisterComponent.Name = "tabPageRegisterComponent";
            tabPageRegisterComponent.Padding = new Padding(3);
            tabPageRegisterComponent.Size = new Size(768, 351);
            tabPageRegisterComponent.TabIndex = 0;
            tabPageRegisterComponent.Text = "Reģistrēt komponenti";
            // 
            // textBoxModel
            // 
            textBoxModel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxModel.Location = new Point(37, 180);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(434, 42);
            textBoxModel.TabIndex = 8;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPrice.Location = new Point(37, 284);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(202, 42);
            textBoxPrice.TabIndex = 7;
            // 
            // buttonRegister
            // 
            buttonRegister.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegister.Location = new Point(497, 267);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(223, 63);
            buttonRegister.TabIndex = 6;
            buttonRegister.Text = "Reģistrēt";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrice.Location = new Point(32, 237);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(89, 35);
            labelPrice.TabIndex = 4;
            labelPrice.Text = "Cena";
            labelPrice.Click += label3_Click;
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelModel.Location = new Point(32, 131);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(126, 35);
            labelModel.TabIndex = 2;
            labelModel.Text = "Modelis";
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(37, 69);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(195, 43);
            comboBoxType.TabIndex = 1;
            comboBoxType.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelType.Location = new Point(32, 19);
            labelType.Name = "labelType";
            labelType.Size = new Size(93, 35);
            labelType.TabIndex = 0;
            labelType.Text = "Veids";
            labelType.Click += label1_Click;
            // 
            // tabPageViewComponent
            // 
            tabPageViewComponent.BackColor = Color.FromArgb(128, 255, 255);
            tabPageViewComponent.Controls.Add(textBoxModel2);
            tabPageViewComponent.Controls.Add(textBoxPrice2);
            tabPageViewComponent.Controls.Add(labelPrice2);
            tabPageViewComponent.Controls.Add(labelModel2);
            tabPageViewComponent.Controls.Add(comboBoxType2);
            tabPageViewComponent.Controls.Add(labelType2);
            tabPageViewComponent.Controls.Add(groupBox1);
            tabPageViewComponent.Location = new Point(4, 33);
            tabPageViewComponent.Name = "tabPageViewComponent";
            tabPageViewComponent.Padding = new Padding(3);
            tabPageViewComponent.Size = new Size(768, 351);
            tabPageViewComponent.TabIndex = 1;
            tabPageViewComponent.Text = "Apskatīt / Rediģēt komponenti";
            tabPageViewComponent.Click += tabPageViewComponent_Click;
            // 
            // textBoxModel2
            // 
            textBoxModel2.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxModel2.Location = new Point(33, 165);
            textBoxModel2.Name = "textBoxModel2";
            textBoxModel2.Size = new Size(378, 36);
            textBoxModel2.TabIndex = 18;
            // 
            // textBoxPrice2
            // 
            textBoxPrice2.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPrice2.Location = new Point(33, 255);
            textBoxPrice2.Name = "textBoxPrice2";
            textBoxPrice2.Size = new Size(202, 36);
            textBoxPrice2.TabIndex = 17;
            // 
            // labelPrice2
            // 
            labelPrice2.AutoSize = true;
            labelPrice2.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrice2.Location = new Point(28, 217);
            labelPrice2.Name = "labelPrice2";
            labelPrice2.Size = new Size(74, 30);
            labelPrice2.TabIndex = 16;
            labelPrice2.Text = "Cena";
            // 
            // labelModel2
            // 
            labelModel2.AutoSize = true;
            labelModel2.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelModel2.Location = new Point(28, 122);
            labelModel2.Name = "labelModel2";
            labelModel2.Size = new Size(106, 30);
            labelModel2.TabIndex = 15;
            labelModel2.Text = "Modelis";
            // 
            // comboBoxType2
            // 
            comboBoxType2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType2.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxType2.FormattingEnabled = true;
            comboBoxType2.Location = new Point(33, 69);
            comboBoxType2.Name = "comboBoxType2";
            comboBoxType2.Size = new Size(174, 38);
            comboBoxType2.TabIndex = 14;
            comboBoxType2.SelectedIndexChanged += comboBoxType2_SelectedIndexChanged;
            // 
            // labelType2
            // 
            labelType2.AutoSize = true;
            labelType2.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelType2.Location = new Point(28, 26);
            labelType2.Name = "labelType2";
            labelType2.Size = new Size(79, 30);
            labelType2.TabIndex = 13;
            labelType2.Text = "Veids";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSaveText);
            groupBox1.Controls.Add(buttonEditInfo);
            groupBox1.Controls.Add(buttonViewInfo);
            groupBox1.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(454, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 282);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Darbība";
            // 
            // buttonSaveText
            // 
            buttonSaveText.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSaveText.Location = new Point(18, 200);
            buttonSaveText.Name = "buttonSaveText";
            buttonSaveText.Size = new Size(252, 48);
            buttonSaveText.TabIndex = 2;
            buttonSaveText.Text = "Saglabāt teksta datnē";
            buttonSaveText.UseVisualStyleBackColor = true;
            buttonSaveText.Click += button4_Click;
            // 
            // buttonEditInfo
            // 
            buttonEditInfo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditInfo.Location = new Point(18, 122);
            buttonEditInfo.Name = "buttonEditInfo";
            buttonEditInfo.Size = new Size(252, 48);
            buttonEditInfo.TabIndex = 1;
            buttonEditInfo.Text = "Labot informāciju";
            buttonEditInfo.UseVisualStyleBackColor = true;
            buttonEditInfo.Click += button3_Click;
            // 
            // buttonViewInfo
            // 
            buttonViewInfo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonViewInfo.Location = new Point(18, 46);
            buttonViewInfo.Name = "buttonViewInfo";
            buttonViewInfo.Size = new Size(252, 48);
            buttonViewInfo.TabIndex = 0;
            buttonViewInfo.Text = "Apskatīt informāciju";
            buttonViewInfo.UseVisualStyleBackColor = true;
            buttonViewInfo.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 414);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Datoru komponentes";
            tabControl1.ResumeLayout(false);
            tabPageRegisterComponent.ResumeLayout(false);
            tabPageRegisterComponent.PerformLayout();
            tabPageViewComponent.ResumeLayout(false);
            tabPageViewComponent.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageRegisterComponent;
        private TabPage tabPageViewComponent;
        private Label labelType;
        private Button buttonRegister;
        private Label labelPrice;
        private Label labelModel;
        private ComboBox comboBoxType;
        private GroupBox groupBox1;
        private Button buttonSaveText;
        private Button buttonEditInfo;
        private Button buttonViewInfo;
        private TextBox textBoxModel;
        private TextBox textBoxPrice;
        private TextBox textBoxModel2;
        private TextBox textBoxPrice2;
        private Label labelPrice2;
        private Label labelModel2;
        private ComboBox comboBoxType2;
        private Label labelType2;
    }
}
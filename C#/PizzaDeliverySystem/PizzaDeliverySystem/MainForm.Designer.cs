namespace PizzaDeliverySystem
{
    partial class MainForm
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
            pizzaList = new ComboBox();
            selectBtn = new Button();
            label1 = new Label();
            submitBtn = new Button();
            cartGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)cartGrid).BeginInit();
            SuspendLayout();
            // 
            // pizzaList
            // 
            pizzaList.FormattingEnabled = true;
            pizzaList.Location = new Point(34, 26);
            pizzaList.Name = "pizzaList";
            pizzaList.Size = new Size(260, 28);
            pizzaList.TabIndex = 11;
            // 
            // selectBtn
            // 
            selectBtn.Location = new Point(300, 25);
            selectBtn.Name = "selectBtn";
            selectBtn.Size = new Size(94, 29);
            selectBtn.TabIndex = 10;
            selectBtn.Text = "Izvēlēties";
            selectBtn.UseVisualStyleBackColor = true;
            selectBtn.Click += selectBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 72);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 12;
            label1.Text = "Pasūtījuma grozs";
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(220, 341);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(174, 29);
            submitBtn.TabIndex = 13;
            submitBtn.Text = "Noformēt pasūtījumu";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // cartGrid
            // 
            cartGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cartGrid.Location = new Point(34, 95);
            cartGrid.Name = "cartGrid";
            cartGrid.RowHeadersWidth = 51;
            cartGrid.RowTemplate.Height = 29;
            cartGrid.Size = new Size(360, 240);
            cartGrid.TabIndex = 14;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 391);
            Controls.Add(cartGrid);
            Controls.Add(submitBtn);
            Controls.Add(label1);
            Controls.Add(pizzaList);
            Controls.Add(selectBtn);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)cartGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox pizzaList;
        private Button selectBtn;
        private Label label1;
        private Button submitBtn;
        private DataGridView cartGrid;
    }
}
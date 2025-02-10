namespace WeatherApp
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
            labelMaxTemp = new Label();
            textBoxMaxTemp = new TextBox();
            textBoxMinTemp = new TextBox();
            labelMinTemp = new Label();
            textBoxHumidity = new TextBox();
            labelHumidity = new Label();
            textBoxWindSpeed = new TextBox();
            labelWindSpeed = new Label();
            textBoxPressure = new TextBox();
            labelPressure = new Label();
            textBoxCity = new TextBox();
            labelCity = new Label();
            textBoxMoon = new TextBox();
            labelMoon = new Label();
            buttonShowForecast = new Button();
            pictureCondition = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            buttonShow2 = new Button();
            labelCity2 = new Label();
            textBoxCity2 = new TextBox();
            dataGridViewForecast = new DataGridView();
            labelSunrise = new Label();
            textBoxSunrise = new TextBox();
            labelSunset = new Label();
            textBoxSunset = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureCondition).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewForecast).BeginInit();
            SuspendLayout();
            // 
            // labelMaxTemp
            // 
            labelMaxTemp.AutoSize = true;
            labelMaxTemp.Location = new Point(65, 24);
            labelMaxTemp.Name = "labelMaxTemp";
            labelMaxTemp.Size = new Size(166, 20);
            labelMaxTemp.TabIndex = 0;
            labelMaxTemp.Text = "Maksimāla temperatūra";
            // 
            // textBoxMaxTemp
            // 
            textBoxMaxTemp.Location = new Point(237, 24);
            textBoxMaxTemp.Name = "textBoxMaxTemp";
            textBoxMaxTemp.ReadOnly = true;
            textBoxMaxTemp.Size = new Size(125, 27);
            textBoxMaxTemp.TabIndex = 1;
            // 
            // textBoxMinTemp
            // 
            textBoxMinTemp.Location = new Point(237, 68);
            textBoxMinTemp.Name = "textBoxMinTemp";
            textBoxMinTemp.ReadOnly = true;
            textBoxMinTemp.Size = new Size(125, 27);
            textBoxMinTemp.TabIndex = 3;
            // 
            // labelMinTemp
            // 
            labelMinTemp.AutoSize = true;
            labelMinTemp.Location = new Point(65, 68);
            labelMinTemp.Name = "labelMinTemp";
            labelMinTemp.Size = new Size(157, 20);
            labelMinTemp.TabIndex = 2;
            labelMinTemp.Text = "Minimāla temperatūra";
            // 
            // textBoxHumidity
            // 
            textBoxHumidity.Location = new Point(237, 111);
            textBoxHumidity.Name = "textBoxHumidity";
            textBoxHumidity.ReadOnly = true;
            textBoxHumidity.Size = new Size(125, 27);
            textBoxHumidity.TabIndex = 5;
            // 
            // labelHumidity
            // 
            labelHumidity.AutoSize = true;
            labelHumidity.Location = new Point(65, 111);
            labelHumidity.Name = "labelHumidity";
            labelHumidity.Size = new Size(63, 20);
            labelHumidity.TabIndex = 4;
            labelHumidity.Text = "Mitrums";
            // 
            // textBoxWindSpeed
            // 
            textBoxWindSpeed.Location = new Point(237, 157);
            textBoxWindSpeed.Name = "textBoxWindSpeed";
            textBoxWindSpeed.ReadOnly = true;
            textBoxWindSpeed.Size = new Size(125, 27);
            textBoxWindSpeed.TabIndex = 7;
            // 
            // labelWindSpeed
            // 
            labelWindSpeed.AutoSize = true;
            labelWindSpeed.Location = new Point(65, 157);
            labelWindSpeed.Name = "labelWindSpeed";
            labelWindSpeed.Size = new Size(86, 20);
            labelWindSpeed.TabIndex = 6;
            labelWindSpeed.Text = "Vēja ātrums";
            // 
            // textBoxPressure
            // 
            textBoxPressure.Location = new Point(237, 202);
            textBoxPressure.Name = "textBoxPressure";
            textBoxPressure.ReadOnly = true;
            textBoxPressure.Size = new Size(125, 27);
            textBoxPressure.TabIndex = 9;
            // 
            // labelPressure
            // 
            labelPressure.AutoSize = true;
            labelPressure.Location = new Point(65, 202);
            labelPressure.Name = "labelPressure";
            labelPressure.Size = new Size(150, 20);
            labelPressure.TabIndex = 8;
            labelPressure.Text = "Atmosfēras spiediens";
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(485, 282);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(125, 27);
            textBoxCity.TabIndex = 11;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(426, 282);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(52, 20);
            labelCity.TabIndex = 10;
            labelCity.Text = "Pilsēta";
            // 
            // textBoxMoon
            // 
            textBoxMoon.Location = new Point(237, 246);
            textBoxMoon.Name = "textBoxMoon";
            textBoxMoon.ReadOnly = true;
            textBoxMoon.Size = new Size(125, 27);
            textBoxMoon.TabIndex = 13;
            // 
            // labelMoon
            // 
            labelMoon.AutoSize = true;
            labelMoon.Location = new Point(65, 246);
            labelMoon.Name = "labelMoon";
            labelMoon.Size = new Size(90, 20);
            labelMoon.TabIndex = 12;
            labelMoon.Text = "Mēness fāze";
            // 
            // buttonShowForecast
            // 
            buttonShowForecast.Location = new Point(616, 282);
            buttonShowForecast.Name = "buttonShowForecast";
            buttonShowForecast.Size = new Size(146, 29);
            buttonShowForecast.TabIndex = 14;
            buttonShowForecast.Text = "Parādīt prognozi";
            buttonShowForecast.UseVisualStyleBackColor = true;
            buttonShowForecast.Click += buttonShowForecast_Click;
            // 
            // pictureCondition
            // 
            pictureCondition.Location = new Point(497, 111);
            pictureCondition.Name = "pictureCondition";
            pictureCondition.Size = new Size(178, 146);
            pictureCondition.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCondition.TabIndex = 15;
            pictureCondition.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(803, 364);
            tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(labelSunrise);
            tabPage1.Controls.Add(textBoxSunrise);
            tabPage1.Controls.Add(labelSunset);
            tabPage1.Controls.Add(textBoxSunset);
            tabPage1.Controls.Add(labelMaxTemp);
            tabPage1.Controls.Add(pictureCondition);
            tabPage1.Controls.Add(textBoxMaxTemp);
            tabPage1.Controls.Add(buttonShowForecast);
            tabPage1.Controls.Add(labelMinTemp);
            tabPage1.Controls.Add(textBoxMoon);
            tabPage1.Controls.Add(textBoxMinTemp);
            tabPage1.Controls.Add(labelMoon);
            tabPage1.Controls.Add(labelHumidity);
            tabPage1.Controls.Add(textBoxCity);
            tabPage1.Controls.Add(textBoxHumidity);
            tabPage1.Controls.Add(labelCity);
            tabPage1.Controls.Add(labelWindSpeed);
            tabPage1.Controls.Add(textBoxPressure);
            tabPage1.Controls.Add(textBoxWindSpeed);
            tabPage1.Controls.Add(labelPressure);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(795, 331);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonShow2);
            tabPage2.Controls.Add(labelCity2);
            tabPage2.Controls.Add(textBoxCity2);
            tabPage2.Controls.Add(dataGridViewForecast);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(795, 304);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonShow2
            // 
            buttonShow2.Location = new Point(234, 29);
            buttonShow2.Name = "buttonShow2";
            buttonShow2.Size = new Size(140, 29);
            buttonShow2.TabIndex = 3;
            buttonShow2.Text = "Parādīt prognozi";
            buttonShow2.UseVisualStyleBackColor = true;
            buttonShow2.Click += buttonShow2_Click;
            // 
            // labelCity2
            // 
            labelCity2.AutoSize = true;
            labelCity2.Location = new Point(23, 29);
            labelCity2.Name = "labelCity2";
            labelCity2.Size = new Size(55, 20);
            labelCity2.TabIndex = 2;
            labelCity2.Text = "Pilsēta:";
            // 
            // textBoxCity2
            // 
            textBoxCity2.Location = new Point(84, 29);
            textBoxCity2.Name = "textBoxCity2";
            textBoxCity2.Size = new Size(125, 27);
            textBoxCity2.TabIndex = 1;
            // 
            // dataGridViewForecast
            // 
            dataGridViewForecast.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewForecast.Location = new Point(0, 76);
            dataGridViewForecast.Name = "dataGridViewForecast";
            dataGridViewForecast.RowHeadersWidth = 51;
            dataGridViewForecast.RowTemplate.Height = 29;
            dataGridViewForecast.Size = new Size(795, 228);
            dataGridViewForecast.TabIndex = 0;
            // 
            // labelSunrise
            // 
            labelSunrise.AutoSize = true;
            labelSunrise.Location = new Point(426, 21);
            labelSunrise.Name = "labelSunrise";
            labelSunrise.Size = new Size(67, 20);
            labelSunrise.TabIndex = 16;
            labelSunrise.Text = "Saullēkts";
            // 
            // textBoxSunrise
            // 
            textBoxSunrise.Location = new Point(598, 21);
            textBoxSunrise.Name = "textBoxSunrise";
            textBoxSunrise.ReadOnly = true;
            textBoxSunrise.Size = new Size(125, 27);
            textBoxSunrise.TabIndex = 17;
            // 
            // labelSunset
            // 
            labelSunset.AutoSize = true;
            labelSunset.Location = new Point(426, 65);
            labelSunset.Name = "labelSunset";
            labelSunset.Size = new Size(65, 20);
            labelSunset.TabIndex = 18;
            labelSunset.Text = "Saulriets";
            // 
            // textBoxSunset
            // 
            textBoxSunset.Location = new Point(598, 65);
            textBoxSunset.Name = "textBoxSunset";
            textBoxSunset.ReadOnly = true;
            textBoxSunset.Size = new Size(125, 27);
            textBoxSunset.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 388);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Laika ziņas";
            ((System.ComponentModel.ISupportInitialize)pictureCondition).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewForecast).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelMaxTemp;
        private TextBox textBoxMaxTemp;
        private TextBox textBoxMinTemp;
        private Label labelMinTemp;
        private TextBox textBoxHumidity;
        private Label labelHumidity;
        private TextBox textBoxWindSpeed;
        private Label labelWindSpeed;
        private TextBox textBoxPressure;
        private Label labelPressure;
        private TextBox textBoxCity;
        private Label labelCity;
        private TextBox textBoxMoon;
        private Label labelMoon;
        private Button buttonShowForecast;
        private PictureBox pictureCondition;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridViewForecast;
        private Button buttonShow2;
        private Label labelCity2;
        private TextBox textBoxCity2;
        private Label labelSunrise;
        private TextBox textBoxSunrise;
        private Label labelSunset;
        private TextBox textBoxSunset;
    }
}
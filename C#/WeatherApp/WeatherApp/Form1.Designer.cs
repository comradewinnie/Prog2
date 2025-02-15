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
            weatherTabs = new TabControl();
            tabPageWeatherNow = new TabPage();
            labelSunrise = new Label();
            textBoxSunrise = new TextBox();
            labelSunset = new Label();
            textBoxSunset = new TextBox();
            tabPageForecast = new TabPage();
            buttonSaveCity = new Button();
            buttonShow2 = new Button();
            labelCity2 = new Label();
            textBoxCity2 = new TextBox();
            dataGridViewForecast = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureCondition).BeginInit();
            weatherTabs.SuspendLayout();
            tabPageWeatherNow.SuspendLayout();
            tabPageForecast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewForecast).BeginInit();
            SuspendLayout();
            // 
            // labelMaxTemp
            // 
            labelMaxTemp.AutoSize = true;
            labelMaxTemp.Location = new Point(57, 18);
            labelMaxTemp.Name = "labelMaxTemp";
            labelMaxTemp.Size = new Size(132, 15);
            labelMaxTemp.TabIndex = 0;
            labelMaxTemp.Text = "Maksimāla temperatūra";
            // 
            // textBoxMaxTemp
            // 
            textBoxMaxTemp.Location = new Point(207, 18);
            textBoxMaxTemp.Margin = new Padding(3, 2, 3, 2);
            textBoxMaxTemp.Name = "textBoxMaxTemp";
            textBoxMaxTemp.ReadOnly = true;
            textBoxMaxTemp.Size = new Size(110, 23);
            textBoxMaxTemp.TabIndex = 1;
            // 
            // textBoxMinTemp
            // 
            textBoxMinTemp.Location = new Point(207, 51);
            textBoxMinTemp.Margin = new Padding(3, 2, 3, 2);
            textBoxMinTemp.Name = "textBoxMinTemp";
            textBoxMinTemp.ReadOnly = true;
            textBoxMinTemp.Size = new Size(110, 23);
            textBoxMinTemp.TabIndex = 3;
            // 
            // labelMinTemp
            // 
            labelMinTemp.AutoSize = true;
            labelMinTemp.Location = new Point(57, 51);
            labelMinTemp.Name = "labelMinTemp";
            labelMinTemp.Size = new Size(125, 15);
            labelMinTemp.TabIndex = 2;
            labelMinTemp.Text = "Minimāla temperatūra";
            // 
            // textBoxHumidity
            // 
            textBoxHumidity.Location = new Point(207, 83);
            textBoxHumidity.Margin = new Padding(3, 2, 3, 2);
            textBoxHumidity.Name = "textBoxHumidity";
            textBoxHumidity.ReadOnly = true;
            textBoxHumidity.Size = new Size(110, 23);
            textBoxHumidity.TabIndex = 5;
            // 
            // labelHumidity
            // 
            labelHumidity.AutoSize = true;
            labelHumidity.Location = new Point(57, 83);
            labelHumidity.Name = "labelHumidity";
            labelHumidity.Size = new Size(52, 15);
            labelHumidity.TabIndex = 4;
            labelHumidity.Text = "Mitrums";
            // 
            // textBoxWindSpeed
            // 
            textBoxWindSpeed.Location = new Point(207, 118);
            textBoxWindSpeed.Margin = new Padding(3, 2, 3, 2);
            textBoxWindSpeed.Name = "textBoxWindSpeed";
            textBoxWindSpeed.ReadOnly = true;
            textBoxWindSpeed.Size = new Size(110, 23);
            textBoxWindSpeed.TabIndex = 7;
            // 
            // labelWindSpeed
            // 
            labelWindSpeed.AutoSize = true;
            labelWindSpeed.Location = new Point(57, 118);
            labelWindSpeed.Name = "labelWindSpeed";
            labelWindSpeed.Size = new Size(68, 15);
            labelWindSpeed.TabIndex = 6;
            labelWindSpeed.Text = "Vēja ātrums";
            // 
            // textBoxPressure
            // 
            textBoxPressure.Location = new Point(207, 152);
            textBoxPressure.Margin = new Padding(3, 2, 3, 2);
            textBoxPressure.Name = "textBoxPressure";
            textBoxPressure.ReadOnly = true;
            textBoxPressure.Size = new Size(110, 23);
            textBoxPressure.TabIndex = 9;
            // 
            // labelPressure
            // 
            labelPressure.AutoSize = true;
            labelPressure.Location = new Point(57, 152);
            labelPressure.Name = "labelPressure";
            labelPressure.Size = new Size(119, 15);
            labelPressure.TabIndex = 8;
            labelPressure.Text = "Atmosfēras spiediens";
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(424, 212);
            textBoxCity.Margin = new Padding(3, 2, 3, 2);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(110, 23);
            textBoxCity.TabIndex = 11;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(373, 212);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(41, 15);
            labelCity.TabIndex = 10;
            labelCity.Text = "Pilsēta";
            // 
            // textBoxMoon
            // 
            textBoxMoon.Location = new Point(207, 184);
            textBoxMoon.Margin = new Padding(3, 2, 3, 2);
            textBoxMoon.Name = "textBoxMoon";
            textBoxMoon.ReadOnly = true;
            textBoxMoon.Size = new Size(110, 23);
            textBoxMoon.TabIndex = 13;
            // 
            // labelMoon
            // 
            labelMoon.AutoSize = true;
            labelMoon.Location = new Point(57, 184);
            labelMoon.Name = "labelMoon";
            labelMoon.Size = new Size(71, 15);
            labelMoon.TabIndex = 12;
            labelMoon.Text = "Mēness fāze";
            // 
            // buttonShowForecast
            // 
            buttonShowForecast.Location = new Point(539, 212);
            buttonShowForecast.Margin = new Padding(3, 2, 3, 2);
            buttonShowForecast.Name = "buttonShowForecast";
            buttonShowForecast.Size = new Size(128, 22);
            buttonShowForecast.TabIndex = 14;
            buttonShowForecast.Text = "Parādīt prognozi";
            buttonShowForecast.UseVisualStyleBackColor = true;
            buttonShowForecast.Click += buttonShowForecast_Click;
            // 
            // pictureCondition
            // 
            pictureCondition.Location = new Point(435, 83);
            pictureCondition.Margin = new Padding(3, 2, 3, 2);
            pictureCondition.Name = "pictureCondition";
            pictureCondition.Size = new Size(156, 110);
            pictureCondition.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCondition.TabIndex = 15;
            pictureCondition.TabStop = false;
            // 
            // weatherTabs
            // 
            weatherTabs.Controls.Add(tabPageWeatherNow);
            weatherTabs.Controls.Add(tabPageForecast);
            weatherTabs.Location = new Point(10, 9);
            weatherTabs.Margin = new Padding(3, 2, 3, 2);
            weatherTabs.Name = "weatherTabs";
            weatherTabs.SelectedIndex = 0;
            weatherTabs.Size = new Size(703, 273);
            weatherTabs.TabIndex = 16;
            // 
            // tabPageWeatherNow
            // 
            tabPageWeatherNow.Controls.Add(labelSunrise);
            tabPageWeatherNow.Controls.Add(textBoxSunrise);
            tabPageWeatherNow.Controls.Add(labelSunset);
            tabPageWeatherNow.Controls.Add(textBoxSunset);
            tabPageWeatherNow.Controls.Add(labelMaxTemp);
            tabPageWeatherNow.Controls.Add(pictureCondition);
            tabPageWeatherNow.Controls.Add(textBoxMaxTemp);
            tabPageWeatherNow.Controls.Add(buttonShowForecast);
            tabPageWeatherNow.Controls.Add(labelMinTemp);
            tabPageWeatherNow.Controls.Add(textBoxMoon);
            tabPageWeatherNow.Controls.Add(textBoxMinTemp);
            tabPageWeatherNow.Controls.Add(labelMoon);
            tabPageWeatherNow.Controls.Add(labelHumidity);
            tabPageWeatherNow.Controls.Add(textBoxCity);
            tabPageWeatherNow.Controls.Add(textBoxHumidity);
            tabPageWeatherNow.Controls.Add(labelCity);
            tabPageWeatherNow.Controls.Add(labelWindSpeed);
            tabPageWeatherNow.Controls.Add(textBoxPressure);
            tabPageWeatherNow.Controls.Add(textBoxWindSpeed);
            tabPageWeatherNow.Controls.Add(labelPressure);
            tabPageWeatherNow.Location = new Point(4, 24);
            tabPageWeatherNow.Margin = new Padding(3, 2, 3, 2);
            tabPageWeatherNow.Name = "tabPageWeatherNow";
            tabPageWeatherNow.Padding = new Padding(3, 2, 3, 2);
            tabPageWeatherNow.Size = new Size(695, 245);
            tabPageWeatherNow.TabIndex = 0;
            tabPageWeatherNow.Text = "Laiks tagad";
            tabPageWeatherNow.UseVisualStyleBackColor = true;
            // 
            // labelSunrise
            // 
            labelSunrise.AutoSize = true;
            labelSunrise.Location = new Point(373, 16);
            labelSunrise.Name = "labelSunrise";
            labelSunrise.Size = new Size(53, 15);
            labelSunrise.TabIndex = 16;
            labelSunrise.Text = "Saullēkts";
            // 
            // textBoxSunrise
            // 
            textBoxSunrise.Location = new Point(523, 16);
            textBoxSunrise.Margin = new Padding(3, 2, 3, 2);
            textBoxSunrise.Name = "textBoxSunrise";
            textBoxSunrise.ReadOnly = true;
            textBoxSunrise.Size = new Size(110, 23);
            textBoxSunrise.TabIndex = 17;
            // 
            // labelSunset
            // 
            labelSunset.AutoSize = true;
            labelSunset.Location = new Point(373, 49);
            labelSunset.Name = "labelSunset";
            labelSunset.Size = new Size(51, 15);
            labelSunset.TabIndex = 18;
            labelSunset.Text = "Saulriets";
            // 
            // textBoxSunset
            // 
            textBoxSunset.Location = new Point(523, 49);
            textBoxSunset.Margin = new Padding(3, 2, 3, 2);
            textBoxSunset.Name = "textBoxSunset";
            textBoxSunset.ReadOnly = true;
            textBoxSunset.Size = new Size(110, 23);
            textBoxSunset.TabIndex = 19;
            // 
            // tabPageForecast
            // 
            tabPageForecast.Controls.Add(buttonSaveCity);
            tabPageForecast.Controls.Add(buttonShow2);
            tabPageForecast.Controls.Add(labelCity2);
            tabPageForecast.Controls.Add(textBoxCity2);
            tabPageForecast.Controls.Add(dataGridViewForecast);
            tabPageForecast.Location = new Point(4, 24);
            tabPageForecast.Margin = new Padding(3, 2, 3, 2);
            tabPageForecast.Name = "tabPageForecast";
            tabPageForecast.Padding = new Padding(3, 2, 3, 2);
            tabPageForecast.Size = new Size(695, 245);
            tabPageForecast.TabIndex = 1;
            tabPageForecast.Text = "Laika prognoze";
            tabPageForecast.UseVisualStyleBackColor = true;
            // 
            // buttonSaveCity
            // 
            buttonSaveCity.Location = new Point(538, 22);
            buttonSaveCity.Margin = new Padding(3, 2, 3, 2);
            buttonSaveCity.Name = "buttonSaveCity";
            buttonSaveCity.Size = new Size(122, 22);
            buttonSaveCity.TabIndex = 4;
            buttonSaveCity.Text = "Saglābāt pilsētu";
            buttonSaveCity.UseVisualStyleBackColor = true;
            buttonSaveCity.Click += buttonSaveCity_Click;
            // 
            // buttonShow2
            // 
            buttonShow2.Location = new Point(205, 22);
            buttonShow2.Margin = new Padding(3, 2, 3, 2);
            buttonShow2.Name = "buttonShow2";
            buttonShow2.Size = new Size(122, 22);
            buttonShow2.TabIndex = 3;
            buttonShow2.Text = "Parādīt prognozi";
            buttonShow2.UseVisualStyleBackColor = true;
            buttonShow2.Click += buttonShow2_Click;
            // 
            // labelCity2
            // 
            labelCity2.AutoSize = true;
            labelCity2.Location = new Point(20, 22);
            labelCity2.Name = "labelCity2";
            labelCity2.Size = new Size(44, 15);
            labelCity2.TabIndex = 2;
            labelCity2.Text = "Pilsēta:";
            // 
            // textBoxCity2
            // 
            textBoxCity2.Location = new Point(74, 22);
            textBoxCity2.Margin = new Padding(3, 2, 3, 2);
            textBoxCity2.Name = "textBoxCity2";
            textBoxCity2.Size = new Size(110, 23);
            textBoxCity2.TabIndex = 1;
            // 
            // dataGridViewForecast
            // 
            dataGridViewForecast.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewForecast.Location = new Point(0, 57);
            dataGridViewForecast.Margin = new Padding(3, 2, 3, 2);
            dataGridViewForecast.Name = "dataGridViewForecast";
            dataGridViewForecast.RowHeadersWidth = 51;
            dataGridViewForecast.RowTemplate.Height = 29;
            dataGridViewForecast.Size = new Size(695, 171);
            dataGridViewForecast.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 291);
            Controls.Add(weatherTabs);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Laika ziņas";
            ((System.ComponentModel.ISupportInitialize)pictureCondition).EndInit();
            weatherTabs.ResumeLayout(false);
            tabPageWeatherNow.ResumeLayout(false);
            tabPageWeatherNow.PerformLayout();
            tabPageForecast.ResumeLayout(false);
            tabPageForecast.PerformLayout();
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
        private TabControl weatherTabs;
        private TabPage tabPageWeatherNow;
        private TabPage tabPageForecast;
        private DataGridView dataGridViewForecast;
        private Button buttonShow2;
        private Label labelCity2;
        private TextBox textBoxCity2;
        private Label labelSunrise;
        private TextBox textBoxSunrise;
        private Label labelSunset;
        private TextBox textBoxSunset;
        private Button buttonSaveCity;
    }
}
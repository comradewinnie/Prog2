using System;
using System.Data;
using System.Linq;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Drawing;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShowForecast_Click(object sender, EventArgs e)
        {
            var cityName = textBoxCity.Text;
            var requestUrl = $"http://api.weatherapi.com/v1/forecast.xml?key=ecdaff50705e449ab6311843250302&q={cityName}&days=1";
            try
            {
                XDocument doc = XDocument.Load(requestUrl);

                string moonPhs = (string)doc.Descendants("moon_phase").FirstOrDefault();
                string maxT = (string)doc.Descendants("maxtemp_c").FirstOrDefault();
                string minT = (string)doc.Descendants("mintemp_c").FirstOrDefault();
                string hum = (string)doc.Descendants("avghumidity").FirstOrDefault();
                string windSpd = (string)doc.Descendants("wind_kph").FirstOrDefault();
                string baroPrss = (string)doc.Descendants("pressure_mb").FirstOrDefault();
                string sunRise = (string)doc.Descendants("sunrise").FirstOrDefault();
                string sunSet = (string)doc.Descendants("sunset").FirstOrDefault();
                string picUrl = (string)doc.Descendants("icon").FirstOrDefault();


                textBoxMoon.Text = moonPhs;
                textBoxMaxTemp.Text = $"{maxT}°C";
                textBoxMinTemp.Text = $"{minT}°C";
                textBoxHumidity.Text = $"{hum}%";
                textBoxWindSpeed.Text = $"{windSpd} km/h";
                textBoxPressure.Text = $"{baroPrss} mb";
                textBoxSunrise.Text = $"{sunRise}";
                textBoxSunset.Text = $"{sunSet}";

                WebClient client = new WebClient();
                byte[] image = client.DownloadData("http:" + picUrl);
                MemoryStream stream = new MemoryStream(image);
                Bitmap icon = new Bitmap(stream);

                pictureCondition.Image = icon;

            }

            catch (Exception HttpRequestException)
            {
                MessageBox.Show("Pilsēta nav atrasta!");
            }
        }

        private void buttonShow2_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Datums", typeof(string));
            table.Columns.Add("Minimāla temperatūra", typeof(string));
            table.Columns.Add("Maksimāla temperatūra", typeof(string));
            table.Columns.Add("Spiediens", typeof(string));
            table.Columns.Add("Mēness fāze", typeof(string));
            table.Columns.Add("Laikapstākļi", typeof(Image));

            var cityName = textBoxCity2.Text;
            var requestUrl = $"http://api.weatherapi.com/v1/forecast.xml?key=ecdaff50705e449ab6311843250302&q={cityName}&days=5";

            XDocument doc = XDocument.Load(requestUrl);

            var forecastDays = doc.Descendants("forecastday");

            foreach (var day in forecastDays)
            {
                string pictureUrl = (string)day.Descendants("icon").FirstOrDefault();

                WebClient client = new WebClient();
                byte[] image = client.DownloadData("http:" + pictureUrl);
                MemoryStream stream = new MemoryStream(image);
                Bitmap icon = new Bitmap(stream);


                object[] row = new object[]
                {
                    (string)day.Descendants("date").FirstOrDefault(),
                    (string)day.Descendants("mintemp_c").FirstOrDefault(),
                    (string)day.Descendants("maxtemp_c").FirstOrDefault(),
                    (string)day.Descendants("pressure_mb").FirstOrDefault(),
                    (string)day.Descendants("moon_phase").FirstOrDefault(),
                    icon
                };
                table.Rows.Add(row);
            };

            dataGridViewForecast.DataSource = table;
        }
    }
}
namespace PC_Components
{
    public partial class Form1 : Form
    {
        private DatoraKomponente komponente;

        public Form1()
        {
            InitializeComponent();

            var items = new List<string>() { "RAM", "CPU", "GPU" };
            comboBoxType.DataSource = items;
            comboBoxType2.DataSource = items;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBoxModel.Text))
                {
                    MessageBox.Show("Nav izvēlēts modelis!");
                }
                else if (String.IsNullOrEmpty(textBoxPrice.Text))
                {
                    MessageBox.Show("Nav izvēlēta cena!");
                }
                else if (String.IsNullOrEmpty(comboBoxType.Text))
                {
                    MessageBox.Show("Nav izvēlēts veids!");
                }
                else
                {
                    komponente = new DatoraKomponente(
                        veids: comboBoxType2.SelectedItem.ToString(),
                        modelis: textBoxModel2.Text,
                        cena: Convert.ToDouble(textBoxPrice2.Text)
                    );
                    MessageBox.Show("Komponenete ir atjaunināta!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Notikusi kļūda!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (komponente != null)
                {
                    comboBoxType2.SelectedItem = komponente.Veids;
                    textBoxModel2.Text = komponente.Modelis;
                    textBoxPrice2.Text = komponente.Cena.ToString();
                }
                else
                {
                    MessageBox.Show("Komponente nav reģistrēta!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Notikusi kļūda!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("komponente.txt");
            writer.WriteLine("-Datora komponente-");
            writer.WriteLine($"Veids: {komponente.Veids}");
            writer.WriteLine($"Modelis: {komponente.Modelis}");
            writer.WriteLine($"Cena: {komponente.Cena.ToString()} EUR");
            writer.Close();

            MessageBox.Show("Dati ierakstīti failā!");
        }

        private void tabPageViewComponent_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxType2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBoxModel.Text))
                {
                    MessageBox.Show("Nav izvēlēts modelis!");
                }
                else if (String.IsNullOrEmpty(textBoxPrice.Text))
                {
                    MessageBox.Show("Nav izvēlēta cena!");
                }
                else if (String.IsNullOrEmpty(comboBoxType.Text))
                {
                    MessageBox.Show("Nav izvēlēts veids!");
                }
                else
                {
                    komponente = new DatoraKomponente(
                        veids: comboBoxType.SelectedItem.ToString(),
                        modelis: textBoxModel.Text,
                        cena: Convert.ToDouble(textBoxPrice.Text)
                    );
                    MessageBox.Show("Komponenete ir reģistrēta!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Notikusi kļūda!");
            }
            
        }
    }

    public class DatoraKomponente
    {
        public string Veids;
        public double Cena;
        public string Modelis;

        public DatoraKomponente(string veids, double cena, string modelis)
        {
            Veids = veids;
            Cena = cena;
            Modelis = modelis;
        }
    }
}
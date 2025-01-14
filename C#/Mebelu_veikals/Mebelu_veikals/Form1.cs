using Microsoft.Data.Sqlite;
using System.ComponentModel;
using System.Windows.Forms;

namespace Mebelu_veikals
{
    public partial class Form1 : Form
    {
        private FurnitureManager furnitureManager;

        public Form1()
        {
            InitializeComponent();

            furnitureManager = new FurnitureManager(connectionString: "Data Source=furniture.db");
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Nav ievadīts nosaukums!");
                }
                else if (String.IsNullOrEmpty(priceTextBox.Text))
                {
                    MessageBox.Show("Nav ievadīta cena!");
                }
                else if (String.IsNullOrEmpty(descTextBox.Text))
                {
                    MessageBox.Show("Nav ievadīts apraksts!");
                }
                else if (String.IsNullOrEmpty(hTextBox.Text))
                {
                    MessageBox.Show("Nav ievadīts augstums!");
                }
                else if (String.IsNullOrEmpty(wTextBox.Text))
                {
                    MessageBox.Show("Nav ievadīts platums!");
                }
                else if (String.IsNullOrEmpty(lTextBox.Text))
                {
                    MessageBox.Show("Nav ievadīts garums!");
                }
                else
                {
                    furnitureManager.AddFurniture(nameTextBox.Text, descTextBox.Text, Convert.ToDouble(priceTextBox.Text),
                        Convert.ToInt32(hTextBox.Text), Convert.ToInt32(wTextBox.Text), Convert.ToInt32(lTextBox.Text));

                    MessageBox.Show("Prece ir pievienota!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Notikusi kļūda!");
            }
        }
    }
}
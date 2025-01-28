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

            var furniture = furnitureManager.ReadFurniture();

            var furnitureNames = new List<string>();

            foreach (var f in furniture)
            {
                furnitureNames.Add(f.Name);
            }

            selectProductComboBox.DataSource = furnitureNames;
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            var furniture = furnitureManager.ReadFurnitureByName(selectProductComboBox.Text);
            nameTextBox.Text = furniture.Name;
            descTextBox.Text = furniture.Description;
            priceTextBox.Text = furniture.Price.ToString();
            hTextBox.Text = furniture.Height.ToString();
            wTextBox.Text = furniture.Width.ToString();
            lTextBox.Text = furniture.Length.ToString();
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

                    List<string> furnitureList = (List<string>)selectProductComboBox.DataSource;
                    furnitureList.Add(nameTextBox.Text);

                    selectProductComboBox.DataSource = null;
                    selectProductComboBox.DataSource = furnitureList;

                    MessageBox.Show("Prece ir pievienota!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Notikusi kļūda!");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            furnitureManager.DeleteFurnitureByName(selectProductComboBox.Text);

            List<string> furnitureList = (List<string>)selectProductComboBox.DataSource;
            furnitureList.Remove(nameTextBox.Text);

            selectProductComboBox.DataSource = null;
            selectProductComboBox.DataSource = furnitureList;

            MessageBox.Show($"Mēbele tika izdzēsta no tabulas!");
        }

        private void buttonExportCSV_Click(object sender, EventArgs e)
        {
            furnitureManager.ExportSQLToCSV();
        }

        private void buttonImportCSV_Click(object sender, EventArgs e)
        {
            furnitureManager.ImportCSVToSQL();

            var furniture = furnitureManager.ReadFurniture();

            var furnitureNames = new List<string>();

            foreach (var f in furniture)
            {
                furnitureNames.Add(f.Name);
            }

            selectProductComboBox.DataSource = furnitureNames;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            furnitureManager.EditFurnitureByName(
                selectProductComboBox.Text,
                descTextBox.Text,
                Convert.ToDouble(priceTextBox.Text),
                Convert.ToInt32(hTextBox.Text),
                Convert.ToInt32(wTextBox.Text),
                Convert.ToInt32(lTextBox.Text)
                );

            var furniture = furnitureManager.ReadFurniture();

            var furnitureNames = new List<string>();

            foreach (var f in furniture)
            {
                furnitureNames.Add(f.Name);
            }

            selectProductComboBox.DataSource = furnitureNames;
        }
    }
}
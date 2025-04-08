using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDeliverySystem
{
    public partial class AdminForm : Form
    {
        PizzaDb _pizzaDb;
        public AdminForm()
        {
            InitializeComponent();
            _pizzaDb = new PizzaDb("Data Source=pizza.db");
            UpdatePizzaComboBox();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var pizza = new Pizza()
                {
                    Description = descTxt.Text,
                    Size = Convert.ToInt32(sizeTxt.Text),
                    Price = Convert.ToDouble(priceTxt.Text)
                };

                _pizzaDb.CreatePizza(pizza);
                MessageBox.Show("Pica tika pievienota!", "Paziņojums", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Notikusi kļūda! " + ex.Message, "Kļūda", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
            UpdatePizzaComboBox();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var selectedName = pizzaList.Text;
            var pizzas = _pizzaDb.ReadPizzas();

            var selectedPizza = pizzas.Find(x => x.Description == selectedName);
            if (selectedPizza != null)
            {
                _pizzaDb.DeletePizza(selectedPizza);
                UpdatePizzaComboBox();
            }
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            var selectedName = pizzaList.Text;
            var pizzas = _pizzaDb.ReadPizzas();

            var selectedPizza = pizzas.Find(x => x.Description == selectedName);
            if (selectedPizza != null)
            {
                descTxt.Text = selectedPizza.Description;
                priceTxt.Text = selectedPizza.Price.ToString();
                sizeTxt.Text = selectedPizza.Size.ToString();
            }
        }

        private void UpdatePizzaComboBox()
        {
            var pizzas = _pizzaDb.ReadPizzas();
            var pizzasDesc = pizzas.Select(x => x.Description).ToList();

            pizzaList.DataSource = pizzasDesc;
        }
    }
}

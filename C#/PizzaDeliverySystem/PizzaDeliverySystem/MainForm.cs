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
    public partial class MainForm : Form
    {
        private PizzaDb _pizzaDb;
        private OrderDb _orderDb;
        private List<Pizza> _pizzaList = new List<Pizza>();
        private int _userId;
        public MainForm(int userId)
        {
            InitializeComponent();
            _pizzaDb = new PizzaDb("Data Source=pizza.db");
            _orderDb = new OrderDb("Data Source=pizza.db");
            UpdatePizzaComboBox();
            UpdatePizzaDataGrid();
            _userId = userId;
        }
        private void UpdatePizzaComboBox()
        {
            var pizzas = _pizzaDb.ReadPizzas();
            var pizzasDesc = pizzas.Select(x => x.Description).ToList();

            pizzaList.DataSource = pizzasDesc;
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            var selectedName = pizzaList.Text;
            var pizzas = _pizzaDb.ReadPizzas();

            var selectedPizza = pizzas.Find(x => x.Description == selectedName);
            if (selectedPizza != null)
            {
                _pizzaList.Add(selectedPizza);
            }

            UpdatePizzaDataGrid();
        }

        private void UpdatePizzaDataGrid()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Size", typeof(int));
            table.Columns.Add("Price", typeof(double));

            foreach (var pizza in _pizzaList)
            {
                table.Rows.Add(new object[]
                {
                    pizza.Description,
                    pizza.Size,
                    pizza.Price,
                });
            }

            cartGrid.DataSource = table;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            var orderId = _orderDb.CreateOrder(_userId);
            _orderDb.AddPizzasToOrder(orderId, _pizzaList);
            var orderPrice = _orderDb.GetOrderTotalPrice(orderId);

            MessageBox.Show("Izveidots pasūtījums ar cenu: " + orderPrice);

            //MessageBox.Show($"Izveidots pasūtījums ar ID: {orderId.ToString()}\nPasūtījuma summa: {GetTotalPrice()}");
        }

        // Easy way with dataGridView:
        /*
        private double GetTotalPrice()
        {
            double sum = 0;
            foreach (DataGridViewRow row in cartGrid.Rows)
            {
                double amount = Convert.ToDouble(row.Cells[cartGrid.Columns["Price"].Index].Value);
                sum += amount;
            }
            return sum;
        }
        */

        // Difficult way with database:

    }
}

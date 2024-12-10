// Install NuGet packages: Microsoft.Data.Sqlite.Core, SQLitePCLRaw.bundle_e_sqlite3

using System;
using Microsoft.Data.Sqlite;
using Microsoft.Data.SqlClient;

class Program
{
    public static void Main()
    {
		// Connection to database string SQLite
		string connectionString = "Data Source=pizza_store.db";
		try 
		{
			var pizzaCtrl = new PizzaCtrl(connectionString);
			
			while (true)
			{
				Console.WriteLine("Choose action: 'add', 'print', or 'exit'.");
				var userCommand = Console.ReadLine();
				
				switch (userCommand)
				{
					case "add":
						pizzaCtrl.AddPizza();
						break;
					case "print":
						pizzaCtrl.PrintPizzas();
						break;
					case "exit":
						return;
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("An error occurred: " + ex.Message);	
		}
	}
	
	public class PizzaCtrl
	{
		private readonly string connectionString;
		
		public PizzaCtrl(string connectionString)
		{
			this.connectionString = connectionString;
			CreatePizzaTable();
		}
		
		public void AddPizza()
		{
			Console.WriteLine("Please, enter pizza name:");
			string pizzaName = Console.ReadLine();
			
			Console.WriteLine("Please, enter pizza size:");
			string pizzaSize = Console.ReadLine();
			
			Console.WriteLine("Please, enter pizza price:");
			double pizzaPrice = Convert.ToDouble(Console.ReadLine());
			
			AddPizzaToTable(pizzaName, pizzaSize, pizzaPrice);
		}
		
		private void CreatePizzaTable()
		{
			using (var connection = new SqliteConnection(connectionString))
			{
				connection.Open();
				
				var createTableCmd = connection.CreateCommand();
				createTableCmd.CommandText = 
					@"CREATE TABLE IF NOT EXISTS Pizzas (
						ID INTEGER PRIMARY KEY AUTOINCREMENT,
						Name TEXT NOT NULL,
						Size TEXT NOT NULL,
						Price REAL NOT NULL
						);";
				createTableCmd.ExecuteNonQuery();
				Console.WriteLine("Table created or exists already.");
			}
		}
		
		private void AddPizzaToTable(string name, string size, double price)
		{
			using (var connection = new SqliteConnection(connectionString))
			{
				connection.Open();
			
				var insertCmd = connection.CreateCommand();
				insertCmd.CommandText = "INSERT INTO Pizzas(Name, Size, Price) VALUES (@name, @size, @price)";
				insertCmd.Parameters.AddWithValue("@name", name);
				insertCmd.Parameters.AddWithValue("@size", size);
				insertCmd.Parameters.AddWithValue("@price", price);

				insertCmd.ExecuteNonQuery();
				Console.WriteLine("Pizza is added to database.");
			}
		}
		
		private SqliteDataReader GetAllPizzasFromTable()
		{
			using (var connection = new SqliteConnection(connectionString))
			{
				connection.Open();
				
				var selectCmd = connection.CreateCommand();
				selectCmd.CommandText = "SELECT * FROM Pizzas";

				return selectCmd.ExecuteReader();
			}
		}
		
		public void PrintPizzas()
		{
			using (var reader = GetAllPizzasFromTable())
			{				
				Console.WriteLine("Pizza List:");
				while(reader.Read())
				{
					Console.WriteLine($"ID: {reader["ID"]}, name: {reader["Name"]}, size: {reader["Size"]}, price: {reader["Price"]}.");
				}
			}
		}
	}
}

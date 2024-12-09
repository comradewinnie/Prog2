// Install NuGet packages: Microsoft.Data.Sqlite.Core, SQLitePCLRaw.bundle_e_sqlite3

using System;
using Microsoft.Data.Sqlite;
public class Program
{
    public static void Main()
    {
		// Connection to database string SQLite
		string connectionString = "Data Source=pizza_store.db";
		try {
			// Create and open SQLite connection
			using (var connection = new SqliteConnection(connectionString))
			{
				connection.Open();
				
				// Create table
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
				
				// Prompt user for pizza details
				Console.WriteLine("Please, enter pizza name:");
				string pizzaName = Console.ReadLine();
				Console.WriteLine("Please, enter pizza size:");
				string pizzaSize = Console.ReadLine();
				Console.WriteLine("Please, enter pizza price:");
				double pizzaPrice = Convert.ToDouble(Console.ReadLine());
				
				// Insert data in database
				var insertCmd = connection.CreateCommand();
				insertCmd.CommandText = "INSERT INTO Pizzas(Name, Size, Price) VALUES (@name, @size, @price)";
				insertCmd.Parameters.AddWithValue("@name", pizzaName);
				insertCmd.Parameters.AddWithValue("@size", pizzaSize);
				insertCmd.Parameters.AddWithValue("@price", pizzaPrice);
				
				insertCmd.ExecuteNonQuery();
				Console.WriteLine("Pizza is added to database.");
				
				// Query to display pizza database elements
				var selectCmd = connection.CreateCommand();
				selectCmd.CommandText = "SELECT * FROM Pizzas";
				
				using (var reader = selectCmd.ExecuteReader())
				{
					Console.WriteLine("Pizza List:");
					while(reader.Read())
					{
						Console.WriteLine($"ID: {reader["ID"]}, name: {reader["Name"]}, size: {reader["Size"]}, price: {reader["Price"]}.");
					}
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("An error occurred: " + ex.Message);	
		}
	}
}

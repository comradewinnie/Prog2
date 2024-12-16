// Install NuGet packages: Microsoft.Data.Sqlite.Core, SQLitePCLRaw.bundle_e_sqlite3

using System;
using Microsoft.Data.Sqlite;

class Program
{
    public static void Main()
    {
		// Connection to database string SQLite
		string connectionString = "Data Source=tesla.db";
	
		try 
		{
			var teslaCtrl = new TeslaCtrl(connectionString);
			
			while (true)
			{
				Console.WriteLine("Choose action: 'start', 'print', or 'exit'.");
				var userCommand = Console.ReadLine();
				
				switch (userCommand)
				{
					case "add":
						teslaCtrl.AddClient();
						break;
					case "print":
						teslaCtrl.PrintTeslas();
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
	
	public class TeslaCtrl
	{
		private readonly string connectionString;
		
		public TeslaCtrl(string connectionString)
		{
			this.connectionString = connectionString;
			CreateTeslaTable();
			CreateClientTable();
		}
		
		private void CreateTeslaTable()
		{
			using (var connection = new SqliteConnection(connectionString))
			{
				connection.Open();
				
				var createTableCmd = connection.CreateCommand();
				createTableCmd.CommandText = 
					@"CREATE TABLE IF NOT EXISTS Teslas (
						ID INTEGER PRIMARY KEY AUTOINCREMENT,
						Model TEXT NOT NULL,
						Hourly rate REAL NOT NULL,
						Kilometer rate REAL NOT NULL
						);";
				createTableCmd.ExecuteNonQuery();
				Console.WriteLine("Tesla table created or exists already.");
			}
		}
		
		private void CreateClientTable()
		{
			using (var connection = new SqliteConnection(connectionString))
			{
				connection.Open();
				
				var createTableCmd = connection.CreateCommand();
				createTableCmd.CommandText = 
					@"CREATE TABLE IF NOT EXISTS Clients (
						ID INTEGER PRIMARY KEY AUTOINCREMENT,
						Name TEXT NOT NULL,
						Surname TEXT NOT NULL,
						Email TEXT NOT NULL
						);";
				createTableCmd.ExecuteNonQuery();
				Console.WriteLine("Client table created or exists already.");
			}
		}
		
		public void AddClient()
		{
			Console.WriteLine("Please, enter your name:");
			string clientName = Console.ReadLine();
			
			Console.WriteLine("Please, enter your surname:");
			string clientSurname = Console.ReadLine();
			
			Console.WriteLine("Please, enter your e-mail:");
			string clientMail = Console.ReadLine();
			
			AddClientToTable(clientName, clientSurname, clientMail);
		}
		
		private void AddClientToTable(string name, string surname, string mail)
		{
			using (var connection = new SqliteConnection(connectionString))
			{
				connection.Open();
			
				var insertCmd = connection.CreateCommand();
				insertCmd.CommandText = "INSERT INTO Clients(Name, Surname, Email) VALUES (@name, @surname, @mail)";
				insertCmd.Parameters.AddWithValue("@name", name);
				insertCmd.Parameters.AddWithValue("@surname", surname);
				insertCmd.Parameters.AddWithValue("@mail", mail);

				insertCmd.ExecuteNonQuery();
				Console.WriteLine("Client is added to database.");
			}
		}
				
		public void PrintTeslas()
		{
			using (var connection = new SqliteConnection(connectionString))
			{
				connection.Open();
				
				var selectCmd = connection.CreateCommand();
				selectCmd.CommandText = "SELECT * FROM Teslas";

				using (var reader = selectCmd.ExecuteReader())
				{				
					Console.WriteLine("Tesla List:");
					while(reader.Read())
					{
						Console.WriteLine($"ID: {reader["ID"]}, model: {reader["Model"]}, price per hour: {reader["Hourly rate"]}, prcie per kilometer: {reader["Kilometer rate"]}.");
					}
				}
			}
		}
	}
}

using System;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace Mebelu_veikals
{
    public class FurnitureManager
    {
        private readonly string connectionString;

        public FurnitureManager(string connectionString)
        {
            this.connectionString = connectionString;

            CreateFurnitureTable();
        }

        public List<Furniture> ReadFurniture()
        {
            var furnitureList = new List<Furniture>();

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM Furniture";

                using (var reader = selectCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var newFurniture = new Furniture(
                                reader["Name"].ToString(),
                                reader["Description"].ToString(),
                                Convert.ToDouble(reader["Price"]),
                                Convert.ToInt32(reader["Height"]),
                                Convert.ToInt32(reader["Width"]),
                                Convert.ToInt32(reader["Length"])
                            );
                        furnitureList.Add(newFurniture);
                    }
                }
            }

            return furnitureList;
        }
        public void AddFurniture(string name, string description, double price, int height, int width, int length)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var createRecordCommand = connection.CreateCommand();
                createRecordCommand.CommandText = @"INSERT INTO Furniture(Name, Description, Price, Height, Width, Length) 
                VALUES (@name, @description, @price, @height, @width, @length)";

                createRecordCommand.Parameters.AddWithValue("name", name);
                createRecordCommand.Parameters.AddWithValue("description", description);
                createRecordCommand.Parameters.AddWithValue("price", price);
                createRecordCommand.Parameters.AddWithValue("height", height);
                createRecordCommand.Parameters.AddWithValue("width", width);
                createRecordCommand.Parameters.AddWithValue("length", length);

                createRecordCommand.ExecuteNonQuery();
            }
        }

        public Furniture ReadFurnitureByName(string name)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = @"SELECT * FROM Furniture WHERE Name = @name";
                selectCmd.Parameters.AddWithValue("name", name);

                using (var reader = selectCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return new Furniture(
                                reader["Name"].ToString(),
                                reader["Description"].ToString(),
                                Convert.ToDouble(reader["Price"]),
                                Convert.ToInt32(reader["Height"]),
                                Convert.ToInt32(reader["Width"]),
                                Convert.ToInt32(reader["Length"])
                            );
                    }
                }
            }

            throw new Exception("Furniture with such name not found");
        }

        private void CreateFurnitureTable()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var createTableCommand = connection.CreateCommand();
                createTableCommand.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Furniture (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL UNIQUE,
                        Description TEXT NOT NULL,
                        Price REAL NOT NULL,
                        Height INTEGER NOT NULL,
                        Width INTEGER NOT NULL,
                        Length INTEGER NOT NULL
                    )
                ";
                createTableCommand.ExecuteNonQuery();
            }
        }

        public void DeleteFurnitureByName(string name)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var deleteCmd = connection.CreateCommand();
                deleteCmd.CommandText = @"DELETE FROM Furniture WHERE Name = @name";
                deleteCmd.Parameters.AddWithValue("name", name);
                deleteCmd.ExecuteNonQuery();
            }
        }

        public void ExportSQLToCSV(string pathToCsv)
        {
            var furniture = ReadFurniture();


            using (var w = new StreamWriter(pathToCsv))
            {
                w.WriteLine("Name;Description;Price;Height;Width;Length");

                foreach (var f in furniture)
                {
                    w.WriteLine($"{f.Name};{f.Description};{f.Price};{f.Height};{f.Width};{f.Length}");
                }

                w.Flush();
            }
        }

        public void ImportCSVToSQL(string pathToCsv)
        {
            var furnitures = ReadFurniture();
            var furnitureNames = furnitures.Select(x => x.Name).ToList();
            
            string? line;
            using (var r = new StreamReader(pathToCsv))
            {
                r.ReadLine();

                while ((line = r.ReadLine()) != null)
                {
                    string[] values = line.Split(';');

                    var name = values[0];
                    var description = values[1];
                    var price = Convert.ToDouble(values[2]);
                    var height = Convert.ToInt32(values[3]);
                    var width = Convert.ToInt32(values[4]);
                    var length = Convert.ToInt32(values[5]);

                    if (furnitureNames.Contains(name))
                    {
                        EditFurnitureByName(name, description, price, height, width, length);
                    }
                    else 
                    {
                        AddFurniture(name, description, price, height, width, length);
                    }
                }
            }
        }

        public void EditFurnitureByName(string name, string description, double price, int height, int width, int length)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var editCmd = connection.CreateCommand();
                editCmd.CommandText = @"UPDATE Furniture SET Description = @description, Price = @price, Height = @height, Width = @width, Length = @length WHERE Name = @name";
                editCmd.Parameters.AddWithValue("name", name);
                editCmd.Parameters.AddWithValue("description", description);
                editCmd.Parameters.AddWithValue("price", price);
                editCmd.Parameters.AddWithValue("height", height);
                editCmd.Parameters.AddWithValue("width", width);
                editCmd.Parameters.AddWithValue("length", length);
                editCmd.ExecuteNonQuery();
            }
        }

    }
}

using System;
using Microsoft.Data.Sqlite;

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

        public void ExportSQLToCSV()
        {

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM Furniture";
                using (var reader = selectCmd.ExecuteReader())
                {
                    using (StreamWriter writer = new StreamWriter("furniture.csv"))
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            writer.Write(reader.GetName(i));
                            if (i < reader.FieldCount - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();

                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                writer.Write(reader[i].ToString());
                                if (i < reader.FieldCount - 1)
                                    writer.Write(",");
                            }
                            writer.WriteLine();
                        }
                    }
                }
                MessageBox.Show("Tabula ir eksportēta uz CSV!");
            }
        }

        public void ImportCSVToSQL()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    using (StreamReader reader = new StreamReader("furniture.csv"))
                    {
                        string headerLine = reader.ReadLine();
                        if (headerLine == null)
                        {
                            MessageBox.Show("Fails 'furniture.csv' ir tukšs!");
                            return;
                        }

                        string[] columns = headerLine.Split(',');

                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] values = line.Split(',');

                            // Assume the first column is the 'name' field we want to check for
                            string name = values[0];

                            // Construct the SQL command dynamically
                            var cmd = connection.CreateCommand();

                            // Check if the record with the specific name already exists
                            cmd.CommandText = "SELECT COUNT(*) FROM Furniture WHERE Name = @name";
                            cmd.Parameters.AddWithValue("@name", name);
                            long count = (long)cmd.ExecuteScalar();

                            if (count > 0)
                            {
                                // If the record exists, restore (or update) it
                                cmd.CommandText = "UPDATE Furniture SET Description = @description, Price = @price, Height = @height, Width = @width, Length = @length WHERE Name = @name";
                                cmd.Parameters.AddWithValue("@description", values[1]); // Category
                                cmd.Parameters.AddWithValue("@price", values[2]);    // Price
                                cmd.Parameters.AddWithValue("@height", values[3]);
                                cmd.Parameters.AddWithValue("@width", values[4]);
                                cmd.Parameters.AddWithValue("@length", values[5]);// Quantity
                            }
                            else
                            {
                                // If the record doesn't exist, insert a new one
                                var placeholders = string.Join(", ", new string[columns.Length].Select((_, i) => $"@param{i}"));
                                cmd.CommandText = $"INSERT INTO Furniture ({string.Join(", ", columns)}) VALUES ({placeholders})";
                                for (int i = 0; i < columns.Length; i++)
                                {
                                    cmd.Parameters.AddWithValue($"@param{i}", values[i]);
                                }
                            }
                        }

                        transaction.Commit();
                    }
                }
            }

            MessageBox.Show("CSV fails ir importēts!");
        }
        
    }
}

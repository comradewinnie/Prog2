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

                        string[] columns = headerLine.Split(',');

                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] values = line.Split(',');

                            string name = values[1];

                            using (var checkCmd = connection.CreateCommand())
                            {
                                checkCmd.CommandText = "SELECT COUNT(*) FROM Furniture WHERE Name = @name";
                                checkCmd.Parameters.AddWithValue("@name", name);
                                long count = (long)checkCmd.ExecuteScalar();

                                if (count > 0)
                                {
                                    using (var updateCmd = connection.CreateCommand())
                                    {
                                        updateCmd.CommandText = "UPDATE Furniture SET Description = @description, Price = @price, Height = @height, Width = @width, Length = @length WHERE Name = @name";
                                        updateCmd.Parameters.AddWithValue("@name", name);
                                        updateCmd.Parameters.AddWithValue("@description", values[2]);
                                        updateCmd.Parameters.AddWithValue("@price", values[3]);
                                        updateCmd.Parameters.AddWithValue("@height", values[4]);
                                        updateCmd.Parameters.AddWithValue("@width", values[5]);
                                        updateCmd.Parameters.AddWithValue("@length", values[6]);
                                        updateCmd.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    using (var insertCmd = connection.CreateCommand())
                                    {
                                        var placeholders = string.Join(", ", columns.Select((_, i) => $"@param{i}"));
                                        insertCmd.CommandText = $"INSERT INTO Furniture ({string.Join(", ", columns)}) VALUES ({placeholders})";

                                        for (int i = 0; i < columns.Length; i++)
                                        {
                                            insertCmd.Parameters.AddWithValue($"@param{i}", values[i]);
                                        }

                                        insertCmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                        transaction.Commit();
                    }
                }
            }

            MessageBox.Show("CSV fails ir importēts!");
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
            MessageBox.Show("Mēbele ir rediģēta!");
        }

    }
}

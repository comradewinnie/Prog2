﻿using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliverySystem
{
     class OrderDb
    {
        private readonly string connectionString;

        public OrderDb(string connectionString)
        {
            this.connectionString = connectionString;
            CreateOrderTable();
        }

        private void CreateOrderTable()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var createTableCommand = connection.CreateCommand();
                createTableCommand.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Orders (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        IsPaid BOOLEAN REQUIRED,
                        CreatedAt TEXT REQUIRED,
                        OrderUser INTEGER REQUIRED,
                        FOREIGN KEY (OrderUser) REFERENCES Users(Id)
                    )
                ";

                createTableCommand.ExecuteNonQuery();
            }
        }

        public void CreateOrder(int userId)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var createUserCommand = connection.CreateCommand();
                createUserCommand.CommandText = @"
                    INSERT INTO Order(IsPaid, CreatedAt, OrderUser)
                    VALUES (@ispaid, @createdat, @orderuser)"
                ;

                createUserCommand.Parameters.AddWithValue("ispaid", false);
                createUserCommand.Parameters.AddWithValue("createdat", DateTime.UtcNow.ToLongTimeString());
                createUserCommand.Parameters.AddWithValue("orderuser", userId);

                createUserCommand.ExecuteNonQuery();
            }
        }
    }
}

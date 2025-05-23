﻿using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliverySystem
{
    internal class UserDb
    {
        private readonly string connectionString;

        public UserDb(string connectionString)
        {
            this.connectionString = connectionString;
            CreateUserTable();
        }
        public void CreateUserTable()
        {
            using (var connection = new SqliteConnection(connectionString))
            { 
                connection.Open();

                var createTableCommand = connection.CreateCommand();
                createTableCommand.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL UNIQUE,
                        Password TEXT NOT NULL,
                        IsAdmin BOOLEAN)
                ";

                createTableCommand.ExecuteNonQuery();
            }
        }

        public void CreateUser(string username, string password, bool isAdmin)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var createUserCommand = connection.CreateCommand();
                createUserCommand.CommandText = @"
                    INSERT INTO Users(Username, Password, IsAdmin)
                    VALUES (@username, @password, @isAdmin)";

                createUserCommand.Parameters.AddWithValue("username", username);
                createUserCommand.Parameters.AddWithValue("password", password);
                createUserCommand.Parameters.AddWithValue("isAdmin", isAdmin);
                createUserCommand.ExecuteNonQuery();
            }
        }

        public (int, string, string, bool) GetUser(string username)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var selectUserCommand = connection.CreateCommand();
                selectUserCommand.CommandText = @"
                    SELECT Id, Username, Password, IsAdmin FROM Users
                    WHERE Username = @username
                ";
                selectUserCommand.Parameters.AddWithValue("username", username);

                using (var reader = selectUserCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return (Convert.ToInt32(reader["Id"]), reader["Username"].ToString(), reader["Password"].ToString(), Convert.ToBoolean(reader["IsAdmin"]));
                    }
                }

                throw new Exception("User not found");
            }
        }
    }
}

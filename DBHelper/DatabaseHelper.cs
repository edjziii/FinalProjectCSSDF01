using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace EmployeeManagementSystem
{
    public class DatabaseHelper
    {
        private readonly string _connectionString;

        public DatabaseHelper()
        {
            // Replace with your XAMPP MySQL credentials
            _connectionString = "Server=localhost;Database=EmployeeDB;Uid=root;Pwd=;";
        }

        // Execute SELECT queries
        public DataTable ExecuteQuery(string query)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                var command = new MySqlCommand(query, connection);
                var adapter = new MySqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        // Execute INSERT, UPDATE, DELETE queries
        public void ExecuteNonQuery(string query)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                var command = new MySqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public DataTable ExecuteQueryWithParameters(string query, Dictionary<string, object> parameters)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                var command = new MySqlCommand(query, connection);

                foreach (var param in parameters)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value);
                }

                var adapter = new MySqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

    }
}

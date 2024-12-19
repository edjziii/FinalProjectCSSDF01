using System;
using System.Collections.Generic;
using System.Data;

namespace EmployeeManagementSystem
{
    public class EmployeeController
    {
        private readonly DatabaseHelper _dbHelper;

        public EmployeeController()
        {
            _dbHelper = new DatabaseHelper();
        }

        // Fetch employees from the database
        public List<EmployeeModel> GetEmployees()
        {
            var employees = new List<EmployeeModel>();
            var query = "SELECT Id, Name, Email, Position FROM Employees";
            var table = _dbHelper.ExecuteQuery(query);

            foreach (DataRow row in table.Rows)
            {
                employees.Add(new EmployeeModel
                {
                    Id = (int)row["Id"],
                    Name = row["Name"].ToString(),
                    Email = row["Email"].ToString(),
                    Position = row["Position"].ToString()
                });
            }

            return employees;
        }

        // Add a new employee to the database

        public void UpdateEmployee(EmployeeModel employee)
        {
            var query = "UPDATE Employees SET Name = @Name WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
    {
        { "@Name", employee.Name },
        { "@Id", employee.Id }
    };
            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        public List<EmployeeModel> SearchEmployeesByName(string name)
        {
            var employees = new List<EmployeeModel>();
            var query = "SELECT Id, Name, Email, Position FROM Employees WHERE Name LIKE @Name";
            var parameters = new Dictionary<string, object> { { "@Name", $"%{name}%" } };
            var table = _dbHelper.ExecuteQueryWithParameters(query, parameters);

            foreach (DataRow row in table.Rows)
            {
                employees.Add(new EmployeeModel
                {
                    Id = (int)row["Id"],
                    Name = row["Name"].ToString(),
                    Email = row["Email"].ToString(),
                    Position = row["Position"].ToString()
                });
            }

            return employees;
        }
        public List<EmployeeModel> SearchEmployees(string searchValue, string searchBy)
        {
            var employees = new List<EmployeeModel>();
            var query = string.Empty;
            var parameters = new Dictionary<string, object>();

            // Determine the query based on the searchBy parameter
            switch (searchBy.ToLower())
            {
                case "id":
                    if (!int.TryParse(searchValue, out var id))
                        throw new ArgumentException("Invalid ID. Please provide a numeric value.");

                    query = "SELECT Id, Name, Email, Position FROM Employees WHERE Id = @SearchValue";
                    parameters.Add("@SearchValue", id);
                    break;

                case "name":
                    query = "SELECT Id, Name, Email, Position FROM Employees WHERE Name LIKE @SearchValue";
                    parameters.Add("@SearchValue", $"%{searchValue}%");
                    break;

                case "email":
                    query = "SELECT Id, Name, Email, Position FROM Employees WHERE Email LIKE @SearchValue";
                    parameters.Add("@SearchValue", $"%{searchValue}%");
                    break;

                case "position":
                    query = "SELECT Id, Name, Email, Position FROM Employees WHERE Position LIKE @SearchValue";
                    parameters.Add("@SearchValue", $"%{searchValue}%");
                    break;

                default:
                    throw new ArgumentException("Invalid search field. Use 'id', 'name', 'email', or 'position'.");
            }

            // Execute query
            var table = _dbHelper.ExecuteQueryWithParameters(query, parameters);

            // Populate the employee list from the result
            foreach (DataRow row in table.Rows)
            {
                employees.Add(new EmployeeModel
                {
                    Id = (int)row["Id"],
                    Name = row["Name"].ToString(),
                    Email = row["Email"].ToString(),
                    Position = row["Position"].ToString()
                });
            }

            return employees;
        }
        public EmployeeModel GetEmployeeById(int id)
        {
            var query = "SELECT Id, Name, Email, Position FROM Employees WHERE Id = @Id";
            var parameters = new Dictionary<string, object> { { "@Id", id } };
            var table = _dbHelper.ExecuteQueryWithParameters(query, parameters);

            if (table.Rows.Count == 0)
                return null;

            var row = table.Rows[0];
            return new EmployeeModel
            {
                Id = (int)row["Id"],
                Name = row["Name"].ToString(),
                Email = row["Email"].ToString(),
                Position = row["Position"].ToString()
            };
        }

        public bool DeleteEmployee(int id)
        {
            var query = "DELETE FROM Employees WHERE Id = @Id";
            var parameters = new Dictionary<string, object> { { "@Id", id } };

            return _dbHelper.ExecuteNonQueryWithParameters(query, parameters) > 0;
        }

        public bool AddEmployee(EmployeeModel employee)
        {
            var query = "INSERT INTO Employees (Id, Name, Email, Position) VALUES (@Id, @Name, @Email, @Position)";
            var parameters = new Dictionary<string, object>
    {
        { "@Id", employee.Id },
        { "@Name", employee.Name },
        { "@Email", employee.Email },
        { "@Position", employee.Position }
    };

            return _dbHelper.ExecuteNonQueryWithParameters(query, parameters) > 0;
        }

    }
}

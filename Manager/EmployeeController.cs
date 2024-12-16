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
            var query = "SELECT Id, Name FROM Employees";
            var table = _dbHelper.ExecuteQuery(query);

            foreach (DataRow row in table.Rows)
            {
                employees.Add(new EmployeeModel
                {
                    Id = (int)row["Id"],
                    Name = row["Name"].ToString()
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
            var query = "SELECT Id, Name FROM Employees WHERE Name LIKE @Name";
            var parameters = new Dictionary<string, object> { { "@Name", $"%{name}%" } };
            var table = _dbHelper.ExecuteQueryWithParameters(query, parameters);

            foreach (DataRow row in table.Rows)
            {
                employees.Add(new EmployeeModel
                {
                    Id = (int)row["Id"],
                    Name = row["Name"].ToString()
                });
            }

            return employees;
        }

    }
}

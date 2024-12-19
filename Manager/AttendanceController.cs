using System.Collections.Generic;
using System.Data;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem
{
    public class AttendanceController
    {
        private readonly DatabaseHelper _dbHelper;

        public AttendanceController()
        {
            _dbHelper = new DatabaseHelper();
        }
        public DataTable GetAttendanceByDate(string selectedDate)
        {
            string query = "SELECT EID  AS EmployeeID, EName AS EmployeeName, EDate AS DateTime, status AS Status FROM Attendance WHERE Date = @date";
            var parameters = new Dictionary<string, object>
            {
                { "@date", selectedDate }
            };
            return _dbHelper.ExecuteSelectQuery(query, parameters);
        }
    }
}

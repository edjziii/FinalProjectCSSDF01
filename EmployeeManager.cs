using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EmployeeManagementSystem
{    
    public partial class EmployeeInterface : Form
    {
        private Button activeButton; // Keep track of the active button
        private Color defaultButtonColor; // Store the original button color
        private Color defaultButtonForeColor; // Store the original button text color
        private EmployeeController _controller;

        public EmployeeInterface()
        {
            InitializeComponent();

            // Store the original button color and text color
            defaultButtonColor = btn_employee.BackColor;
            defaultButtonForeColor = btn_employee.ForeColor;
            _controller = new EmployeeController();
            LoadEmployeeData();
        }
        private void HighlightButton(Button button)
        {
            if (activeButton != null)
            {
                // Reset the style of the previously active button to original
                activeButton.BackColor = defaultButtonColor;
                activeButton.ForeColor = defaultButtonForeColor;
                activeButton.FlatAppearance.BorderSize = 0; // Remove border on inactive button
            }

            // Apply highlight style to the new active button
            activeButton = button;
            activeButton.BackColor = Color.LightBlue; // Highlight color
            activeButton.ForeColor = Color.DarkBlue; // Text color
            activeButton.FlatAppearance.BorderSize = 2; // Optional border size for the active button
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            panel_home.Visible = true;
            panel_employee.Visible = false;
            panel_attendance.Visible = false;
            panel_accounting.Visible = false;
            panel_recruitment.Visible = false;
        }

        private void btn_recent_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            panel_home.Visible = false;
            panel_employee.Visible = true;
            panel_attendance.Visible = false;
            panel_accounting.Visible = false;
            panel_recruitment.Visible = false;
        }

        private void btn_attendance_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            panel_home.Visible = false;
            panel_employee.Visible = false;
            panel_attendance.Visible = true;
            panel_accounting.Visible = false;
            panel_recruitment.Visible = false;
        }

        private void btn_termination_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            panel_home.Visible = false;
            panel_employee.Visible = false;
            panel_attendance.Visible = false;
            panel_accounting.Visible = true;
            panel_recruitment.Visible = false;
        }

        private void btn_recruitment_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            panel_home.Visible = false;
            panel_employee.Visible = false;
            panel_attendance.Visible = false;
            panel_accounting.Visible = false;
            panel_recruitment.Visible = true;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadEmployeeData()
        {
            var employees = _controller.GetEmployees();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = employees;
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected employee's ID
                var selectedRow = dataGridView1.SelectedRows[0];
                int employeeId = (int)selectedRow.Cells["Id"].Value;

                // Get the updated name from the TextBox
                string updatedName = txtEmployeeName.Text;

                if (!string.IsNullOrWhiteSpace(updatedName))
                {
                    // Create an EmployeeModel object with updated data
                    var updatedEmployee = new EmployeeModel
                    {
                        Id = employeeId,
                        Name = updatedName
                    };

                    // Call the controller to update the database
                    _controller.UpdateEmployee(updatedEmployee);
                    MessageBox.Show("Employee updated successfully!");

                    // Refresh the data grid
                    LoadEmployeeData();
                }
                else
                {
                    MessageBox.Show("Employee name cannot be empty.");
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to update.");
            }
            LoadEmployeeData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchName = txtSearchName.Text; // Assume a TextBox named txtSearchName for search input
            if (!string.IsNullOrWhiteSpace(searchName))
            {
                var filteredEmployees = _controller.SearchEmployeesByName(searchName);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = filteredEmployees;
            }
            else
            {
                MessageBox.Show("Please enter a name to search.");
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearchName.Clear();
            txtEmployeeName.Clear();
            LoadEmployeeData(); // Reload all employees
        }
    }
}

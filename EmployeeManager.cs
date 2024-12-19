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
            panel_update.Visible = false;
            panel_view.Visible = false;
            panel_terminate.Visible = false;
            panel_new.Visible = false;
        }

        private void btn_recent_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            panel_home.Visible = false;
            panel_update.Visible = true;
            panel_view.Visible = false;
            panel_terminate.Visible = false;
            panel_new.Visible = false;
        }

        private void btn_attendance_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            panel_home.Visible = false;
            panel_update.Visible = false;
            panel_view.Visible = true;
            panel_terminate.Visible = false;
            panel_new.Visible = false;
        }

        private void btn_termination_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            panel_home.Visible = false;
            panel_update.Visible = false;
            panel_view.Visible = false;
            panel_terminate.Visible = true;
            panel_new.Visible = false;
        }

        private void btn_recruitment_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            panel_home.Visible = false;
            panel_update.Visible = false;
            panel_view.Visible = false;
            panel_terminate.Visible = false;
            panel_new.Visible = true;
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
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = employees;
            dataGridViewEmployees.DataSource = null;
            dataGridViewEmployees.DataSource = employees;
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = employees;
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

        private void button1_Click(object sender, EventArgs e)
        {
            var searchValue = textBox1.Text; // Assume a TextBox named txtSearchValue for search input
            var searchBy = comboBox1.SelectedItem?.ToString(); // Assume a ComboBox named cmbSearchBy for selecting search criteria

            if (string.IsNullOrWhiteSpace(searchValue))
            {
                MessageBox.Show("Please enter a value to search.");
                return;
            }

            if (string.IsNullOrWhiteSpace(searchBy))
            {
                MessageBox.Show("Please select a search criterion.");
                return;
            }

            try
            {
                // Call the controller's search method with the selected searchBy and searchValue
                var filteredEmployees = _controller.SearchEmployees(searchValue, searchBy.ToLower());
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = filteredEmployees;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message); // Show error message for invalid search field
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchId.Text, out int id))
            {
                var employee = _controller.GetEmployeeById(id); // Fetch employee by ID

                if (employee != null)
                {
                    dataGridViewEmployees.DataSource = null;
                    dataGridViewEmployees.DataSource = new List<EmployeeModel> { employee }; // Show the result in DataGridView
                }
                else
                {
                    MessageBox.Show("No employee found with the specified ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewEmployees.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void ClearDataGridView()
        {
            dataGridViewEmployees.DataSource = null;
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Delete button clicked!"); // Log message
            MessageBox.Show("Delete button clicked!");

            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewEmployees.SelectedRows[0];
                var id = (int)selectedRow.Cells["Id"].Value;

                var confirmation = MessageBox.Show(
                    $"Are you sure you want to delete the employee with ID {id}?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmation == DialogResult.Yes)
                {
                    var success = _controller.DeleteEmployee(id); // Deletes from the database

                    if (success)
                    {
                        MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Remove from data source
                        var bindingSource = dataGridViewEmployees.DataSource as BindingSource;
                        if (bindingSource != null)
                        {
                            var dataTable = bindingSource.DataSource as DataTable;
                            if (dataTable != null)
                            {
                                var row = dataTable.AsEnumerable().FirstOrDefault(r => r.Field<int>("Id") == id);
                                if (row != null)
                                {
                                    row.Delete(); // Deletes the row from the DataTable
                                    dataTable.AcceptChanges(); // Reflect changes in DataGridView
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadEmployeeData();
        }

        private void ClearInputFields()
        {
            txtBox_Id.Clear();
            txtBox_Name.Clear();
            txtBox_Email.Clear();
            txtBox_Position.Clear();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                // Get input values from TextBoxes
                int id = int.Parse(txtBox_Id.Text);
                string name = txtBox_Name.Text;
                string email = txtBox_Email.Text;
                string position = txtBox_Position.Text;

                // Validate inputs
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(position))
                {
                    MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Add the employee to the database
                var success = _controller.AddEmployee(new EmployeeModel
                {
                    Id = id,
                    Name = name,
                    Email = email,
                    Position = position
                });

                if (success)
                {
                    MessageBox.Show("Employee added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to add the employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadEmployeeData();
        }
    }
}

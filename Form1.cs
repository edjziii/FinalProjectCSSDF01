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
    public partial class Form1 : Form
    {
        private Button activeButton; // Keep track of the active button
        private Color defaultButtonColor; // Store the original button color
        private Color defaultButtonForeColor; // Store the original button text color

        public Form1()
        {
            InitializeComponent();

            // Store the original button color and text color
            defaultButtonColor = btn_recent.BackColor;
            defaultButtonForeColor = btn_recent.ForeColor;
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

        }

        private void btn_recent_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            panel_recent.Visible = true;
            panel_attendance.Visible = false;
            panel_accounting.Visible = false;
        }

        private void btn_attendance_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            panel_recent.Visible = false;
            panel_attendance.Visible = true;
            panel_accounting.Visible = false;
        }

        private void btn_accounting_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            panel_recent.Visible = false;
            panel_attendance.Visible = false;
            panel_accounting.Visible = true;
        }

        private void btn_recruitment_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

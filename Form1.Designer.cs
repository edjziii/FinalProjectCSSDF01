namespace EmployeeManagementSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_recent = new System.Windows.Forms.Panel();
            this.panel_navigation = new System.Windows.Forms.Panel();
            this.btn_recruitment = new System.Windows.Forms.Button();
            this.btn_recent = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_accounting = new System.Windows.Forms.Button();
            this.btn_attendance = new System.Windows.Forms.Button();
            this.panel_attendance = new System.Windows.Forms.Panel();
            this.panel_accounting = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel_recruitment = new System.Windows.Forms.Panel();
            this.panel_home = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel_navigation.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_recent
            // 
            this.panel_recent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(178)))), ((int)(((byte)(211)))));
            this.panel_recent.Location = new System.Drawing.Point(387, 12);
            this.panel_recent.Name = "panel_recent";
            this.panel_recent.Size = new System.Drawing.Size(722, 596);
            this.panel_recent.TabIndex = 4;
            // 
            // panel_navigation
            // 
            this.panel_navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(229)))), ((int)(((byte)(232)))));
            this.panel_navigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_navigation.Controls.Add(this.btn_recruitment);
            this.panel_navigation.Controls.Add(this.btn_recent);
            this.panel_navigation.Controls.Add(this.btn_exit);
            this.panel_navigation.Controls.Add(this.btn_accounting);
            this.panel_navigation.Controls.Add(this.btn_attendance);
            this.panel_navigation.Location = new System.Drawing.Point(14, 199);
            this.panel_navigation.Name = "panel_navigation";
            this.panel_navigation.Size = new System.Drawing.Size(341, 384);
            this.panel_navigation.TabIndex = 4;
            // 
            // btn_recruitment
            // 
            this.btn_recruitment.BackColor = System.Drawing.Color.Transparent;
            this.btn_recruitment.FlatAppearance.BorderSize = 0;
            this.btn_recruitment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recruitment.Location = new System.Drawing.Point(0, 225);
            this.btn_recruitment.Name = "btn_recruitment";
            this.btn_recruitment.Size = new System.Drawing.Size(341, 76);
            this.btn_recruitment.TabIndex = 4;
            this.btn_recruitment.Text = "                  Recruitment";
            this.btn_recruitment.UseVisualStyleBackColor = false;
            this.btn_recruitment.Click += new System.EventHandler(this.btn_recruitment_Click);
            // 
            // btn_recent
            // 
            this.btn_recent.BackColor = System.Drawing.Color.Transparent;
            this.btn_recent.FlatAppearance.BorderSize = 0;
            this.btn_recent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recent.Location = new System.Drawing.Point(0, 0);
            this.btn_recent.Name = "btn_recent";
            this.btn_recent.Size = new System.Drawing.Size(341, 76);
            this.btn_recent.TabIndex = 1;
            this.btn_recent.Text = "          Recent";
            this.btn_recent.UseVisualStyleBackColor = false;
            this.btn_recent.Click += new System.EventHandler(this.btn_recent_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(0, 300);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(341, 76);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "  Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_accounting
            // 
            this.btn_accounting.BackColor = System.Drawing.Color.Transparent;
            this.btn_accounting.FlatAppearance.BorderSize = 0;
            this.btn_accounting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_accounting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_accounting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accounting.Location = new System.Drawing.Point(0, 150);
            this.btn_accounting.Name = "btn_accounting";
            this.btn_accounting.Size = new System.Drawing.Size(341, 76);
            this.btn_accounting.TabIndex = 3;
            this.btn_accounting.Text = "                 Accounting";
            this.btn_accounting.UseVisualStyleBackColor = false;
            this.btn_accounting.Click += new System.EventHandler(this.btn_accounting_Click);
            // 
            // btn_attendance
            // 
            this.btn_attendance.BackColor = System.Drawing.Color.Transparent;
            this.btn_attendance.FlatAppearance.BorderSize = 0;
            this.btn_attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_attendance.Location = new System.Drawing.Point(0, 75);
            this.btn_attendance.Name = "btn_attendance";
            this.btn_attendance.Size = new System.Drawing.Size(341, 76);
            this.btn_attendance.TabIndex = 2;
            this.btn_attendance.Text = "                 Attendance";
            this.btn_attendance.UseVisualStyleBackColor = false;
            this.btn_attendance.Click += new System.EventHandler(this.btn_attendance_Click);
            // 
            // panel_attendance
            // 
            this.panel_attendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(178)))), ((int)(((byte)(211)))));
            this.panel_attendance.Location = new System.Drawing.Point(387, 12);
            this.panel_attendance.Name = "panel_attendance";
            this.panel_attendance.Size = new System.Drawing.Size(722, 596);
            this.panel_attendance.TabIndex = 5;
            // 
            // panel_accounting
            // 
            this.panel_accounting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(178)))), ((int)(((byte)(211)))));
            this.panel_accounting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_accounting.Location = new System.Drawing.Point(387, 12);
            this.panel_accounting.Name = "panel_accounting";
            this.panel_accounting.Size = new System.Drawing.Size(722, 596);
            this.panel_accounting.TabIndex = 5;
            // 
            // btn_home
            // 
            this.btn_home.AutoSize = true;
            this.btn_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_home.BackgroundImage")));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Location = new System.Drawing.Point(14, 14);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(341, 179);
            this.btn_home.TabIndex = 1;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.panel4);
            this.MainPanel.Controls.Add(this.panel_home);
            this.MainPanel.Controls.Add(this.panel_recent);
            this.MainPanel.Controls.Add(this.panel_attendance);
            this.MainPanel.Controls.Add(this.panel_accounting);
            this.MainPanel.Controls.Add(this.panel_recruitment);
            this.MainPanel.Location = new System.Drawing.Point(1, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1122, 621);
            this.MainPanel.TabIndex = 13;
            // 
            // panel_recruitment
            // 
            this.panel_recruitment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(178)))), ((int)(((byte)(211)))));
            this.panel_recruitment.Location = new System.Drawing.Point(387, 12);
            this.panel_recruitment.Name = "panel_recruitment";
            this.panel_recruitment.Size = new System.Drawing.Size(722, 596);
            this.panel_recruitment.TabIndex = 1;
            // 
            // panel_home
            // 
            this.panel_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(178)))), ((int)(((byte)(211)))));
            this.panel_home.Location = new System.Drawing.Point(387, 12);
            this.panel_home.Name = "panel_home";
            this.panel_home.Size = new System.Drawing.Size(722, 596);
            this.panel_home.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(178)))), ((int)(((byte)(211)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btn_home);
            this.panel4.Controls.Add(this.panel_navigation);
            this.panel4.Location = new System.Drawing.Point(13, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(368, 596);
            this.panel4.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(137)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(1122, 620);
            this.Controls.Add(this.MainPanel);
            this.Name = "Form1";
            this.Text = "EMPLOYEE MANAGEMENT SYSTEM";
            this.panel_navigation.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_recent;
        private System.Windows.Forms.Panel panel_attendance;
        private System.Windows.Forms.Panel panel_accounting;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel_navigation;
        private System.Windows.Forms.Button btn_recent;
        private System.Windows.Forms.Button btn_attendance;
        private System.Windows.Forms.Button btn_accounting;
        private System.Windows.Forms.Button btn_recruitment;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.Panel panel_recruitment;
        private System.Windows.Forms.Panel panel4;
    }
}


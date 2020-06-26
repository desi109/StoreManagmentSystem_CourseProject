using System;

namespace StoreManagmentSystem
{
    partial class FormEmployee
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
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.workHoursEmployeeLb = new System.Windows.Forms.Label();
            this.workHoursEmployeeTb = new System.Windows.Forms.TextBox();
            this.salaryEmployeeLb = new System.Windows.Forms.Label();
            this.salaryEmployeeTb = new System.Windows.Forms.TextBox();
            this.nameEmployeeLb = new System.Windows.Forms.Label();
            this.nameEmployeeTb = new System.Windows.Forms.TextBox();
            this.idEmployeeLb = new System.Windows.Forms.Label();
            this.saveEmployeeBtn = new System.Windows.Forms.Button();
            this.editCatalogEmployeeBtn = new System.Windows.Forms.Button();
            this.idEmployeeTb = new System.Windows.Forms.TextBox();
            this.employeeInformationEmployeeLb = new System.Windows.Forms.Label();
            this.panelEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEmployee
            // 
            this.panelEmployee.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelEmployee.Controls.Add(this.workHoursEmployeeLb);
            this.panelEmployee.Controls.Add(this.workHoursEmployeeTb);
            this.panelEmployee.Controls.Add(this.salaryEmployeeLb);
            this.panelEmployee.Controls.Add(this.salaryEmployeeTb);
            this.panelEmployee.Controls.Add(this.nameEmployeeLb);
            this.panelEmployee.Controls.Add(this.nameEmployeeTb);
            this.panelEmployee.Controls.Add(this.idEmployeeLb);
            this.panelEmployee.Controls.Add(this.saveEmployeeBtn);
            this.panelEmployee.Controls.Add(this.editCatalogEmployeeBtn);
            this.panelEmployee.Controls.Add(this.idEmployeeTb);
            this.panelEmployee.Controls.Add(this.employeeInformationEmployeeLb);
            this.panelEmployee.Location = new System.Drawing.Point(24, 21);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(569, 423);
            this.panelEmployee.TabIndex = 3;
            // 
            // workHoursEmployeeLb
            // 
            this.workHoursEmployeeLb.AutoSize = true;
            this.workHoursEmployeeLb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workHoursEmployeeLb.Location = new System.Drawing.Point(24, 265);
            this.workHoursEmployeeLb.Name = "workHoursEmployeeLb";
            this.workHoursEmployeeLb.Size = new System.Drawing.Size(102, 23);
            this.workHoursEmployeeLb.TabIndex = 12;
            this.workHoursEmployeeLb.Text = "Work Hours";
            // 
            // workHoursEmployeeTb
            // 
            this.workHoursEmployeeTb.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.workHoursEmployeeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workHoursEmployeeTb.Location = new System.Drawing.Point(141, 261);
            this.workHoursEmployeeTb.Name = "workHoursEmployeeTb";
            this.workHoursEmployeeTb.Size = new System.Drawing.Size(317, 27);
            this.workHoursEmployeeTb.TabIndex = 11;
            // 
            // salaryEmployeeLb
            // 
            this.salaryEmployeeLb.AutoSize = true;
            this.salaryEmployeeLb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salaryEmployeeLb.Location = new System.Drawing.Point(33, 214);
            this.salaryEmployeeLb.Name = "salaryEmployeeLb";
            this.salaryEmployeeLb.Size = new System.Drawing.Size(57, 23);
            this.salaryEmployeeLb.TabIndex = 10;
            this.salaryEmployeeLb.Text = "Salary";
            // 
            // salaryEmployeeTb
            // 
            this.salaryEmployeeTb.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.salaryEmployeeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salaryEmployeeTb.Location = new System.Drawing.Point(141, 210);
            this.salaryEmployeeTb.Name = "salaryEmployeeTb";
            this.salaryEmployeeTb.Size = new System.Drawing.Size(317, 27);
            this.salaryEmployeeTb.TabIndex = 9;
            // 
            // nameEmployeeLb
            // 
            this.nameEmployeeLb.AllowDrop = true;
            this.nameEmployeeLb.AutoSize = true;
            this.nameEmployeeLb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameEmployeeLb.Location = new System.Drawing.Point(33, 162);
            this.nameEmployeeLb.Name = "nameEmployeeLb";
            this.nameEmployeeLb.Size = new System.Drawing.Size(56, 23);
            this.nameEmployeeLb.TabIndex = 8;
            this.nameEmployeeLb.Text = "Name";
            // 
            // nameEmployeeTb
            // 
            this.nameEmployeeTb.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.nameEmployeeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameEmployeeTb.Location = new System.Drawing.Point(141, 158);
            this.nameEmployeeTb.Name = "nameEmployeeTb";
            this.nameEmployeeTb.Size = new System.Drawing.Size(317, 27);
            this.nameEmployeeTb.TabIndex = 7;
            // 
            // idEmployeeLb
            // 
            this.idEmployeeLb.AutoSize = true;
            this.idEmployeeLb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idEmployeeLb.Location = new System.Drawing.Point(33, 113);
            this.idEmployeeLb.Name = "idEmployeeLb";
            this.idEmployeeLb.Size = new System.Drawing.Size(57, 23);
            this.idEmployeeLb.TabIndex = 6;
            this.idEmployeeLb.Text = "Id No.";
            // 
            // saveEmployeeBtn
            // 
            this.saveEmployeeBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveEmployeeBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.saveEmployeeBtn.FlatAppearance.BorderSize = 4;
            this.saveEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveEmployeeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveEmployeeBtn.Location = new System.Drawing.Point(393, 340);
            this.saveEmployeeBtn.Name = "saveEmployeeBtn";
            this.saveEmployeeBtn.Size = new System.Drawing.Size(137, 41);
            this.saveEmployeeBtn.TabIndex = 5;
            this.saveEmployeeBtn.Text = "Save";
            this.saveEmployeeBtn.UseVisualStyleBackColor = false;
            this.saveEmployeeBtn.Click += new System.EventHandler(this.saveEmployeeBtn_Click);
            // 
            // editCatalogEmployeeBtn
            // 
            this.editCatalogEmployeeBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.editCatalogEmployeeBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.editCatalogEmployeeBtn.FlatAppearance.BorderSize = 4;
            this.editCatalogEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCatalogEmployeeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editCatalogEmployeeBtn.Location = new System.Drawing.Point(37, 340);
            this.editCatalogEmployeeBtn.Name = "editCatalogEmployeeBtn";
            this.editCatalogEmployeeBtn.Size = new System.Drawing.Size(156, 41);
            this.editCatalogEmployeeBtn.TabIndex = 4;
            this.editCatalogEmployeeBtn.Text = "Edit Catalog";
            this.editCatalogEmployeeBtn.UseVisualStyleBackColor = false;
            this.editCatalogEmployeeBtn.Click += new System.EventHandler(this.editCatalogEmployeeBtn_Click);
            // 
            // idEmployeeTb
            // 
            this.idEmployeeTb.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.idEmployeeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idEmployeeTb.Location = new System.Drawing.Point(142, 109);
            this.idEmployeeTb.Name = "idEmployeeTb";
            this.idEmployeeTb.ReadOnly = true;
            this.idEmployeeTb.Size = new System.Drawing.Size(316, 27);
            this.idEmployeeTb.TabIndex = 1;
            // 
            // employeeInformationEmployeeLb
            // 
            this.employeeInformationEmployeeLb.AutoSize = true;
            this.employeeInformationEmployeeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeInformationEmployeeLb.Location = new System.Drawing.Point(135, 13);
            this.employeeInformationEmployeeLb.Name = "employeeInformationEmployeeLb";
            this.employeeInformationEmployeeLb.Size = new System.Drawing.Size(322, 36);
            this.employeeInformationEmployeeLb.TabIndex = 0;
            this.employeeInformationEmployeeLb.Text = "Employee Information";
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(619, 467);
            this.Controls.Add(this.panelEmployee);
            this.Name = "FormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.panelEmployee.ResumeLayout(false);
            this.panelEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        private void nameForSearchEmployeeTb_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion

        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.Label idEmployeeLb;
        private System.Windows.Forms.Button saveEmployeeBtn;
        private System.Windows.Forms.Button editCatalogEmployeeBtn;
        private System.Windows.Forms.TextBox idEmployeeTb;
        private System.Windows.Forms.Label employeeInformationEmployeeLb;
        private System.Windows.Forms.Label nameEmployeeLb;
        private System.Windows.Forms.TextBox nameEmployeeTb;
        private System.Windows.Forms.Label workHoursEmployeeLb;
        private System.Windows.Forms.TextBox workHoursEmployeeTb;
        private System.Windows.Forms.Label salaryEmployeeLb;
        private System.Windows.Forms.TextBox salaryEmployeeTb;
    }
}
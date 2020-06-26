namespace StoreManagmentSystem
{
    partial class FormStart
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
            this.employeeLb = new System.Windows.Forms.Label();
            this.buyerLb = new System.Windows.Forms.Label();
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.addEmployeeBtn = new System.Windows.Forms.Button();
            this.deleteEmployeeBtn = new System.Windows.Forms.Button();
            this.nameEmployeeListB = new System.Windows.Forms.ListBox();
            this.searchEmployeeBtn = new System.Windows.Forms.Button();
            this.nameForSearchEmployeeTb = new System.Windows.Forms.TextBox();
            this.panelBuyer = new System.Windows.Forms.Panel();
            this.nameForSearchBuyerTb = new System.Windows.Forms.TextBox();
            this.addBuyerBtn = new System.Windows.Forms.Button();
            this.deleteBuyerBtn = new System.Windows.Forms.Button();
            this.nameBuyerListB = new System.Windows.Forms.ListBox();
            this.searchBuyerBtn = new System.Windows.Forms.Button();
            this.panelEmployee.SuspendLayout();
            this.panelBuyer.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeLb
            // 
            this.employeeLb.AutoSize = true;
            this.employeeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeLb.Location = new System.Drawing.Point(155, 21);
            this.employeeLb.Name = "employeeLb";
            this.employeeLb.Size = new System.Drawing.Size(223, 51);
            this.employeeLb.TabIndex = 0;
            this.employeeLb.Text = "Employee";
            // 
            // buyerLb
            // 
            this.buyerLb.AutoSize = true;
            this.buyerLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buyerLb.Location = new System.Drawing.Point(250, 21);
            this.buyerLb.Name = "buyerLb";
            this.buyerLb.Size = new System.Drawing.Size(140, 51);
            this.buyerLb.TabIndex = 1;
            this.buyerLb.Text = "Buyer";
            // 
            // panelEmployee
            // 
            this.panelEmployee.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelEmployee.Controls.Add(this.addEmployeeBtn);
            this.panelEmployee.Controls.Add(this.deleteEmployeeBtn);
            this.panelEmployee.Controls.Add(this.nameEmployeeListB);
            this.panelEmployee.Controls.Add(this.searchEmployeeBtn);
            this.panelEmployee.Controls.Add(this.nameForSearchEmployeeTb);
            this.panelEmployee.Controls.Add(this.employeeLb);
            this.panelEmployee.Location = new System.Drawing.Point(20, 17);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(575, 596);
            this.panelEmployee.TabIndex = 2;
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addEmployeeBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addEmployeeBtn.FlatAppearance.BorderSize = 4;
            this.addEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployeeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEmployeeBtn.Location = new System.Drawing.Point(409, 521);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(137, 41);
            this.addEmployeeBtn.TabIndex = 5;
            this.addEmployeeBtn.Text = "Add New";
            this.addEmployeeBtn.UseVisualStyleBackColor = false;
            this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // deleteEmployeeBtn
            // 
            this.deleteEmployeeBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteEmployeeBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteEmployeeBtn.FlatAppearance.BorderSize = 4;
            this.deleteEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEmployeeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteEmployeeBtn.Location = new System.Drawing.Point(37, 521);
            this.deleteEmployeeBtn.Name = "deleteEmployeeBtn";
            this.deleteEmployeeBtn.Size = new System.Drawing.Size(156, 41);
            this.deleteEmployeeBtn.TabIndex = 4;
            this.deleteEmployeeBtn.Text = "Delete Employee";
            this.deleteEmployeeBtn.UseVisualStyleBackColor = false;
            this.deleteEmployeeBtn.Click += new System.EventHandler(this.deleteEmployeeBtn_Click);
            // 
            // nameEmployeeListB
            // 
            this.nameEmployeeListB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameEmployeeListB.FormattingEnabled = true;
            this.nameEmployeeListB.ItemHeight = 18;
            this.nameEmployeeListB.Items.AddRange(new object[] {
            ""});
            this.nameEmployeeListB.Location = new System.Drawing.Point(37, 220);
            this.nameEmployeeListB.Name = "nameEmployeeListB";
            this.nameEmployeeListB.Size = new System.Drawing.Size(509, 256);
            this.nameEmployeeListB.TabIndex = 3;
            this.nameEmployeeListB.DoubleClick += new System.EventHandler(this.nameEmployeeListB_DoubleClick);
            // 
            // searchEmployeeBtn
            // 
            this.searchEmployeeBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchEmployeeBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchEmployeeBtn.FlatAppearance.BorderSize = 4;
            this.searchEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchEmployeeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchEmployeeBtn.Location = new System.Drawing.Point(409, 102);
            this.searchEmployeeBtn.Name = "searchEmployeeBtn";
            this.searchEmployeeBtn.Size = new System.Drawing.Size(137, 41);
            this.searchEmployeeBtn.TabIndex = 2;
            this.searchEmployeeBtn.Text = "Search";
            this.searchEmployeeBtn.UseVisualStyleBackColor = false;
            this.searchEmployeeBtn.Click += new System.EventHandler(this.searchEmployeeBtn_Click);
            // 
            // nameForSearchEmployeeTb
            // 
            this.nameForSearchEmployeeTb.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.nameForSearchEmployeeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameForSearchEmployeeTb.Location = new System.Drawing.Point(37, 109);
            this.nameForSearchEmployeeTb.Name = "nameForSearchEmployeeTb";
            this.nameForSearchEmployeeTb.Size = new System.Drawing.Size(351, 27);
            this.nameForSearchEmployeeTb.TabIndex = 1;
            this.nameForSearchEmployeeTb.Text = "  type name for search ...";
            // 
            // panelBuyer
            // 
            this.panelBuyer.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelBuyer.Controls.Add(this.nameForSearchBuyerTb);
            this.panelBuyer.Controls.Add(this.addBuyerBtn);
            this.panelBuyer.Controls.Add(this.deleteBuyerBtn);
            this.panelBuyer.Controls.Add(this.nameBuyerListB);
            this.panelBuyer.Controls.Add(this.searchBuyerBtn);
            this.panelBuyer.Controls.Add(this.buyerLb);
            this.panelBuyer.Location = new System.Drawing.Point(613, 17);
            this.panelBuyer.Name = "panelBuyer";
            this.panelBuyer.Size = new System.Drawing.Size(575, 596);
            this.panelBuyer.TabIndex = 3;
            // 
            // nameForSearchBuyerTb
            // 
            this.nameForSearchBuyerTb.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.nameForSearchBuyerTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameForSearchBuyerTb.Location = new System.Drawing.Point(41, 109);
            this.nameForSearchBuyerTb.Name = "nameForSearchBuyerTb";
            this.nameForSearchBuyerTb.Size = new System.Drawing.Size(351, 27);
            this.nameForSearchBuyerTb.TabIndex = 7;
            this.nameForSearchBuyerTb.Text = "  type name for search ...";
            // 
            // addBuyerBtn
            // 
            this.addBuyerBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addBuyerBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addBuyerBtn.FlatAppearance.BorderSize = 4;
            this.addBuyerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBuyerBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBuyerBtn.Location = new System.Drawing.Point(416, 521);
            this.addBuyerBtn.Name = "addBuyerBtn";
            this.addBuyerBtn.Size = new System.Drawing.Size(137, 41);
            this.addBuyerBtn.TabIndex = 6;
            this.addBuyerBtn.Text = "Add New";
            this.addBuyerBtn.UseVisualStyleBackColor = false;
            this.addBuyerBtn.Click += new System.EventHandler(this.addBuyerBtn_Click);
            // 
            // deleteBuyerBtn
            // 
            this.deleteBuyerBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteBuyerBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteBuyerBtn.FlatAppearance.BorderSize = 4;
            this.deleteBuyerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBuyerBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBuyerBtn.Location = new System.Drawing.Point(41, 521);
            this.deleteBuyerBtn.Name = "deleteBuyerBtn";
            this.deleteBuyerBtn.Size = new System.Drawing.Size(156, 41);
            this.deleteBuyerBtn.TabIndex = 5;
            this.deleteBuyerBtn.Text = "Delete Buyer";
            this.deleteBuyerBtn.UseVisualStyleBackColor = false;
            this.deleteBuyerBtn.Click += new System.EventHandler(this.deleteBuyerBtn_Click);
            // 
            // nameBuyerListB
            // 
            this.nameBuyerListB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBuyerListB.FormattingEnabled = true;
            this.nameBuyerListB.ItemHeight = 18;
            this.nameBuyerListB.Items.AddRange(new object[] {
            ""});
            this.nameBuyerListB.Location = new System.Drawing.Point(41, 220);
            this.nameBuyerListB.Name = "nameBuyerListB";
            this.nameBuyerListB.Size = new System.Drawing.Size(509, 256);
            this.nameBuyerListB.TabIndex = 4;
            this.nameBuyerListB.DoubleClick += new System.EventHandler(this.nameBuyerListB_DoubleClick);
            // 
            // searchBuyerBtn
            // 
            this.searchBuyerBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchBuyerBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchBuyerBtn.FlatAppearance.BorderSize = 4;
            this.searchBuyerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBuyerBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBuyerBtn.Location = new System.Drawing.Point(416, 102);
            this.searchBuyerBtn.Name = "searchBuyerBtn";
            this.searchBuyerBtn.Size = new System.Drawing.Size(137, 41);
            this.searchBuyerBtn.TabIndex = 3;
            this.searchBuyerBtn.Text = "Search ";
            this.searchBuyerBtn.UseVisualStyleBackColor = false;
            this.searchBuyerBtn.Click += new System.EventHandler(this.searchBuyerBtn_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1210, 636);
            this.Controls.Add(this.panelBuyer);
            this.Controls.Add(this.panelEmployee);
            this.Name = "FormStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Managment System";
            this.panelEmployee.ResumeLayout(false);
            this.panelEmployee.PerformLayout();
            this.panelBuyer.ResumeLayout(false);
            this.panelBuyer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label employeeLb;
        private System.Windows.Forms.Label buyerLb;
        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.TextBox nameForSearchEmployeeTb;
        private System.Windows.Forms.Panel panelBuyer;
        private System.Windows.Forms.Button addEmployeeBtn;
        private System.Windows.Forms.Button deleteEmployeeBtn;
        private System.Windows.Forms.ListBox nameEmployeeListB;
        private System.Windows.Forms.Button searchEmployeeBtn;
        private System.Windows.Forms.Button addBuyerBtn;
        private System.Windows.Forms.Button deleteBuyerBtn;
        private System.Windows.Forms.ListBox nameBuyerListB;
        private System.Windows.Forms.Button searchBuyerBtn;
        private System.Windows.Forms.TextBox nameForSearchBuyerTb;
    }
}


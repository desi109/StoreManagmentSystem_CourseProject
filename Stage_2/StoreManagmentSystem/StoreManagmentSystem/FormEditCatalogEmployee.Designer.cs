namespace StoreManagmentSystem
{
    partial class FormEditCatalogEmployee
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
            this.productsCatalogEditEditCatalogLb = new System.Windows.Forms.Label();
            this.addProductEditCatalogBtn = new System.Windows.Forms.Button();
            this.productEditCatalogListB = new System.Windows.Forms.ListBox();
            this.searchProductEditCatalogBtn = new System.Windows.Forms.Button();
            this.productForSearchEditCatalogTb = new System.Windows.Forms.TextBox();
            this.deleteProductCatalogBtn = new System.Windows.Forms.Button();
            this.panelEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEmployee
            // 
            this.panelEmployee.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelEmployee.Controls.Add(this.deleteProductCatalogBtn);
            this.panelEmployee.Controls.Add(this.productsCatalogEditEditCatalogLb);
            this.panelEmployee.Controls.Add(this.addProductEditCatalogBtn);
            this.panelEmployee.Controls.Add(this.productEditCatalogListB);
            this.panelEmployee.Controls.Add(this.searchProductEditCatalogBtn);
            this.panelEmployee.Controls.Add(this.productForSearchEditCatalogTb);
            this.panelEmployee.Location = new System.Drawing.Point(24, 22);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(575, 596);
            this.panelEmployee.TabIndex = 3;
            // 
            // productsCatalogEditEditCatalogLb
            // 
            this.productsCatalogEditEditCatalogLb.AutoSize = true;
            this.productsCatalogEditEditCatalogLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productsCatalogEditEditCatalogLb.Location = new System.Drawing.Point(130, 24);
            this.productsCatalogEditEditCatalogLb.Name = "productsCatalogEditEditCatalogLb";
            this.productsCatalogEditEditCatalogLb.Size = new System.Drawing.Size(352, 36);
            this.productsCatalogEditEditCatalogLb.TabIndex = 6;
            this.productsCatalogEditEditCatalogLb.Text = "Products Catalog  (edit)";
            // 
            // addProductEditCatalogBtn
            // 
            this.addProductEditCatalogBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addProductEditCatalogBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addProductEditCatalogBtn.FlatAppearance.BorderSize = 4;
            this.addProductEditCatalogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductEditCatalogBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProductEditCatalogBtn.Location = new System.Drawing.Point(409, 521);
            this.addProductEditCatalogBtn.Name = "addProductEditCatalogBtn";
            this.addProductEditCatalogBtn.Size = new System.Drawing.Size(137, 41);
            this.addProductEditCatalogBtn.TabIndex = 5;
            this.addProductEditCatalogBtn.Text = "Add New";
            this.addProductEditCatalogBtn.UseVisualStyleBackColor = false;
            this.addProductEditCatalogBtn.Click += new System.EventHandler(this.addProductEditCatalogBtn_Click);
            // 
            // productEditCatalogListB
            // 
            this.productEditCatalogListB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productEditCatalogListB.FormattingEnabled = true;
            this.productEditCatalogListB.ItemHeight = 18;
            this.productEditCatalogListB.Items.AddRange(new object[] {
            ""});
            this.productEditCatalogListB.Location = new System.Drawing.Point(37, 220);
            this.productEditCatalogListB.Name = "productEditCatalogListB";
            this.productEditCatalogListB.Size = new System.Drawing.Size(509, 256);
            this.productEditCatalogListB.TabIndex = 3;
            this.productEditCatalogListB.DoubleClick += new System.EventHandler(this.productEditCatalogListB_DoubleClick);
            // 
            // searchProductEditCatalogBtn
            // 
            this.searchProductEditCatalogBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchProductEditCatalogBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchProductEditCatalogBtn.FlatAppearance.BorderSize = 4;
            this.searchProductEditCatalogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchProductEditCatalogBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchProductEditCatalogBtn.Location = new System.Drawing.Point(409, 102);
            this.searchProductEditCatalogBtn.Name = "searchProductEditCatalogBtn";
            this.searchProductEditCatalogBtn.Size = new System.Drawing.Size(137, 41);
            this.searchProductEditCatalogBtn.TabIndex = 2;
            this.searchProductEditCatalogBtn.Text = "Search";
            this.searchProductEditCatalogBtn.UseVisualStyleBackColor = false;
            this.searchProductEditCatalogBtn.Click += new System.EventHandler(this.searchProductEditCatalogBtn_Click);
            // 
            // productForSearchEditCatalogTb
            // 
            this.productForSearchEditCatalogTb.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.productForSearchEditCatalogTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productForSearchEditCatalogTb.Location = new System.Drawing.Point(37, 109);
            this.productForSearchEditCatalogTb.Name = "productForSearchEditCatalogTb";
            this.productForSearchEditCatalogTb.Size = new System.Drawing.Size(351, 27);
            this.productForSearchEditCatalogTb.TabIndex = 1;
            this.productForSearchEditCatalogTb.Text = "  type product for search ...";
            // 
            // deleteProductCatalogBtn
            // 
            this.deleteProductCatalogBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteProductCatalogBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteProductCatalogBtn.FlatAppearance.BorderSize = 4;
            this.deleteProductCatalogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProductCatalogBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteProductCatalogBtn.Location = new System.Drawing.Point(37, 521);
            this.deleteProductCatalogBtn.Name = "deleteProductCatalogBtn";
            this.deleteProductCatalogBtn.Size = new System.Drawing.Size(156, 41);
            this.deleteProductCatalogBtn.TabIndex = 7;
            this.deleteProductCatalogBtn.Text = "Delete Product";
            this.deleteProductCatalogBtn.UseVisualStyleBackColor = false;
            this.deleteProductCatalogBtn.Click += new System.EventHandler(this.deleteProductCatalogBtn_Click);
            // 
            // FormEditCatalogEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(625, 633);
            this.Controls.Add(this.panelEmployee);
            this.Name = "FormEditCatalogEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Catalog";
            this.panelEmployee.ResumeLayout(false);
            this.panelEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.Button addProductEditCatalogBtn;
        private System.Windows.Forms.Button searchProductEditCatalogBtn;
        private System.Windows.Forms.TextBox productForSearchEditCatalogTb;
        private System.Windows.Forms.Label productsCatalogEditEditCatalogLb;
        private System.Windows.Forms.ListBox productEditCatalogListB;
        private System.Windows.Forms.Button deleteProductCatalogBtn;
    }
}
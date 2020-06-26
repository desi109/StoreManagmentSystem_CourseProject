namespace StoreManagmentSystem
{
    partial class FormBuyer
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
            this.deleteSelectedBuyerBtn = new System.Windows.Forms.Button();
            this.billBuyerLb = new System.Windows.Forms.Label();
            this.billBuyerTb = new System.Windows.Forms.TextBox();
            this.purchasedProductsBuyerListB = new System.Windows.Forms.ListBox();
            this.purchasedProductsBuyerLb = new System.Windows.Forms.Label();
            this.nameBuyerLb = new System.Windows.Forms.Label();
            this.nameBuyerTb = new System.Windows.Forms.TextBox();
            this.idBuyerLb = new System.Windows.Forms.Label();
            this.saveBuyerBtn = new System.Windows.Forms.Button();
            this.buyNewBuyerBtn = new System.Windows.Forms.Button();
            this.idBuyerTb = new System.Windows.Forms.TextBox();
            this.buyerInformationBuyerLb = new System.Windows.Forms.Label();
            this.panelEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEmployee
            // 
            this.panelEmployee.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelEmployee.Controls.Add(this.deleteSelectedBuyerBtn);
            this.panelEmployee.Controls.Add(this.billBuyerLb);
            this.panelEmployee.Controls.Add(this.billBuyerTb);
            this.panelEmployee.Controls.Add(this.purchasedProductsBuyerListB);
            this.panelEmployee.Controls.Add(this.purchasedProductsBuyerLb);
            this.panelEmployee.Controls.Add(this.nameBuyerLb);
            this.panelEmployee.Controls.Add(this.nameBuyerTb);
            this.panelEmployee.Controls.Add(this.idBuyerLb);
            this.panelEmployee.Controls.Add(this.saveBuyerBtn);
            this.panelEmployee.Controls.Add(this.buyNewBuyerBtn);
            this.panelEmployee.Controls.Add(this.idBuyerTb);
            this.panelEmployee.Controls.Add(this.buyerInformationBuyerLb);
            this.panelEmployee.Location = new System.Drawing.Point(21, 21);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(547, 596);
            this.panelEmployee.TabIndex = 4;
            // 
            // deleteSelectedBuyerBtn
            // 
            this.deleteSelectedBuyerBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteSelectedBuyerBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteSelectedBuyerBtn.FlatAppearance.BorderSize = 4;
            this.deleteSelectedBuyerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedBuyerBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteSelectedBuyerBtn.Location = new System.Drawing.Point(156, 539);
            this.deleteSelectedBuyerBtn.Name = "deleteSelectedBuyerBtn";
            this.deleteSelectedBuyerBtn.Size = new System.Drawing.Size(148, 41);
            this.deleteSelectedBuyerBtn.TabIndex = 14;
            this.deleteSelectedBuyerBtn.Text = "Delete Selected";
            this.deleteSelectedBuyerBtn.UseVisualStyleBackColor = false;
            this.deleteSelectedBuyerBtn.Click += new System.EventHandler(this.deleteSelectedBuyerBtn_Click);
            // 
            // billBuyerLb
            // 
            this.billBuyerLb.AllowDrop = true;
            this.billBuyerLb.AutoSize = true;
            this.billBuyerLb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.billBuyerLb.Location = new System.Drawing.Point(32, 180);
            this.billBuyerLb.Name = "billBuyerLb";
            this.billBuyerLb.Size = new System.Drawing.Size(32, 23);
            this.billBuyerLb.TabIndex = 13;
            this.billBuyerLb.Text = "Bill";
            // 
            // billBuyerTb
            // 
            this.billBuyerTb.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.billBuyerTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.billBuyerTb.Location = new System.Drawing.Point(140, 176);
            this.billBuyerTb.Name = "billBuyerTb";
            this.billBuyerTb.ReadOnly = true;
            this.billBuyerTb.Size = new System.Drawing.Size(317, 27);
            this.billBuyerTb.TabIndex = 12;
            this.billBuyerTb.Text = "0";
            // 
            // purchasedProductsBuyerListB
            // 
            this.purchasedProductsBuyerListB.FormattingEnabled = true;
            this.purchasedProductsBuyerListB.ItemHeight = 16;
            this.purchasedProductsBuyerListB.Items.AddRange(new object[] {
            ""});
            this.purchasedProductsBuyerListB.Location = new System.Drawing.Point(37, 259);
            this.purchasedProductsBuyerListB.Name = "purchasedProductsBuyerListB";
            this.purchasedProductsBuyerListB.Size = new System.Drawing.Size(479, 228);
            this.purchasedProductsBuyerListB.TabIndex = 11;
            // 
            // purchasedProductsBuyerLb
            // 
            this.purchasedProductsBuyerLb.AutoSize = true;
            this.purchasedProductsBuyerLb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purchasedProductsBuyerLb.Location = new System.Drawing.Point(33, 233);
            this.purchasedProductsBuyerLb.Name = "purchasedProductsBuyerLb";
            this.purchasedProductsBuyerLb.Size = new System.Drawing.Size(161, 23);
            this.purchasedProductsBuyerLb.TabIndex = 10;
            this.purchasedProductsBuyerLb.Text = "Purchased Products";
            // 
            // nameBuyerLb
            // 
            this.nameBuyerLb.AllowDrop = true;
            this.nameBuyerLb.AutoSize = true;
            this.nameBuyerLb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBuyerLb.Location = new System.Drawing.Point(32, 126);
            this.nameBuyerLb.Name = "nameBuyerLb";
            this.nameBuyerLb.Size = new System.Drawing.Size(56, 23);
            this.nameBuyerLb.TabIndex = 8;
            this.nameBuyerLb.Text = "Name";
            // 
            // nameBuyerTb
            // 
            this.nameBuyerTb.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.nameBuyerTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBuyerTb.Location = new System.Drawing.Point(140, 122);
            this.nameBuyerTb.Name = "nameBuyerTb";
            this.nameBuyerTb.Size = new System.Drawing.Size(317, 27);
            this.nameBuyerTb.TabIndex = 7;
            // 
            // idBuyerLb
            // 
            this.idBuyerLb.AutoSize = true;
            this.idBuyerLb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idBuyerLb.Location = new System.Drawing.Point(32, 77);
            this.idBuyerLb.Name = "idBuyerLb";
            this.idBuyerLb.Size = new System.Drawing.Size(57, 23);
            this.idBuyerLb.TabIndex = 6;
            this.idBuyerLb.Text = "Id No.";
            // 
            // saveBuyerBtn
            // 
            this.saveBuyerBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveBuyerBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.saveBuyerBtn.FlatAppearance.BorderSize = 4;
            this.saveBuyerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBuyerBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBuyerBtn.Location = new System.Drawing.Point(433, 539);
            this.saveBuyerBtn.Name = "saveBuyerBtn";
            this.saveBuyerBtn.Size = new System.Drawing.Size(83, 41);
            this.saveBuyerBtn.TabIndex = 5;
            this.saveBuyerBtn.Text = "Save";
            this.saveBuyerBtn.UseVisualStyleBackColor = false;
            this.saveBuyerBtn.Click += new System.EventHandler(this.saveBuyerBtn_Click);
            // 
            // buyNewBuyerBtn
            // 
            this.buyNewBuyerBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buyNewBuyerBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buyNewBuyerBtn.FlatAppearance.BorderSize = 4;
            this.buyNewBuyerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyNewBuyerBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buyNewBuyerBtn.Location = new System.Drawing.Point(37, 539);
            this.buyNewBuyerBtn.Name = "buyNewBuyerBtn";
            this.buyNewBuyerBtn.Size = new System.Drawing.Size(103, 41);
            this.buyNewBuyerBtn.TabIndex = 4;
            this.buyNewBuyerBtn.Text = "Buy New";
            this.buyNewBuyerBtn.UseVisualStyleBackColor = false;
            this.buyNewBuyerBtn.Click += new System.EventHandler(this.buyNewBuyerBtn_Click);
            // 
            // idBuyerTb
            // 
            this.idBuyerTb.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.idBuyerTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idBuyerTb.Location = new System.Drawing.Point(141, 73);
            this.idBuyerTb.Name = "idBuyerTb";
            this.idBuyerTb.ReadOnly = true;
            this.idBuyerTb.Size = new System.Drawing.Size(316, 27);
            this.idBuyerTb.TabIndex = 1;
            // 
            // buyerInformationBuyerLb
            // 
            this.buyerInformationBuyerLb.AutoSize = true;
            this.buyerInformationBuyerLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buyerInformationBuyerLb.Location = new System.Drawing.Point(135, 13);
            this.buyerInformationBuyerLb.Name = "buyerInformationBuyerLb";
            this.buyerInformationBuyerLb.Size = new System.Drawing.Size(266, 36);
            this.buyerInformationBuyerLb.TabIndex = 0;
            this.buyerInformationBuyerLb.Text = "Buyer Information";
            // 
            // FormBuyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(587, 629);
            this.Controls.Add(this.panelEmployee);
            this.Name = "FormBuyer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buyer";
            this.panelEmployee.ResumeLayout(false);
            this.panelEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.Label idBuyerLb;
        private System.Windows.Forms.Button saveBuyerBtn;
        private System.Windows.Forms.Button buyNewBuyerBtn;
        private System.Windows.Forms.TextBox idBuyerTb;
        private System.Windows.Forms.Label buyerInformationBuyerLb;
        private System.Windows.Forms.ListBox purchasedProductsBuyerListB;
        private System.Windows.Forms.Label purchasedProductsBuyerLb;
        private System.Windows.Forms.Label billBuyerLb;
        private System.Windows.Forms.TextBox billBuyerTb;
        private System.Windows.Forms.Label nameBuyerLb;
        private System.Windows.Forms.TextBox nameBuyerTb;
        private System.Windows.Forms.Button deleteSelectedBuyerBtn;
    }
}
namespace StoreManagmentSystem
{
    partial class FormMakePurchaseBuyer
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
            this.amountMakePurchaseLb = new System.Windows.Forms.Label();
            this.amountMakePurchaseTb = new System.Windows.Forms.TextBox();
            this.selectedProductMakePurchaseLb = new System.Windows.Forms.Label();
            this.buyMakePurchaseBtn = new System.Windows.Forms.Button();
            this.selectedProductMakePurchaseTb = new System.Windows.Forms.TextBox();
            this.makePurchaseLb = new System.Windows.Forms.Label();
            this.productMakePurchaseBuyerListB = new System.Windows.Forms.ListBox();
            this.searchMakePurchaseBuyerBtn = new System.Windows.Forms.Button();
            this.productForSearchMakePurchaseBuyerTb = new System.Windows.Forms.TextBox();
            this.purchaseOkBtn = new System.Windows.Forms.Button();
            this.lvPurchaseBuyerLb = new System.Windows.Forms.Label();
            this.pricePurchaseBuyerTb = new System.Windows.Forms.TextBox();
            this.modelPurchaseBuyerTb = new System.Windows.Forms.TextBox();
            this.typePurchaseBuyerTb = new System.Windows.Forms.TextBox();
            this.amountPurchaseBuyerTb = new System.Windows.Forms.TextBox();
            this.amountPurchaseBuyerLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.purchaseInformationBuyerLb = new System.Windows.Forms.Label();
            this.panelEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEmployee
            // 
            this.panelEmployee.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelEmployee.Controls.Add(this.amountMakePurchaseLb);
            this.panelEmployee.Controls.Add(this.amountMakePurchaseTb);
            this.panelEmployee.Controls.Add(this.selectedProductMakePurchaseLb);
            this.panelEmployee.Controls.Add(this.buyMakePurchaseBtn);
            this.panelEmployee.Controls.Add(this.selectedProductMakePurchaseTb);
            this.panelEmployee.Controls.Add(this.makePurchaseLb);
            this.panelEmployee.Controls.Add(this.productMakePurchaseBuyerListB);
            this.panelEmployee.Controls.Add(this.searchMakePurchaseBuyerBtn);
            this.panelEmployee.Controls.Add(this.productForSearchMakePurchaseBuyerTb);
            this.panelEmployee.Location = new System.Drawing.Point(21, 24);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(575, 596);
            this.panelEmployee.TabIndex = 4;
            // 
            // amountMakePurchaseLb
            // 
            this.amountMakePurchaseLb.AutoSize = true;
            this.amountMakePurchaseLb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountMakePurchaseLb.Location = new System.Drawing.Point(15, 542);
            this.amountMakePurchaseLb.Name = "amountMakePurchaseLb";
            this.amountMakePurchaseLb.Size = new System.Drawing.Size(144, 23);
            this.amountMakePurchaseLb.TabIndex = 13;
            this.amountMakePurchaseLb.Text = "Amount  (to buy)";
            // 
            // amountMakePurchaseTb
            // 
            this.amountMakePurchaseTb.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.amountMakePurchaseTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountMakePurchaseTb.Location = new System.Drawing.Point(180, 538);
            this.amountMakePurchaseTb.Name = "amountMakePurchaseTb";
            this.amountMakePurchaseTb.ReadOnly = true;
            this.amountMakePurchaseTb.Size = new System.Drawing.Size(208, 27);
            this.amountMakePurchaseTb.TabIndex = 12;
            this.amountMakePurchaseTb.Text = "  ";
            // 
            // selectedProductMakePurchaseLb
            // 
            this.selectedProductMakePurchaseLb.AutoSize = true;
            this.selectedProductMakePurchaseLb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedProductMakePurchaseLb.Location = new System.Drawing.Point(15, 496);
            this.selectedProductMakePurchaseLb.Name = "selectedProductMakePurchaseLb";
            this.selectedProductMakePurchaseLb.Size = new System.Drawing.Size(139, 23);
            this.selectedProductMakePurchaseLb.TabIndex = 11;
            this.selectedProductMakePurchaseLb.Text = "Selected Product";
            // 
            // buyMakePurchaseBtn
            // 
            this.buyMakePurchaseBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buyMakePurchaseBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buyMakePurchaseBtn.FlatAppearance.BorderSize = 4;
            this.buyMakePurchaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyMakePurchaseBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buyMakePurchaseBtn.Location = new System.Drawing.Point(450, 531);
            this.buyMakePurchaseBtn.Name = "buyMakePurchaseBtn";
            this.buyMakePurchaseBtn.Size = new System.Drawing.Size(96, 41);
            this.buyMakePurchaseBtn.TabIndex = 10;
            this.buyMakePurchaseBtn.Text = "Buy";
            this.buyMakePurchaseBtn.UseVisualStyleBackColor = false;
            this.buyMakePurchaseBtn.Click += new System.EventHandler(this.buyMakePurchaseBtn_Click);
            // 
            // selectedProductMakePurchaseTb
            // 
            this.selectedProductMakePurchaseTb.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.selectedProductMakePurchaseTb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectedProductMakePurchaseTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedProductMakePurchaseTb.Location = new System.Drawing.Point(180, 492);
            this.selectedProductMakePurchaseTb.Name = "selectedProductMakePurchaseTb";
            this.selectedProductMakePurchaseTb.ReadOnly = true;
            this.selectedProductMakePurchaseTb.Size = new System.Drawing.Size(208, 27);
            this.selectedProductMakePurchaseTb.TabIndex = 7;
            this.selectedProductMakePurchaseTb.Text = "  ";
            // 
            // makePurchaseLb
            // 
            this.makePurchaseLb.AutoSize = true;
            this.makePurchaseLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.makePurchaseLb.Location = new System.Drawing.Point(130, 24);
            this.makePurchaseLb.Name = "makePurchaseLb";
            this.makePurchaseLb.Size = new System.Drawing.Size(234, 36);
            this.makePurchaseLb.TabIndex = 6;
            this.makePurchaseLb.Text = "Make Purchase";
            // 
            // productMakePurchaseBuyerListB
            // 
            this.productMakePurchaseBuyerListB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productMakePurchaseBuyerListB.FormattingEnabled = true;
            this.productMakePurchaseBuyerListB.ItemHeight = 18;
            this.productMakePurchaseBuyerListB.Items.AddRange(new object[] {
            ""});
            this.productMakePurchaseBuyerListB.Location = new System.Drawing.Point(37, 170);
            this.productMakePurchaseBuyerListB.Name = "productMakePurchaseBuyerListB";
            this.productMakePurchaseBuyerListB.Size = new System.Drawing.Size(509, 274);
            this.productMakePurchaseBuyerListB.TabIndex = 3;
            this.productMakePurchaseBuyerListB.DoubleClick += new System.EventHandler(this.productMakePurchaseBuyerListB_DoubleClick);
            // 
            // searchMakePurchaseBuyerBtn
            // 
            this.searchMakePurchaseBuyerBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchMakePurchaseBuyerBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchMakePurchaseBuyerBtn.FlatAppearance.BorderSize = 4;
            this.searchMakePurchaseBuyerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchMakePurchaseBuyerBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchMakePurchaseBuyerBtn.Location = new System.Drawing.Point(409, 102);
            this.searchMakePurchaseBuyerBtn.Name = "searchMakePurchaseBuyerBtn";
            this.searchMakePurchaseBuyerBtn.Size = new System.Drawing.Size(137, 41);
            this.searchMakePurchaseBuyerBtn.TabIndex = 2;
            this.searchMakePurchaseBuyerBtn.Text = "Search";
            this.searchMakePurchaseBuyerBtn.UseVisualStyleBackColor = false;
            this.searchMakePurchaseBuyerBtn.Click += new System.EventHandler(this.searchMakePurchaseBuyerBtn_Click);
            // 
            // productForSearchMakePurchaseBuyerTb
            // 
            this.productForSearchMakePurchaseBuyerTb.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.productForSearchMakePurchaseBuyerTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productForSearchMakePurchaseBuyerTb.Location = new System.Drawing.Point(37, 109);
            this.productForSearchMakePurchaseBuyerTb.Name = "productForSearchMakePurchaseBuyerTb";
            this.productForSearchMakePurchaseBuyerTb.Size = new System.Drawing.Size(351, 27);
            this.productForSearchMakePurchaseBuyerTb.TabIndex = 1;
            this.productForSearchMakePurchaseBuyerTb.Text = "  type product for search ...";
            // 
            // purchaseOkBtn
            // 
            this.purchaseOkBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.purchaseOkBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.purchaseOkBtn.FlatAppearance.BorderSize = 4;
            this.purchaseOkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseOkBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purchaseOkBtn.Location = new System.Drawing.Point(664, 391);
            this.purchaseOkBtn.Name = "purchaseOkBtn";
            this.purchaseOkBtn.Size = new System.Drawing.Size(96, 41);
            this.purchaseOkBtn.TabIndex = 34;
            this.purchaseOkBtn.Text = "OK";
            this.purchaseOkBtn.UseVisualStyleBackColor = false;
            this.purchaseOkBtn.Click += new System.EventHandler(this.purchaseOkBtn_Click);
            // 
            // lvPurchaseBuyerLb
            // 
            this.lvPurchaseBuyerLb.AllowDrop = true;
            this.lvPurchaseBuyerLb.AutoSize = true;
            this.lvPurchaseBuyerLb.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvPurchaseBuyerLb.Location = new System.Drawing.Point(864, 295);
            this.lvPurchaseBuyerLb.Name = "lvPurchaseBuyerLb";
            this.lvPurchaseBuyerLb.Size = new System.Drawing.Size(88, 19);
            this.lvPurchaseBuyerLb.TabIndex = 33;
            this.lvPurchaseBuyerLb.Text = "lv. (per item)";
            // 
            // pricePurchaseBuyerTb
            // 
            this.pricePurchaseBuyerTb.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.pricePurchaseBuyerTb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pricePurchaseBuyerTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pricePurchaseBuyerTb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pricePurchaseBuyerTb.Location = new System.Drawing.Point(764, 295);
            this.pricePurchaseBuyerTb.Name = "pricePurchaseBuyerTb";
            this.pricePurchaseBuyerTb.ReadOnly = true;
            this.pricePurchaseBuyerTb.Size = new System.Drawing.Size(104, 23);
            this.pricePurchaseBuyerTb.TabIndex = 32;
            // 
            // modelPurchaseBuyerTb
            // 
            this.modelPurchaseBuyerTb.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.modelPurchaseBuyerTb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.modelPurchaseBuyerTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modelPurchaseBuyerTb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelPurchaseBuyerTb.Location = new System.Drawing.Point(764, 257);
            this.modelPurchaseBuyerTb.Name = "modelPurchaseBuyerTb";
            this.modelPurchaseBuyerTb.ReadOnly = true;
            this.modelPurchaseBuyerTb.Size = new System.Drawing.Size(219, 23);
            this.modelPurchaseBuyerTb.TabIndex = 31;
            // 
            // typePurchaseBuyerTb
            // 
            this.typePurchaseBuyerTb.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.typePurchaseBuyerTb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.typePurchaseBuyerTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typePurchaseBuyerTb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typePurchaseBuyerTb.Location = new System.Drawing.Point(677, 257);
            this.typePurchaseBuyerTb.Name = "typePurchaseBuyerTb";
            this.typePurchaseBuyerTb.ReadOnly = true;
            this.typePurchaseBuyerTb.Size = new System.Drawing.Size(81, 23);
            this.typePurchaseBuyerTb.TabIndex = 30;
            this.typePurchaseBuyerTb.Text = " ";
            // 
            // amountPurchaseBuyerTb
            // 
            this.amountPurchaseBuyerTb.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.amountPurchaseBuyerTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountPurchaseBuyerTb.Location = new System.Drawing.Point(764, 326);
            this.amountPurchaseBuyerTb.Name = "amountPurchaseBuyerTb";
            this.amountPurchaseBuyerTb.Size = new System.Drawing.Size(85, 27);
            this.amountPurchaseBuyerTb.TabIndex = 29;
            // 
            // amountPurchaseBuyerLb
            // 
            this.amountPurchaseBuyerLb.AllowDrop = true;
            this.amountPurchaseBuyerLb.AutoSize = true;
            this.amountPurchaseBuyerLb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountPurchaseBuyerLb.Location = new System.Drawing.Point(661, 330);
            this.amountPurchaseBuyerLb.Name = "amountPurchaseBuyerLb";
            this.amountPurchaseBuyerLb.Size = new System.Drawing.Size(76, 23);
            this.amountPurchaseBuyerLb.TabIndex = 28;
            this.amountPurchaseBuyerLb.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(673, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Price:";
            // 
            // purchaseInformationBuyerLb
            // 
            this.purchaseInformationBuyerLb.AutoSize = true;
            this.purchaseInformationBuyerLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purchaseInformationBuyerLb.Location = new System.Drawing.Point(659, 194);
            this.purchaseInformationBuyerLb.Name = "purchaseInformationBuyerLb";
            this.purchaseInformationBuyerLb.Size = new System.Drawing.Size(259, 29);
            this.purchaseInformationBuyerLb.TabIndex = 26;
            this.purchaseInformationBuyerLb.Text = "Purchase Information";
            // 
            // FormMakePurchaseBuyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1024, 647);
            this.Controls.Add(this.purchaseOkBtn);
            this.Controls.Add(this.lvPurchaseBuyerLb);
            this.Controls.Add(this.pricePurchaseBuyerTb);
            this.Controls.Add(this.modelPurchaseBuyerTb);
            this.Controls.Add(this.typePurchaseBuyerTb);
            this.Controls.Add(this.amountPurchaseBuyerTb);
            this.Controls.Add(this.amountPurchaseBuyerLb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.purchaseInformationBuyerLb);
            this.Controls.Add(this.panelEmployee);
            this.Name = "FormMakePurchaseBuyer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make Purchase";
            this.panelEmployee.ResumeLayout(false);
            this.panelEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.Button buyMakePurchaseBtn;
        private System.Windows.Forms.TextBox selectedProductMakePurchaseTb;
        private System.Windows.Forms.Label makePurchaseLb;
        private System.Windows.Forms.ListBox productMakePurchaseBuyerListB;
        private System.Windows.Forms.Button searchMakePurchaseBuyerBtn;
        private System.Windows.Forms.TextBox productForSearchMakePurchaseBuyerTb;
        private System.Windows.Forms.Label amountMakePurchaseLb;
        private System.Windows.Forms.TextBox amountMakePurchaseTb;
        private System.Windows.Forms.Label selectedProductMakePurchaseLb;
        private System.Windows.Forms.Button purchaseOkBtn;
        private System.Windows.Forms.Label lvPurchaseBuyerLb;
        private System.Windows.Forms.TextBox pricePurchaseBuyerTb;
        private System.Windows.Forms.TextBox modelPurchaseBuyerTb;
        private System.Windows.Forms.TextBox typePurchaseBuyerTb;
        private System.Windows.Forms.TextBox amountPurchaseBuyerTb;
        private System.Windows.Forms.Label amountPurchaseBuyerLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label purchaseInformationBuyerLb;
    }
}
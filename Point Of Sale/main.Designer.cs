namespace Point_Of_Sale
{
    partial class main
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
            this.add_category = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnAddCashier = new System.Windows.Forms.Button();
            this.btnViewCashier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_category
            // 
            this.add_category.Location = new System.Drawing.Point(12, 71);
            this.add_category.Name = "add_category";
            this.add_category.Size = new System.Drawing.Size(119, 38);
            this.add_category.TabIndex = 0;
            this.add_category.Text = "Add category";
            this.add_category.UseVisualStyleBackColor = true;
            this.add_category.Click += new System.EventHandler(this.add_category_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(12, 131);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(119, 38);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnAddCashier
            // 
            this.btnAddCashier.Location = new System.Drawing.Point(12, 187);
            this.btnAddCashier.Name = "btnAddCashier";
            this.btnAddCashier.Size = new System.Drawing.Size(119, 38);
            this.btnAddCashier.TabIndex = 2;
            this.btnAddCashier.Text = "Add Cashier";
            this.btnAddCashier.UseVisualStyleBackColor = true;
            this.btnAddCashier.Click += new System.EventHandler(this.btnAddCashier_Click);
            // 
            // btnViewCashier
            // 
            this.btnViewCashier.Location = new System.Drawing.Point(12, 242);
            this.btnViewCashier.Name = "btnViewCashier";
            this.btnViewCashier.Size = new System.Drawing.Size(119, 38);
            this.btnViewCashier.TabIndex = 3;
            this.btnViewCashier.Text = "View Cashier";
            this.btnViewCashier.UseVisualStyleBackColor = true;
            this.btnViewCashier.Click += new System.EventHandler(this.btnViewCashier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cashier";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(333, 71);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(119, 38);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 321);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewCashier);
            this.Controls.Add(this.btnAddCashier);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.add_category);
            this.Name = "main";
            this.Text = "main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_category;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnAddCashier;
        private System.Windows.Forms.Button btnViewCashier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOrder;
    }
}
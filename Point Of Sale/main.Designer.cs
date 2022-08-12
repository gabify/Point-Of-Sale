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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.add_category = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnAddCashier = new System.Windows.Forms.Button();
            this.btnViewCashier = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.navPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_category
            // 
            this.add_category.FlatAppearance.BorderSize = 0;
            this.add_category.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.add_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_category.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_category.ForeColor = System.Drawing.Color.White;
            this.add_category.Location = new System.Drawing.Point(0, 63);
            this.add_category.Name = "add_category";
            this.add_category.Size = new System.Drawing.Size(256, 53);
            this.add_category.TabIndex = 0;
            this.add_category.Text = "Add Category";
            this.add_category.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_category.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.add_category.UseVisualStyleBackColor = true;
            this.add_category.Click += new System.EventHandler(this.add_category_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(0, 134);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(256, 53);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnAddCashier
            // 
            this.btnAddCashier.FlatAppearance.BorderSize = 0;
            this.btnAddCashier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAddCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCashier.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCashier.ForeColor = System.Drawing.Color.White;
            this.btnAddCashier.Location = new System.Drawing.Point(0, 202);
            this.btnAddCashier.Name = "btnAddCashier";
            this.btnAddCashier.Size = new System.Drawing.Size(256, 53);
            this.btnAddCashier.TabIndex = 2;
            this.btnAddCashier.Text = "Add Cashier";
            this.btnAddCashier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCashier.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddCashier.UseVisualStyleBackColor = true;
            this.btnAddCashier.Click += new System.EventHandler(this.btnAddCashier_Click);
            // 
            // btnViewCashier
            // 
            this.btnViewCashier.FlatAppearance.BorderSize = 0;
            this.btnViewCashier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnViewCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCashier.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCashier.ForeColor = System.Drawing.Color.White;
            this.btnViewCashier.Location = new System.Drawing.Point(0, 272);
            this.btnViewCashier.Name = "btnViewCashier";
            this.btnViewCashier.Size = new System.Drawing.Size(256, 53);
            this.btnViewCashier.TabIndex = 3;
            this.btnViewCashier.Text = "View Cashier";
            this.btnViewCashier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCashier.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnViewCashier.UseVisualStyleBackColor = true;
            this.btnViewCashier.Click += new System.EventHandler(this.btnViewCashier_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(965, 16);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(119, 38);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(57)))));
            this.headerPanel.Controls.Add(this.pictureBox1);
            this.headerPanel.Controls.Add(this.label4);
            this.headerPanel.Controls.Add(this.btnOrder);
            this.headerPanel.Controls.Add(this.lblClose);
            this.headerPanel.Controls.Add(this.label3);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1370, 57);
            this.headerPanel.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(43, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Food App";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1305, 21);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(53, 23);
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "Close";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "KWIK-KWIK";
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(177)))), ((int)(((byte)(194)))));
            this.navPanel.Controls.Add(this.label5);
            this.navPanel.Controls.Add(this.add_category);
            this.navPanel.Controls.Add(this.btnAddItem);
            this.navPanel.Controls.Add(this.btnAddCashier);
            this.navPanel.Controls.Add(this.btnViewCashier);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPanel.Location = new System.Drawing.Point(0, 57);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(256, 692);
            this.navPanel.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Main Menu";
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(255, 57);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1115, 692);
            this.mainPanel.TabIndex = 9;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.Text = "main";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_category;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnAddCashier;
        private System.Windows.Forms.Button btnViewCashier;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel mainPanel;
    }
}
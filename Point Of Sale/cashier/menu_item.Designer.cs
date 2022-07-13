namespace Point_Of_Sale.cashier
{
    partial class menu_item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_item_name = new System.Windows.Forms.Label();
            this.lbl_item_category = new System.Windows.Forms.Label();
            this.lbl_item_price = new System.Windows.Forms.Label();
            this.pb_item_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_item_image)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_item_name
            // 
            this.lbl_item_name.AutoSize = true;
            this.lbl_item_name.Location = new System.Drawing.Point(3, 11);
            this.lbl_item_name.Name = "lbl_item_name";
            this.lbl_item_name.Size = new System.Drawing.Size(58, 13);
            this.lbl_item_name.TabIndex = 0;
            this.lbl_item_name.Text = "Item Name";
            // 
            // lbl_item_category
            // 
            this.lbl_item_category.AutoSize = true;
            this.lbl_item_category.Location = new System.Drawing.Point(3, 34);
            this.lbl_item_category.Name = "lbl_item_category";
            this.lbl_item_category.Size = new System.Drawing.Size(49, 13);
            this.lbl_item_category.TabIndex = 1;
            this.lbl_item_category.Text = "Category";
            // 
            // lbl_item_price
            // 
            this.lbl_item_price.AutoSize = true;
            this.lbl_item_price.Location = new System.Drawing.Point(3, 136);
            this.lbl_item_price.Name = "lbl_item_price";
            this.lbl_item_price.Size = new System.Drawing.Size(31, 13);
            this.lbl_item_price.TabIndex = 2;
            this.lbl_item_price.Text = "Price";
            // 
            // pb_item_image
            // 
            this.pb_item_image.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pb_item_image.Location = new System.Drawing.Point(70, 52);
            this.pb_item_image.Name = "pb_item_image";
            this.pb_item_image.Size = new System.Drawing.Size(100, 97);
            this.pb_item_image.TabIndex = 3;
            this.pb_item_image.TabStop = false;
            this.pb_item_image.Click += new System.EventHandler(this.pb_item_image_Click);
            // 
            // menu_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pb_item_image);
            this.Controls.Add(this.lbl_item_price);
            this.Controls.Add(this.lbl_item_category);
            this.Controls.Add(this.lbl_item_name);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "menu_item";
            this.Size = new System.Drawing.Size(187, 161);
            this.Load += new System.EventHandler(this.menu_item_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu_item_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pb_item_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_item_name;
        private System.Windows.Forms.Label lbl_item_category;
        private System.Windows.Forms.Label lbl_item_price;
        private System.Windows.Forms.PictureBox pb_item_image;
    }
}

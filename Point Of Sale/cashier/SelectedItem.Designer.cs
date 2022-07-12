namespace Point_Of_Sale.cashier
{
    partial class SelectedItem
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
            this.lblNumOfOrder = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblitemPrice = new System.Windows.Forms.Label();
            this.btnremove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumOfOrder
            // 
            this.lblNumOfOrder.AutoSize = true;
            this.lblNumOfOrder.Location = new System.Drawing.Point(3, 14);
            this.lblNumOfOrder.Name = "lblNumOfOrder";
            this.lblNumOfOrder.Size = new System.Drawing.Size(38, 13);
            this.lblNumOfOrder.TabIndex = 0;
            this.lblNumOfOrder.Text = "Orders";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(54, 14);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(58, 13);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Item Name";
            // 
            // lblitemPrice
            // 
            this.lblitemPrice.AutoSize = true;
            this.lblitemPrice.Location = new System.Drawing.Point(125, 14);
            this.lblitemPrice.Name = "lblitemPrice";
            this.lblitemPrice.Size = new System.Drawing.Size(54, 13);
            this.lblitemPrice.TabIndex = 2;
            this.lblitemPrice.Text = "Item Price";
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(185, 9);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(26, 23);
            this.btnremove.TabIndex = 3;
            this.btnremove.Text = "-";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // SelectedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.lblitemPrice);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblNumOfOrder);
            this.Name = "SelectedItem";
            this.Size = new System.Drawing.Size(223, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumOfOrder;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblitemPrice;
        private System.Windows.Forms.Button btnremove;
    }
}

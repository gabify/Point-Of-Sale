namespace Point_Of_Sale.cashier
{
    partial class order
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
            this.order_panel = new System.Windows.Forms.Panel();
            this.selectedOrderLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTotalorder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlaceorder = new System.Windows.Forms.Button();
            this.btnClearOrders = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menu_layout = new System.Windows.Forms.FlowLayoutPanel();
            this.order_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // order_panel
            // 
            this.order_panel.Controls.Add(this.selectedOrderLayout);
            this.order_panel.Controls.Add(this.lblTotalorder);
            this.order_panel.Controls.Add(this.label2);
            this.order_panel.Controls.Add(this.btnPlaceorder);
            this.order_panel.Controls.Add(this.btnClearOrders);
            this.order_panel.Controls.Add(this.label1);
            this.order_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.order_panel.Location = new System.Drawing.Point(459, 0);
            this.order_panel.Name = "order_panel";
            this.order_panel.Size = new System.Drawing.Size(244, 458);
            this.order_panel.TabIndex = 1;
            // 
            // selectedOrderLayout
            // 
            this.selectedOrderLayout.AutoScroll = true;
            this.selectedOrderLayout.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.selectedOrderLayout.Location = new System.Drawing.Point(0, 102);
            this.selectedOrderLayout.Name = "selectedOrderLayout";
            this.selectedOrderLayout.Size = new System.Drawing.Size(244, 279);
            this.selectedOrderLayout.TabIndex = 5;
            // 
            // lblTotalorder
            // 
            this.lblTotalorder.AutoSize = true;
            this.lblTotalorder.Location = new System.Drawing.Point(135, 384);
            this.lblTotalorder.Name = "lblTotalorder";
            this.lblTotalorder.Size = new System.Drawing.Size(0, 13);
            this.lblTotalorder.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total:";
            // 
            // btnPlaceorder
            // 
            this.btnPlaceorder.Location = new System.Drawing.Point(64, 414);
            this.btnPlaceorder.Name = "btnPlaceorder";
            this.btnPlaceorder.Size = new System.Drawing.Size(99, 32);
            this.btnPlaceorder.TabIndex = 2;
            this.btnPlaceorder.Text = "Place Order";
            this.btnPlaceorder.UseVisualStyleBackColor = true;
            this.btnPlaceorder.Click += new System.EventHandler(this.btnPlaceorder_Click);
            // 
            // btnClearOrders
            // 
            this.btnClearOrders.Location = new System.Drawing.Point(138, 60);
            this.btnClearOrders.Name = "btnClearOrders";
            this.btnClearOrders.Size = new System.Drawing.Size(75, 23);
            this.btnClearOrders.TabIndex = 1;
            this.btnClearOrders.Text = "Clear All";
            this.btnClearOrders.UseVisualStyleBackColor = true;
            this.btnClearOrders.Click += new System.EventHandler(this.btnClearOrders_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Order";
            // 
            // menu_layout
            // 
            this.menu_layout.AutoScroll = true;
            this.menu_layout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menu_layout.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_layout.Location = new System.Drawing.Point(0, 0);
            this.menu_layout.Name = "menu_layout";
            this.menu_layout.Size = new System.Drawing.Size(453, 458);
            this.menu_layout.TabIndex = 2;
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 458);
            this.Controls.Add(this.menu_layout);
            this.Controls.Add(this.order_panel);
            this.Name = "order";
            this.Text = "order";
            this.Load += new System.EventHandler(this.order_Load);
            this.order_panel.ResumeLayout(false);
            this.order_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel order_panel;
        private System.Windows.Forms.FlowLayoutPanel menu_layout;
        private System.Windows.Forms.Label lblTotalorder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlaceorder;
        private System.Windows.Forms.Button btnClearOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel selectedOrderLayout;
    }
}
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
            this.menu_layout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // order_panel
            // 
            this.order_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.order_panel.Location = new System.Drawing.Point(484, 0);
            this.order_panel.Name = "order_panel";
            this.order_panel.Size = new System.Drawing.Size(200, 458);
            this.order_panel.TabIndex = 1;
            // 
            // menu_layout
            // 
            this.menu_layout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menu_layout.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_layout.Location = new System.Drawing.Point(0, 0);
            this.menu_layout.Name = "menu_layout";
            this.menu_layout.Size = new System.Drawing.Size(478, 458);
            this.menu_layout.TabIndex = 2;
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 458);
            this.Controls.Add(this.menu_layout);
            this.Controls.Add(this.order_panel);
            this.Name = "order";
            this.Text = "order";
            this.Load += new System.EventHandler(this.order_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel order_panel;
        private System.Windows.Forms.FlowLayoutPanel menu_layout;
    }
}
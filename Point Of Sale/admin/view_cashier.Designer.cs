namespace Point_Of_Sale.admin
{
    partial class view_cashier
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
            this.dgvCashier = new System.Windows.Forms.DataGridView();
            this.pbCashier = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cashier_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middle_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCashier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCashier
            // 
            this.dgvCashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCashier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cashier_id,
            this.detail_id,
            this.user_id,
            this.first_name,
            this.middle_name,
            this.last_name,
            this.gender,
            this.img});
            this.dgvCashier.Location = new System.Drawing.Point(12, 193);
            this.dgvCashier.Name = "dgvCashier";
            this.dgvCashier.Size = new System.Drawing.Size(579, 179);
            this.dgvCashier.TabIndex = 0;
            this.dgvCashier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCashier_CellClick);
            // 
            // pbCashier
            // 
            this.pbCashier.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbCashier.Location = new System.Drawing.Point(12, 23);
            this.pbCashier.Name = "pbCashier";
            this.pbCashier.Size = new System.Drawing.Size(127, 115);
            this.pbCashier.TabIndex = 1;
            this.pbCashier.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Middle Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gender:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(271, 96);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(0, 13);
            this.lblGender.TabIndex = 10;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(271, 73);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(0, 13);
            this.lblLastName.TabIndex = 9;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(271, 48);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(0, 13);
            this.lblMiddleName.TabIndex = 8;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(271, 23);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(0, 13);
            this.lblFirstName.TabIndex = 7;
            // 
            // cashier_id
            // 
            this.cashier_id.DataPropertyName = "cashier_id";
            this.cashier_id.HeaderText = "Cashier Id";
            this.cashier_id.Name = "cashier_id";
            this.cashier_id.Visible = false;
            // 
            // detail_id
            // 
            this.detail_id.DataPropertyName = "cashier_detail_id";
            this.detail_id.HeaderText = "Detail Id";
            this.detail_id.Name = "detail_id";
            this.detail_id.Visible = false;
            // 
            // user_id
            // 
            this.user_id.DataPropertyName = "user_id";
            this.user_id.HeaderText = "User Id";
            this.user_id.Name = "user_id";
            this.user_id.Visible = false;
            // 
            // first_name
            // 
            this.first_name.DataPropertyName = "cashier_first_name";
            this.first_name.HeaderText = "First Name";
            this.first_name.Name = "first_name";
            // 
            // middle_name
            // 
            this.middle_name.DataPropertyName = "cashier_middle_name";
            this.middle_name.HeaderText = "Middle Name";
            this.middle_name.Name = "middle_name";
            // 
            // last_name
            // 
            this.last_name.DataPropertyName = "cashier_last_name";
            this.last_name.HeaderText = "Last Name";
            this.last_name.Name = "last_name";
            // 
            // gender
            // 
            this.gender.DataPropertyName = "cashier_gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            // 
            // img
            // 
            this.img.DataPropertyName = "cashier_image";
            this.img.HeaderText = "Image";
            this.img.Name = "img";
            // 
            // view_cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 384);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCashier);
            this.Controls.Add(this.dgvCashier);
            this.Name = "view_cashier";
            this.Text = "view_cashier";
            this.Load += new System.EventHandler(this.view_cashier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCashier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCashier;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashier_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn middle_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn img;
        private System.Windows.Forms.PictureBox pbCashier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblFirstName;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point_Of_Sale.operations;

namespace Point_Of_Sale.admin
{
    public partial class view_cashier : Form
    {
        public view_cashier()
        {
            InitializeComponent();
        }

        private void dgvCashier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblFirstName.Text = dgvCashier.CurrentRow.Cells[3].Value.ToString();
            lblMiddleName.Text = dgvCashier.CurrentRow.Cells[4].Value.ToString();
            lblLastName.Text = dgvCashier.CurrentRow.Cells[5].Value.ToString();
            lblGender.Text = dgvCashier.CurrentRow.Cells[6].Value.ToString();
            pbCashier.Image = new Bitmap(dgvCashier.CurrentRow.Cells[7].Value.ToString());
        }

        private void view_cashier_Load(object sender, EventArgs e)
        {
            Cashier cash = new Cashier();
            dgvCashier.DataSource = cash.getCashier();
        }
    }
}

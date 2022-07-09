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
    public partial class add_cashier : Form
    {
        string image_filename;
        string gender;
        public add_cashier()
        {
            InitializeComponent();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg; *.png; *.gif)| *.jpeg; *.PNG; *.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbCashierImage.Image = new Bitmap(open.FileName);
                image_filename = open.FileName;
            }
        }

        private void rdMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string[] data = new string[7];
            data[0] = txtFirstName.Text;
            data[1] = txtMiddleName.Text;
            data[2] = txtLastName.Text;
            data[3] = gender;
            data[4] = image_filename;
            data[5] = txtusername.Text;
            if (txtpass.Text == txtconpass.Text)
            {
                data[6] = txtpass.Text;
                Cashier cash = new Cashier();
                cash.addCashier(data);
                clearFields();
                MessageBox.Show("Cashier registered successfully!");
            }
            else
            {
                MessageBox.Show("Password does not match.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearFields()
        {
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtusername.Text = "";
            txtpass.Text = "";
            txtconpass.Text = "";
            rdMale.Checked = false;
            rdFemale.Checked = false;
            pbCashierImage.Image = null;
        }
    }
}

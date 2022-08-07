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

namespace Point_Of_Sale.cashier
{
    public partial class CashierLogin : Form
    {
        string username, password;
        login log = new login();
        public CashierLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                unameError.Text = "Username is missing.";
                unameError.Visible = true;
                btnLogin.Enabled = false;
            }
            else
            {
                unameError.Visible = false;
                btnLogin.Enabled = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                errorPass.Text = "Password is missing";
                errorPass.Visible = true;
                btnLogin.Enabled = false;
            }
            else
            {
                unameError.Visible = false;
                btnLogin.Enabled = true;
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.ForeColor = Color.Black;
            txtUsername.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.ForeColor = Color.Black;
            txtPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            password = txtPassword.Text;
            username = txtUsername.Text;
            int result = log.userLogin(username, password);

            switch (result)
            {
                case 0: // if user does not exist
                    unameError.Text = "User does not exist";
                    unameError.Visible = true;
                    errorPass.Text = "Incorrect Password";
                    errorPass.Visible = true;
                    break;
                case 10: // if correct username and password is correct and user level is for admin
                    MessageBox.Show("This user is not allowed to access cashier.");
                    break;
                case 11: // if correct username and password is correct and user level is for cashier
                    CashierMain form = new CashierMain();
                    form.Show();
                    Hide();
                    break;
                case 2: // if password is incorrect
                    errorPass.Text = "Incorrect Password";
                    errorPass.Visible = true;
                    break;
            }
        }
    }
}

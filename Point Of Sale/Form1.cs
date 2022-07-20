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
using Point_Of_Sale.cashier;

namespace Point_Of_Sale
{
    public partial class Form1 : Form
    {
        login log = new login();
        string username, password;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.ForeColor = Color.Black;
            txtUsername.Text = "";
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.ForeColor = Color.Black;
            txtPassword.Text = "";
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

        private void btnCashier_Click(object sender, EventArgs e)
        {
            CashierLogin form = new CashierLogin();
            form.Show();
            Hide();
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
                    main form = new main();
                    form.Show();
                    Hide();
                    break;
                case 11: // if correct username and password is correct but user level is for cashier
                    MessageBox.Show("This user is not allowed to access the admin.");
                    break;
                case 2: // if password is incorrect
                    errorPass.Text = "Incorrect Password";
                    errorPass.Visible = true;
                    break;
            }
        }
    }
}

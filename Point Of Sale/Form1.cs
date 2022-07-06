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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (log.ifEmpty(txtUsername.Text))
            {
                MessageBox.Show("Invalid username. Try again");
            }
            else
            {
                username = txtUsername.Text;
                if (log.ifEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Invalid password. Try again");
                }
                else
                {
                    password = txtPassword.Text;
                    int result = log.userLogin(username, password);

                    switch (result)
                    {
                        case 0: // if user does not exist
                            MessageBox.Show("Invalid username and password. User does not exist");
                            break;
                        case 1: // if correct username and password is correct
                            main form = new main();
                            form.Show();
                            break;
                        case 2: // if password is incorrect
                            MessageBox.Show("Incorrect password. Try again");
                            break;
                    }
                }
            }


        }
    }
}

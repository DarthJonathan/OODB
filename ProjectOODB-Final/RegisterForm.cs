using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOODB_Final
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TO:DO Make "Email have already been registered error

            if(string.IsNullOrWhiteSpace(nameField.Text))
            {
                MessageBox.Show("Please Fill The Name Field");
            }
            else if (string.IsNullOrWhiteSpace(emailField.Text))
            {
                MessageBox.Show("Please Fill The Email Field");
            }else if(
                !emailField.Text.Contains(".com") ||
                emailField.Text.IndexOf('@') != emailField.Text.LastIndexOf('@')
                )
            {
                MessageBox.Show("Email is not Valid");
            }
            else if(string.IsNullOrWhiteSpace(passwordField.Text))
            {
                MessageBox.Show("Please Fill The Password Field");
            }
            else if (string.IsNullOrWhiteSpace(addressField.Text))
            {
                MessageBox.Show("Please Fill The Address Field");
            }
            else if (string.IsNullOrWhiteSpace(phoneField.Text))
            {
                MessageBox.Show("Please Fill The Phone Field");
            }else if(phoneField.Text.Length > 13 || phoneField.Text.Length < 11 || !phoneField.Text.StartsWith("08"))
            {
                MessageBox.Show("Phone Number is Not Valid");
            }
            else
            {
                String UserID = "";

                //TO:DO Check user id with database if existing person is available

                User newUser = new User(nameField.Text, emailField.Text, passwordField.Text, addressField.Text, phoneField.Text, UserID, "Customer");
            }

        }
    }
}

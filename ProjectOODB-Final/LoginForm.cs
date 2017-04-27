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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //Login Button
        private void loginButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(emailForm.Text))
            {
                MessageBox.Show("E-mail Must Be Filled!");
            }else if (string.IsNullOrWhiteSpace(passwordForm.Text))
            {
                MessageBox.Show("Password Must Be Filled!");
            }else
            {
                //TO:DO check password and username on database
                if(true)
                {
                    SessionData.isSignedIn = true;
                    //TO:DO take the user type from database
                    SessionData.loginType = "Customer";
                    MessageBox.Show("You are now logged in!");
                    this.Close();
                }else
                {
                    MessageBox.Show("Wrong username or password!");
                }
            }
        }

        //Register Now Button
        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm regis = new RegisterForm();
            regis.MdiParent = this.MdiParent;
            regis.Show();
        }
    }
}

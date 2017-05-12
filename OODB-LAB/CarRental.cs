using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OODB_LAB
{
    public partial class CarRental : Form
    {
        LoginForm loginForm = new LoginForm();
        RegisterForm registerForm = new RegisterForm();

        public CarRental()
        {
            InitializeComponent();

            //So the user cannot rescale the window, TO:DO user can still minimize fix this
            this.WindowState = FormWindowState.Maximized;

            //Hide and show menu if logged in
            if(SessionData.isSignedIn == false)
            {
                this.signOutToolStripMenuItem.Visible = false;
                this.loginToolStripMenuItem.Visible = true;
                this.registerToolStripMenuItem.Visible = true;
                this.serviceToolStripMenuItem.Visible = false;
                this.staffMenuToolStripMenuItem.Visible = false;
            }
            else if(SessionData.loginType.Equals("Staff"))
            {
                this.signOutToolStripMenuItem.Visible = true;
                this.loginToolStripMenuItem.Visible = false;
                this.registerToolStripMenuItem.Visible = false;
                this.serviceToolStripMenuItem.Visible = false;
            }else if(SessionData.loginType.Equals("Customer"))
            {
                this.signOutToolStripMenuItem.Visible = true;
                this.loginToolStripMenuItem.Visible = false;
                this.registerToolStripMenuItem.Visible = false;
                this.staffMenuToolStripMenuItem.Visible = false;
            }
           
        }

        private void footerTime_Tick(object sender, EventArgs e)
        {
            footertimestat.Text = "Welcome to The Best Car Rental in Jakarta | " + DateTime.Now.ToLongDateString();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginForm = new LoginForm();

            if (this.MdiChildren.Count() > 0)
            {
                foreach (Form child in this.MdiChildren)
                {
                    if (this.MdiChildren.Contains(loginForm))
                    {
                        child.Close();
                    }

                }
            }
            else
            {
                loginForm.MdiParent = this;
                loginForm.Show();
            }
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registerForm = new RegisterForm();

            if (this.MdiChildren.Count() > 0)
            {
                foreach (Form child in this.MdiChildren)
                {
                    if (this.MdiChildren.Contains(registerForm))
                    {
                        child.Close();
                    }

                }
            }
            else
            {
                registerForm.MdiParent = this;
                registerForm.Show();
            }
        }
    }

    
}

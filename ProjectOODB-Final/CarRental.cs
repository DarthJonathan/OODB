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
    public partial class CarRental : Form
    {
        LoginForm loginForm = new LoginForm();

        public CarRental()
        {
            InitializeComponent();
        }

        private void footerTime_Tick(object sender, EventArgs e)
        {
            footertimestat.Text = "Welcome to The Best Car Rental in Jakarta | " + DateTime.Now.ToLongDateString();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
    }

    
}

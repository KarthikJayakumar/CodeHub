using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEmailService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the btnTrigger control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <author>karthik.jayakumar - 04-Apr-17 - 13:23 PM</author>
        private void btnTrigger_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Enter User Name");
                txtUserName.Focus();
            }
            else if (string.IsNullOrEmpty(txtUid.Text))
            {
                MessageBox.Show("Enter UID");
                txtUid.Focus();
            }
            else
            {
                EmailService.EmailServiceClient serviceCalling = new EmailService.EmailServiceClient();
                int value = serviceCalling.TriggerMail(txtUserName.Text, txtUid.Text);
                if (value == 1)
                {
                    MessageBox.Show("Mail sent!");
                }
                else
                {
                    MessageBox.Show("Mail have not sent!. Check the UserName / UID");
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <author>karthik.jayakumar - 04-Apr-17 - 13:26 PM</author>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

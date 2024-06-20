using MultiForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApplication
{
    public partial class Form2 : Form
    {
        public Database D1;
        public Form2(Database Dt)
        {
            InitializeComponent();
            D1 = Dt;
        }

        /// <summary>
        /// Set Panel visbilities to Customer Sign in when loading the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            customerPanel.Visible = true;
            employeePanel.Visible = false;
            createNewAccountPanel.Visible = true;
        }

        /// <summary>
        /// Close Form when user signs in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customerSignInButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Load Employee Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void employeeSignInButton_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(D1);
            f1.Show();
            this.Close();
        }

        /// <summary>
        /// Switch Page to Customer Sign in by setting Panel visibilities
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void switchToCustomerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            employeePanel.Visible = false;
            customerPanel.Visible = true;
            createNewAccountPanel.Visible = true;
        }

        /// <summary>
        /// Switch Page to Employee Sign in by setting Panel visibilities
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void switchToEmployeeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            employeePanel.Visible = true;
            customerPanel.Visible = false;
            createNewAccountPanel.Visible = false;
        }

    }
}

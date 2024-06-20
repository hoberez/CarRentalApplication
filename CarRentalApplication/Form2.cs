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

        private void Form2_Load(object sender, EventArgs e)
        {
            customerPanel.Visible = true;
            employeePanel.Visible = false;
            createNewAccountPanel.Visible = true;
        }


        private void customerSignInButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createNewAccountPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employeeSignInButton_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(D1);
            f1.Show();
            this.Close();
        }

        private void switchToCustomerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            employeePanel.Visible = false;
            customerPanel.Visible = true;
            createNewAccountPanel.Visible = true;
        }

        private void switchToEmployeeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            employeePanel.Visible = true;
            customerPanel.Visible = false;
            createNewAccountPanel.Visible = false;
        }

        private void customerPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

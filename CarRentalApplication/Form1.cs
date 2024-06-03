using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CarRentalApplication
{
    public partial class Form1 : Form
    {
        //public SqlConnection myConnection;
        // public SqlCommand myCommand;
        // public SqlDataReader myReader;

        public Form1()
        {
            InitializeComponent();
            ///////////////////////////////
            //operation.Items.Clear();
            // operation.Items.Add("Show all");
            // operation.Items.Add("Show with starting grade: ");
            //////////////////////////////////
            ///

            listView1.View = View.Details;
            listView2.View = View.Details;
            listView3.View = View.Details;
            listView4.View = View.Details;

            // String connectionString = "Server = DESKTOP-PL0JUL4; Database = 291_FinalProject; Trusted_Connection = yes;";

            // SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

            ///  try
            // {
            //     myConnection.Open(); // Open connection
            //      myCommand = new SqlCommand();
            //       myCommand.Connection = myConnection; // Link the command stream to the connection
            //  }
            //  catch (Exception e)
            //   {
            //     MessageBox.Show(e.ToString(), "Error");
            //      this.Close();
            //   }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;

            panel8.Visible = false;
            panel9.Visible = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;

            panel8.Visible = true;
            panel9.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void return2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click_1(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel7.Visible = true;

            panel3.Visible = true;
            panel5.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel7.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel7.Visible = true;

            panel3.Visible = false;
            panel5.Visible = true;

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

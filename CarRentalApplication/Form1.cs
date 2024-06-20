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
using MultiForm;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Diagnostics.Eventing.Reader;



namespace CarRentalApplication
{
    public partial class Form1 : Form
    {
        public Database D1;


        public Form1(Database Dt)
        {
            InitializeComponent();
            D1 = Dt;

            menuChangeButton.FlatAppearance.BorderSize = 0;
            menuReportsButton.FlatAppearance.BorderSize = 0;
            menuSignOutButton.FlatAppearance.BorderSize = 0;
        }

        /// <summary>
        /// Set panel visibilities and fill combo boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            employeePanel.Visible = true;

            menuPanel.Visible = false;
            setAllEmployeePagesFalse();
            sectionTitleLabel.Text = "General";
            generalPanel.Visible = true;

            fillBranchComboBox();
            fillCarTypeComboBox();
        }

        /// <summary>
        /// User is shown the modify panel with all the text boxes and combo boxes set to the selected car
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifyButton_Click(object sender, EventArgs e)
        {
            // Does not transfer to modify panel if no car is selected in the datagridview carData
            if (carData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Error: Must select a row to modify by clicking on the left-most column of the table");
                return;
            }

            // set panel visibilities
            setAllEmployeePagesFalse();
            changeCarPanel.Visible = true;
            modifyCarPanel.Visible = true;
            AddCarPanel.Visible = false;
            showCarTypeButton.Visible = true;
            menuPanel.Visible = false;

            // set textboxes and selecteditem in comboboxes to the selected car in carData
            modifyCarIDValue.Text = carData.SelectedRows[0].Cells["CarID"].Value.ToString();
            modifyColorText.Text = carData.SelectedRows[0].Cells["Colour"].Value.ToString();
            modifyManufacturerText.Text = carData.SelectedRows[0].Cells["Manufacturer"].Value.ToString();
            modifyModelIDComboBox.SelectedIndex = modifyModelIDComboBox.Items.IndexOf(carData.SelectedRows[0].Cells["ModelID"].Value.ToString().Trim());
            modifyBranchIDComboBox.SelectedItem = carData.SelectedRows[0].Cells["BranchID"].Value.ToString().Trim();
        }

        /// <summary>
        /// Transfer user to the Add Page where user can add a car by setting panel visibilities
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            setAllEmployeePagesFalse();
            changeCarPanel.Visible = true;

            modifyCarPanel.Visible = false;
            AddCarPanel.Visible = true;
            showCarTypeButton.Visible = true;
        }

        /// <summary>
        /// Set the side menu panel visibility when menu button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox menu = (CheckBox)sender;
            if (menu.Checked)
            {
                menuPanel.Visible = true;
            }
            else
            {
                menuPanel.Visible = false;
            }
        }

        /// <summary>
        /// Change Panel visibilities to show the General Section
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuGeneralButton_CheckedChanged(object sender, EventArgs e)
        {
            setAllEmployeePagesFalse();
            generalPanel.Visible = true;
            sectionTitleLabel.Text = "General";
        }

        /// <summary>
        /// Change Panel visibilities to show the Change Car Information Section
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuChangeButton_CheckedChanged(object sender, EventArgs e)
        {
            setAllEmployeePagesFalse();
            viewCarsPanel.Visible = true;
            sectionTitleLabel.Text = "Change Car Information";
        }

        /// <summary>
        /// Change Panel viaibilities to show the Reports Section
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuReportsButton_CheckedChanged(object sender, EventArgs e)
        {
            setAllEmployeePagesFalse();
            reportsPanel.Visible = true;
            sectionTitleLabel.Text = "Reports";
        }

        private void setAllEmployeePagesFalse()
        {
            generalPanel.Visible = false;
            accountInformationPanel.Visible = false;
            viewCarsPanel.Visible = false;
            reportsPanel.Visible = false;
            changeCarPanel.Visible = false;
        }

        /// <summary>
        /// Close the Employee Form when user 'signs out'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuSignOutButton_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Refreshes/Shows all the cars in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                D1.query("select * from Car");
                carData.Rows.Clear();
                while (D1.myReader.Read())
                {
                    carData.Rows.Add(D1.myReader["CarID"].ToString(), D1.myReader["Manufacturer"].ToString(), D1.myReader["Colour"].ToString()
                        , D1.myReader["BranchID"].ToString(), D1.myReader["ModelID"].ToString());
                }

                D1.myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                D1.myReader.Close();
            }

        }

        /// <summary>
        /// Return user to the Change Car Information Section  from the add or modify panels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goBackButton_Click(object sender, EventArgs e)
        {
            changeCarPanel.Visible = false;
            viewCarsPanel.Visible = true;

            resetAddPanel();
        }

        /// <summary>
        /// Insert a new car into the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCarButton_Click(object sender, EventArgs e)
        {

            string insertQuery = "INSERT INTO Car (CarID, Colour, Manufacturer, ModelID, BranchID) VALUES (@CarID, @Colour, @Manufacturer, @ModelID, @BranchID)";

            D1.myCommand.CommandText = insertQuery; //CommandText allows us to query the database. Query is an umbrella term for some operations like insert, etc.
            D1.myCommand.Parameters.Clear(); //Clear any previous parameters to prevent conflict

            //Insert the correct values into placeholder location
            D1.myCommand.Parameters.AddWithValue("@CarID", addCarIDText.Text);
            D1.myCommand.Parameters.AddWithValue("@Colour", addColorText.Text);
            D1.myCommand.Parameters.AddWithValue("@Manufacturer", addManufacturerText.Text);
            D1.myCommand.Parameters.AddWithValue("@ModelID", addModelIDComboBox.SelectedItem);
            D1.myCommand.Parameters.AddWithValue("@BranchID", addBranchIDComboBox.SelectedItem);

      
            try
            {
                int rowsAffec = D1.myCommand.ExecuteNonQuery(); // Execute the command
                MessageBox.Show(insertQuery);
                MessageBox.Show("Rental information added to the database successfully.", "Success");
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                MessageBox.Show("Failed to add rental information to the database." +
                    "\n- Make sure to enter a unique Car ID and have inputted in all fields", "Error");
            }

        }

        /// <summary>
        /// Modify a Car in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifyCarButton_Click(object sender, EventArgs e)
        {

            string carID = modifyCarIDValue.Text;
            string colour = modifyColorText.Text; //adding .this is necessary to avoid a naming error
            string manufacturer = modifyManufacturerText.Text; //adding .this is necessary to avoid a naming error
            string modelID = modifyModelIDComboBox.SelectedItem.ToString();
            string branchID = modifyBranchIDComboBox.SelectedItem.ToString();


            //Display what info is going to be modified
            string carInfo = $"Car ID: {carID}\nColour: {colour}\nManufacturer: {manufacturer}\nModel ID: {modelID}\nBranch ID: {branchID}";
            MessageBox.Show(carInfo, "Car Information");

            //We use the query CommandText we set up. We set up the modification locations with SQL injection safe placeholders (@)
            string modifyQuery = "UPDATE Car SET Colour = @Colour, Manufacturer = @Manufacturer, ModelID = @ModelID, BranchID = @BranchID WHERE CarID = @CarID";

            D1.myCommand.CommandText = modifyQuery; //CommandText allows us to query the database. Query is an umbrella term for some operations like insert, etc.
            D1.myCommand.Parameters.Clear(); //Clear any previous parameters to prevent conflict

            //Insert the correct values into placeholder location
            D1.myCommand.Parameters.AddWithValue("@CarID", carID);
            D1.myCommand.Parameters.AddWithValue("@Colour", colour);
            D1.myCommand.Parameters.AddWithValue("@Manufacturer", manufacturer);
            D1.myCommand.Parameters.AddWithValue("@ModelID", modelID);
            D1.myCommand.Parameters.AddWithValue("@BranchID", branchID);

            int rowsAffec = D1.myCommand.ExecuteNonQuery(); // Execute the command

            //Display an error if something goes wrong in order to provide clarity for the user
            if (rowsAffec > 0)
            {
                MessageBox.Show("Car information modified in the database successfully.", "Success");
            }
            else
            {
                MessageBox.Show("Failed to modify car information in the database.", "Error");
            }
        }

        /// <summary>
        /// Delete a Car in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButtonn_Click(object sender, EventArgs e)
        {
            if (carData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Error: Must select a row to delete by clicking on the left-most column of the table");
            }
            //Optional: rename varibales for convenience
            string carID = carData.SelectedRows[0].Cells["CarID"].Value.ToString();

            //Show what car is going to be deleted
            string carInfo = $"Car ID: {carID}";
            MessageBox.Show(carInfo, "Car Information");

            //We use the query CommandText we set up. We set up the deletion locations with SQL injection safe placeholders (@)
            string deleteQuery = "DELETE FROM Car WHERE CarID = @CarID";

            D1.myCommand.CommandText = deleteQuery; //Set the command text to the DELETE statement
            D1.myCommand.Parameters.Clear(); // Clear any previous parameters to prevent conflict

            // Delete the parameteres that will be used in the SqlCommand (which above we have made to be DELETE). AddWithValue bascially means add the SQL command
            D1.myCommand.Parameters.AddWithValue("@CarID", carID);


            try
            {
                D1.myCommand.ExecuteNonQuery(); // Execute the command
                MessageBox.Show("Car information delete from the database successfully.", "Success");
            }
            catch (Exception e2)
            {
                MessageBox.Show("Failed to delete car information in the database as the car has already been reserved.", "Error");
            }
        }

        /// <summary>
        /// Search Car based on component chosen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchComboBox.SelectedItem == null)
            {
                MessageBox.Show("Error: Must select an item from the combobox and enter a value before searching.");
                return;
            }

            try
            {
                D1.query("select * from Car where " + searchComboBox.SelectedItem + "=\'" + searchTextBox.Text + "\'");
                carData.Rows.Clear();
                while (D1.myReader.Read())
                {
                    carData.Rows.Add(D1.myReader["CarID"].ToString(), D1.myReader["Manufacturer"].ToString(), D1.myReader["Colour"].ToString()
                        , D1.myReader["BranchID"].ToString(), D1.myReader["ModelID"].ToString());
                }

                D1.myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                D1.myReader.Close();
            }

        }

        /// <summary>
        ///  Fill Combo boxes with Branches
        /// </summary>
        private void fillBranchComboBox()
        {
            try
            {
                D1.query("select * from Branch");
                addBranchIDComboBox.Items.Clear();
                modifyBranchIDComboBox.Items.Clear();
                while (D1.myReader.Read())
                {
                    Address address = new Address(D1.myReader["Street"].ToString().Trim(), D1.myReader["PostalCode"].ToString().Trim(),
                        D1.myReader["City"].ToString().Trim(), D1.myReader["Province"].ToString().Trim());
                    Branch branch = new Branch(D1.myReader["BranchID"].ToString().Trim(), D1.myReader["BranchName"].ToString().Trim(), address);

                    addBranchIDComboBox.Items.Add(branch.BranchID);
                    modifyBranchIDComboBox.Items.Add(branch.BranchID);
                }
                D1.myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                D1.myReader.Close();
            }
        }

        /// <summary>
        ///  Fill Combo box with Car Types
        /// </summary>
        private void fillCarTypeComboBox()
        {
            try
            {
                D1.query("select * from CarType");
                addModelIDComboBox.Items.Clear();
                modifyModelIDComboBox.Items.Clear();
                while (D1.myReader.Read())
                {
                    Rate rate = new Rate(Convert.ToSingle(D1.myReader["DailyRate"]), Convert.ToSingle(D1.myReader["WeeklyRate"]), Convert.ToSingle(D1.myReader["MonthlyRate"]));
                    CarType carType = new CarType(D1.myReader["ModelID"].ToString().Trim(), D1.myReader["ModelDesc"].ToString().Trim(),
                        int.Parse(D1.myReader["Capacity"].ToString()), rate);

                    addModelIDComboBox.Items.Add(carType.ModelID);
                    modifyModelIDComboBox.Items.Add(carType.ModelID);
                }
                D1.myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                D1.myReader.Close();
            }
        }

        /// <summary>
        /// Reset Text boxes and combo boxes in the Add Panel to null/empty
        /// </summary>
        private void resetAddPanel()
        {
            addCarIDText.Text = "";
            addBranchIDComboBox.SelectedItem = null;
            addManufacturerText.Text = "";
            addColorText.Text = "";
            addModelIDComboBox.SelectedItem = null;
        }

        /// <summary>
        ///  Reset Text Boxes and Combo Box values to the original values of the selected Car
        /// </summary>
        private void resetModifyPanel()
        {
            modifyCarIDValue.Text = carData.SelectedRows[0].Cells["CarID"].Value.ToString();
            modifyColorText.Text = carData.SelectedRows[0].Cells["Colour"].Value.ToString();
            modifyManufacturerText.Text = carData.SelectedRows[0].Cells["Manufacturer"].Value.ToString();
            modifyModelIDComboBox.SelectedIndex = modifyModelIDComboBox.Items.IndexOf(carData.SelectedRows[0].Cells["ModelID"].Value.ToString().Trim());
            modifyBranchIDComboBox.SelectedItem = carData.SelectedRows[0].Cells["BranchID"].Value.ToString().Trim();

        }

        /// <summary>
        /// Reset Add Car Section
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCarResetButton_Click(object sender, EventArgs e)
        {
            resetAddPanel();
        }

        /// <summary>
        /// Reset Modify Car Section
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifyCarResetButton_Click(object sender, EventArgs e)
        {
            resetModifyPanel(); 
        }

        /// <summary>
        /// Show data for Colour with the highest sales by month
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button21_Click(object sender, EventArgs e)
        {
            reportData.Columns.Clear();
            reportData.Columns.Add("Colour", "Colour");
            reportData.Columns.Add("Total_Rented", "Total Rented");
            int month = report1ComboBox.SelectedIndex + 1;

            string query = "select Colour , count(*) as Total_Rented from (select C.Colour, dateFrom from Car as C, " +
                "RentalTransaction as RT where C.CarID = RT.CarID) T where month(T.DateFrom) = " + month.ToString() +
                "group by Colour order by Total_Rented desc;";

            try
            {
                D1.query(query);


                carData.Rows.Clear();
                while (D1.myReader.Read())
                {
                    reportData.Rows.Add(D1.myReader["Colour"].ToString(), D1.myReader["Total_Rented"].ToString());
                }

                D1.myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                D1.myReader.Close();
            }
        }

        /// <summary>
        /// Show data for Customers who have rented previously
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            reportData.Columns.Clear();
            reportData.Columns.Add("CustomerID", "Customer ID");
            reportData.Columns.Add("FirstName", "First Name");
            reportData.Columns.Add("LastName", "Last Name");
            reportData.Columns.Add("Total_Rents", "Total Rents");
            int month = report1ComboBox.SelectedIndex + 1;

            string query = "select CustomerID, FirstName, LastName, count(*) as Total_Rents from (select C.CustomerID, FirstName, LastName from Customer as C, RentalTransaction as RT where C.CustomerID = RT.CustomerID) T group by CustomerID, FirstName, LastName having count(*) > 1;";
            try
            {
                D1.query(query);


                carData.Rows.Clear();
                while (D1.myReader.Read())
                {
                    reportData.Rows.Add(D1.myReader["CustomerID"].ToString(), D1.myReader["FirstName"].ToString(),
                        D1.myReader["LastName"].ToString(), D1.myReader["Total_Rents"].ToString());
                }

                D1.myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                D1.myReader.Close();
            }
        }

         /// <summary>
         /// Show max and average daily rates of every branch
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            reportData.Columns.Clear();
            reportData.Columns.Add("BranchID", "Branch ID");
            reportData.Columns.Add("BranchName", "Branch Name");
            reportData.Columns.Add("avg_daily_rate", "Average Daily Rate");
            reportData.Columns.Add("max_daily_rate", "Max. Daily Rate");
            int month = report1ComboBox.SelectedIndex + 1;

            string query = "Select B.BranchID, B.BranchName, avg(DailyRate) as avg_daily_rate, max(DailyRate) as max_daily_Rate From CarType CT, Car C, Branch as B Where C.ModelID = CT.ModelID  and C.BranchID = B.BranchID Group by B.BranchID, B.BranchName Order by avg_daily_rate Desc;";
            try
            {
                D1.query(query);


                carData.Rows.Clear();
                while (D1.myReader.Read())
                {
                    reportData.Rows.Add(D1.myReader["BranchID"].ToString(), D1.myReader["BranchName"].ToString(),
                        float.Parse(D1.myReader["avg_daily_rate"].ToString()).ToString("0.00"), D1.myReader["max_daily_rate"].ToString());
                }

                D1.myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                D1.myReader.Close();
            }

        }

        /// <summary>
        /// Show the Top 1 Branch with the most profit in 2024
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            reportData.Columns.Clear();
            reportData.Columns.Add("FromBranchID", "Branch ID");
            reportData.Columns.Add("BranchName", "Branch Name");
            reportData.Columns.Add("Profit", "Profit");

            string query = "Select Top 1 FromBranchID, B.BranchName, sum(TotalCost) as Profit \r\nFrom RentalTransaction as RT, Branch as B\r\nWhere B.BranchID = FromBranchID and DateFrom >= '2024-01-01' and DateTo <= '2024-12-31' \r\nGroup by FromBranchID, B.BranchName\r\nOrder by Profit Desc;";
            try
            {
                D1.query(query);


                carData.Rows.Clear();
                while (D1.myReader.Read())
                {
                    reportData.Rows.Add(D1.myReader["FromBranchID"].ToString(), D1.myReader["BranchName"].ToString(), D1.myReader["Profit"].ToString());
                }

                D1.myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                D1.myReader.Close();
            }
        }

        /// <summary>
        ///  Show the manufacturers that are not being rented at every branch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            reportData.Columns.Clear();
            reportData.Columns.Add("Manufacturer", "Manufacturer");

           string query = "Select Manufacturer From Car Group By Manufacturer\r\nHaving count(Distinct BranchID) != (Select count(BranchID)\r\nFrom Branch);\r\n";
            try
            {
                D1.query(query);


                carData.Rows.Clear();
                while (D1.myReader.Read())
                {
                    reportData.Rows.Add(D1.myReader["Manufacturer"].ToString());
                }

                D1.myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                D1.myReader.Close();
            }

        }

        /// <summary>
        /// show all values in the Branch Table form the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            branchCarTypeData.Columns.Clear();
            branchCarTypeData.Columns.Add("BranchID", "Branch ID");
            branchCarTypeData.Columns.Add("BranchName", "Branch Name");
            branchCarTypeData.Columns.Add("Street", "Street");


            string query = "Select * From Branch;";
            try
            {
                D1.query(query);


                carData.Rows.Clear();
                while (D1.myReader.Read())
                {
                    branchCarTypeData.Rows.Add(D1.myReader["BranchID"].ToString(), D1.myReader["BranchName"].ToString(), D1.myReader["Street"].ToString());
                }

                D1.myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                D1.myReader.Close();
            }

        }

        /// <summary>
        /// show all the car types in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showCarTypeButton_Click(object sender, EventArgs e)
        {
            branchCarTypeData.Columns.Clear();
            branchCarTypeData.Columns.Add("ModelID", "Model ID");
            branchCarTypeData.Columns.Add("ModelDesc", "Car Type");
            branchCarTypeData.Columns.Add("Capacity", "# Seats");


            string query = "Select * From CarType;";
            try
            {
                D1.query(query);


                carData.Rows.Clear();
                while (D1.myReader.Read())
                {
                    branchCarTypeData.Rows.Add(D1.myReader["ModelID"].ToString(), D1.myReader["ModelDesc"].ToString(), D1.myReader["Capacity"].ToString());
                }

                D1.myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                D1.myReader.Close();
            }

        }
    }
}

using MultiForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CarRentalApplication
{
    public partial class Form5 : Form
    {
        Database D1;
        Dictionary<Panel, Car> carsFiltered;
        Dictionary<string, CarType> carTypesFiltered;
        List<Branch> branches;
        bool newCustomer;

        public Form5()
        {
            this.D1 = new Database();
            this.carsFiltered = new Dictionary<Panel, Car>();
            this.carTypesFiltered = new Dictionary<string, CarType>();
            this.branches = new List<Branch>();
            this.newCustomer = false;
            InitializeComponent();
        }

        /// <summary>
        /// Sets and clears the form when loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form5_Load(object sender, EventArgs e)
        {
            mainPagePanel.Visible = true;
            transactionsPanel.Visible = false;
            filterPanel.Visible = false;
            fillBranchComboBox();
            carFlowPanel.Controls.Clear();
            search.FlatAppearance.BorderSize = 0;
            sameBranchButton.FlatAppearance.BorderSize = 0;
            filterButton.FlatAppearance.BorderSize = 0;
        }

        /// <summary>
        /// Loads another form for user to sign in to as a customer or employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void signInOutButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(D1);
            f2.Show();
        }

        /// <summary>
        /// Searches then fills page with cars available based on the inputted date and branch pick up and drop off location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessage = new StringBuilder("Error:");
            string dateErrorMessage = "\n- Must select a drop off date equal or greater than the pick up date.";
            string locationErrorMessage = "\n- Must select pick up and drop off branch locations.";

            bool dateError = dateTo.Value < dateFrom.Value;
            bool locationError = pickUpComboBox.SelectedItem == null || dropOffComboBox.SelectedItem == null;

            if (dateError)
                errorMessage.Append(dateErrorMessage);

            if (locationError)
                errorMessage.Append(locationErrorMessage);

            // Search does not go through if error exists in user input
            if (dateError || locationError)
            {
                MessageBox.Show(errorMessage.ToString());
                return;
            }

            // clear previous search history
            carFlowPanel.Controls.Clear();
            this.carsFiltered.Clear();
            this.carTypesFiltered.Clear();

            string query = String.Format("select * From Car as C, CarType as CT where C.ModelID = CT.ModelID and C.BranchID = \'{0}\' " +
                "and CarID not in (select C.CarID From Car as C, RentalTransaction as RT where C.CarID = RT.CarID and " +
                "(\'{1}\' between RT.dateFrom and RT.dateTo or \'{2}\' between RT.dateFrom and RT.dateTo));",
                branches[pickUpComboBox.SelectedIndex].BranchID, dateFrom.Value.ToString("yyyy-MM-dd"), dateTo.Value.ToString("yyyy-MM-dd"));
            try
            {
                D1.query(query);

                while (D1.myReader.Read())
                {
                    Car car = new Car(D1.myReader["CarID"].ToString().Trim(), D1.myReader["Manufacturer"].ToString().Trim(), D1.myReader["Colour"].ToString().Trim(),
                        D1.myReader["ModelID"].ToString().Trim(), D1.myReader["BranchID"].ToString().Trim());

                    Rate rate = new Rate(Convert.ToSingle(D1.myReader["DailyRate"]), Convert.ToSingle(D1.myReader["WeeklyRate"]), Convert.ToSingle(D1.myReader["MonthlyRate"]));
                    CarType carType = new CarType(D1.myReader["ModelID"].ToString().Trim(), D1.myReader["ModelDesc"].ToString().Trim(),
                        int.Parse(D1.myReader["Capacity"].ToString()), rate);

                    Panel panel = createCarPanel(car, carType);

                    carFlowPanel.Controls.Add(panel);
                    carsFiltered.Add(panel, car);

                    if (!carTypesFiltered.ContainsKey(carType.ModelID))
                    {
                        carTypesFiltered.Add(carType.ModelID, carType);
                    }
                }
                D1.myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(query);
                MessageBox.Show(e3.ToString(), "Error");
                D1.myReader.Close();
            }
        }

        /// <summary>
        /// Create a panel to display on the main page of a car and its information
        /// </summary>
        /// <param name="car"></param>
        /// <param name="carType"></param>
        /// <returns>Panel object containing information of a car</returns>
        private Panel createCarPanel(Car car, CarType carType)
        {
            Panel panel = new Panel();
            Label manufacturerLabel = new Label();
            Label carIDLabel = new Label();
            Label modelDescLabel = new Label();
            Label colourLabel = new Label();
            Label capacityLabel = new Label();
            Label dailyRateTitleLabel = new Label();
            Label weeklyRateTitleLabel = new Label();
            Label monthlyRateTitleLabel = new Label();
            Label dailyRateLabel = new Label();
            Label weeklyRateLabel = new Label();
            Label monthlyRateLabel = new Label();
            Label rateCostLabel = new Label();
            Label totalLabel = new Label();

            panel.Controls.Add(manufacturerLabel);
            panel.Controls.Add(carIDLabel);
            panel.Controls.Add(modelDescLabel);
            panel.Controls.Add(colourLabel);
            panel.Controls.Add(capacityLabel);
            panel.Controls.Add(dailyRateTitleLabel);
            panel.Controls.Add(weeklyRateTitleLabel);
            panel.Controls.Add(monthlyRateTitleLabel);
            panel.Controls.Add(dailyRateLabel);
            panel.Controls.Add(weeklyRateLabel);
            panel.Controls.Add(monthlyRateLabel);
            panel.Controls.Add(rateCostLabel);
            panel.Controls.Add(totalLabel);

            panel.Size = new Size(964, 140);
            panel.BackColor = Color.White;
            panel.Click += carPanel_Click;

            Font defaultFont = new Font("Segoe UI", 11F);
            Font rateFont = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Color defaultForeColor = Color.Black;
            Color rateColor = Color.Green;

            modifyLabel(carIDLabel, car.CarID, new Point(38, 24), defaultFont, defaultForeColor);
            modifyLabel(manufacturerLabel, car.Manufacturer, new Point(38, 56), new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0), defaultForeColor);
            modifyLabel(modelDescLabel, carType.ModelDesc, new Point(38, 97), defaultFont, defaultForeColor);
            modifyLabel(colourLabel, car.Colour, new Point(200, 24), defaultFont, defaultForeColor);
            modifyLabel(capacityLabel, carType.Capacity.ToString() + " Seats", new Point(200, 56), defaultFont, defaultForeColor);
            modifyLabel(dailyRateTitleLabel, "Daily Rate", new Point(326, 24), defaultFont, defaultForeColor);
            modifyLabel(weeklyRateTitleLabel, "Weekly Rate", new Point(450, 24), defaultFont, defaultForeColor);
            modifyLabel(monthlyRateTitleLabel, "Monthly Rate", new Point(580, 24), defaultFont, defaultForeColor);
            modifyLabel(dailyRateLabel, "$" + carType.Rate.DailyRate.ToString(), new Point(326, 56), rateFont, rateColor);
            modifyLabel(weeklyRateLabel, "$" + carType.Rate.WeeklyRate.ToString(), new Point(450, 56), rateFont, rateColor);
            modifyLabel(monthlyRateLabel, "$" + carType.Rate.MonthlyRate.ToString(), new Point(580, 56), rateFont, rateColor);
            modifyLabel(rateCostLabel, carType.Rate.calculateCost((dateTo.Value - dateFrom.Value).Days + 1).ToString("c2"), new Point(720, 56), rateFont, rateColor);
            modifyLabel(totalLabel, "Total", new Point(720, 24), defaultFont, defaultForeColor);
            return panel;
        }

        /// <summary>
        /// Set label values
        /// </summary>
        /// <param name="label"></param>
        /// <param name="name"></param>
        /// <param name="location"></param>
        /// <param name="font"></param>
        /// <param name="foreColor"></param>
        public void modifyLabel(Label label, string name, Point location, Font font, Color foreColor)
        {
            label.AutoSize = true;
            label.Text = name;
            label.Location = location;
            label.Font = font;
            label.ForeColor = foreColor;
        }

        /// <summary>
        /// Go Back to the Main Page From the Transactions Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goBackButton_Click(object sender, EventArgs e)
        {
            transactionsPanel.Visible = false;
            mainPagePanel.Visible = true;
        }

        /// <summary>
        /// Go to transactions page with the selected car
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void carPanel_Click(object sender, EventArgs e)
        {
            // Panel clicked of the car the user chose
            Panel panel = (Panel)sender;

            // Switch from main rental page to the transaction page
            mainPagePanel.Visible = false;
            transactionsPanel.Visible = true;
            existingCustomerPanel.Visible = true;
            customerIDPanel.Visible = false;
            newCustomerPanel.Visible = false;

            // Show car information to be rented on the rental transaction page
            tBrandLabel.Text = carsFiltered[panel].Manufacturer;
            tCarTypeLabel.Text = carTypesFiltered[carsFiltered[panel].ModelID].ModelDesc;
            tCarIDLabel.Text = carsFiltered[panel].CarID;
            tSeatsLabel.Text = carTypesFiltered[carsFiltered[panel].ModelID].Capacity.ToString();
            tColorLabel.Text = carsFiltered[panel].Colour.ToString();
            tPickUpBranchLabel.Text = pickUpComboBox.SelectedItem.ToString();
            tDropOffBranchLabel.Text = dropOffComboBox.SelectedItem.ToString();
            tPickUpDateLabel.Text = dateFrom.Value.ToString("MMMM dd, yyyy");
            tDropOffDateLabel.Text = dateTo.Value.ToString("MMMM dd, yyyy");

            // Calculate the costs, fees and total for the rental
            int daysRented = (dateTo.Value - dateFrom.Value).Days + 1;
            float costValue = carTypesFiltered[carsFiltered[panel].ModelID].Rate.calculateCost(daysRented);
            float feesValue = calculateFees();
            calculationLabel.Text = carTypesFiltered[carsFiltered[panel].ModelID].Rate.getCalculationFormula(daysRented);
            cost.Text = costValue.ToString();
            fees.Text = feesValue.ToString();
            totalCost.Text = (costValue + feesValue).ToString();

        }

        /// <summary>
        /// fill combo boxes with branch values from database
        /// </summary>
        private void fillBranchComboBox()
        {
            try
            {
                D1.query("select * from Branch");

                while (D1.myReader.Read())
                {
                    Address address = new Address(D1.myReader["Street"].ToString().Trim(), D1.myReader["PostalCode"].ToString().Trim(),
                        D1.myReader["City"].ToString().Trim(), D1.myReader["Province"].ToString().Trim());
                    Branch branch = new Branch(D1.myReader["BranchID"].ToString().Trim(), D1.myReader["BranchName"].ToString().Trim(), address);

                    branches.Add(branch);
                    dropOffComboBox.Items.Add(branch.ToString());
                    pickUpComboBox.Items.Add(branch.ToString());
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
        /// Set the drop off location to the same location as the pick up location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sameBranchButton_Click(object sender, EventArgs e)
        {
            dropOffComboBox.SelectedItem = pickUpComboBox.SelectedItem;
        }


        /// <summary>
        /// Set visibilities to the existing customer panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ecYesButton_Click(object sender, EventArgs e)
        {
            newCustomer = false;
            existingCustomerPanel.Visible = false;
            customerIDPanel.Visible = true;
            newCustomerPanel.Visible = false;
            existingCustomerID.Clear();
        }

        /// <summary>
        /// Set visibilities to the the new customer panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ecNoButton_Click(object sender, EventArgs e)
        {
            newCustomer = true;
            existingCustomerPanel.Visible = false;
            customerIDPanel.Visible = false;
            newCustomerPanel.Visible = true;
            refreshCustomerSection();
        }

        /// <summary>
        /// Customer reserves car
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reserveButton_Click(object sender, EventArgs e)
        {
            string transactionsCustomerID = existingCustomerID.Text; // get customer ID if customer is new or existing
            // Handle new customer
            if (newCustomer)
            {
                // Check if user inputs are valid and user-readable message boxes of invalid inputs
                if (checkValidCustomerInformation())
                    return;
                insertCustomer();
                transactionsCustomerID = customerID.Text;
            }
            else // Existing Customer
            {
                if (checkUniqueCustomerID(existingCustomerID.Text))
                {
                    MessageBox.Show("Customer ID does not exist.", "Error");
                    return;
                }
            }
            string rID = generateRegistrationID();
            insertTransaction_2(transactionsCustomerID, rID);

            transactionsPanel.Visible = false;
            mainPagePanel.Visible = true;
            carFlowPanel.Controls.Clear();
        }

        /// <summary>
        /// Insert new customer insto the database
        /// </summary>
        private void insertCustomer()
        {
            string insertQuery = "INSERT INTO Customer (CustomerID, FirstName, LastName, Age, Street, City," +
                "Province, PostalCode, EmailAddress, PhoneNumber) VALUES (@CustomerID, @FirstName, @LastName, @Age, @Street, @City," +
                "@Province, @PostalCode, @EmailAddress, @PhoneNumber)";

            D1.myCommand.CommandText = insertQuery; //CommandText allows us to query the database. Query is an umbrella term for some operations like insert, etc.
            D1.myCommand.Parameters.Clear(); //Clear any previous parameters to prevent conflict

            //Insert the correct values into placeholder location
            D1.myCommand.Parameters.AddWithValue("@CustomerID", customerID.Text);
            D1.myCommand.Parameters.AddWithValue("@FirstName", firstName.Text);
            D1.myCommand.Parameters.AddWithValue("@LastName", lastName.Text);
            D1.myCommand.Parameters.AddWithValue("@Age", Int32.Parse(age.Text));
            D1.myCommand.Parameters.AddWithValue("@Street", street.Text);
            D1.myCommand.Parameters.AddWithValue("@City", city.Text);
            D1.myCommand.Parameters.AddWithValue("@Province", province.Text);
            D1.myCommand.Parameters.AddWithValue("@PostalCode", postalCode.Text);
            D1.myCommand.Parameters.AddWithValue("@EmailAddress", emailAddress.Text);
            D1.myCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber.Text);

            try
            {
                D1.myCommand.ExecuteNonQuery(); // Execute the command
                //MessageBox.Show(insertQuery);
                MessageBox.Show("New customer information added successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Failed to add your customer information into the database. Please try again!", "Error");
            }
        }


        /// <summary>
        /// insert Transaction into the database
        /// </summary>
        /// <param name="transactionCustomerID"></param>
        /// <param name="rID"></param>
        private void insertTransaction_2(string transactionCustomerID, string rID)
        {
            string insertQuery = "INSERT INTO RentalTransaction (RegistrationID, DateFrom, DateTo, Fees, TotalCost, FromBranchID, ToBranchID, EmployeeID, CustomerID, CarID) " +
                "VALUES (@RegistrationID, @DateFrom, @DateTo, @Fees, @TotalCost, @FromBranchID, @ToBranchID, @EmployeeID, @CustomerID, @CarID)";

            D1.myCommand.CommandText = insertQuery; //CommandText allows us to query the database. Query is an umbrella term for some operations like insert, etc.
            D1.myCommand.Parameters.Clear(); //Clear any previous parameters to prevent conflict
            

            //Insert the correct values into placeholder location
            D1.myCommand.Parameters.AddWithValue("@RegistrationID", rID);
            D1.myCommand.Parameters.AddWithValue("@DateFrom", dateFrom.Value);
            D1.myCommand.Parameters.AddWithValue("@DateTo", dateTo.Value);
            D1.myCommand.Parameters.AddWithValue("@Fees", Int32.Parse(fees.Text));
            D1.myCommand.Parameters.AddWithValue("@TotalCost", Int32.Parse(totalCost.Text));
            D1.myCommand.Parameters.AddWithValue("@FromBranchID", branches[pickUpComboBox.SelectedIndex].BranchID);
            D1.myCommand.Parameters.AddWithValue("@ToBranchID", branches[dropOffComboBox.SelectedIndex].BranchID);
            D1.myCommand.Parameters.AddWithValue("@EmployeeID", "1212");
            D1.myCommand.Parameters.AddWithValue("@CustomerID", transactionCustomerID);
            D1.myCommand.Parameters.AddWithValue("@CarID", tCarIDLabel.Text);
            try
            {
                D1.myCommand.ExecuteNonQuery(); // Execute the command
                //MessageBox.Show(insertQuery);
                MessageBox.Show("Car has been reserved!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Failed to reserve car. Please try again!", "Error");
            }
        }

        /// <summary>
        /// Clear transactions text boxes for new use
        /// </summary>
        private void refreshCustomerSection()
        {
            customerID.Clear();
            firstName.Clear();
            lastName.Clear();
            age.Clear();
            street.Clear();
            city.Clear();
            province.Clear();
            postalCode.Clear();
            emailAddress.Clear();
            phoneNumber.Clear();
        }

        /// <summary>
        /// Calculate additional car fees
        /// </summary>
        /// <returns></returns>
        private float calculateFees()
        {
            float cleaningFees = 60;
            float differentBranchFee = 0;

            if (!String.Equals(tPickUpBranchLabel.Text, tDropOffBranchLabel.Text))
            {
                differentBranchFee = 25;
            }
            return cleaningFees + differentBranchFee;
        }

        /// <summary>
        /// generate a new registrationID for a rental transaction
        /// </summary>
        /// <returns></returns>
        private string generateRegistrationID()
        {
            Random random = new Random();
            int registrationID = random.Next(1000, 9999);

            return registrationID.ToString();
        }

        /// <summary>
        /// Handles exceptions due to user input and sends customer/client-readable messages telling them how to fix the errors.
        /// </summary>
        /// <returns>bool value: true if error is found else false</returns>
        private bool checkValidCustomerInformation()
        {
            StringBuilder errorMessage = new StringBuilder("Error: ");
            // string errorMessage = "Error: ";
            int ageResult;
            bool ageValid = true;
            bool isAgeNumeric = int.TryParse(age.Text, out ageResult);
            bool isPhoneNumeric = int.TryParse(phoneNumber.Text, out _);
            bool isCustomerIDUnique = !checkUniqueCustomerID(customerID.Text);
            bool customerIDFilled = customerID.Text.Length == 0;
            bool driversInfoFilled = firstName.Text.Length == 0 || lastName.Text.Length == 0 || ageLabel.Text.Length == 0;
            bool contactInfoFilled = phoneNumber.Text.Length == 0 || emailAddress.Text.Length == 0;
            bool billingAddressFilled = street.Text.Length == 0 || postalCode.Text.Length == 0 || city.Text.Length == 0 || province.Text.Length == 0;
            if (customerIDFilled) errorMessage.Append("\n- Please enter a Customer ID.");
            else if (isCustomerIDUnique) errorMessage.Append("\n- Customer ID already exists. Please choose a new ID.");
            if (driversInfoFilled) errorMessage.Append("\n- Please fill out the Driver's information section.");
            if (contactInfoFilled)  errorMessage.Append("\n- Please fill out the Contact Information section.");
            if (billingAddressFilled) errorMessage.Append("\n- Please fill out the Billing Address section.");
            if (!isAgeNumeric && age.Text.Length == 0)  errorMessage.Append("\n- Age must be filled out and numeric.");
            else
            {
                if (ageResult < 21) ageValid = false;

            }
            if (isPhoneNumeric && phoneNumber.Text.Length != 0) errorMessage.Append("\n- Phone Number must be format as shown in the example.");

            if (!ageValid)
            {
                MessageBox.Show("Sorry! you must be at least 21 years old to rent a car with us.");
                return true;
            }

            if (!isAgeNumeric || isPhoneNumeric || isCustomerIDUnique || driversInfoFilled || contactInfoFilled || billingAddressFilled)
            {
                MessageBox.Show(errorMessage.ToString());
                return true;
            }
            return false;
        }

        /// <summary>
        /// check if CustomerID is unique
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        private bool checkUniqueCustomerID(string customerID)
        {
            try
            {
                D1.query("Select CustomerID from Customer");

                while (D1.myReader.Read())
                {
                    if (String.Equals(D1.myReader["CustomerID"].ToString().Trim(), customerID))
                    {
                        D1.myReader.Close();
                        return false;
                    }
                }
                D1.myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                D1.myReader.Close();
            }

            return true;
        }

    }
}

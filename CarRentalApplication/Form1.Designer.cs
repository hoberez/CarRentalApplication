namespace CarRentalApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            openFileDialog1 = new OpenFileDialog();
            menuPanel = new Panel();
            menuGeneralButton = new RadioButton();
            menuSignOutButton = new RadioButton();
            menuReportsButton = new RadioButton();
            menuChangeButton = new RadioButton();
            sectionTitleLabel = new Label();
            menuCheckBox = new CheckBox();
            employeePanel = new Panel();
            reportsPanel = new Panel();
            panel3 = new Panel();
            reportData = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label11 = new Label();
            report1ComboBox = new ComboBox();
            label4 = new Label();
            label43 = new Label();
            button21 = new Button();
            panel6 = new Panel();
            label12 = new Label();
            button8 = new Button();
            panel5 = new Panel();
            label3 = new Label();
            button6 = new Button();
            panel4 = new Panel();
            button5 = new Button();
            label2 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            label1 = new Label();
            accountInformationPanel = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel10 = new Panel();
            label50 = new Label();
            label49 = new Label();
            panel11 = new Panel();
            label48 = new Label();
            label51 = new Label();
            panel12 = new Panel();
            label52 = new Label();
            label53 = new Label();
            panel13 = new Panel();
            label54 = new Label();
            label55 = new Label();
            panel15 = new Panel();
            label58 = new Label();
            label59 = new Label();
            panel14 = new Panel();
            label56 = new Label();
            label57 = new Label();
            panel7 = new Panel();
            label5 = new Label();
            label7 = new Label();
            panel8 = new Panel();
            label8 = new Label();
            label10 = new Label();
            viewCarsPanel = new Panel();
            label14 = new Label();
            showAllButton = new Button();
            label9 = new Label();
            searchComboBox = new ComboBox();
            carData = new DataGridView();
            CarID = new DataGridViewTextBoxColumn();
            Manufacturer = new DataGridViewTextBoxColumn();
            Colour = new DataGridViewTextBoxColumn();
            BranchID = new DataGridViewTextBoxColumn();
            ModelID = new DataGridViewTextBoxColumn();
            label32 = new Label();
            searchTextBox = new TextBox();
            addButton = new Button();
            searchButton = new Button();
            modifyButton = new Button();
            deleteButtonn = new Button();
            changeCarPanel = new Panel();
            carTypePanel = new Panel();
            showCarTypeButton = new Button();
            button1 = new Button();
            carTypeLabel = new Label();
            branchCarTypeData = new DataGridView();
            modifyCarPanel = new Panel();
            modifyCarIDValue = new Label();
            modifyModelIDLabel = new Label();
            modifyModelIDComboBox = new ComboBox();
            modifyBranchIDComboBox = new ComboBox();
            modifyCarMainLabel = new Label();
            modifyCarResetButton = new Button();
            modifyCarButton = new Button();
            modifyCarIDLabel = new Label();
            modifyCarTypeLabel = new Label();
            modifyBranchIDLabel = new Label();
            goBackButton2 = new Button();
            modifyColorText = new TextBox();
            modifyManufacturer = new Label();
            modifyColorLabel = new Label();
            modifyManufacturerText = new TextBox();
            AddCarPanel = new Panel();
            label6 = new Label();
            addModelIDComboBox = new ComboBox();
            addBranchIDComboBox = new ComboBox();
            addCarMainLabel = new Label();
            addCarResetButton = new Button();
            addCarButton = new Button();
            addCarIDText = new TextBox();
            addCarIDlabel = new Label();
            label38 = new Label();
            addBranchIDlabel = new Label();
            goBackButton1 = new Button();
            addColorText = new TextBox();
            addManufacturerLabel = new Label();
            addColorLabel = new Label();
            addManufacturerText = new TextBox();
            generalPanel = new Panel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label62 = new Label();
            panel17 = new Panel();
            label63 = new Label();
            panel19 = new Panel();
            monthCalendar1 = new MonthCalendar();
            databaseBindingSource = new BindingSource(components);
            menuPanel.SuspendLayout();
            employeePanel.SuspendLayout();
            reportsPanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reportData).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            accountInformationPanel.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel15.SuspendLayout();
            panel14.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            viewCarsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carData).BeginInit();
            changeCarPanel.SuspendLayout();
            carTypePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)branchCarTypeData).BeginInit();
            modifyCarPanel.SuspendLayout();
            AddCarPanel.SuspendLayout();
            generalPanel.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.Lavender;
            menuPanel.Controls.Add(menuGeneralButton);
            menuPanel.Controls.Add(menuSignOutButton);
            menuPanel.Controls.Add(menuReportsButton);
            menuPanel.Controls.Add(menuChangeButton);
            menuPanel.Location = new Point(0, 46);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(298, 556);
            menuPanel.TabIndex = 11;
            // 
            // menuGeneralButton
            // 
            menuGeneralButton.Appearance = Appearance.Button;
            menuGeneralButton.FlatStyle = FlatStyle.Flat;
            menuGeneralButton.Font = new Font("Segoe UI", 12F);
            menuGeneralButton.Location = new Point(0, 16);
            menuGeneralButton.Name = "menuGeneralButton";
            menuGeneralButton.Size = new Size(298, 38);
            menuGeneralButton.TabIndex = 48;
            menuGeneralButton.TabStop = true;
            menuGeneralButton.Text = "General";
            menuGeneralButton.UseVisualStyleBackColor = true;
            menuGeneralButton.CheckedChanged += menuGeneralButton_CheckedChanged;
            // 
            // menuSignOutButton
            // 
            menuSignOutButton.Appearance = Appearance.Button;
            menuSignOutButton.FlatStyle = FlatStyle.Flat;
            menuSignOutButton.Font = new Font("Segoe UI", 12F);
            menuSignOutButton.Location = new Point(3, 148);
            menuSignOutButton.Name = "menuSignOutButton";
            menuSignOutButton.Size = new Size(298, 38);
            menuSignOutButton.TabIndex = 47;
            menuSignOutButton.TabStop = true;
            menuSignOutButton.Text = "Sign Out";
            menuSignOutButton.UseVisualStyleBackColor = true;
            menuSignOutButton.CheckedChanged += menuSignOutButton_CheckedChanged;
            // 
            // menuReportsButton
            // 
            menuReportsButton.Appearance = Appearance.Button;
            menuReportsButton.FlatStyle = FlatStyle.Flat;
            menuReportsButton.Font = new Font("Segoe UI", 12F);
            menuReportsButton.Location = new Point(0, 104);
            menuReportsButton.Name = "menuReportsButton";
            menuReportsButton.Size = new Size(298, 38);
            menuReportsButton.TabIndex = 46;
            menuReportsButton.TabStop = true;
            menuReportsButton.Text = "Reports";
            menuReportsButton.UseVisualStyleBackColor = true;
            menuReportsButton.CheckedChanged += menuReportsButton_CheckedChanged;
            // 
            // menuChangeButton
            // 
            menuChangeButton.Appearance = Appearance.Button;
            menuChangeButton.FlatStyle = FlatStyle.Flat;
            menuChangeButton.Font = new Font("Segoe UI", 12F);
            menuChangeButton.Location = new Point(0, 60);
            menuChangeButton.Name = "menuChangeButton";
            menuChangeButton.Size = new Size(298, 38);
            menuChangeButton.TabIndex = 45;
            menuChangeButton.TabStop = true;
            menuChangeButton.Text = "Search and Change Car Info";
            menuChangeButton.UseVisualStyleBackColor = true;
            menuChangeButton.CheckedChanged += menuChangeButton_CheckedChanged;
            // 
            // sectionTitleLabel
            // 
            sectionTitleLabel.AutoSize = true;
            sectionTitleLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sectionTitleLabel.Location = new Point(88, 12);
            sectionTitleLabel.Name = "sectionTitleLabel";
            sectionTitleLabel.Size = new Size(263, 31);
            sectionTitleLabel.TabIndex = 31;
            sectionTitleLabel.Text = "Change Car Information";
            // 
            // menuCheckBox
            // 
            menuCheckBox.Appearance = Appearance.Button;
            menuCheckBox.CheckAlign = ContentAlignment.MiddleCenter;
            menuCheckBox.Font = new Font("Verdana", 13.2F, FontStyle.Bold);
            menuCheckBox.Location = new Point(8, 7);
            menuCheckBox.Name = "menuCheckBox";
            menuCheckBox.Size = new Size(54, 39);
            menuCheckBox.TabIndex = 35;
            menuCheckBox.Text = "≡";
            menuCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            menuCheckBox.UseVisualStyleBackColor = true;
            menuCheckBox.CheckedChanged += menuCheckBox_CheckedChanged;
            // 
            // employeePanel
            // 
            employeePanel.BackColor = Color.Lavender;
            employeePanel.Controls.Add(menuPanel);
            employeePanel.Controls.Add(sectionTitleLabel);
            employeePanel.Controls.Add(menuCheckBox);
            employeePanel.Controls.Add(viewCarsPanel);
            employeePanel.Controls.Add(changeCarPanel);
            employeePanel.Controls.Add(generalPanel);
            employeePanel.Controls.Add(reportsPanel);
            employeePanel.Controls.Add(accountInformationPanel);
            employeePanel.Location = new Point(14, 11);
            employeePanel.Name = "employeePanel";
            employeePanel.Size = new Size(1009, 567);
            employeePanel.TabIndex = 33;
            // 
            // reportsPanel
            // 
            reportsPanel.BackColor = Color.White;
            reportsPanel.Controls.Add(panel3);
            reportsPanel.Controls.Add(flowLayoutPanel1);
            reportsPanel.Location = new Point(0, 47);
            reportsPanel.Name = "reportsPanel";
            reportsPanel.Size = new Size(1008, 493);
            reportsPanel.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Lavender;
            panel3.Controls.Add(reportData);
            panel3.Location = new Point(457, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(547, 460);
            panel3.TabIndex = 12;
            // 
            // reportData
            // 
            reportData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reportData.Location = new Point(5, 12);
            reportData.Name = "reportData";
            reportData.RowHeadersWidth = 51;
            reportData.Size = new Size(537, 436);
            reportData.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Lavender;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Location = new Point(11, 15);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(436, 459);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(report1ComboBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label43);
            panel1.Controls.Add(button21);
            panel1.Location = new Point(8, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 83);
            panel1.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 48);
            label11.Name = "label11";
            label11.Size = new Size(55, 20);
            label11.TabIndex = 7;
            label11.Text = "Month:";
            // 
            // report1ComboBox
            // 
            report1ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            report1ComboBox.FormattingEnabled = true;
            report1ComboBox.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "November", "December" });
            report1ComboBox.Location = new Point(80, 45);
            report1ComboBox.Name = "report1ComboBox";
            report1ComboBox.Size = new Size(151, 28);
            report1ComboBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(10, 9);
            label4.Name = "label4";
            label4.Size = new Size(395, 28);
            label4.TabIndex = 0;
            label4.Text = "Colours ordered by highest sales in a month";
            label4.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Segoe UI", 12F);
            label43.Location = new Point(10, 25);
            label43.Name = "label43";
            label43.Size = new Size(17, 28);
            label43.TabIndex = 0;
            label43.Text = "'";
            label43.TextAlign = ContentAlignment.BottomCenter;
            // 
            // button21
            // 
            button21.BackColor = Color.Green;
            button21.Location = new Point(261, 43);
            button21.Name = "button21";
            button21.Size = new Size(115, 31);
            button21.TabIndex = 5;
            button21.Text = "Generate";
            button21.UseVisualStyleBackColor = false;
            button21.Click += button21_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label12);
            panel6.Controls.Add(button8);
            panel6.Location = new Point(8, 97);
            panel6.Name = "panel6";
            panel6.Size = new Size(420, 83);
            panel6.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(10, 11);
            label12.Name = "label12";
            label12.Size = new Size(328, 28);
            label12.TabIndex = 8;
            label12.Text = "Customers who've rented previously";
            label12.TextAlign = ContentAlignment.BottomCenter;
            // 
            // button8
            // 
            button8.BackColor = Color.Green;
            button8.Location = new Point(261, 43);
            button8.Name = "button8";
            button8.Size = new Size(115, 31);
            button8.TabIndex = 5;
            button8.Text = "Generate";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(button6);
            panel5.Location = new Point(8, 186);
            panel5.Name = "panel5";
            panel5.Size = new Size(420, 83);
            panel5.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 12);
            label3.Name = "label3";
            label3.Size = new Size(347, 28);
            label3.TabIndex = 0;
            label3.Text = "Branch with the highest profits in 2024";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // button6
            // 
            button6.BackColor = Color.Green;
            button6.Location = new Point(261, 43);
            button6.Name = "button6";
            button6.Size = new Size(115, 31);
            button6.TabIndex = 5;
            button6.Text = "Generate";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(button5);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(8, 275);
            panel4.Name = "panel4";
            panel4.Size = new Size(420, 83);
            panel4.TabIndex = 14;
            // 
            // button5
            // 
            button5.BackColor = Color.Green;
            button5.Location = new Point(261, 43);
            button5.Name = "button5";
            button5.Size = new Size(115, 31);
            button5.TabIndex = 5;
            button5.Text = "Generate";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F);
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.Location = new Point(13, 8);
            label2.Name = "label2";
            label2.Size = new Size(386, 58);
            label2.TabIndex = 0;
            label2.Text = "Manufacturers whose cars are not being rented at every branch";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(8, 364);
            panel2.Name = "panel2";
            panel2.Size = new Size(420, 83);
            panel2.TabIndex = 14;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.Location = new Point(261, 43);
            button3.Name = "button3";
            button3.Size = new Size(115, 31);
            button3.TabIndex = 5;
            button3.Text = "Generate";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(372, 64);
            label1.TabIndex = 0;
            label1.Text = "Avg. and Max. Daily Rates of Cars in each Branch";
            // 
            // accountInformationPanel
            // 
            accountInformationPanel.BackColor = Color.White;
            accountInformationPanel.Controls.Add(flowLayoutPanel2);
            accountInformationPanel.Location = new Point(-1, 47);
            accountInformationPanel.Name = "accountInformationPanel";
            accountInformationPanel.Size = new Size(1008, 490);
            accountInformationPanel.TabIndex = 12;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Lavender;
            flowLayoutPanel2.Controls.Add(panel10);
            flowLayoutPanel2.Controls.Add(panel11);
            flowLayoutPanel2.Controls.Add(panel12);
            flowLayoutPanel2.Controls.Add(panel13);
            flowLayoutPanel2.Controls.Add(panel15);
            flowLayoutPanel2.Controls.Add(panel14);
            flowLayoutPanel2.Controls.Add(panel7);
            flowLayoutPanel2.Controls.Add(panel8);
            flowLayoutPanel2.Location = new Point(254, 1);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(5);
            flowLayoutPanel2.Size = new Size(478, 519);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // panel10
            // 
            panel10.Controls.Add(label50);
            panel10.Controls.Add(label49);
            panel10.Location = new Point(105, 10);
            panel10.Margin = new Padding(100, 5, 100, 5);
            panel10.Name = "panel10";
            panel10.Size = new Size(267, 49);
            panel10.TabIndex = 3;
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Location = new Point(113, 15);
            label50.Name = "label50";
            label50.Size = new Size(45, 20);
            label50.TabIndex = 2;
            label50.Text = "None";
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Location = new Point(3, 15);
            label49.Name = "label49";
            label49.Size = new Size(97, 20);
            label49.TabIndex = 1;
            label49.Text = "Employee ID:";
            // 
            // panel11
            // 
            panel11.Controls.Add(label48);
            panel11.Controls.Add(label51);
            panel11.Location = new Point(105, 69);
            panel11.Margin = new Padding(100, 5, 100, 5);
            panel11.Name = "panel11";
            panel11.Size = new Size(267, 49);
            panel11.TabIndex = 4;
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Location = new Point(113, 15);
            label48.Name = "label48";
            label48.Size = new Size(45, 20);
            label48.TabIndex = 2;
            label48.Text = "None";
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Location = new Point(3, 15);
            label51.Name = "label51";
            label51.Size = new Size(83, 20);
            label51.TabIndex = 1;
            label51.Text = "First Name:";
            // 
            // panel12
            // 
            panel12.Controls.Add(label52);
            panel12.Controls.Add(label53);
            panel12.Location = new Point(105, 128);
            panel12.Margin = new Padding(100, 5, 100, 5);
            panel12.Name = "panel12";
            panel12.Size = new Size(267, 49);
            panel12.TabIndex = 4;
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Location = new Point(113, 15);
            label52.Name = "label52";
            label52.Size = new Size(45, 20);
            label52.TabIndex = 2;
            label52.Text = "None";
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.Location = new Point(3, 15);
            label53.Name = "label53";
            label53.Size = new Size(82, 20);
            label53.TabIndex = 1;
            label53.Text = "Last Name:";
            // 
            // panel13
            // 
            panel13.Controls.Add(label54);
            panel13.Controls.Add(label55);
            panel13.Location = new Point(105, 187);
            panel13.Margin = new Padding(100, 5, 100, 5);
            panel13.Name = "panel13";
            panel13.Size = new Size(267, 49);
            panel13.TabIndex = 4;
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.Location = new Point(113, 15);
            label54.Name = "label54";
            label54.Size = new Size(45, 20);
            label54.TabIndex = 2;
            label54.Text = "None";
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.Location = new Point(3, 15);
            label55.Name = "label55";
            label55.Size = new Size(51, 20);
            label55.TabIndex = 1;
            label55.Text = "Street:";
            // 
            // panel15
            // 
            panel15.Controls.Add(label58);
            panel15.Controls.Add(label59);
            panel15.Location = new Point(105, 246);
            panel15.Margin = new Padding(100, 5, 100, 5);
            panel15.Name = "panel15";
            panel15.Size = new Size(267, 49);
            panel15.TabIndex = 5;
            // 
            // label58
            // 
            label58.AutoSize = true;
            label58.Location = new Point(113, 15);
            label58.Name = "label58";
            label58.Size = new Size(45, 20);
            label58.TabIndex = 2;
            label58.Text = "None";
            // 
            // label59
            // 
            label59.AutoSize = true;
            label59.Location = new Point(3, 15);
            label59.Name = "label59";
            label59.Size = new Size(90, 20);
            label59.TabIndex = 1;
            label59.Text = "Postal Code:";
            // 
            // panel14
            // 
            panel14.Controls.Add(label56);
            panel14.Controls.Add(label57);
            panel14.Location = new Point(105, 305);
            panel14.Margin = new Padding(100, 5, 100, 5);
            panel14.Name = "panel14";
            panel14.Size = new Size(267, 49);
            panel14.TabIndex = 5;
            // 
            // label56
            // 
            label56.AutoSize = true;
            label56.Location = new Point(113, 15);
            label56.Name = "label56";
            label56.Size = new Size(45, 20);
            label56.TabIndex = 2;
            label56.Text = "None";
            // 
            // label57
            // 
            label57.AutoSize = true;
            label57.Location = new Point(3, 15);
            label57.Name = "label57";
            label57.Size = new Size(100, 20);
            label57.TabIndex = 1;
            label57.Text = "City, Province:";
            // 
            // panel7
            // 
            panel7.Controls.Add(label5);
            panel7.Controls.Add(label7);
            panel7.Location = new Point(105, 364);
            panel7.Margin = new Padding(100, 5, 100, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(267, 49);
            panel7.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 15);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 2;
            label5.Text = "None";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 15);
            label7.Name = "label7";
            label7.Size = new Size(111, 20);
            label7.TabIndex = 1;
            label7.Text = "Phone Number:";
            // 
            // panel8
            // 
            panel8.Controls.Add(label8);
            panel8.Controls.Add(label10);
            panel8.Location = new Point(105, 423);
            panel8.Margin = new Padding(100, 5, 100, 5);
            panel8.Name = "panel8";
            panel8.Size = new Size(267, 49);
            panel8.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(113, 15);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 2;
            label8.Text = "None";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 15);
            label10.Name = "label10";
            label10.Size = new Size(106, 20);
            label10.TabIndex = 1;
            label10.Text = "Email Address:";
            // 
            // viewCarsPanel
            // 
            viewCarsPanel.BackColor = Color.White;
            viewCarsPanel.Controls.Add(label14);
            viewCarsPanel.Controls.Add(showAllButton);
            viewCarsPanel.Controls.Add(label9);
            viewCarsPanel.Controls.Add(searchComboBox);
            viewCarsPanel.Controls.Add(carData);
            viewCarsPanel.Controls.Add(label32);
            viewCarsPanel.Controls.Add(searchTextBox);
            viewCarsPanel.Controls.Add(addButton);
            viewCarsPanel.Controls.Add(searchButton);
            viewCarsPanel.Controls.Add(modifyButton);
            viewCarsPanel.Controls.Add(deleteButtonn);
            viewCarsPanel.Location = new Point(0, 48);
            viewCarsPanel.Name = "viewCarsPanel";
            viewCarsPanel.Size = new Size(1009, 489);
            viewCarsPanel.TabIndex = 10;
            // 
            // label14
            // 
            label14.Location = new Point(779, 417);
            label14.Name = "label14";
            label14.Size = new Size(198, 20);
            label14.TabIndex = 41;
            label14.Text = "Refresh to see new changes";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // showAllButton
            // 
            showAllButton.Location = new Point(153, 56);
            showAllButton.Name = "showAllButton";
            showAllButton.Size = new Size(157, 29);
            showAllButton.TabIndex = 37;
            showAllButton.Text = "Refresh/Show All";
            showAllButton.UseVisualStyleBackColor = true;
            showAllButton.Click += refresh_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(351, 58);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 34;
            label9.Text = "Search By:";
            // 
            // searchComboBox
            // 
            searchComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            searchComboBox.FormattingEnabled = true;
            searchComboBox.Items.AddRange(new object[] { "CarID", "Manufacturer", "Colour", "BranchID", "ModelID" });
            searchComboBox.Location = new Point(433, 54);
            searchComboBox.Name = "searchComboBox";
            searchComboBox.Size = new Size(152, 28);
            searchComboBox.TabIndex = 33;
            // 
            // carData
            // 
            carData.AllowUserToAddRows = false;
            carData.AllowUserToDeleteRows = false;
            carData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            carData.Columns.AddRange(new DataGridViewColumn[] { CarID, Manufacturer, Colour, BranchID, ModelID });
            carData.Location = new Point(21, 93);
            carData.MultiSelect = false;
            carData.Name = "carData";
            carData.ReadOnly = true;
            carData.RowHeadersWidth = 51;
            carData.Size = new Size(956, 322);
            carData.TabIndex = 31;
            // 
            // CarID
            // 
            CarID.HeaderText = "CarID";
            CarID.MinimumWidth = 6;
            CarID.Name = "CarID";
            CarID.ReadOnly = true;
            CarID.Width = 125;
            // 
            // Manufacturer
            // 
            Manufacturer.HeaderText = "Manufacturer";
            Manufacturer.MinimumWidth = 6;
            Manufacturer.Name = "Manufacturer";
            Manufacturer.ReadOnly = true;
            Manufacturer.Width = 125;
            // 
            // Colour
            // 
            Colour.HeaderText = "Colour";
            Colour.MinimumWidth = 6;
            Colour.Name = "Colour";
            Colour.ReadOnly = true;
            Colour.Width = 125;
            // 
            // BranchID
            // 
            BranchID.HeaderText = "BranchID";
            BranchID.MinimumWidth = 6;
            BranchID.Name = "BranchID";
            BranchID.ReadOnly = true;
            BranchID.Width = 125;
            // 
            // ModelID
            // 
            ModelID.HeaderText = "ModelID";
            ModelID.MinimumWidth = 6;
            ModelID.Name = "ModelID";
            ModelID.ReadOnly = true;
            ModelID.Width = 125;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.Location = new Point(21, 14);
            label32.Name = "label32";
            label32.Size = new Size(257, 31);
            label32.TabIndex = 30;
            label32.Text = "Agency's Car Collection";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(591, 54);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(286, 27);
            searchTextBox.TabIndex = 6;
            // 
            // addButton
            // 
            addButton.BackColor = Color.Green;
            addButton.Location = new Point(21, 56);
            addButton.Name = "addButton";
            addButton.Size = new Size(126, 29);
            addButton.TabIndex = 8;
            addButton.Text = "Add New Car...";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.DodgerBlue;
            searchButton.Location = new Point(883, 54);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 9;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // modifyButton
            // 
            modifyButton.Location = new Point(22, 424);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(94, 29);
            modifyButton.TabIndex = 0;
            modifyButton.Text = "Modify";
            modifyButton.UseVisualStyleBackColor = true;
            modifyButton.Click += modifyButton_Click;
            // 
            // deleteButtonn
            // 
            deleteButtonn.BackColor = Color.FromArgb(192, 0, 0);
            deleteButtonn.Location = new Point(123, 424);
            deleteButtonn.Name = "deleteButtonn";
            deleteButtonn.Size = new Size(94, 29);
            deleteButtonn.TabIndex = 7;
            deleteButtonn.Text = "Delete";
            deleteButtonn.UseVisualStyleBackColor = false;
            deleteButtonn.Click += deleteButtonn_Click;
            // 
            // changeCarPanel
            // 
            changeCarPanel.BackColor = Color.White;
            changeCarPanel.Controls.Add(carTypePanel);
            changeCarPanel.Controls.Add(modifyCarPanel);
            changeCarPanel.Controls.Add(AddCarPanel);
            changeCarPanel.Location = new Point(0, 47);
            changeCarPanel.Name = "changeCarPanel";
            changeCarPanel.Size = new Size(1109, 493);
            changeCarPanel.TabIndex = 10;
            changeCarPanel.Visible = false;
            // 
            // carTypePanel
            // 
            carTypePanel.BackColor = Color.Lavender;
            carTypePanel.Controls.Add(showCarTypeButton);
            carTypePanel.Controls.Add(button1);
            carTypePanel.Controls.Add(carTypeLabel);
            carTypePanel.Controls.Add(branchCarTypeData);
            carTypePanel.Location = new Point(360, 36);
            carTypePanel.Name = "carTypePanel";
            carTypePanel.Size = new Size(629, 418);
            carTypePanel.TabIndex = 37;
            // 
            // showCarTypeButton
            // 
            showCarTypeButton.BackColor = Color.Green;
            showCarTypeButton.Location = new Point(304, 14);
            showCarTypeButton.Name = "showCarTypeButton";
            showCarTypeButton.Size = new Size(151, 29);
            showCarTypeButton.TabIndex = 34;
            showCarTypeButton.Text = "Show Car Types";
            showCarTypeButton.UseVisualStyleBackColor = false;
            showCarTypeButton.Click += showCarTypeButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Location = new Point(461, 14);
            button1.Name = "button1";
            button1.Size = new Size(151, 29);
            button1.TabIndex = 38;
            button1.Text = "Show Branches";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // carTypeLabel
            // 
            carTypeLabel.AutoSize = true;
            carTypeLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carTypeLabel.Location = new Point(16, 10);
            carTypeLabel.Name = "carTypeLabel";
            carTypeLabel.Size = new Size(184, 31);
            carTypeLabel.TabIndex = 35;
            carTypeLabel.Text = "List of Car Types";
            // 
            // branchCarTypeData
            // 
            branchCarTypeData.AllowUserToAddRows = false;
            branchCarTypeData.AllowUserToDeleteRows = false;
            branchCarTypeData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            branchCarTypeData.Location = new Point(16, 49);
            branchCarTypeData.Name = "branchCarTypeData";
            branchCarTypeData.ReadOnly = true;
            branchCarTypeData.RowHeadersWidth = 51;
            branchCarTypeData.Size = new Size(596, 361);
            branchCarTypeData.TabIndex = 35;
            // 
            // modifyCarPanel
            // 
            modifyCarPanel.BackColor = Color.Lavender;
            modifyCarPanel.Controls.Add(modifyCarIDValue);
            modifyCarPanel.Controls.Add(modifyModelIDLabel);
            modifyCarPanel.Controls.Add(modifyModelIDComboBox);
            modifyCarPanel.Controls.Add(modifyBranchIDComboBox);
            modifyCarPanel.Controls.Add(modifyCarMainLabel);
            modifyCarPanel.Controls.Add(modifyCarResetButton);
            modifyCarPanel.Controls.Add(modifyCarButton);
            modifyCarPanel.Controls.Add(modifyCarIDLabel);
            modifyCarPanel.Controls.Add(modifyCarTypeLabel);
            modifyCarPanel.Controls.Add(modifyBranchIDLabel);
            modifyCarPanel.Controls.Add(goBackButton2);
            modifyCarPanel.Controls.Add(modifyColorText);
            modifyCarPanel.Controls.Add(modifyManufacturer);
            modifyCarPanel.Controls.Add(modifyColorLabel);
            modifyCarPanel.Controls.Add(modifyManufacturerText);
            modifyCarPanel.Location = new Point(28, 35);
            modifyCarPanel.Name = "modifyCarPanel";
            modifyCarPanel.Size = new Size(322, 419);
            modifyCarPanel.TabIndex = 36;
            // 
            // modifyCarIDValue
            // 
            modifyCarIDValue.AutoSize = true;
            modifyCarIDValue.Location = new Point(145, 67);
            modifyCarIDValue.Name = "modifyCarIDValue";
            modifyCarIDValue.Size = new Size(53, 20);
            modifyCarIDValue.TabIndex = 34;
            modifyCarIDValue.Text = "Car ID:";
            // 
            // modifyModelIDLabel
            // 
            modifyModelIDLabel.AutoSize = true;
            modifyModelIDLabel.Location = new Point(38, 240);
            modifyModelIDLabel.Name = "modifyModelIDLabel";
            modifyModelIDLabel.Size = new Size(70, 20);
            modifyModelIDLabel.TabIndex = 33;
            modifyModelIDLabel.Text = "ModelID:";
            // 
            // modifyModelIDComboBox
            // 
            modifyModelIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            modifyModelIDComboBox.FormattingEnabled = true;
            modifyModelIDComboBox.Items.AddRange(new object[] { "oerug", "2q9732", "eoruvfeh", "vfeou" });
            modifyModelIDComboBox.Location = new Point(145, 234);
            modifyModelIDComboBox.Name = "modifyModelIDComboBox";
            modifyModelIDComboBox.Size = new Size(125, 28);
            modifyModelIDComboBox.TabIndex = 32;
            // 
            // modifyBranchIDComboBox
            // 
            modifyBranchIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            modifyBranchIDComboBox.FormattingEnabled = true;
            modifyBranchIDComboBox.Items.AddRange(new object[] { "2", "32" });
            modifyBranchIDComboBox.Location = new Point(145, 95);
            modifyBranchIDComboBox.Name = "modifyBranchIDComboBox";
            modifyBranchIDComboBox.Size = new Size(125, 28);
            modifyBranchIDComboBox.TabIndex = 31;
            // 
            // modifyCarMainLabel
            // 
            modifyCarMainLabel.AutoSize = true;
            modifyCarMainLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modifyCarMainLabel.Location = new Point(15, 11);
            modifyCarMainLabel.Name = "modifyCarMainLabel";
            modifyCarMainLabel.Size = new Size(130, 31);
            modifyCarMainLabel.TabIndex = 15;
            modifyCarMainLabel.Text = "Modify Car";
            // 
            // modifyCarResetButton
            // 
            modifyCarResetButton.Location = new Point(160, 312);
            modifyCarResetButton.Name = "modifyCarResetButton";
            modifyCarResetButton.Size = new Size(94, 29);
            modifyCarResetButton.TabIndex = 30;
            modifyCarResetButton.Text = "Reset";
            modifyCarResetButton.UseVisualStyleBackColor = true;
            modifyCarResetButton.Click += modifyCarResetButton_Click;
            // 
            // modifyCarButton
            // 
            modifyCarButton.BackColor = Color.Green;
            modifyCarButton.Location = new Point(46, 312);
            modifyCarButton.Name = "modifyCarButton";
            modifyCarButton.Size = new Size(94, 29);
            modifyCarButton.TabIndex = 0;
            modifyCarButton.Text = "Modify";
            modifyCarButton.UseVisualStyleBackColor = false;
            modifyCarButton.Click += modifyCarButton_Click;
            // 
            // modifyCarIDLabel
            // 
            modifyCarIDLabel.AutoSize = true;
            modifyCarIDLabel.Location = new Point(30, 67);
            modifyCarIDLabel.Name = "modifyCarIDLabel";
            modifyCarIDLabel.Size = new Size(53, 20);
            modifyCarIDLabel.TabIndex = 2;
            modifyCarIDLabel.Text = "Car ID:";
            // 
            // modifyCarTypeLabel
            // 
            modifyCarTypeLabel.AutoSize = true;
            modifyCarTypeLabel.Location = new Point(37, 218);
            modifyCarTypeLabel.Name = "modifyCarTypeLabel";
            modifyCarTypeLabel.Size = new Size(69, 20);
            modifyCarTypeLabel.TabIndex = 14;
            modifyCarTypeLabel.Text = "Car Type:";
            // 
            // modifyBranchIDLabel
            // 
            modifyBranchIDLabel.AutoSize = true;
            modifyBranchIDLabel.Location = new Point(30, 99);
            modifyBranchIDLabel.Name = "modifyBranchIDLabel";
            modifyBranchIDLabel.Size = new Size(76, 20);
            modifyBranchIDLabel.TabIndex = 4;
            modifyBranchIDLabel.Text = "Branch ID:";
            // 
            // goBackButton2
            // 
            goBackButton2.Location = new Point(46, 356);
            goBackButton2.Name = "goBackButton2";
            goBackButton2.Size = new Size(208, 36);
            goBackButton2.TabIndex = 9;
            goBackButton2.Text = "Go Back";
            goBackButton2.UseVisualStyleBackColor = true;
            goBackButton2.Click += goBackButton_Click;
            // 
            // modifyColorText
            // 
            modifyColorText.Location = new Point(145, 129);
            modifyColorText.Name = "modifyColorText";
            modifyColorText.Size = new Size(125, 27);
            modifyColorText.TabIndex = 5;
            // 
            // modifyManufacturer
            // 
            modifyManufacturer.AutoSize = true;
            modifyManufacturer.Location = new Point(30, 166);
            modifyManufacturer.Name = "modifyManufacturer";
            modifyManufacturer.Size = new Size(97, 20);
            modifyManufacturer.TabIndex = 8;
            modifyManufacturer.Text = "Manufacturer";
            // 
            // modifyColorLabel
            // 
            modifyColorLabel.AutoSize = true;
            modifyColorLabel.Location = new Point(30, 132);
            modifyColorLabel.Name = "modifyColorLabel";
            modifyColorLabel.Size = new Size(48, 20);
            modifyColorLabel.TabIndex = 6;
            modifyColorLabel.Text = "Color:";
            // 
            // modifyManufacturerText
            // 
            modifyManufacturerText.Location = new Point(145, 163);
            modifyManufacturerText.Name = "modifyManufacturerText";
            modifyManufacturerText.Size = new Size(125, 27);
            modifyManufacturerText.TabIndex = 7;
            // 
            // AddCarPanel
            // 
            AddCarPanel.BackColor = Color.Lavender;
            AddCarPanel.Controls.Add(label6);
            AddCarPanel.Controls.Add(addModelIDComboBox);
            AddCarPanel.Controls.Add(addBranchIDComboBox);
            AddCarPanel.Controls.Add(addCarMainLabel);
            AddCarPanel.Controls.Add(addCarResetButton);
            AddCarPanel.Controls.Add(addCarButton);
            AddCarPanel.Controls.Add(addCarIDText);
            AddCarPanel.Controls.Add(addCarIDlabel);
            AddCarPanel.Controls.Add(label38);
            AddCarPanel.Controls.Add(addBranchIDlabel);
            AddCarPanel.Controls.Add(goBackButton1);
            AddCarPanel.Controls.Add(addColorText);
            AddCarPanel.Controls.Add(addManufacturerLabel);
            AddCarPanel.Controls.Add(addColorLabel);
            AddCarPanel.Controls.Add(addManufacturerText);
            AddCarPanel.Location = new Point(28, 35);
            AddCarPanel.Name = "AddCarPanel";
            AddCarPanel.Size = new Size(322, 419);
            AddCarPanel.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 240);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 33;
            label6.Text = "Model ID:";
            // 
            // addModelIDComboBox
            // 
            addModelIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            addModelIDComboBox.FormattingEnabled = true;
            addModelIDComboBox.Location = new Point(145, 234);
            addModelIDComboBox.Name = "addModelIDComboBox";
            addModelIDComboBox.Size = new Size(125, 28);
            addModelIDComboBox.TabIndex = 32;
            // 
            // addBranchIDComboBox
            // 
            addBranchIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            addBranchIDComboBox.FormattingEnabled = true;
            addBranchIDComboBox.Location = new Point(145, 95);
            addBranchIDComboBox.Name = "addBranchIDComboBox";
            addBranchIDComboBox.Size = new Size(125, 28);
            addBranchIDComboBox.TabIndex = 31;
            // 
            // addCarMainLabel
            // 
            addCarMainLabel.AutoSize = true;
            addCarMainLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addCarMainLabel.Location = new Point(15, 11);
            addCarMainLabel.Name = "addCarMainLabel";
            addCarMainLabel.Size = new Size(151, 31);
            addCarMainLabel.TabIndex = 15;
            addCarMainLabel.Text = "Add New Car";
            // 
            // addCarResetButton
            // 
            addCarResetButton.Location = new Point(160, 312);
            addCarResetButton.Name = "addCarResetButton";
            addCarResetButton.Size = new Size(94, 29);
            addCarResetButton.TabIndex = 30;
            addCarResetButton.Text = "Reset";
            addCarResetButton.UseVisualStyleBackColor = true;
            addCarResetButton.Click += addCarResetButton_Click;
            // 
            // addCarButton
            // 
            addCarButton.BackColor = Color.Green;
            addCarButton.Location = new Point(46, 312);
            addCarButton.Name = "addCarButton";
            addCarButton.Size = new Size(94, 29);
            addCarButton.TabIndex = 0;
            addCarButton.Text = "Add";
            addCarButton.UseVisualStyleBackColor = false;
            addCarButton.Click += addCarButton_Click;
            // 
            // addCarIDText
            // 
            addCarIDText.Location = new Point(145, 64);
            addCarIDText.Name = "addCarIDText";
            addCarIDText.Size = new Size(125, 27);
            addCarIDText.TabIndex = 1;
            // 
            // addCarIDlabel
            // 
            addCarIDlabel.AutoSize = true;
            addCarIDlabel.Location = new Point(30, 67);
            addCarIDlabel.Name = "addCarIDlabel";
            addCarIDlabel.Size = new Size(53, 20);
            addCarIDlabel.TabIndex = 2;
            addCarIDlabel.Text = "Car ID:";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(37, 218);
            label38.Name = "label38";
            label38.Size = new Size(69, 20);
            label38.TabIndex = 14;
            label38.Text = "Car Type:";
            // 
            // addBranchIDlabel
            // 
            addBranchIDlabel.AutoSize = true;
            addBranchIDlabel.Location = new Point(30, 99);
            addBranchIDlabel.Name = "addBranchIDlabel";
            addBranchIDlabel.Size = new Size(76, 20);
            addBranchIDlabel.TabIndex = 4;
            addBranchIDlabel.Text = "Branch ID:";
            // 
            // goBackButton1
            // 
            goBackButton1.Location = new Point(46, 356);
            goBackButton1.Name = "goBackButton1";
            goBackButton1.Size = new Size(208, 36);
            goBackButton1.TabIndex = 9;
            goBackButton1.Text = "Go Back";
            goBackButton1.UseVisualStyleBackColor = true;
            goBackButton1.Click += goBackButton_Click;
            // 
            // addColorText
            // 
            addColorText.Location = new Point(145, 129);
            addColorText.Name = "addColorText";
            addColorText.Size = new Size(125, 27);
            addColorText.TabIndex = 5;
            // 
            // addManufacturerLabel
            // 
            addManufacturerLabel.AutoSize = true;
            addManufacturerLabel.Location = new Point(30, 166);
            addManufacturerLabel.Name = "addManufacturerLabel";
            addManufacturerLabel.Size = new Size(100, 20);
            addManufacturerLabel.TabIndex = 8;
            addManufacturerLabel.Text = "Manufacturer:";
            // 
            // addColorLabel
            // 
            addColorLabel.AutoSize = true;
            addColorLabel.Location = new Point(30, 132);
            addColorLabel.Name = "addColorLabel";
            addColorLabel.Size = new Size(48, 20);
            addColorLabel.TabIndex = 6;
            addColorLabel.Text = "Color:";
            // 
            // addManufacturerText
            // 
            addManufacturerText.Location = new Point(145, 163);
            addManufacturerText.Name = "addManufacturerText";
            addManufacturerText.Size = new Size(125, 27);
            addManufacturerText.TabIndex = 7;
            // 
            // generalPanel
            // 
            generalPanel.BackColor = Color.White;
            generalPanel.Controls.Add(flowLayoutPanel4);
            generalPanel.Location = new Point(-1, 48);
            generalPanel.Name = "generalPanel";
            generalPanel.Size = new Size(1008, 492);
            generalPanel.TabIndex = 14;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label62);
            flowLayoutPanel4.Controls.Add(panel17);
            flowLayoutPanel4.Controls.Add(label63);
            flowLayoutPanel4.Controls.Add(panel19);
            flowLayoutPanel4.Location = new Point(23, 10);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(298, 461);
            flowLayoutPanel4.TabIndex = 39;
            // 
            // label62
            // 
            label62.AutoSize = true;
            label62.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label62.Location = new Point(3, 0);
            label62.Name = "label62";
            label62.Size = new Size(181, 31);
            label62.TabIndex = 36;
            label62.Text = "Announcements";
            // 
            // panel17
            // 
            panel17.BackColor = Color.FromArgb(224, 224, 224);
            panel17.Location = new Point(3, 34);
            panel17.Name = "panel17";
            panel17.Size = new Size(285, 125);
            panel17.TabIndex = 37;
            // 
            // label63
            // 
            label63.AutoSize = true;
            label63.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label63.Location = new Point(3, 162);
            label63.Name = "label63";
            label63.Size = new Size(106, 31);
            label63.TabIndex = 36;
            label63.Text = "Calendar";
            // 
            // panel19
            // 
            panel19.BackColor = Color.White;
            panel19.Controls.Add(monthCalendar1);
            panel19.Location = new Point(3, 196);
            panel19.Name = "panel19";
            panel19.Size = new Size(361, 235);
            panel19.TabIndex = 37;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(11, 9);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // databaseBindingSource
            // 
            databaseBindingSource.DataSource = typeof(MultiForm.Database);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 543);
            Controls.Add(employeePanel);
            Name = "Form1";
            Text = "Car Rental - Employee Form";
            Load += Form1_Load;
            menuPanel.ResumeLayout(false);
            employeePanel.ResumeLayout(false);
            employeePanel.PerformLayout();
            reportsPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)reportData).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            accountInformationPanel.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            viewCarsPanel.ResumeLayout(false);
            viewCarsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)carData).EndInit();
            changeCarPanel.ResumeLayout(false);
            carTypePanel.ResumeLayout(false);
            carTypePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)branchCarTypeData).EndInit();
            modifyCarPanel.ResumeLayout(false);
            modifyCarPanel.PerformLayout();
            AddCarPanel.ResumeLayout(false);
            AddCarPanel.PerformLayout();
            generalPanel.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            panel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private Panel menuPanel;
        private RadioButton menuSignOutButton;
        private RadioButton menuReportsButton;
        private RadioButton menuChangeButton;
        private Label sectionTitleLabel;
        private CheckBox menuCheckBox;
        private Panel employeePanel;
        private Panel reportsPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button21;
        private Label label43;
        private RadioButton menuGeneralButton;
        private Panel generalPanel;
        private Label label62;
        private Panel panel17;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label63;
        private Panel panel19;
        private MonthCalendar monthCalendar1;
        private Panel changeCarPanel;
        private Label carTypeLabel;
        private Panel AddCarPanel;
        private ComboBox addModelIDComboBox;
        private ComboBox addBranchIDComboBox;
        private Label addCarMainLabel;
        private Button addCarResetButton;
        private Button addCarButton;
        private TextBox addCarIDText;
        private Label addCarIDlabel;
        private Label label38;
        private Label addBranchIDlabel;
        private Button goBackButton1;
        private TextBox addColorText;
        private Label addManufacturerLabel;
        private Label addColorLabel;
        private TextBox addManufacturerText;
        private Panel viewCarsPanel;
        private DataGridView carData;
        private Label label32;
        private TextBox searchTextBox;
        private Button addButton;
        private Button searchButton;
        private Button modifyButton;
        private Button deleteButtonn;
        private Label label6;
        private Panel modifyCarPanel;
        private Label modifyModelIDLabel;
        private ComboBox modifyModelIDComboBox;
        private ComboBox modifyBranchIDComboBox;
        private Label modifyCarMainLabel;
        private Button modifyCarResetButton;
        private Button modifyCarButton;
        private Label modifyCarIDLabel;
        private Label modifyCarTypeLabel;
        private Label modifyBranchIDLabel;
        private Button goBackButton2;
        private TextBox modifyColorText;
        private Label modifyManufacturer;
        private Label modifyColorLabel;
        private TextBox modifyManufacturerText;
        private Label label9;
        private ComboBox searchComboBox;
        private Panel panel3;
        private Panel panel1;
        private Panel panel6;
        private Label label4;
        private Button button8;
        private Panel panel5;
        private Label label3;
        private Button button6;
        private Panel panel4;
        private Label label2;
        private Button button5;
        private Panel panel2;
        private Label label1;
        private Button button3;
        private DataGridViewTextBoxColumn CarID;
        private BindingSource databaseBindingSource;
        private DataGridViewTextBoxColumn Manufacturer;
        private DataGridViewTextBoxColumn Colour;
        private DataGridViewTextBoxColumn BranchID;
        private DataGridViewTextBoxColumn ModelID;
        private Button showAllButton;
        private Panel carTypePanel;
        private Button showCarTypeButton;
        private DataGridView branchCarTypeData;
        private Label modifyCarIDValue;
        private Label label14;
        private Panel accountInformationPanel;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel10;
        private Label label50;
        private Label label49;
        private Panel panel11;
        private Label label48;
        private Label label51;
        private Panel panel12;
        private Label label52;
        private Label label53;
        private Panel panel13;
        private Label label54;
        private Label label55;
        private Panel panel15;
        private Label label58;
        private Label label59;
        private Panel panel14;
        private Label label56;
        private Label label57;
        private Panel panel7;
        private Label label5;
        private Label label7;
        private Panel panel8;
        private Label label8;
        private Label label10;
        private DataGridView reportData;
        private Label label11;
        private ComboBox report1ComboBox;
        private Label label12;
        private Button button1;
    }
}

namespace CarRentalApplication
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            createNewAccountPanel = new Panel();
            createNewAccountButton = new Button();
            customerPanel = new Panel();
            customerSignInButton2 = new Button();
            switchToEmployeeLink = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            employeePanel = new Panel();
            switchToCustomerLink = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            employeeSignInButton = new Button();
            employeeSignInLabel = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            createNewAccountPanel.SuspendLayout();
            customerPanel.SuspendLayout();
            employeePanel.SuspendLayout();
            SuspendLayout();
            // 
            // createNewAccountPanel
            // 
            createNewAccountPanel.BackColor = Color.White;
            createNewAccountPanel.Controls.Add(createNewAccountButton);
            createNewAccountPanel.Location = new Point(50, 392);
            createNewAccountPanel.Name = "createNewAccountPanel";
            createNewAccountPanel.Size = new Size(403, 115);
            createNewAccountPanel.TabIndex = 15;
            // 
            // createNewAccountButton
            // 
            createNewAccountButton.BackColor = Color.Transparent;
            createNewAccountButton.FlatStyle = FlatStyle.Flat;
            createNewAccountButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createNewAccountButton.ForeColor = Color.DodgerBlue;
            createNewAccountButton.Location = new Point(61, 21);
            createNewAccountButton.Name = "createNewAccountButton";
            createNewAccountButton.Padding = new Padding(5);
            createNewAccountButton.Size = new Size(274, 78);
            createNewAccountButton.TabIndex = 10;
            createNewAccountButton.Text = "Create a new account?";
            createNewAccountButton.UseVisualStyleBackColor = false;
            // 
            // customerPanel
            // 
            customerPanel.BackColor = Color.White;
            customerPanel.Controls.Add(customerSignInButton2);
            customerPanel.Controls.Add(switchToEmployeeLink);
            customerPanel.Controls.Add(label3);
            customerPanel.Controls.Add(label4);
            customerPanel.Controls.Add(label5);
            customerPanel.Controls.Add(textBox5);
            customerPanel.Controls.Add(textBox6);
            customerPanel.Location = new Point(49, 52);
            customerPanel.Name = "customerPanel";
            customerPanel.Size = new Size(403, 333);
            customerPanel.TabIndex = 16;
            customerPanel.Paint += customerPanel_Paint;
            // 
            // customerSignInButton2
            // 
            customerSignInButton2.BackColor = Color.DodgerBlue;
            customerSignInButton2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerSignInButton2.ForeColor = Color.White;
            customerSignInButton2.Location = new Point(104, 241);
            customerSignInButton2.Name = "customerSignInButton2";
            customerSignInButton2.Size = new Size(190, 43);
            customerSignInButton2.TabIndex = 16;
            customerSignInButton2.Text = "Sign In";
            customerSignInButton2.UseVisualStyleBackColor = false;
            customerSignInButton2.Click += customerSignInButton2_Click;
            // 
            // switchToEmployeeLink
            // 
            switchToEmployeeLink.AutoSize = true;
            switchToEmployeeLink.LinkColor = Color.Black;
            switchToEmployeeLink.Location = new Point(202, 302);
            switchToEmployeeLink.Name = "switchToEmployeeLink";
            switchToEmployeeLink.Size = new Size(189, 20);
            switchToEmployeeLink.TabIndex = 12;
            switchToEmployeeLink.TabStop = true;
            switchToEmployeeLink.Text = "Switch to Employee Sign In";
            switchToEmployeeLink.LinkClicked += switchToEmployeeLink_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(50, 85);
            label3.Name = "label3";
            label3.Size = new Size(253, 28);
            label3.TabIndex = 6;
            label3.Text = "Enter Phone Number/Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(50, 154);
            label4.Name = "label4";
            label4.Size = new Size(147, 28);
            label4.TabIndex = 7;
            label4.Text = "Enter Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(40, 18);
            label5.Name = "label5";
            label5.Size = new Size(246, 41);
            label5.TabIndex = 2;
            label5.Text = "Customer Sign In";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(50, 116);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(314, 27);
            textBox5.TabIndex = 3;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(50, 185);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(314, 27);
            textBox6.TabIndex = 4;
            // 
            // employeePanel
            // 
            employeePanel.BackColor = Color.White;
            employeePanel.Controls.Add(switchToCustomerLink);
            employeePanel.Controls.Add(label1);
            employeePanel.Controls.Add(label2);
            employeePanel.Controls.Add(employeeSignInButton);
            employeePanel.Controls.Add(employeeSignInLabel);
            employeePanel.Controls.Add(textBox3);
            employeePanel.Controls.Add(textBox4);
            employeePanel.Location = new Point(49, 53);
            employeePanel.Name = "employeePanel";
            employeePanel.Size = new Size(403, 333);
            employeePanel.TabIndex = 14;
            // 
            // switchToCustomerLink
            // 
            switchToCustomerLink.AutoSize = true;
            switchToCustomerLink.LinkColor = Color.Black;
            switchToCustomerLink.Location = new Point(203, 302);
            switchToCustomerLink.Name = "switchToCustomerLink";
            switchToCustomerLink.Size = new Size(184, 20);
            switchToCustomerLink.TabIndex = 15;
            switchToCustomerLink.TabStop = true;
            switchToCustomerLink.Text = "Switch to Customer sign In";
            switchToCustomerLink.LinkClicked += switchToCustomerLink_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(50, 85);
            label1.Name = "label1";
            label1.Size = new Size(253, 28);
            label1.TabIndex = 6;
            label1.Text = "Enter Phone Number/Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(50, 154);
            label2.Name = "label2";
            label2.Size = new Size(147, 28);
            label2.TabIndex = 7;
            label2.Text = "Enter Password:";
            // 
            // employeeSignInButton
            // 
            employeeSignInButton.BackColor = Color.DodgerBlue;
            employeeSignInButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeeSignInButton.ForeColor = Color.White;
            employeeSignInButton.Location = new Point(104, 245);
            employeeSignInButton.Name = "employeeSignInButton";
            employeeSignInButton.Size = new Size(190, 43);
            employeeSignInButton.TabIndex = 13;
            employeeSignInButton.Text = "Sign In";
            employeeSignInButton.UseVisualStyleBackColor = false;
            employeeSignInButton.Click += employeeSignInButton_Click;
            // 
            // employeeSignInLabel
            // 
            employeeSignInLabel.AutoSize = true;
            employeeSignInLabel.Font = new Font("Segoe UI", 18F);
            employeeSignInLabel.Location = new Point(40, 18);
            employeeSignInLabel.Name = "employeeSignInLabel";
            employeeSignInLabel.Size = new Size(248, 41);
            employeeSignInLabel.TabIndex = 2;
            employeeSignInLabel.Text = "Employee Sign In";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(50, 116);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(314, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(50, 185);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(314, 27);
            textBox4.TabIndex = 4;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(503, 559);
            Controls.Add(createNewAccountPanel);
            Controls.Add(customerPanel);
            Controls.Add(employeePanel);
            Name = "Form2";
            Text = "Sign In";
            Load += Form2_Load;
            createNewAccountPanel.ResumeLayout(false);
            customerPanel.ResumeLayout(false);
            customerPanel.PerformLayout();
            employeePanel.ResumeLayout(false);
            employeePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private LinkLabel linkLabel1;
        private Button button1;
        private Button button2;
        private LinkLabel changeSignInlLinkLabel;
        private LinkLabel switchToCustomerLinkLabel;
        private LinkLabel switchToEmployeeSignIn;
        private Button customerSignInButton;
        private Panel createNewAccountPanel;
        private Button createNewAccountButton;
        private Panel customerPanel;
        private Button customerSignInButton2;
        private LinkLabel switchToEmployeeLink;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private TextBox textBox6;
        private Panel employeePanel;
        private LinkLabel switchToCustomerLink;
        private Label label1;
        private Label label2;
        private Button employeeSignInButton;
        private Label employeeSignInLabel;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
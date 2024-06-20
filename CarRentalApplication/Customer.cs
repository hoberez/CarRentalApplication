using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApplication
{
    internal class Customer
    {
        private string customerID;
        private string firstName;
        private string lastName;
        private Address address;
        private string phoneNumber;
        private string emailAddress;

        public Customer(string customerID, string firstName, string lastName, Address address, string phoneNumber, string emailAddress)
        {
            this.customerID = customerID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
        }

        //GETTER methods
        public string CustomerID { get { return customerID; } }
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public Address Address { get { return address; } }
        public string PhoneNumber { get { return phoneNumber; } }
        public string EmailAddress { get { return emailAddress; } }
    }
}


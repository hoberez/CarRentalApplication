using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApplication
{
    internal class Employee
    {
        private string employeeID;

        private string firstName;
        private string lastName;
        private Address address;

        public Employee(string firstName, string lastName, Address address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
        }

        public string FirstName {  get { return firstName; } }
        public string LastName { get { return lastName; } }
        public Address Address { get { return address; } }
    }
}

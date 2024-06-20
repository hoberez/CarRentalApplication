using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApplication
{
    internal class Branch
    {
        private string branchID;
        private string name;
        private Address address;

        public Branch(string branchID, string name, Address address) 
        {
            this.branchID = branchID;
            this.name = name;
            this.address = address;
           
        }

        public override string ToString()
        {
            return name + ": " + address.Street;
        }
        // GETTER methods
        public string BranchID {  get { return branchID; } }
        public string Name { get { return name; } }
        public Address Address { get { return address; } }

    }
}

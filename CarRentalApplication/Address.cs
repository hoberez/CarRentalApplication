using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApplication
{
    internal class Address
    {
        private string street;
        private string postalCode;
        private string city;
        private string province;
        public Address(string street, string postalCode, string city, string province)
        {
            this.street = street;
            this.postalCode = postalCode;
            this.city = city;
            this.province = province;
        }

        // GETTER methods
        public string Street { get { return this.street; } }
        public string PostalCode { get { return this.postalCode; } }
        public string City { get { return this.city; } }
        public string Province { get { return this.province; } }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApplication
{
    internal class Data
    {
        private Dictionary<string, Car> cars;
        private Dictionary<string, CarType> carTypes;
        private Dictionary<string, Branch> branches;
        private Dictionary<string, Employee> employees;
        private Dictionary<string, Customer> customers;
        private Dictionary<string, RentalTransaction> rentalTransactions;

        public Data(Dictionary<string, Car> cars, Dictionary<string, CarType> carTypes, Dictionary<string, Branch> branches, Dictionary<string, Employee> employees, Dictionary<string, Customer> customers, Dictionary<string, RentalTransaction> rentalTransactions)
        {
            this.cars = cars;
            this.carTypes = carTypes;
            this.branches = branches;
            this.employees = employees;
            this.customers = customers;
            this.rentalTransactions = rentalTransactions;
        }

        public Dictionary<string, Car> Cars { get { return cars; } }
        public Dictionary<string, CarType> CarType { get { return carTypes; } }
        public Dictionary<string, Branch> Branches { get { return branches; } }
        public Dictionary<string, Customer> Customers { get { return customers; } }
        public Dictionary<string, RentalTransaction> RentalTransactions { get { return rentalTransactions; } }
    }
}

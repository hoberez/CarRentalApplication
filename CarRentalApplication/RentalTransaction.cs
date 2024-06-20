using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApplication
{
    internal class RentalTransaction
    {
        private string registrationID;
        private string dateFrom;
        private string dateTo;
        private float fees;
        private float totalCost;
        private string fromBranchID;
        private string toBranchID;
        private string employeeID;
        private string customerID;
        private string carID;

        public RentalTransaction(string registrationID, string dateFrom, string dateTo, float fees, float totalCost, string fromBranchID, string toBranchID, string employeeID, string customerID, string carID)
        {
            this.registrationID = registrationID;
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;
            this.fees = fees;
            this.totalCost = totalCost;
            this.fromBranchID = fromBranchID;
            this.toBranchID = toBranchID;
            this.employeeID = employeeID;
            this.customerID = customerID;
            this.carID = carID;
        }

        public string RegistrationID {  get { return registrationID; } }
        public string DateFrom { get { return dateFrom; } }
        public string DateTo { get { return dateTo; } }
        public float Fees { get { return fees; } }
        public float TotalCost { get { return totalCost; } }
        public string FromBranchID { get { return fromBranchID;} }
        public string ToBranchID { get { return toBranchID;} }
        public string EmployeeID { get { return employeeID;} }
        public string CustomerID { get { return customerID;} }
        public string CarID { get { return carID;} }
    }
}

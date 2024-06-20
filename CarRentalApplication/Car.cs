using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApplication
{
    internal class Car
    {
        private string carID;
        private string manufacturer;
        private string colour;
        private string modelID;
        private string branchID;

        public Car(string carID, string manufacturer, string colour, string modelID, string branchID) 
        { 
            this.carID = carID;
            this.manufacturer = manufacturer;
            this.colour = colour;
            this.modelID = modelID;
            this.branchID = branchID;
        }


        //GETTER methods
        public string CarID { get { return carID; } }
        public string Manufacturer { get { return manufacturer; } }
        public string Colour { get { return colour; } }
        public string ModelID { get {return modelID; } }
        public string BranchID { get {return branchID;} }
    }
}

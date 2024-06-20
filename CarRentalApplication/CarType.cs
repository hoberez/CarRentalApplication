using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApplication
{
    internal class CarType
    {
        private string modelID;
        private string modelDesc;
        private int capacity;
        private Rate rate;

        public CarType(string modelID, string modelDesc, int capacity, Rate rate)
        {
            this.modelID = modelID;
            this.modelDesc = modelDesc;
            this.capacity = capacity;
            this.rate = rate;
        }

        // GETTER Methods
        public string ModelID { get { return modelID; } }
        public string ModelDesc { get { return modelDesc; } }
        public int Capacity { get { return capacity; } }
        public Rate Rate { get { return rate; } }

    }
}

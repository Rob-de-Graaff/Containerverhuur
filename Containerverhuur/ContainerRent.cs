using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containerverhuur
{
    class ContainerRent
    {
        private string name;
        private double rent;
        private double collectMin;
        private double collectMax;
        private double discount;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Rent
        {
            get { return rent; }
            set { rent = value; }
        }

        public double CollectMin
        {
            get { return collectMin; }
            set { collectMin = value; }
        }

        public double CollectMax
        {
            get { return collectMax; }
            set { collectMax = value; }
        }

        public double Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public ContainerRent(string containerName, double containerRent, double containerCollectMin, double containerCollectMax, double containerDiscount)
        {
            name = containerName;
            rent = containerRent;
            collectMin = containerCollectMin;
            collectMax = containerCollectMax;
            discount = containerDiscount;
        }
    }
}

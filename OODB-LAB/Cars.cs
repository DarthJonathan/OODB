using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODB_LAB
{
    class Cars
    {
        private String id { get; set; }
        private String carName { get; set; }
        private int rentPrice { get; set; }
        private String carType { get; set; }
        private int carYear { get; set; }

        public Cars (String carName, int rentPrice, String carType, int carYear)
        {
            this.carName = carName;
            this.rentPrice = rentPrice;
            this.carType = carType;
            this.carYear = carYear;
        }

    }
}

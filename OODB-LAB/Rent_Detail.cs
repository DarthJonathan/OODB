using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODB_LAB
{
    class Rent_Detail
    {
        private String rent_id { get; set; }
        private String car_id { get; set; }
        private int quantity { get; set; }

        public Rent_Detail (String rent_id, String car_id, int quantity)
        {
            this.rent_id = rent_id;
            this.car_id = car_id;
            this.quantity = quantity;
        }
    }
}

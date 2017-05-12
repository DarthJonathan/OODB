using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODB_LAB
{
    class Rents
    {
        private String id { get; set; }
        private String user_id { get; set; }
        private int duration { get; set; }
        private String rentDate { get; set; }
        private int status { get; set; }

        public Rents (String user_id, int duration, String rentDate, int status)
        {
            this.user_id = user_id;
            this.duration = duration;
            this.rentDate = rentDate;
            this.status = status;
        }
  
    }
}

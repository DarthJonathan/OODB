using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODB_LAB
{
    class Reviews
    {
        private String id { get; set; }
        private String rentID { get; set; }
        private String userID { get; set; }
        private String contentReview { get; set; }

        public Reviews (String rentID, String userID, String contentReview)
        {
            this.rentID = userID;
            this.userID = userID;
            this.contentReview = contentReview;
        }
    }
}

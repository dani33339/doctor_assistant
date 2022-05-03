using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor_assistant
{
     public class Patientsinfo
    {
        //bais Data
        public MongoDB.Bson.ObjectId Id_unic { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int PhoneNumber { get; set; }
        public String Gender { get; set; }
        public String Id { get; set; }
        public String City { get; set; }
        public String Street { get; set; }
        public String HouseNumber { get; set; }
        public String Age { get; set; }

       
        //Navigation Properties
        public int DoctorId { get; set; }
        public DoctorInfo Doctor { get; set; }
    }
}

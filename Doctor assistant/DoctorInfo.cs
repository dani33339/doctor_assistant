using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Doctor_assistant
{
    public class DoctorInfo
    {
        public String Id { get; set; }
        public MongoDB.Bson.ObjectId Id_unic { get; set; }
        public String UserName { get; set; }
        public String FullName { get; set; }
        public String Password { get; set; }
        //Navigation Properties
        public List<MongoDB.Bson.ObjectId> Patients { get; set; }

    }
}

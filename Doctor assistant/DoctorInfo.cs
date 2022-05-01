using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Doctor_assistant
{
    class DoctorInfo
    {
        public String Id_unic { get; set; }
        public MongoDB.Bson.ObjectId Id { get; set; }
        public String UserName { get; set; }
        public String FullName { get; set; }
        public String Password { get; set; }

    }
}

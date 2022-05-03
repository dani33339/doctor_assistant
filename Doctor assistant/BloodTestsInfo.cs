using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor_assistant
{
    public class BloodTestsInfo
    {
        public MongoDB.Bson.ObjectId Id { get; set; }
        public int WBC { get; set; }
        public int Neut { get; set; }
        public int Lymph { get; set; }
        public int RBC { get; set; }
        public int HCT { get; set; }
        public int UREA { get; set; }
        public int Hb { get; set; }
        public int Crtn { get; set; }
        public int iron { get; set; }
        public int HDL { get; set; }
        public int AP { get; set; }


        //Navigation Properties
        public int PatientId { get; set; }
        public Patientsinfo Patien { get; set; }
    }
}

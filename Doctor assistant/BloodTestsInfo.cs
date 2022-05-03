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
        public double WBC { get; set; }
        public double Neut { get; set; }
        public double Lymph { get; set; }
        public double RBC { get; set; }
        public double HCT { get; set; }
        public double UREA { get; set; }
        public double Hb { get; set; }
        public double Crtn { get; set; }
        public double iron { get; set; }
        public double HDL { get; set; }
        public double AP { get; set; }


        //Navigation Properties
        public int PatientId { get; set; }
        public Patientsinfo Patient { get; set; }
    }
}

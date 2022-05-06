using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Doctor_assistant.Forms
{
    public partial class Diagnosis : Form
    {
        public DoctorInfo doctor;
        public Patientsinfo patient;
        public BloodTestsInfo bloodtest;


        int numberofQuestions=3;
        Questions[] array = new Question[numberofQuestions];

        //Dictionary<string, Boolean> Questions = new Dictionary<string, Boolean>(){
        //{"המטופל מעשן",false} ,{" המטופל יוצא עדות המזרח",false},{"המטופל אתיופי",false} };
        

        public Diagnosis(DoctorInfo obj1, Patientsinfo obj2,BloodTestsInfo obj3)
        {
            InitializeComponent();
            doctor = obj1;
            patient = obj2;
            bloodtest = obj3;

            docname_label.Text = "שלום דוקטור \n" + doctor.FullName;

            if (patient.Gender == "נקבה")
                Questions.Add("האם את בהריון", false);

            currentquestions=

            AskQuestions();
            MakeDiagnosis();
        }

        public void AskQuestions ()
        {

        }

        public void MakeDiagnosis() 
        {
            Dictionary<string, string> Recomendation = new Dictionary<string, string>(){
            {"anemia","Two 10 mg B12 pills a day for a month"},
            {"diet","Schedule an appointment with Nutrition"},
            {"bleeding","To be rushed to the hospital urgently"},
            {"Hyperlipidemia", "Schedule an appointment with a nutritionist, a 5 mg pill of Simobil daily for a week"},
            {"Disruption of blood / blood cell formation", "10 mg pill of B12 a day for a month, 5 mg pill of folic acid a day for a month "},
            {"Hematological disorder", "An injection of a hormone to encourage red blood cell production"},
            {"Iron poisoning", "To be evacuated to the hospital"},
            {"Dehydration", "Complete rest while lying down, returning fluids to drinking"},
            {"Infection", "Dedicated antibiotics"},
            {"Vitamin deficiency", "Referral for a blood test to identify the missing vitamins"},
            {"Viral disease", "Rest at home"},
            {"Diseases of the biliary tract", "Referral to surgical treatment"},
            {"Heart disease", "Schedule an appointment with a nutritionist"},
            {"Blood disease", "A combination of cyclophosphamide and corticosteroids"},
            {"Liver disease", "Referral to a specific diagnosis for the purpose of determining treatment"},
            {"Kidney disease", "Balance blood sugar levels"},
            {"Iron deficiency", "Two 10 mg B12 pills a day for a month"},
            {"Muscle diseases", "Two 5 mg pills of Altman c3 turmeric a day for a month"},
            {"Smokers", "to stop smoking"},
            {"Lung disease", "Stop smoking / Refer to an X-ray of the lungs"},
            {"Overactive thyroid gland", "Propylthiouracil to reduce thyroid activity"},
            {"Adult Diabetes", "Insulin adjustment for the patient"},
            {"cancer", "Antarctinib - Entrectinib"},
            {"Increased consumption of meat", "Schedule an appointment with a nutritionist"},
            {"Use of various medications","Referral to a family doctor for a match between medications"},
            {"Malnutrition", "Schedule an appointment with Nutrition"}
            };

            String diagnosis = "";
            String OutRecomendation = "";
            //WBC
            if ((Convert.ToDouble(bloodtest.WBC) > 11000 && patient.Age >= 18) ||
                (Convert.ToDouble(bloodtest.WBC) > 15500 && patient.Age > 3 && patient.Age < 17) ||
                (Convert.ToDouble(bloodtest.WBC) > 17500 && patient.Age < 3))
            {
                diagnosis = diagnosis + "Infection"+",";
                OutRecomendation = OutRecomendation + "," + Recomendation["Infection"];
            }
            if ((bloodtest.WBC < 4500 && patient.Age >= 18) ||
                (bloodtest.WBC < 5500 && patient.Age > 3 && patient.Age < 17) ||
                (bloodtest.WBC < 6000 && patient.Age < 3))
            {
                diagnosis = diagnosis + "Viral disease"+",";
                OutRecomendation = OutRecomendation + "," + Recomendation["Viral disease"];
            }

            //Neut
            if (bloodtest.Neut > 54)
            {
                if (!diagnosis.Contains("Infection"))
                {
                    diagnosis = diagnosis + "Infection";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Infection"];
                }
            }
            if (bloodtest.Neut < 28)
            {
                diagnosis = diagnosis + "Disruption of blood / blood cell formation";
                OutRecomendation = OutRecomendation + "," + Recomendation["Disruption of blood / blood cell formation"];
            }

            //Lymph
            if (bloodtest.Lymph > 52)
            {
                if (!diagnosis.Contains("Infection"))
                {
                    diagnosis = diagnosis + "Infection";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Infection"] + "or" + " ";
                }
                if (!diagnosis.Contains("cancer"))
                {
                    diagnosis = diagnosis + "cancer";
                    OutRecomendation = OutRecomendation + "," + Recomendation["cancer"];
                }
            }
            if (bloodtest.Lymph < 36)
            {
                if (!diagnosis.Contains("Disruption of blood / blood cell formation"))
                {
                    diagnosis = diagnosis + "Disruption of blood / blood cell formation";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Disruption of blood / blood cell formation"];
                }
            }

            //RBC
            if (bloodtest.RBC > 6)
            {
                if (!diagnosis.Contains("Disruption of blood / blood cell formation"))
                {
                    diagnosis = diagnosis + "Disruption of blood / blood cell formation";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Infection"] + "or" + " ";
                }
                if (!diagnosis.Contains("Smokers"))
                {
                    diagnosis = diagnosis + "Smokers";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Smokers"] + "or" + " ";
                }
                if (!diagnosis.Contains("Lung disease"))
                {
                    diagnosis = diagnosis + "Lung disease";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Lung disease"] + ",";
                }
            }
            if (bloodtest.RBC < 4.5)
            {
                if (!diagnosis.Contains("anemia"))
                {
                    diagnosis = diagnosis + "anemia";
                    OutRecomendation = OutRecomendation + "," + Recomendation["anemia"] + "or" + " ";
                }
                if (!diagnosis.Contains("bleeding"))
                {
                    diagnosis = diagnosis + "bleeding";
                    OutRecomendation = OutRecomendation + "," + Recomendation["bleeding"];
                }
            }

            //HCT
            if ((bloodtest.HCT > 54 && patient.Gender == "זכר") ||
                (bloodtest.HCT > 47 && patient.Gender == "נקבה"))
            {
                if (!diagnosis.Contains("Smokers"))
                {
                    diagnosis = diagnosis + "Smokers";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Smokers"];
                }
            }

            if ((bloodtest.HCT < 37 && patient.Gender == "זכר") ||
                (bloodtest.HCT < 33 && patient.Gender == "נקבה"))
            {
                if (!diagnosis.Contains("anemia"))
                {
                    diagnosis = diagnosis + "anemia";
                    OutRecomendation = OutRecomendation + "," + Recomendation["anemia"] + "or" + " ";
                }
                if (!diagnosis.Contains("bleeding"))
                {
                    diagnosis = diagnosis + "bleeding";
                    OutRecomendation = OutRecomendation + "," + Recomendation["bleeding"];
                }
            }

            //Urea
            if (bloodtest.UREA > 43)
            {
                if (!diagnosis.Contains("Kidney disease"))
                {
                    diagnosis = diagnosis + "Kidney disease";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Kidney disease"] + "or" + " ";
                }
                if (!diagnosis.Contains("Dehydration"))
                {
                    diagnosis = diagnosis + "Dehydration";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Dehydration"] + "or" + " ";
                }
                if (!diagnosis.Contains("diet"))
                {
                    diagnosis = diagnosis + "diet";
                    OutRecomendation = OutRecomendation + "," + Recomendation["bleeding"];
                }
            }
            if (bloodtest.UREA < 17)
            {
                if (!diagnosis.Contains("Malnutrition"))
                {
                    diagnosis = diagnosis + "Malnutrition";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Malnutrition"] + "or" + " ";
                }
                if (!diagnosis.Contains("diet"))
                {
                    diagnosis = diagnosis + "diet";
                    OutRecomendation = OutRecomendation + "," + Recomendation["diet"] + "or" + " ";
                }
                if (!diagnosis.Contains("Liver disease"))
                {
                    diagnosis = diagnosis + "Liver disease";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Liver disease"];
                }
            }

            //Hb
            if ((bloodtest.Hb < 12 && patient.Age >= 18) ||
                (bloodtest.Hb < 11.5 && patient.Age < 18))
            {
                if (!diagnosis.Contains("anemia"))
                {
                    diagnosis = diagnosis + "anemia";
                    OutRecomendation = OutRecomendation + "," + Recomendation["anemia"] + "or" + " ";
                }
                if (!diagnosis.Contains("Hematological disorder"))
                {
                    diagnosis = diagnosis + "diet";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Hematological disorder"] + "or" + " ";
                }
                if (!diagnosis.Contains("Iron deficiency"))
                {
                    diagnosis = diagnosis + "Iron deficiency";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Iron deficiency"];
                }
                if (!diagnosis.Contains("bleeding"))
                {
                    diagnosis = diagnosis + "bleeding";
                    OutRecomendation = OutRecomendation + "," + Recomendation["bleeding"];
                }
            }

            //Crtn
            if ((bloodtest.Crtn > 1 && patient.Age >= 3 && patient.Age <= 59) ||
                (bloodtest.Crtn < 1.2 && patient.Age >= 60) ||
                (bloodtest.Crtn < 0.5 && patient.Age < 3))
            {
                if (!diagnosis.Contains("Kidney disease"))
                {
                    diagnosis = diagnosis + "Kidney disease";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Kidney disease"] + "or" + " ";
                }
                if (!diagnosis.Contains("Muscle diseases"))
                {
                    diagnosis = diagnosis + "Muscle diseases";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Muscle diseases"] + "or" + " ";
                }
                if (!diagnosis.Contains("Increased consumption of meat"))
                {
                    diagnosis = diagnosis + "Increased consumption of meat";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Increased consumption of meat"];
                }
            }

            if ((bloodtest.Crtn < 0.6 && patient.Age >= 18) ||
                (bloodtest.Crtn < 0.5 && patient.Age >= 3 && patient.Age >= 17) ||
                (bloodtest.Crtn < 0.2 && patient.Age < 3))
            {
                if (!diagnosis.Contains("Muscle diseases"))
                {
                    diagnosis = diagnosis + "Muscle diseases";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Muscle diseases"] + "or" + " ";
                }
                if (!diagnosis.Contains("Malnutrition"))
                {
                    diagnosis = diagnosis + "Muscle diseases";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Malnutrition"];
                }
            }

            //Iron
            if ((bloodtest.iron > 160 && patient.Gender == "זכר") ||
                (bloodtest.iron > 160 - 160 * 0.2 && patient.Gender == "נקבה"))
            {
                if (!diagnosis.Contains("Iron poisoning"))
                {
                    diagnosis = diagnosis + "Iron poisoning";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Iron poisoning"];
                }
            }

            if ((bloodtest.iron < 60 && patient.Gender == "זכר") ||
                (bloodtest.iron < 60 - 60 * 0.2 && patient.Gender == "נקבה"))
            {
                if (!diagnosis.Contains("Malnutrition"))
                {
                    diagnosis = diagnosis + "Malnutrition";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Malnutrition"] + "or" + " ";
                }
                if (!diagnosis.Contains("Iron deficiency"))
                {
                    diagnosis = diagnosis + "Iron deficiency";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Iron deficiency"] + "or" + " ";
                }
                if (!diagnosis.Contains("bleeding"))
                {
                    diagnosis = diagnosis + "bleeding";
                    OutRecomendation = OutRecomendation + "," + Recomendation["bleeding"];
                }
            }

            //HDL
            if ((bloodtest.HDL < 29 && patient.Gender == "זכר") ||
               (bloodtest.HDL < 34 && patient.Gender == "נקבה"))
            {
                if (!diagnosis.Contains("Heart disease"))
                {
                    diagnosis = diagnosis + "Heart disease";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Heart disease"] + "or" + " ";
                }
                if (!diagnosis.Contains("Hyperlipidemia"))
                {
                    diagnosis = diagnosis + "Hyperlipidemia";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Hyperlipidemia"] + "or" + " ";
                }
                if (!diagnosis.Contains("Adult diabetes"))
                {
                    diagnosis = diagnosis + "Adult diabetes";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Adult diabetes"];
                }
            }

            //AP
            if (bloodtest.AP > 90)
            {
                if (!diagnosis.Contains("Liver disease"))
                {
                    diagnosis = diagnosis + "Heart disease";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Heart disease"] + "or" + " ";
                }
                if (!diagnosis.Contains("Diseases of the biliary tract"))
                {
                    diagnosis = diagnosis + "Diseases of the biliary tract";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Diseases of the biliary tract"] + "or" + " ";
                }
                if (!diagnosis.Contains("Overactive thyroid gland"))
                {
                    diagnosis = diagnosis + "Overactive thyroid gland";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Overactive thyroid gland"] + "or" + " ";
                }
                if (!diagnosis.Contains("Use of various medications"))
                {
                    diagnosis = diagnosis + "Use of various medications";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Use of various medications"] + "or" + " ";
                }
            }

            if (bloodtest.AP < 30)
            {
                if (!diagnosis.Contains("Malnutrition"))
                {
                    diagnosis = diagnosis + "Malnutrition";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Malnutrition"] + "or" + " ";
                }
                if (!diagnosis.Contains("Vitamin deficiency"))
                {
                    diagnosis = diagnosis + "Vitamin deficiency";
                    OutRecomendation = OutRecomendation + "," + Recomendation["Vitamin deficiency"];
                }
            }

            MessageBox.Show(diagnosis);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void docname_label_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MyPatients_btn_Click(object sender, EventArgs e)
        {
            Patients newForm = new Patients(doctor);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private void AddPatients_btn_Click(object sender, EventArgs e)
        {
            Addpatients newForm = new Addpatients(doctor);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
                question_label.Text = entry.Key;
            }
        }
    }
}

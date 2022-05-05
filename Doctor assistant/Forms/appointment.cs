using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using MongoDB.Driver;


namespace Doctor_assistant.Forms
{
    public partial class appointment : Form
    {
        MongoClient Pm_Client, Bm_Client;
        IMongoDatabase Pm_Database,Bm_Database;
        IMongoCollection<Patientsinfo> Pm_Collection;
        IMongoCollection<BloodTestsInfo> Bm_Collection;


        public DoctorInfo doctor;
        public Patientsinfo patient;

        public appointment(DoctorInfo obj1, Patientsinfo obj2)
        {
            InitializeComponent();
            dataGridView.Visible = false;

            Pm_Client = new MongoClient("mongodb+srv://antonvo:0nCdIz2V538QvyD1@cluster0.frcvr.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            Pm_Database = Pm_Client.GetDatabase("Patients");
            Pm_Collection = Pm_Database.GetCollection<Patientsinfo>("Data");

            Bm_Client = new MongoClient("mongodb+srv://antonvo:0nCdIz2V538QvyD1@cluster0.frcvr.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            Bm_Database = Bm_Client.GetDatabase("BloodTests");
            Bm_Collection = Bm_Database.GetCollection<BloodTestsInfo>("Data");


            doctor = obj1;
            patient = obj2;
            docname_label.Text = "שלום דוקטור \n" + doctor.FullName;
            patientname_label.Text = patient.FirstName +" "+ patient.LastName;
            pantientid_label.Text = patient.PId;
        }

        private void imortfile_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            dataGridView.DataSource = result.Tables["גיליון1"];
                            dataGridView.Visible = true;
                            BloodTestsInfo NewBloodTestsInfo = new BloodTestsInfo();
                            NewBloodTestsInfo.WBC = Convert.ToDouble(dataGridView.Columns[1].Name);
                            NewBloodTestsInfo.Neut = Convert.ToDouble(dataGridView.Rows[0].Cells[1].Value.ToString());
                            NewBloodTestsInfo.Lymph = Convert.ToDouble(dataGridView.Rows[1].Cells[1].Value.ToString());
                            NewBloodTestsInfo.RBC = Convert.ToDouble(dataGridView.Rows[2].Cells[1].Value.ToString());
                            NewBloodTestsInfo.HCT = Convert.ToDouble(dataGridView.Rows[3].Cells[1].Value.ToString());
                            NewBloodTestsInfo.UREA = Convert.ToDouble(dataGridView.Rows[4].Cells[1].Value.ToString());
                            NewBloodTestsInfo.Hb = Convert.ToDouble(dataGridView.Rows[5].Cells[1].Value.ToString());
                            NewBloodTestsInfo.Crtn = Convert.ToDouble(dataGridView.Rows[6].Cells[1].Value.ToString());
                            NewBloodTestsInfo.iron = Convert.ToDouble(dataGridView.Rows[7].Cells[1].Value.ToString());
                            NewBloodTestsInfo.HDL = Convert.ToDouble(dataGridView.Rows[8].Cells[1].Value.ToString());
                            NewBloodTestsInfo.AP = Convert.ToDouble(dataGridView.Rows[9].Cells[1].Value.ToString());
                            NewBloodTestsInfo.PatientId = patient.PId;
                            NewBloodTestsInfo.Patient = patient;
                            Bm_Collection.InsertOne(NewBloodTestsInfo);
                            patient.BloodTests.Add(NewBloodTestsInfo.Id);

                            var updateDfinition = Builders<Patientsinfo>.Update.Set(a => a.BloodTests, patient.BloodTests);
                            var filter = Builders<Patientsinfo>.Filter;
                            var patientfilter = filter.Eq(x => x.Id, patient.Id);
                            Pm_Collection.UpdateOne(patientfilter, updateDfinition);
                            MessageBox.Show("BloodTest has been successfully saved.");
                        }
                    }
                }
            }
        }

        private void docname_label_Click(object sender, EventArgs e)
        {
            
        }

        private void medicalindices_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void appointment_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void diagnosis_btn_Click(object sender, EventArgs e)
        {
            int numberofDiseases = 26;
                    
            Dictionary<string, string> Recomendation =new Dictionary<string, string>(){
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
            if ((Convert.ToDouble(dataGridView.Columns[1].Name) > 11000 && Int32.Parse(patient.Age) >= 18) ||
                (Convert.ToDouble(dataGridView.Columns[1].Name) > 15500 && Int32.Parse(patient.Age) > 3 && Int32.Parse(patient.Age) < 17) ||
                (Convert.ToDouble(dataGridView.Columns[1].Name) > 17500 && Int32.Parse(patient.Age) < 3))
            {
                diagnosis = diagnosis + "Infection";
                OutRecomendation = OutRecomendation + Recomendation["Infection"];
            }

            if ((Convert.ToDouble(dataGridView.Columns[1].Name) < 4500 && Int32.Parse(patient.Age) >= 18) ||
                (Convert.ToDouble(dataGridView.Columns[1].Name) < 5500 && Int32.Parse(patient.Age) > 3 && Int32.Parse(patient.Age) < 17) ||
                (Convert.ToDouble(dataGridView.Columns[1].Name) < 6000 && Int32.Parse(patient.Age) < 3))
            {
                diagnosis = diagnosis + "Viral disease";
                OutRecomendation = OutRecomendation + Recomendation["Viral disease"];
            }

            if (Convert.ToDouble(dataGridView.Columns[2].Name) > 54)
            {
                if (!diagnosis.Contains("Infection"))
                {
                    diagnosis = diagnosis + "Infection";
                    OutRecomendation = OutRecomendation + Recomendation["Infection"];
                }
            }

            if (Convert.ToDouble(dataGridView.Columns[2].Name) < 28)
            {             
                    diagnosis = diagnosis + "Disruption of blood / blood cell formation";
                    OutRecomendation = OutRecomendation + Recomendation["Disruption of blood / blood cell formation"];               
            }

            if (Convert.ToDouble(dataGridView.Columns[3].Name) > 52)
            {
                if (!diagnosis.Contains("Infection"))
                { 
                    diagnosis = diagnosis + "Infection" ;
                    OutRecomendation = OutRecomendation + Recomendation["Infection"] + "or" + " ";
                }
                if (!diagnosis.Contains("cancer"))
                {
                    diagnosis = diagnosis + "cancer";
                    OutRecomendation = OutRecomendation +  Recomendation["cancer"];
                }
            }

            if (Convert.ToDouble(dataGridView.Columns[3].Name) < 36)
            {
                if (!diagnosis.Contains("Disruption of blood / blood cell formation"))
                {
                    diagnosis = diagnosis + "Disruption of blood / blood cell formation";
                    OutRecomendation = OutRecomendation + Recomendation["Disruption of blood / blood cell formation"];
                }
            }

            if (Convert.ToDouble(dataGridView.Columns[4].Name) > 6)
            {

            }










                //Diagnosis newForm = new Diagnosis(doctor);
                //this.Hide();
                //newForm.ShowDialog();
                //this.Close();
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
    }

}

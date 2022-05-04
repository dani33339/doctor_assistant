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
            int[] diagnosis = new int[numberofDiseases];
            Array.Clear(diagnosis, 0, diagnosis.Length);//set 0 to all values
            Dictionary<string, double> My_dict2 =new Dictionary<string, double>(){
             {"anemia", 0},{"diet", 0},{"bleeding", 0},{"bleeding", 0},{"bleeding", 0},{"bleeding", 0},{"bleeding", 0},
            {"Hyperlipidemia", 0},{"Blood cell disorder", 0},{"Hematological disorder", 0},{"Iron poisoning", 0},
            {"Dehydration", 0},{"Infection", 0},{"Vitamin deficiency", 0},{"Viral disease", 0},{"Diseases of the biliary tract", 0},{"bleeding", 0},
            {"Heart disease", 0},
            {"Blood disease", 0},{"Liver disease", 0},{"Kidney disease", 0},{"Iron deficiency", 0},{"Muscle diseases", 0},
            {"Smokers", 0},{"Lung disease", 0},{"Overactive thyroid gland", 0},{"Adult Diabetes", 0},{"cancer", 0},
            {"Increased consumption of meat", 0},{"Use of various medications", 0},{"Malnutrition", 0}};

            String diagnosis="";
            if ((Convert.ToDouble(dataGridView.Columns[1].Name) > 11000 && Int32.Parse(patient.Age) >= 18) ||
                (Convert.ToDouble(dataGridView.Columns[1].Name) > 15500 && Int32.Parse(patient.Age) > 3 && Int32.Parse(patient.Age) < 17) ||
                (Convert.ToDouble(dataGridView.Columns[1].Name) > 17500 && Int32.Parse(patient.Age) < 3))
                diagnosis = diagnosis + ", Infection";

            if ((Convert.ToDouble(dataGridView.Columns[1].Name) < 4500 && Int32.Parse(patient.Age) >= 18) ||
                (Convert.ToDouble(dataGridView.Columns[1].Name) < 5500 && Int32.Parse(patient.Age) > 3 && Int32.Parse(patient.Age) < 17) ||
                (Convert.ToDouble(dataGridView.Columns[1].Name) < 6000 && Int32.Parse(patient.Age) < 3))
                diagnosis = diagnosis + "Viral disease";



            //Diagnosis newForm = new Diagnosis(doctor);
            //this.Hide();
            //newForm.ShowDialog();
            //this.Close();
        }

        public String  ()
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

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
            doctor = obj1;
            patient = obj2;

            InitializeComponent();


            Pm_Client = new MongoClient("mongodb+srv://antonvo:0nCdIz2V538QvyD1@cluster0.frcvr.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            Pm_Database = Pm_Client.GetDatabase("Patients");
            Pm_Collection = Pm_Database.GetCollection<Patientsinfo>("Data");

            Bm_Client = new MongoClient("mongodb+srv://antonvo:0nCdIz2V538QvyD1@cluster0.frcvr.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            Bm_Database = Bm_Client.GetDatabase("BloodTests");
            Bm_Collection = Bm_Database.GetCollection<BloodTestsInfo>("Data");

            docname_label.Text = "שלום דוקטור \n" + doctor.FullName;
            patientname_label.Text = patient.FirstName + " " + patient.LastName;
            pantientid_label.Text = patient.PId;
            dataGridView.Visible = false;
            testexists_label.Visible = false;
            appointment_label.Text = "צור ביקור ל" + patient.FirstName;

            //if patient have bloodtest in the db
            if (patient.BloodTests.Count() > 0)
                FilldataGridView();

        }

        /*import last test from the db*/
        public void FilldataGridView()
        {

            imortfile_btn.ButtonText = "ייבא קובץ בדיקות דם חדשות";
            dataGridView.Visible = true;
            testexists_label.Visible = true;
            MongoDB.Bson.ObjectId mostrecent = patient.BloodTests.Last();
            var bloodtest = BloodTestsInfoFinder(mostrecent);
            dataGridView.Columns.Add("WBC", "WBC");
            dataGridView.Columns.Add("Neut", "Neut");
            dataGridView.Columns.Add("Lymph", "Lymph");
            dataGridView.Columns.Add("HCT", "HCT");
            dataGridView.Columns.Add("Urea", "Urea");
            dataGridView.Columns.Add("Hb", "Hb");
            dataGridView.Columns.Add("Crtn", "Crtn");
            dataGridView.Columns.Add("HDL", "HDL");
            dataGridView.Columns.Add("AP", "AP");

            dataGridView[0, 0].Value = bloodtest.WBC;
            dataGridView[1, 0].Value = bloodtest.Neut;
            dataGridView[2, 0].Value = bloodtest.Lymph;
            dataGridView[3, 0].Value = bloodtest.HCT;
            dataGridView[4, 0].Value = bloodtest.UREA;
            dataGridView[5, 0].Value = bloodtest.Hb;
            dataGridView[6, 0].Value = bloodtest.Crtn;
            dataGridView[7, 0].Value = bloodtest.HDL;
            dataGridView[8, 0].Value = bloodtest.AP;

        }


        public BloodTestsInfo BloodTestsInfoFinder(MongoDB.Bson.ObjectId Id)
        {
            var filter = Builders<BloodTestsInfo>.Filter;
            var idfilter = filter.Eq(x => x.Id, Id);
            var bloodtest = Bm_Collection.Find<BloodTestsInfo>(idfilter).FirstOrDefault();
            return bloodtest;
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

                            //clear dataGridView from old test
                            dataGridView.DataSource = null;
                            dataGridView.Rows.Clear();
                            dataGridView.Columns.Clear();

                            //import the new data to the dataGridView
                            dataGridView.DataSource = result.Tables["גיליון1"];
                            dataGridView.Visible = true;
                            testexists_label.Visible = true;
                            BloodTestsInfo NewBloodTestsInfo = new BloodTestsInfo();
                            NewBloodTestsInfo.WBC = Convert.ToDouble(dataGridView[0,0].Value);
                            NewBloodTestsInfo.Neut = Convert.ToDouble(dataGridView[1, 0].Value);
                            NewBloodTestsInfo.Lymph = Convert.ToDouble(dataGridView[2, 0].Value);
                            NewBloodTestsInfo.RBC = Convert.ToDouble(dataGridView[3, 0].Value);
                            NewBloodTestsInfo.HCT = Convert.ToDouble(dataGridView[4, 0].Value);
                            NewBloodTestsInfo.UREA = Convert.ToDouble(dataGridView[5, 0].Value);
                            NewBloodTestsInfo.Hb = Convert.ToDouble(dataGridView[6, 0].Value);
                            NewBloodTestsInfo.Crtn = Convert.ToDouble(dataGridView[7, 0].Value);
                            NewBloodTestsInfo.iron = Convert.ToDouble(dataGridView[8, 0].Value);
                            NewBloodTestsInfo.HDL = Convert.ToDouble(dataGridView[9, 0].Value);
                            NewBloodTestsInfo.AP = Convert.ToDouble(dataGridView[10, 0].Value);
                            NewBloodTestsInfo.PatientId = patient.PId;
                            NewBloodTestsInfo.Patient = patient;
                            Bm_Collection.InsertOne(NewBloodTestsInfo);
                            patient.BloodTests.Add(NewBloodTestsInfo.Id);

                            var updateDfinition = Builders<Patientsinfo>.Update.Set(a => a.BloodTests, patient.BloodTests);
                            var filter = Builders<Patientsinfo>.Filter;
                            var patientfilter = filter.Eq(x => x.Id, patient.Id);
                            Pm_Collection.UpdateOne(patientfilter, updateDfinition);
                            MessageBox.Show("בדיקות הדם נשמרו בהצלחה");
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
            MongoDB.Bson.ObjectId mostrecent = patient.BloodTests.Last();
            var bloodtest = BloodTestsInfoFinder(mostrecent);
            Diagnosis newForm = new Diagnosis(doctor,patient, bloodtest);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private void appointment_label_Click(object sender, EventArgs e)
        {

        }

        private void AddPatients_btn_Click_1(object sender, EventArgs e)
        {
            Addpatients newForm = new Addpatients(doctor);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private void MyPatients_btn_Click_1(object sender, EventArgs e)
        {
            Patients newForm = new Patients(doctor);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }



    }

}

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
        MongoClient Pm_Client;
        IMongoDatabase Pm_Database;
        IMongoCollection<Patientsinfo> Pm_Collection;
        IMongoCollection<BloodTestsInfo> Bm_Collection;
        
        public DoctorInfo doctor;
        public Patientsinfo patient;

        DataTableCollection dataTableCollection;
        public appointment(DoctorInfo obj1, Patientsinfo obj2)
        {
            InitializeComponent();

            Pm_Client = new MongoClient("mongodb+srv://antonvo:0nCdIz2V538QvyD1@cluster0.frcvr.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            Pm_Database = Pm_Client.GetDatabase("Patients");
            Pm_Collection = Pm_Database.GetCollection<Patientsinfo>("Data");
            Bm_Collection = Pm_Database.GetCollection<BloodTestsInfo>("BloodTests");


            doctor = obj1;
            patient = obj2;
            docname_label.Text = "שלום דוקטור \n" + doctor.FullName;
            patientname_label.Text = patient.FirstName + patient.LastName;
            pantientid_label.Text = patient.Citizenship_Id;
            appointment_label.Text = "צור ביקור ל" + obj2.FirstName;
        }

        private void imortfile_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
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
                            dataTableCollection = result.Tables;

                            BloodTestsInfo bloodTest = new BloodTestsInfo();

                            
                                






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


        private void pantientid_label_Click(object sender, EventArgs e)
        {

        }

        private void appointment_Load(object sender, EventArgs e)
        {

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

        private void patientname_label_Click(object sender, EventArgs e)
        {

        }

        private void appointment_label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

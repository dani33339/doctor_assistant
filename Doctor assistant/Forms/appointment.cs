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
        MongoClient Pm_Client, Dm_Client;
        IMongoDatabase Pm_Database, Dm_Database;
        IMongoCollection<Patientsinfo> Pm_Collection;
        IMongoCollection<BloodTestsInfo> Pb_Collection;
        IMongoCollection<DoctorInfo> Dm_Collection;


        public DoctorInfo doctor;
        public Patientsinfo patient;

        DataTableCollection dataTableCollection;
        public appointment(DoctorInfo obj1, Patientsinfo obj2)
        {
            InitializeComponent();
            dataGridView.Visible = false;

            Pm_Client = new MongoClient("mongodb+srv://antonvo:0nCdIz2V538QvyD1@cluster0.frcvr.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            Pm_Database = Pm_Client.GetDatabase("Patients");
            Pm_Collection = Pm_Database.GetCollection<Patientsinfo>("Data");
            Pb_Collection = Pm_Database.GetCollection<BloodTestsInfo>("BloodTests");


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
                            NewBloodTestsInfo.Patient = patient;
                            Pb_Collection.InsertOne(NewBloodTestsInfo);
                            doctor.Patients.Add(NewBloodTestsInfo.Id);
                            var updateDfinition = Builders<DoctorInfo>.Update.Set(a => a.Patients, doctor.Patients);
                            var filter = Builders<DoctorInfo>.Filter;
                            var doctorfilter = filter.Eq(x => x.Id, doctor.Id);
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

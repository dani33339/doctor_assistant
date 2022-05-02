using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace Doctor_assistant.Forms
{
    public partial class Patients : Form
    {
        MongoClient Pm_Client;
        IMongoDatabase Pm_Database;
        IMongoCollection<Patientsinfo> Pm_Collection;
        public DoctorInfo doctor;
        public Patients(DoctorInfo obj)
        {
            InitializeComponent();
            Pm_Client = new MongoClient("mongodb+srv://antonvo:0nCdIz2V538QvyD1@cluster0.frcvr.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            Pm_Database = Pm_Client.GetDatabase("Patients");
            Pm_Collection = Pm_Database.GetCollection<Patientsinfo>("Data");


            doctor = obj;
            docname_label.Text = "hello dr \n" + doctor.FullName;
            List<Patientsinfo> PatientsList = new List<Patientsinfo>();

            foreach (MongoDB.Bson.ObjectId id in doctor.Patients)
            {
                PatientsList.Add(PatientFinder(id));
            }

            

            foreach (Patientsinfo Patient in PatientsList)
            {
                ListViewItem item = new ListViewItem();

                item.SubItems.Add(Patient.HouseNumber);
                item.SubItems.Add(Patient.Street);
                item.SubItems.Add(Patient.City);
                item.SubItems.Add(Convert.ToString(Patient.PhoneNumber));
                item.SubItems.Add(Patient.Age);                
                item.SubItems.Add(Patient.Gender);
                item.SubItems.Add(Patient.id_unic);             
                item.SubItems.Add(Patient.FirstName);
                item.SubItems.Add(Patient.LastName);

                listView.Items.Add(item);
            }
            
            




        }

        public Patientsinfo PatientFinder(MongoDB.Bson.ObjectId id) 
        {
            var filter = Builders<Patientsinfo>.Filter;
            var idfilter = filter.Eq(x => x.Id, id);
            var Patient = Pm_Collection.Find<Patientsinfo>(idfilter).FirstOrDefault();

            return Patient;
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void AddToTable(ListViewItem item)
        {
            listView.Items.Add(item);
        }

    }
}

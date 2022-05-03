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
            docname_label.Text = "שלום דוקטור \n" + doctor.FullName;
            List<Patientsinfo> PatientsList = new List<Patientsinfo>();

            foreach (MongoDB.Bson.ObjectId id_unic in doctor.Patients)
            {
                PatientsList.Add(PatientFinder(id_unic));
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
                item.SubItems.Add(Patient.Id);             
                item.SubItems.Add(Patient.FirstName);
                item.SubItems.Add(Patient.LastName);

                listView.Items.Add(item);
            }
<<<<<<< HEAD




            

=======
        }

        public void myList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView.SelectedItems.Count >= 1)
            {
                ListViewItem item = listView.SelectedItems[0];

                //here i check for the Mouse pointer location on click if its contained 
                // in the actual selected item's bounds or not .
                // cuz i ran into a problem with the ui once because of that ..
                if (item.Bounds.Contains(e.Location))
                {
                    MessageBox.Show("Double Clicked on :" + item.Text);
                }
            }
>>>>>>> Daniel
        }

            public Patientsinfo PatientFinder(MongoDB.Bson.ObjectId Id_unic) 
        {
            var filter = Builders<Patientsinfo>.Filter;
            var idfilter = filter.Eq(x => x.Id_unic, Id_unic);
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

<<<<<<< HEAD
        private void listView_SelectedIndexChanged_1(object sender, EventArgs e)
        {

=======
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
>>>>>>> Daniel
        }
    }
}

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


            foreach (MongoDB.Bson.ObjectId Id in doctor.Patients)
            {
                if (PatientFinder(Id)!=null)
                    PatientsList.Add(PatientFinder(Id));
            }

            foreach (Patientsinfo Patient in PatientsList)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(Patient.HouseNumber.ToString());
                item.SubItems.Add(Patient.Street);
                item.SubItems.Add(Patient.City);
                item.SubItems.Add(Patient.PhoneNumber);
                item.SubItems.Add(Patient.Age.ToString());
                item.SubItems.Add(Patient.Gender);
                item.SubItems.Add(Patient.PId);
                item.SubItems.Add(Patient.LastName);
                item.SubItems.Add(Patient.FirstName);
                listView.Items.Add(item);
            }

        }

        //public void myList_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    if (listView.SelectedItems.Count >= 1)
        //    {
        //        ListViewItem item = listView.SelectedItems[0];

        //        if (item.Bounds.Contains(e.Location))
        //        {
        //            MessageBox.Show("Double Clicked on :" + item.Text);
        //        }
        //    }
        //}

            public Patientsinfo PatientFinder(MongoDB.Bson.ObjectId Id) 
        {
            var filter = Builders<Patientsinfo>.Filter;
            var idfilter = filter.Eq(x => x.Id, Id);
            var Patient = Pm_Collection.Find<Patientsinfo>(idfilter).FirstOrDefault();
            return Patient;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            var list = listView.Items
                                .Cast<ListViewItem>()
                                .Where(
                                    x => x.SubItems
                                          .Cast<ListViewItem.ListViewSubItem>()
                                          .Any(y => y.Text.Contains(searchBox.Text)))
                                .ToArray();
            listView.Items.Clear();
            listView.Items.AddRange(list);

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

        private void Patients_Load(object sender, EventArgs e)
        {

        }

        private void listView_Click(object sender, EventArgs e)
        {
            var firstSelectedItem = listView.SelectedItems[0];

            var filter = Builders<Patientsinfo>.Filter;

            var Pid = filter.Eq(x => x.PId, firstSelectedItem.SubItems[7].Text);

            var patient = Pm_Collection.Find<Patientsinfo>(Pid).FirstOrDefault();

            appointment newForm = new appointment(doctor,patient);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stopfilter_Click(object sender, EventArgs e)
        {
            Patients newForm = new Patients(doctor);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
    }
}

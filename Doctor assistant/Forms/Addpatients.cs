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
    

    public partial class Addpatients : Form
    {
        MongoClient Pm_Client,Dm_Client;
        IMongoDatabase Pm_Database , Dm_Database;
        IMongoCollection<Patientsinfo> Pm_Collection;
        IMongoCollection<DoctorInfo> Dm_Collection;

        public DoctorInfo doctor;
        public Addpatients(DoctorInfo obj)
        {
            InitializeComponent();

            Pm_Client = new MongoClient("mongodb+srv://antonvo:0nCdIz2V538QvyD1@cluster0.frcvr.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            Pm_Database = Pm_Client.GetDatabase("Patients");
            Pm_Collection = Pm_Database.GetCollection<Patientsinfo>("Data");

            Dm_Client = new MongoClient("mongodb+srv://antonvo:0nCdIz2V538QvyD1@cluster0.frcvr.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            Dm_Database = Dm_Client.GetDatabase("Doctor");
            Dm_Collection = Dm_Database.GetCollection<DoctorInfo>("Account");

            doctor = obj;
            docname_label.Text = "שלום דוקטור \n" +  doctor.FullName;
        }

        


        private void bunifuPaginate1_OnPageChange(object sender, int page)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            GoToappointment();
        }

        private void GoToappointment()
        {
            Patients newForm = new Patients(doctor);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
        

        private void patient_picturebox_Click(object sender, EventArgs e)
        {
            GoToappointment();
        }

        public void docname_label_Click(object sender, EventArgs e)
        {
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MyPatients_btn_Click(object sender, EventArgs e)
        {
            GoToappointment();
        }

        private void AddPatients_btn_Click(object sender, EventArgs e)
        {

        }

        private void AddPatient_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
                if ((string.IsNullOrEmpty(tb.Text))|| gender_combobox.SelectedIndex == -1)
                {
                    MessageBox.Show("עליך למלא את כל הפרטים!");
                    return;
                }

           

            if (System.Text.RegularExpressions.Regex.IsMatch(id_textbox.Text, "[^0-9]"))
            {
                MessageBox.Show("תעודת זהות אינה תקינה");
                id_textbox.Text = id_textbox.Text.Remove(id_textbox.Text.Length - 1);
                return;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(phone_textbox.Text, "[^0-9]"))
            {
                MessageBox.Show("מספר פלאפון אינו תקין");
                phone_textbox.Text = phone_textbox.Text.Remove(phone_textbox.Text.Length - 1);
                return;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(apartment_textbox.Text, "[^0-9]") || (Int32.Parse(apartment_textbox.Text) < 0 || Int32.Parse(apartment_textbox.Text) > 1000))
            {
                MessageBox.Show("מספר בית אינו תקין");
                apartment_textbox.Text = apartment_textbox.Text.Remove(apartment_textbox.Text.Length - 1);
                return;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(age_textbox.Text, "[^0-9]") || (Int32.Parse(age_textbox.Text) < 0 || Int32.Parse(age_textbox.Text) >= 120))
            {
                MessageBox.Show("הגיל אינו תקין");
                age_textbox.Text = age_textbox.Text.Remove(age_textbox.Text.Length - 1);
                return;
            }

            Patientsinfo NewPatiet = new Patientsinfo();
            NewPatiet.Age = Int32.Parse(age_textbox.Text);
            NewPatiet.City = city_textbox.Text;
            NewPatiet.DoctorId = doctor.DId;
            NewPatiet.FirstName = name_textbox.Text;
            NewPatiet.Gender = gender_combobox.Text;
            NewPatiet.HouseNumber = Int32.Parse(apartment_textbox.Text);
            NewPatiet.PId = id_textbox.Text;
            NewPatiet.LastName = lastname_textbox.Text;
            NewPatiet.Street = street_textbox.Text;
            NewPatiet.Doctor = doctor;
            NewPatiet.PhoneNumber = phone_textbox.Text;
            NewPatiet.BloodTests = new List<MongoDB.Bson.ObjectId>();


            Pm_Collection.InsertOne(NewPatiet);
            doctor.Patients.Add(NewPatiet.Id);
        
            var updateDfinition = Builders<DoctorInfo>.Update.Set(a => a.Patients, doctor.Patients);
            var filter = Builders<DoctorInfo>.Filter;
            var doctorfilter = filter.Eq(x => x.Id, doctor.Id);
            Dm_Collection.UpdateOne(doctorfilter, updateDfinition); 
            MessageBox.Show("מטופל נשמר בהצלחה");

            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Clear();
            }
            gender_combobox.ResetText();
            GoToappointment();
        }

        
        private void name_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void street_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void city_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_textbox_TextChanged(object sender, EventArgs e)
        {
            id_textbox.MaxLength = 9;
        }

        private void lastname_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void age_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_textbox_TextChanged(object sender, EventArgs e)
        {
            phone_textbox.MaxLength = 10;
        }

        private void Addpatients_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gender_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void apartment_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

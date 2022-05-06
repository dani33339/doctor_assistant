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
        public BloodTestsInfo bloodtest;
        Question question; 

        public Diagnosis(DoctorInfo obj1,Question obj4)
        {
            InitializeComponent();
            doctor = obj1;
            question = obj4;

            docname_label.Text = "שלום דוקטור \n" + doctor.FullName;
            question_label.Text = question.name;

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
            question.status = true;
            this.Hide();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}

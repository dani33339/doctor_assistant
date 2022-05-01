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
    public partial class Addpatients : Form
    {
        public static Addpatients instance;
        public Label tb1;
        public Addpatients()
        {
            InitializeComponent();
            instance = this;
            tb1 = docname_label;
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
            Patients newForm = new Patients();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

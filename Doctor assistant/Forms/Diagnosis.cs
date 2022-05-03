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
        public Diagnosis(DoctorInfo obj)
        {
            InitializeComponent();
            doctor = obj;
            docname_label.Text = "hello dr \n" + doctor.FullName;
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
    }
}

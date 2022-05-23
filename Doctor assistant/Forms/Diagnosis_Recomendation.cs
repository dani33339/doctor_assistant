using ServiceStack.OrmLite.Dapper;
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
    public partial class Diagnosis_Recomendation : Form
    {
        public Diagnosis_Recomendation(Dictionary<string, string> Conclusion_Window , Patientsinfo patient ,BloodTestsInfo BloodTests , String[] Indices)
        {
            InitializeComponent();

            result_label.Text = " תוצאה עבור מטופל  "+ patient.FirstName;
            foreach (var Conclusion in Conclusion_Window)
            {
                String[] rowa= { Conclusion.Key, Conclusion.Value };
                ListViewItem item = new ListViewItem(rowa);                            
                listView.Items.Add(item);

            }

            heat.Text = Indices[0];
            pulse.Text = Indices[1];
            bloodpressure.Text = Indices[2];
            WBC.Text = BloodTests.WBC.ToString();
            Neut.Text = BloodTests.Neut.ToString();
            Lymph.Text = BloodTests.Lymph.ToString();
            RBC.Text = BloodTests.RBC.ToString();
            Hb.Text = BloodTests.Hb.ToString();
            Crtn.Text = BloodTests.Crtn.ToString();
            Iron.Text = BloodTests.iron.ToString();
            HDL.Text = BloodTests.HDL.ToString();
            AP.Text = BloodTests.AP.ToString();
            UREA.Text = BloodTests.UREA.ToString();
            HCT.Text = BloodTests.HCT.ToString();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)  
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}

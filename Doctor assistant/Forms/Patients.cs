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
    public partial class Patients : Form
    {
        public static Patients instance;
        public Label tb1;
        public Patients()
        {
            InitializeComponent(); 
            instance = this;
            tb1 = docname_label;
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
    }
}

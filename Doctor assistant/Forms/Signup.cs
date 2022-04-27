using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Doctor_assistant.Forms
{
    public partial class Signup : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dani\Documents\DBdoctor.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand cm = new SqlCommand();

        public Signup()
        {

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (password_textbox.Text != repassword_textbox.Text)
            {
                MessageBox.Show("Password did not Match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cm = new SqlCommand("INSERT INTO tbUser(username,fullname,password,phone)VALUES(@username,@fullname,@password,@phone)", con);
            cm.Parameters.AddWithValue("@username", username_textbox.Text);
            cm.Parameters.AddWithValue("@fullname", name_textbox.Text);
            cm.Parameters.AddWithValue("@password", password_textbox.Text);
            cm.Parameters.AddWithValue("@phone", phone_textbox.Text);
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User has been successfully saved.");
            Clear();
            GoToPatients();
        }
        public void Clear()
        {
             username_textbox.Clear();
             name_textbox.Clear();
              password_textbox.Clear();
              repassword_textbox.Clear();
              phone_textbox.Clear();
        }
        private void GoToPatients()
        {
            Patients newForm = new Patients();
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
    }

  }

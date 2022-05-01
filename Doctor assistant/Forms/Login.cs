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
using MongoDB.Driver;
using MongoDB.Bson;

namespace Doctor_assistant.Forms
{
    public partial class Login : Form
    {
        MongoClient m_Client;
        IMongoDatabase m_Database;
        IMongoCollection<DoctorInfo> m_Collection;
        public Login()
        {
            InitializeComponent();

            m_Client = new MongoClient("mongodb+srv://antonvo:0nCdIz2V538QvyD1@cluster0.frcvr.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            m_Database = m_Client.GetDatabase("Doctor");
            m_Collection = m_Database.GetCollection<DoctorInfo>("Account");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {

        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void nextpagebtn_Click(object sender, EventArgs e)
        {
            Addpatients newForm = new Addpatients();  
            this.Hide();    
            newForm.ShowDialog();    
            this.Close();    
        }

        private void login_button_Click_1(object sender, EventArgs e)
        {
            try
            {
                String User = username_textbox.Text;
                String Password = password_textbox.Text;

                var filter = Builders<DoctorInfo>.Filter;

                var userfilter = filter.Eq(x => x.UserName, User);

                var Passwordfilter = filter.Eq(x => x.Password, Password);

                var finalfilter = filter.And(userfilter, Passwordfilter);

                var enteruser = m_Collection.Find<DoctorInfo>(finalfilter).FirstOrDefault();


                
                if (enteruser != null)
                {
                    MessageBox.Show("שלום דוקטור " + enteruser.FullName + "  ", "ניתנה גישה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Addpatients newForm = new Addpatients();
                    this.Hide();
                    newForm.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("סיסמא או שם משתמש לא נכונים", "גישה נדחתה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            Signup newForm = new Signup();
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private void appointmetbtn_Click(object sender, EventArgs e)
        {
            appointment newForm = new appointment();
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
    }
}

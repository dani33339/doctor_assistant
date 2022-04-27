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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\dani\Documents\DBdoctor.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
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
                cm = new SqlCommand("SELECT * FROM tbUser WHERE username=@username AND password=@password", con);
                cm.Parameters.AddWithValue("@username", username_textbox.Text);
                cm.Parameters.AddWithValue("@password", password_textbox.Text);
                con.Open();
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("שלום דוקטור " + dr["fullname"].ToString() + "  ", "ניתנה גישה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Addpatients newForm = new Addpatients();
                    this.Hide();
                    newForm.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("סיסמא או שם משתמש לא נכונים", "גישה נדחתה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
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
    }
}

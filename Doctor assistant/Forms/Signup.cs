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
                MessageBox.Show("הסיסמאות לא תואמות", "אזהרה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CheckUser(username_textbox.Text))
            {
                MessageBox.Show("שם המשתמש לא תקין\n שם משתמש - מכיל בין 6 ל 8 תווים. מתוך התווים, לכל היותר 2 ספרות וכל השאר אותיות ", "אזהרה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CheckPassword(password_textbox.Text))
            {
                MessageBox.Show("הסיסמא לא תקינה\n סיסמה – בין 8 ל 10 תווים. מכיל לפחות אות אחת, סיפרה אחת ותו מיוחד אחד )!,#,$ וכו'(.", "אזהרה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Checkid(id_textbox.Text))
            {
                MessageBox.Show("תעודת זהות לא תקינה", "אזהרה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cm = new SqlCommand("INSERT INTO tbUser(username,fullname,password,id)VALUES(@username,@fullname,@password,@id)", con);
            cm.Parameters.AddWithValue("@username", username_textbox.Text);
            cm.Parameters.AddWithValue("@fullname", name_textbox.Text);
            cm.Parameters.AddWithValue("@password", password_textbox.Text);
            cm.Parameters.AddWithValue("@id", id_textbox.Text);
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User has been successfully saved.");
            Clear();
            GoToPatients();
        }

        public bool Checkid(string id)
        {
            string digits = new String(id.Where(Char.IsDigit).ToArray());
            if (digits.Length != 9)
                return false;
            return true;
        }


        /*return's true if user name is valid*/
        public bool CheckUser(string user)
        {
            if (user.Length < 6 || user.Length > 8)
                return false;
            string digits = new String(user.Where(Char.IsDigit).ToArray());
            string letters = new String(user.Where(Char.IsLetter).ToArray());
            if (digits.Length > 2)
                return false;
            if (letters.Length + digits.Length != user.Length)
                return false;
            return true;
        }

        /*return's true if password name is valid*/
        public bool CheckPassword(string password)
        {
            if (password.Length < 6 || password.Length > 8)
                return false;
            string digits = new String(password.Where(Char.IsDigit).ToArray());
            string letters = new String(password.Where(Char.IsLetter).ToArray());
            password.Where(c => !char.IsLetterOrDigit(c));
            if (digits.Length == 0 || letters.Length == 0 || password.Length-digits.Length-letters.Length==0)
                return false;
            return true;
        }
        public void Clear()
        {
             username_textbox.Clear();
             name_textbox.Clear();
             password_textbox.Clear();
             repassword_textbox.Clear();
             id_textbox.Clear();
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

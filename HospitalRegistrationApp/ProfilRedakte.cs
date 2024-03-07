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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalRegistrationApp
{
    public partial class ProfilRedakte : Form
    {

        int account_id;
        public ProfilRedakte(int account_id)
        {
            InitializeComponent();
            this.account_id = account_id;
        }

        private void buttonredakte_Click(object sender, EventArgs e)
        {
            if (textBoxname.Text == "")
            {
                MessageBox.Show("Ad daxil et");
                return;
            }

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Update TBLAccount set AccountName=@name, AccountDateOfBirth=@dob, AccountPhone=@phone, AccountNotes =@notes  where  AccountID=@account_id";
            cmd.Parameters.AddWithValue("@name", textBoxname.Text);
            cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.ToString());
            cmd.Parameters.AddWithValue("@phone", textBoxphone.Text);
            cmd.Parameters.AddWithValue("@notes", textBoxnotes.Text);
            cmd.Parameters.AddWithValue("@account_id", account_id);

            conn.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Ugurlu Update");
            }
            else
            {
                MessageBox.Show("Update edilmedi.");
            }



            conn.Close();



        }

        SqlConnection conn = new SqlConnection(Properties.Resources.ConnectionString);
        private void ProfilRedakte_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select Username, AccountName,AccountDateOfBirth,AccountPhone,AccountType,AccountNotes,AccountCreationDate from TBLUser,TBLAccount  where UserID=AccountUserID and AccountID=@account_id";
            cmd.Parameters.AddWithValue("@account_id", account_id);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBoxaccid.Text = account_id.ToString();
                textBoxusname.Text = reader.GetValue(0).ToString();
                textBoxname.Text = reader.GetValue(1).ToString();
                try {
                    dateTimePicker1.Value = DateTime.Parse(reader.GetValue(2).ToString());
                }

                catch { }

                textBoxphone.Text = reader.GetValue(3).ToString();

                if (reader.GetInt32(4) == 0)
                {
                    textBoxtype.Text = "Resepsiyon";
                }
                else if (reader.GetInt32(4) == 1)
                {
                    textBoxtype.Text = "Həkim";
                }
                else if (reader.GetInt32(4) == 2)
                {
                    textBoxtype.Text = "Həkim";
                }



                textBoxnotes.Text = reader.GetValue(5).ToString();
                textBoxcreatedon.Text = reader.GetValue(6).ToString();


            }

        




        conn.Close();

        }
    }
}

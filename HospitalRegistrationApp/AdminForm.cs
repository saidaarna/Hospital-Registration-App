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
namespace HospitalRegistrationApp
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void updateList(string query)
        {
                SqlConnection conn = new SqlConnection(Properties.Resources.ConnectionString);
                SqlCommand cmd = conn.CreateCommand();
                conn.Open();
            cmd.CommandText = "SELECT AccountID,AccountName, AccountType from TBLAccount where AccountType in(0,1) and (AccountName like @query or AccountPhone like @query) order by AccountType";
            cmd.Parameters.AddWithValue("@query", query+"%");

            SqlDataReader reader = cmd.ExecuteReader();

            listBox1.Items.Clear();
            while(reader.Read())
            {
                listBox1.Items.Add(new Hesab(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));
            }

                conn.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            updateList("");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            updateList(textBox4.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int account_id;
            try
            {
                account_id = ((Hesab)listBox1.SelectedItem).getId();
            }
            catch (Exception){
                return;
            }
            SqlConnection conn = new SqlConnection(Properties.Resources.ConnectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select Username, AccountName,AccountDateOfBirth,AccountPhone,AccountType,AccountNotes,AccountCreationDate from TBLUser,TBLAccount  where UserID=AccountUserID and AccountID=@id";
            cmd.Parameters.AddWithValue("@id", account_id);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                textBoxId.Text=account_id.ToString();
                textBoxistad.Text = reader.GetValue(0).ToString();
                textBoxad.Text= reader.GetValue(1).ToString();
                textBoxdt.Text = reader.GetValue(2).ToString();
                textBoxtel.Text = reader.GetValue(3).ToString();

                if (reader.GetInt32(4) == 0)
                {
                    textBoxtip.Text = "Resepsiyon";
                }
                else 
                {
                    textBoxtip.Text = "Həkim";
                }
                


                textBoxqeyd.Text = reader.GetValue(5).ToString();
                textBoxyt.Text = reader.GetValue(6).ToString();


            }


            conn.Close();


        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (!validateInput())
            {
                MessageBox.Show("MELUMATLARI DAXIL ET");
                return;
            }
            SqlConnection conn= new SqlConnection(Properties.Resources.ConnectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert into TBLUser (Username,UserPassword) values(@username,@password)";
            cmd.Parameters.AddWithValue("@username",yeniistAD.Text);
            cmd.Parameters.AddWithValue("@password", yisifre.Text);

            conn.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {

                
                cmd.CommandText = "select UserID from TBLUser where Username=@username";
                int user_id = (int)cmd.ExecuteScalar();

                cmd.CommandText = "insert into TBLAccount (AccountUserID,AccountName,AccountType,AccountNotes,AccountCreationDate) values(@user_id,@name,@type,@notes,@date)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@user_id", user_id);
                cmd.Parameters.AddWithValue("@name", yeniad.Text);
                cmd.Parameters.AddWithValue("@type", comboBox1.SelectedIndex);
                cmd.Parameters.AddWithValue("@notes", yeniqeyd.Text);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Hesab yaradıldı.");
                }
                else
                    MessageBox.Show("Error: Hesab yaradilmadi.");

            }

            else
                MessageBox.Show("Error: Istifadeci yaradilmadi.");
           
            conn.Close();
            updateList("");

            yeniad.Clear();
            yeniistAD.Clear();
            yisifre.Clear();
            yeniqeyd.Clear();
           


        }

        private bool validateInput()
        {
            if(yeniistAD.Text=="" || yeniad.Text=="" || yisifre.Text == "")
            {
                return false;
            }
            if(comboBox1.SelectedIndex<0)
            {
                return false;
            }
            return true;
        }


           
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Əminsinizmi?", "Məlumat Silinəcək", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (textBoxistad.Text == "")
                {
                    return;
                }

                SqlConnection conn = new SqlConnection(Properties.Resources.ConnectionString);
                SqlCommand cmd = conn.CreateCommand();


                cmd.CommandText = "delete from TBLUser where Username =@username";
                cmd.Parameters.AddWithValue("@username", textBoxistad.Text);
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Hesab silindi.");
                }
                else
                    MessageBox.Show("Hesab silinmedi.");



                conn.Close();
                updateList("");
                textBoxistad.Clear();
                textBoxad.Clear();
                textBoxqeyd.Clear();
                textBoxdt.Clear();
                textBoxtel.Clear();
                textBoxtip.Clear();
                textBoxyt.Clear();
                textBoxId.Clear();
            }

            else if (dialogResult == DialogResult.No)
            {
              
                MessageBox.Show("Məlumat silinmədi", "Status");
            }
        }
    }
}

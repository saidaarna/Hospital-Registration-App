using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace HospitalRegistrationApp
{
    public partial class PasProf : Form
    {
        public PasProf()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(Properties.Resources.ConnectionString);
        SqlCommand cmd;
        private void updateList(string query)
        {
            cmd= conn.CreateCommand();
            
            cmd.CommandText = "SELECT AccountID,AccountName, AccountType from TBLAccount where AccountType=2 and (AccountName like @query or AccountPhone like @query) ";
            cmd.Parameters.AddWithValue("@query", query+"%");
            conn.Open();

          

            SqlDataReader reader = cmd.ExecuteReader();

            listBox1.Items.Clear();
            while (reader.Read())
            {
                listBox1.Items.Add(new Hesab(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));
            }

            conn.Close();
        }

        private void adtel_TextChanged(object sender, EventArgs e)
        {
            updateList(adtel.Text);
        }

        private void PasProf_Load(object sender, EventArgs e)
        {
            updateList("");
        }

        private void buttonsaxla_Click(object sender, EventArgs e)
        {
            if(ad.Text=="" || tel.Text == "")
            {
                MessageBox.Show("Məlumatları daxil et");
                return;
            }

            cmd = conn.CreateCommand();
            
                cmd.CommandText = "insert into TBLAccount (AccountName,AccountPhone,AccountNotes,AccountType, AccountCreationDate) values(@name,@phone,@notes,2,@date)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@phone", tel.Text);
                cmd.Parameters.AddWithValue("@name", ad.Text);
                cmd.Parameters.AddWithValue("@notes", qeyd.Text);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                
            conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Hesab yaradıldı.");
                }
                else
                    MessageBox.Show("Error: Hesab yaradilmadi.");


            conn.Close();
            updateList("");

            ad.Clear();
            tel.Clear();
            qeyd.Clear();


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex<0 || listBox1.SelectedIndex>= listBox1.Items.Count)
            {
                return;
            }

            int account_id = ((Hesab)listBox1.SelectedItem).getId();

            cmd = conn.CreateCommand();
            cmd.CommandText = "select AccountName,AccountDateOfBirth,AccountPhone, AccountNotes,AccountCreationDate from TBLAccount  where  AccountID=@id";
            cmd.Parameters.AddWithValue("@id", account_id);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                hesabid.Text = account_id.ToString();
                rad.Text = reader.GetValue(0).ToString();

                DateTime dob=new DateTime();
                if(DateTime.TryParse(reader.GetValue(1).ToString(), out dob))
                {
                    dateTimePicker1.Value = dob;
                }



                rtel.Text = reader.GetValue(2).ToString();
                rqeyd.Text = reader.GetValue(3).ToString();

                
                ryt.Text = reader.GetValue(4).ToString();


            }


            conn.Close();
            updateList("");

        }

        private void buttonredakte_Click(object sender, EventArgs e)
        {

            if (rad.Text == "" || rtel.Text=="")
            {
                MessageBox.Show("Ad və telefonu daxil et");
                return;
            }

            cmd = conn.CreateCommand();
            cmd.CommandText = "Update TBLAccount set AccountName=@name, AccountDateOfBirth=@dob, AccountPhone=@phone, AccountNotes =@notes  where  AccountID=@id";
            cmd.Parameters.AddWithValue("@name", rad.Text);
            cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.ToString());
            cmd.Parameters.AddWithValue("@phone", rtel.Text);
            cmd.Parameters.AddWithValue("@notes", rqeyd.Text);
            cmd.Parameters.AddWithValue("@id", hesabid.Text);

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
            updateList("");

        }
    }
}

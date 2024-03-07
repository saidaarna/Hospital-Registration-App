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
using System.Collections;

namespace HospitalRegistrationApp
{
    public partial class RezYarat : Form
    {
        int res_id;
        public RezYarat(int id)
        {
            InitializeComponent();
            res_id = id;
        }


        SqlConnection conn = new SqlConnection(Properties.Resources.ConnectionString);
        SqlCommand cmd;
        private void updateList(string query)
        {
            cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT AccountID,AccountName, AccountType from TBLAccount where AccountType=2 and (AccountName like @query or AccountPhone like @query) ";
            cmd.Parameters.AddWithValue("@query", query + "%");
            conn.Open();



            SqlDataReader reader = cmd.ExecuteReader();

            listBox1.Items.Clear();
            while (reader.Read())
            {
                listBox1.Items.Add(new Hesab(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));
            }

            conn.Close();
        }

        private void RezYarat_Load(object sender, EventArgs e)
        {
            updateList("");
            updateSlots();
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void adtel_TextChanged(object sender, EventArgs e)
        {
            updateList(adtel.Text);
        }


        private void updateSlots()
        {
            cmd=conn.CreateCommand();
            cmd.CommandText = "Select Res_VisitSlot from TBLReservation where Res_VisitDate=@date";
            cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));

            conn.Open();



            SqlDataReader reader = cmd.ExecuteReader();
            Dictionary<int,string> slots = utils.getSlots();
          
            while (reader.Read())
            {
                slots.Remove(reader.GetInt32(0));
            }
            comboBox1.Items.Clear();
            foreach(object slot in slots.ToArray())
                comboBox1.Items.Add(slot);

            if(comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;    
            }




            conn.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            updateSlots();
        }

        private void buttonelave_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex<0 || listBox1.SelectedIndex>=listBox1.Items.Count  )
            {
                MessageBox.Show("Pasiyent secin.");
                return;
            }

            if (comboBox1.SelectedIndex < 0 )
            {
                MessageBox.Show("Saat secin.");
                return;
            }

            int patient_id=((Hesab)listBox1.SelectedItem).getId();
            int slot=((KeyValuePair<int,string>) comboBox1.SelectedItem).Key;

            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into TBLReservation (Res_SecretaryID,Res_PatientID,Res_VisitDate,Res_VisitSlot,ReservationDate) values(@secretary_id,@patient_id,@visit_date,@visit_slot,@date)";
            cmd.Parameters.AddWithValue("@secretary_id", res_id);
            cmd.Parameters.AddWithValue("@patient_id", patient_id);
            cmd.Parameters.AddWithValue("@visit_date", dateTimePicker1.Value.ToString());
            cmd.Parameters.AddWithValue("@visit_slot", slot);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);

            conn.Open();



            if (cmd.ExecuteNonQuery() > 0)
            {
                cmd.CommandText = "select ReservationID from TBLReservation where Res_VisitDate=@visit_date and Res_VisitSlot=@visit_slot";
                int reservation_id = (int)cmd.ExecuteScalar();





                MessageBox.Show("Rezerv edildi.");
                MessageBox.Show("Rezervasiya ID:"+reservation_id.ToString());
            }
            else
                MessageBox.Show("Error: Hesab yaradilmadi.");

        




        conn.Close();
            updateSlots();

        }

       
    }

    }


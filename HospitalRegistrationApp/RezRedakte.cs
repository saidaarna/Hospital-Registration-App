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
    public partial class RezRedakte : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Resources.ConnectionString);
        SqlCommand cmd;
        public RezRedakte(Rezervasiya res)
        {
            InitializeComponent();


            dateTimePicker1.Value = res.visit_date;
            id.Text = res.id.ToString();
            pasiyent.Text = res.patient.ToString();
            resepsiyon.Text = res.secretary.ToString();
            tarix.Text = res.date.ToString();

            dateTimePicker1.MinDate = DateTime.Today;
            updateCombo(res.slot);



        }

        private void updateCombo(int visit_slot)
        {

            Dictionary<int, string> slots = utils.getSlots();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Res_VisitSlot from TBLReservation where Res_VisitDate=@date and ReservationID<>@id";

            cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@id", id.Text);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            
                slots.Remove(reader.GetInt32(0));
                comboBox1.Items.Clear();
                foreach (KeyValuePair<int, string> slot in slots)
                {
                    comboBox1.Items.Add(slot);
                    if (slot.Key == visit_slot)
                        comboBox1.SelectedItem = slot;
                }

                conn.Close();
            

        }
        private void buttonred_Click(object sender, EventArgs e)
        {


            cmd = conn.CreateCommand();
            cmd.CommandText = "Update TBLReservation set Res_VisitDate=@visit_date, Res_VisitSlot=@visit_slot  where  ReservationID=@id";
            cmd.Parameters.AddWithValue("@visit_date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@visit_slot", ((KeyValuePair<int,string>)comboBox1.SelectedItem).Key);
            cmd.Parameters.AddWithValue("@id", id.Text);

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

        private void buttonsil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Əminsinizmi?", "Rezervasiya silinəcək", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

                cmd = conn.CreateCommand();
                cmd.CommandText = "delete from TBLReservation where ReservationID =@id";
                cmd.Parameters.AddWithValue("@id", id.Text);
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Rezervasiya silindi.");
                }
                else
                    MessageBox.Show("Rezervasiya silinmedi.");



                conn.Close();
            }

            else if (dialogResult == DialogResult.No)
            {
                
                MessageBox.Show("Rezervasiya silinmedi.", "Status");
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            updateCombo(1);
        }
    }
}

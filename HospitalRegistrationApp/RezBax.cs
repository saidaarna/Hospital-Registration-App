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
    public partial class RezBax : Form
    {
        int account_id, account_type;
        public RezBax(int id)
        {
            InitializeComponent();
           account_id = id;
        }

        SqlConnection conn = new SqlConnection(Properties.Resources.ConnectionString);
        SqlCommand cmd;


        private void updateList()
        {
            cmd = conn.CreateCommand();

            if(radioButtontarix.Checked ) 
            cmd.CommandText = "Select ReservationID, Res_PatientID, patient.AccountName,Res_SecretaryID,secretary.AccountName,Res_VisitDate, Res_VisitSlot, ReservationDate from TBLReservation, TBLAccount as patient, TBLAccount as secretary where Res_PatientID= patient.AccountID and Res_SecretaryID=secretary.AccountID and Res_VisitDate=@date";
            else if (radioButtonadtelrez.Checked)
            cmd.CommandText = "Select ReservationID, Res_PatientID, patient.AccountName,Res_SecretaryID,secretary.AccountName,Res_VisitDate, Res_VisitSlot, ReservationDate from TBLReservation, TBLAccount as patient, TBLAccount as secretary where Res_PatientID= patient.AccountID and Res_SecretaryID=secretary.AccountID and (patient.AccountName like @query or patient.AccountPhone like @query or ReservationID like @query)";
            else
            cmd.CommandText = "Select ReservationID, Res_PatientID, patient.AccountName,Res_SecretaryID,secretary.AccountName,Res_VisitDate, Res_VisitSlot, ReservationDate from TBLReservation, TBLAccount as patient, TBLAccount as secretary where Res_PatientID= patient.AccountID and Res_SecretaryID=secretary.AccountID and (patient.AccountName like @query or patient.AccountPhone like @query or ReservationID like @query) and Res_VisitDate=@date";

            cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@query", adtelrez.Text+"%");
            conn.Open();



            SqlDataReader reader = cmd.ExecuteReader();

            listBox1.Items.Clear();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int patient_id = reader.GetInt32(1);
                string patient_name=reader.GetString(2);
                int secretary_id = reader.GetInt32(3);
                string secretary_name = reader.GetString(4);
                DateTime visit_date = new DateTime();
                DateTime.TryParse(reader.GetValue(5).ToString(), out visit_date);
                int slot = reader.GetInt32(6);
                DateTime date = new DateTime();
                DateTime.TryParse(reader.GetValue(7).ToString(), out date);


                listBox1.Items.Add(new Rezervasiya(id,patient_id,patient_name,secretary_id,secretary_name,slot,visit_date,date));
            }

            conn.Close();
        }











        private void buttonred_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex < 0 || listBox1.SelectedIndex >= listBox1.Items.Count)
            {
                MessageBox.Show("Rezervasiya secin.");
                return;
            }

            Rezervasiya res = (Rezervasiya)listBox1.SelectedItem;
            Hide();
              RezRedakte rezRedakte = new RezRedakte(res);
              rezRedakte.ShowDialog();
            updateList();
              Show();
        }

        private void RezBax_Load(object sender, EventArgs e)
        {
            updateList();
            cmd=conn.CreateCommand();
            cmd.CommandText = "select AccountType from TBLAccount where AccountID=@id";
            cmd.Parameters.AddWithValue("@id", account_id);

            conn.Open();



            account_type = (int)cmd.ExecuteScalar();

            

            conn.Close();

        }

        private void adtelrez_TextChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void radioButtontarix_CheckedChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void radioButtonadtelrez_CheckedChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void radioButtonherikisi_CheckedChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateForm();
        }

        private void btnziyaretler_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0 || listBox1.SelectedIndex >= listBox1.Items.Count)
            {
                MessageBox.Show("Rezervasiya secin.");
                return;
            }

            Rezervasiya res = (Rezervasiya)listBox1.SelectedItem;

            Hide();
            Ziyaretler ziyaretler=new Ziyaretler(account_id,res.patient.Key,res.id);
            ziyaretler.ShowDialog();

            Show();

        }

        private void updateForm()
        {

            if (listBox1.SelectedIndex < 0 || listBox1.SelectedIndex >= listBox1.Items.Count)
            {
                MessageBox.Show("Rezervasiya secin.");
                return;
            }

            Rezervasiya res = (Rezervasiya)listBox1.SelectedItem;
            rid.Text = res.id.ToString();
            pasiyent.Text = res.patient.ToString();
            resepsiyon.Text = res.secretary.ToString();
            gt.Text = res.visit_date.Date.ToString();
            gs.Text = utils.getSlots()[res.slot];
            trx.Text = res.date.ToString();

            if (account_type == 0 && res.visit_date >= DateTime.Today)
            {
                buttonred.Enabled = true;
            }
            else
                buttonred.Enabled = false;

            if(account_type==1)
                btnziyaretler.Enabled = true;
            else
                btnziyaretler.Enabled = false;
        }
    }
}

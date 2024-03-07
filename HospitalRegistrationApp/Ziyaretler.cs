using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalRegistrationApp
{
    public partial class Ziyaretler : Form
    {
        int account_id, patient_id, reservation_id;
        public Ziyaretler(int account_id,int patient_id, int reservation_id  )
        {
            InitializeComponent();
            this.account_id = account_id;
            this.patient_id = patient_id;
            this.reservation_id = reservation_id;

            cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT VisitID from TBLVisit where Visit_ReservationID=@reservation_id";
            cmd.Parameters.AddWithValue("@reservation_id", reservation_id);
            conn.Open();

            var result= cmd.ExecuteScalar();

            if (result == null)
            {
                groupBox1.Enabled = true;
            }
            else
                groupBox1.Enabled=false;


            conn.Close();
            updateList();








        }
        SqlConnection conn = new SqlConnection(Properties.Resources.ConnectionString);

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0 || listBox1.SelectedIndex >= listBox1.Items.Count)
            {
                MessageBox.Show("Secin");
                return;
            }

            Ziyaret z = (Ziyaret)listBox1.SelectedItem;

            rzid.Text=z.visit_id.ToString();
            rpasiyent.Text=z.patient.ToString();
            rhekim.Text=z.doctor.ToString();
            rres.Text= z.secretary.ToString();
            rtarix.Text=z.date.ToString();
            rsebeb.Text=z.reasons;
            rdiaqnoz.Text=z.diagnosis;
            rqeyd.Text=z.notes;





        }

        private void buttonelave_Click(object sender, EventArgs e)
        {

            if (sebeb.Text == "" || diaqnoz.Text == "")
            {
                MessageBox.Show("Məlumatları daxil et");
                return;
            }

            cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = "insert into TBLVisit (Visit_ReservationID,VisitReasons,VisitDiagnosis,VisitNotes,Visit_DoctorID,VisitDate) values(@id,@reasons,@diagnosis,@notes,@doctor_id,@date)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", reservation_id);
            cmd.Parameters.AddWithValue("@diagnosis", diaqnoz.Text);
            cmd.Parameters.AddWithValue("@reasons", sebeb.Text);
            cmd.Parameters.AddWithValue("@notes", qeydler.Text);
            cmd.Parameters.AddWithValue("@doctor_id", account_id);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Elave Edildi.");
            }
            else
                MessageBox.Show("Error");


            conn.Close();

            updateList();
            groupBox1.Enabled = false;
            sebeb.Clear();
            diaqnoz.Clear();
            qeydler.Clear();


        }

        private void buttonredaktəet_Click(object sender, EventArgs e)
        {
            if (rsebeb.Text == "" || rdiaqnoz.Text == "")
            {
                MessageBox.Show("Sebeb ve Diaqnozu daxil et");
                return;
            }

            cmd = conn.CreateCommand();
            cmd.CommandText = "Update TBLVisit set VisitReasons=@reasons, VisitDiagnosis=@diagnosis, VisitNotes=@notes  where  VisitID=@id";
            cmd.Parameters.AddWithValue("@id", rzid.Text);
            cmd.Parameters.AddWithValue("@diagnosis", rdiaqnoz.Text);
            cmd.Parameters.AddWithValue("@reasons", rsebeb.Text);
            cmd.Parameters.AddWithValue("@notes", rqeyd.Text);

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
            updateList();
        }

        SqlCommand cmd;
        private void updateList()
        {

             cmd = conn.CreateCommand();
         
            cmd.CommandText = "SELECT VisitID, patient.AccountID,patient.AccountName,secretary.AccountID,secretary.AccountName,doctor.AccountID,doctor.AccountName,VisitDate,VisitReasons,VisitDiagnosis,VisitNotes from TBLVisit, TBLReservation, TBLAccount as secretary,TBLAccount as doctor, TBLAccount as patient where Visit_ReservationID=ReservationID and Res_PatientID=patient.AccountID and Res_SecretaryID=secretary.AccountID and Visit_DoctorID=doctor.AccountID and patient.AccountID=@patient_id";
            cmd.Parameters.AddWithValue("@patient_id", patient_id);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            listBox1.Items.Clear();
            while (reader.Read())
            {
                int visit_id = reader.GetInt32(0);
                int patient_id = reader.GetInt32(1);
                string patient_name = reader.GetString(2);
                int secretary_id = reader.GetInt32(3);
                string secretary_name = reader.GetString(4);
                int doctor_id = reader.GetInt32(5);
                string doctor_name = reader.GetString(6);
                DateTime date = new DateTime();
                DateTime.TryParse(reader.GetValue(7).ToString(), out date);
               string reasons = reader.GetString(8);
                string diagnosis = reader.GetString(9);
                string notes = reader.GetString(10);
             
               


                listBox1.Items.Add(new Ziyaret(visit_id, patient_id, patient_name, secretary_id, secretary_name, doctor_id, doctor_name, date, reasons,diagnosis,notes));

            }

            conn.Close();
        }
       
    }
}

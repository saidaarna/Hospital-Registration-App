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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            string connString = HospitalRegistrationApp.Properties.Resources.ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select UserID from TBLUser where Username=@username and UserPassword=@userPassword";
            cmd.Parameters.AddWithValue("@username",textBoxUsername.Text);
            cmd.Parameters.AddWithValue("@userPassword",textBoxPasword.Text);
            conn.Open();

            var netice = cmd.ExecuteScalar();
            conn.Close();
            if(netice != null)
            {
                if (textBoxUsername.Text == "admin")
                {
                    Hide();
                    AdminForm adminform = new AdminForm();
                    adminform.ShowDialog();
                    Show();
                }
                else
                {
                    conn.Open();
                    cmd.CommandText = "Select AccountID, AccountType from TBLAccount where AccountUserID=@userID";
                    cmd.Parameters.AddWithValue("@userID",netice.ToString());
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    if (reader.Read())
                    {
                        int accountID = reader.GetInt32(0);
                        int accountType = reader.GetInt32(1);
                        conn.Close();
                        if (accountType == 0)
                        {
                           
                            Hide();
                            ResepsnForm resform = new ResepsnForm(accountID);
                            resform.ShowDialog();
                            Show();

                        }

                        if (accountType == 1)
                        {
                          
                            Hide();
                            HekimForm hekimform = new HekimForm(accountID);
                            hekimform.ShowDialog();
                            Show();
                        }

                    }
                }

            }
            else
            {
                MessageBox.Show("Istifadəçi adı və ya şifrə yanlış!");
            }
        }

        
    }
}

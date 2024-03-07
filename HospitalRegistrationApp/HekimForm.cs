using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalRegistrationApp
{
    public partial class HekimForm : Form
    {
        int account_id;
        public HekimForm(int id)
        {
            InitializeComponent();
            account_id = id;
        }

        private void btnHesabiRedakte_Click(object sender, EventArgs e)
        {
            Hide();
            ProfilRedakte profilRedakte = new ProfilRedakte(account_id);
            profilRedakte.ShowDialog();
            Show();
        }

        private void btnRezBax_Click(object sender, EventArgs e)
        {
            Hide();
            RezBax rezBax = new RezBax(account_id);
            rezBax.ShowDialog();
            Show();
        }
    }
}

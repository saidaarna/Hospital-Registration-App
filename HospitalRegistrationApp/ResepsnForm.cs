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
    public partial class ResepsnForm : Form
    {
        int account_id;
        public ResepsnForm(int id)
        {
            InitializeComponent();
            account_id = id;
        }

        private void buttonredakte_Click(object sender, EventArgs e)
        {
            Hide();
            ProfilRedakte profilRedakte = new ProfilRedakte(account_id);
            profilRedakte.ShowDialog();
            Show();
        }

        private void pasprof_Click(object sender, EventArgs e)
        {
            Hide();
            PasProf pasProf = new PasProf();
            pasProf.ShowDialog();
            Show();

        }

        private void buttonrezet_Click(object sender, EventArgs e)
        {
            Hide();
            RezYarat rezYarat = new RezYarat(account_id);
            rezYarat.ShowDialog();
            Show();
        }

        private void rezbax_Click(object sender, EventArgs e)
        {
            Hide();
            RezBax rezBax = new RezBax(account_id);
            rezBax.ShowDialog();
            Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuis1Pulsa
{
    public partial class FormAwal : Form
    {
        public Deposit depo;
        public FormAwal(Deposit de)
        {
            depo = de;
            InitializeComponent();
        }

        private void isiSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDeposit frmDeposit = new FormDeposit();
            frmDeposit.ShowDialog();
            this.Hide();
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
        }

        private void FormAwal_Load(object sender, EventArgs e)
        {

        }
        public FormAwal()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Yakin Menutup Aplikasi ?", "Tutup Aplikasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void mulaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtama fu = new FormUtama();
            fu.Show();
        }
    }
}

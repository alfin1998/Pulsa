using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuis1Pulsa {
    public partial class FormDeposit : Form {
        public FormDeposit() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Deposit deposit = new Deposit();
            deposit.Saldo = Convert.ToInt32(textBox1.Text);
            this.Hide();
            FormAwal fa = new FormAwal(deposit);
            fa.ShowDialog();
        }

        
        private void FormDeposit_Load(object sender, EventArgs e)
        {

        }
    }
}

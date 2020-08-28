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
    public partial class FormUtama : Form {
        private List<Transaksi> daftarTransaksi;

        //public List<Transaksi> daftarTransaksi = new List<Transaksi>();
        //Deposit depos;
        
        public FormUtama() {
            InitializeComponent();
            
            dataGridView1.ColumnCount = 4;
            DaftarTransaksi = daftarTransaksi;
            dataGridView1.Columns[0].Name = "Kartu Perdana";
            dataGridView1.Columns[1].Name = "Nominal";
            dataGridView1.Columns[2].Name = "Harga";
            dataGridView1.Columns[3].Name = "No HP";
           // labelSaldo.Text = Convert.ToString(de.Saldo);
            //depos = de;
        }

        //public FormUtama()
        //{
        //}

        public List<Transaksi> DaftarTransaksi {
            get { return daftarTransaksi; }
            set { daftarTransaksi = value; }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxNominal.SelectedIndex == 0) {
                textBoxHarga.Text = "6000";
            } else if (comboBoxNominal.SelectedIndex == 1) {
                textBoxHarga.Text = "10500";
            } else if (comboBoxNominal.SelectedIndex == 2) {
                textBoxHarga.Text = "21000";
            } else if (comboBoxNominal.SelectedIndex == 3) {
                textBoxHarga.Text = "50000";
            } else {
                textBoxHarga.Text = "98000";
            }
        }

        private void buttonBayar_Click(object sender, EventArgs e) {
            Transaksi currentTransaksi = new Transaksi();
            currentTransaksi.KartuPerdana = Convert.ToString(comboBoxKartuPerdana.SelectedItem);
            currentTransaksi.Nominal = Convert.ToString(comboBoxNominal.SelectedItem);
            currentTransaksi.Harga = textBoxHarga.Text;
            currentTransaksi.NoHP = textBoxNomer.Text;
            String[] row = { currentTransaksi.KartuPerdana, currentTransaksi.Nominal, currentTransaksi.Harga, currentTransaksi.NoHP };
            dataGridView1.Rows.Add(row);
            //depos.SaldoKurang(Convert.ToInt32(textBoxHarga.Text));
            //labelSaldo.Text = Convert.ToString(depos.Saldo);
            Clear();
        }

        private void FormUtama_Load(object sender, EventArgs e) {

        }

        //private void depositToolStripMenuItem_Click(object sender, EventArgs e) {
        //    FormDeposit formDeposit = new FormDeposit();
        //    formDeposit.ShowDialog();
        //}

        private void buttonHapus_Click(object sender, EventArgs e) {
            Clear();
        }

        public void Clear() {
            comboBoxKartuPerdana.SelectedItem = null;
            comboBoxNominal.SelectedItem = null;
            textBoxHarga.Text = null;
            textBoxNomer.Text = null;
        }

        private void textBoxHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxProvider_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelSaldo_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

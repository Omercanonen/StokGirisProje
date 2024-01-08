using Projeclass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokGirisProje
{
    public partial class Tedarikci : Form
    {
        public Tedarikci()
        {
            InitializeComponent();
        }

        Tedarikciler tedarikciler = new Tedarikciler();
        private void button1_Click(object sender, EventArgs e)
        {
            string Ad = txtad.Text;
            string Id = txtıd.Text;
            int TelNo = int.Parse(txttel.Text);
            string Adres = txtadres.Text;

            ((Ifonksiyonlar)tedarikciler).Iekle(Ad, Id, TelNo, Adres);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedrow = dataGridView1.SelectedRows[0];
                string selectedtedarikciId = selectedrow.Cells["tedarikci_id"].Value.ToString();

                Tedarikciler selectedtedarikci = tedarikciler.tedarikcilistesi.FirstOrDefault(t => t.tedarikci_id == selectedtedarikciId);

                if (selectedtedarikci != null)
                {
                    tedarikciler.tedarikcilistesi.Remove(selectedtedarikci);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = tedarikciler.tedarikcilistesi;
                }
                else MessageBox.Show("Lütfen silmek istediğiniz tedarikçiyi seçiniz.");
            }

        }

        private void buttongoster_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tedarikciler.tedarikcilistesi;
        }

        private void buttonaddproduct_Click(object sender, EventArgs e)
        {
            Urunekle urunekle = new Urunekle();
            urunekle.Show();
            Tedarikci Tedarikci = new Tedarikci();
            this.Hide();
        }

        private void buttoncustomer_Click(object sender, EventArgs e)
        {
            Musterisayfa musterisayfa = new Musterisayfa();
            musterisayfa.Show();
            Tedarikci Tedarikci = new Tedarikci();
            this.Hide();

        }

        private void buttonanasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            Tedarikci Tedarikci = new Tedarikci();
            this.Hide();
        }

        private void buttonorders_Click(object sender, EventArgs e)
        {
            Siparisler siparisler = new Siparisler();
            siparisler.Show();
            Tedarikci Tedarikci = new Tedarikci();
            this.Hide();

        }

        private void labellogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}

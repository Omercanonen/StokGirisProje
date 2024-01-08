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
    public partial class Urunekle : Form
    {
        public Urunekle()
        {
            InitializeComponent();
        }
        public urunler urunler = new urunler();


        private void button1_Click(object sender, EventArgs e)
        {
            string urunAdi = txturunadi.Text;
            int urunBarkod = int.Parse(txtbarkod.Text);
            int Adet = int.Parse(txtadet.Text);
            int alisFiyat = int.Parse(txtalisfiyat.Text);
            string kategoriName = txtkategori.Text;


            urunler.Iekle(urunAdi, urunBarkod, Adet, alisFiyat, kategoriName);


        }

        private void buttongoster_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = urunler.urunListesi;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int selectedBarkod = Convert.ToInt32(selectedRow.Cells["urunbarkod"].Value);
                urunler selectedUrun = urunler.urunListesi.FirstOrDefault(u => u.urunbarkod == selectedBarkod);

                if (selectedUrun != null)
                {
                    urunler.urunListesi.Remove(selectedUrun);
                }
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz veriyi seçin!");
            }

        }

        private void buttontedarikciler_Click(object sender, EventArgs e)
        {
            Musterisayfa musterisayfa = new Musterisayfa();
            musterisayfa.Show();
            Urunekle anasayfa = new Urunekle();
            this.Hide();

        }

        private void buttoncategories_Click(object sender, EventArgs e)
        {
            Tedarikci tedarikci = new Tedarikci();
            tedarikci.Show();
            Urunekle urunekle = new Urunekle();
            this.Hide();
        }

        private void buttonorders_Click(object sender, EventArgs e)
        {
            Siparisler siparisler = new Siparisler();
            siparisler.Show();
            Urunekle urunekle = new Urunekle();
            this.Hide();
        }

        private void buttonanasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            Urunekle urunekle = new Urunekle();
            this.Hide();
        }

        private void buttoncustomer_Click(object sender, EventArgs e)
        {
            Musterisayfa musterisayfa = new Musterisayfa();
            musterisayfa.Show();
            Urunekle urunekle = new Urunekle();
            this.Hide();
        }

        private void labellogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}

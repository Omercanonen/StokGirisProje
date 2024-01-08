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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        public Musteri musteri = new Musteri();
        public Tedarikciler tedarikciler = new Tedarikciler();
        public urunler urunler = new urunler();

        private void buttongoster_Click(object sender, EventArgs e)
        {
            dataGridViewmusteri.DataSource = musteri.musteriListesi;
            dataGridViewtedarikci.DataSource = tedarikciler.tedarikcilistesi;
            dataGridViewstok.DataSource = urunler.urunListesi;
        }

        private void buttoncategories_Click(object sender, EventArgs e)
        {
            Tedarikci tedarikci = new Tedarikci();
            tedarikci.Show();
            Anasayfa anasayfa = new Anasayfa();
            this.Hide();
        }

        private void buttonaddproduct_Click(object sender, EventArgs e)
        {
            Urunekle urunekle = new Urunekle();
            urunekle.Show();
            Anasayfa anasayfa = new Anasayfa();
            this.Hide();
        }

        private void buttonorders_Click(object sender, EventArgs e)
        {
            Siparisler siparisler = new Siparisler();
            siparisler.Show();
            Anasayfa anasayfa = new Anasayfa();
            this.Hide();
        }

        private void buttoncustomer_Click(object sender, EventArgs e)
        {
            Musterisayfa musterisayfa = new Musterisayfa();
            musterisayfa.Show();
            Anasayfa anasayfa = new Anasayfa();
            this.Hide();
        }

        private void labellogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Musterisayfa : Form
    {
        public Musterisayfa()
        {
            InitializeComponent();
        }
        Musteri musteri = new Musteri();
        private void buttonkaydet_Click(object sender, EventArgs e)
        {
            string Ad = textmusteriad.Text;
            string Id = textmusteriid.Text;
            int TelNo = int.Parse(textmusteritel.Text);
            string Adres = textmusteriadres.Text;


            ((Ifonksiyonlar)musteri).Iekle(Ad, Id, TelNo, Adres);

        }


        private void buttonsil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string selectedMusteriId = selectedRow.Cells["musteri_id"].Value.ToString();

                Musteri selectedMusteri = musteri.musteriListesi.FirstOrDefault(x => x.musteri_id == selectedMusteriId);

                if (selectedMusteri != null)
                {
                    musteri.musteriListesi.Remove(selectedMusteri);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = musteri.musteriListesi;
                }
                else
                {
                    MessageBox.Show("Silmek istediğiniz müşteriyi seçiniz!");
                }
            }
        }

        private void buttongoster_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = musteri.musteriListesi;
        }

        private void buttonaddproduct_Click(object sender, EventArgs e)
        {
            Urunekle urunekle = new Urunekle();
            urunekle.Show();
            Musterisayfa musterisayfa = new Musterisayfa();
            this.Hide();
        }

        private void buttontedarikciler_Click(object sender, EventArgs e)
        {
            Tedarikci Tedarikci = new Tedarikci();
            Tedarikci.Show();
            Musterisayfa musterisayfa = new Musterisayfa();
            this.Hide();
        }

        private void buttonanasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            Musterisayfa musterisayfa = new Musterisayfa();
            this.Hide();
        }

        private void buttonorders_Click(object sender, EventArgs e)
        {
            Siparisler siparisler = new Siparisler();
            siparisler.Show();
            Musterisayfa musterisayfa = new Musterisayfa();
            this.Hide();
        }

        private void labellogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}

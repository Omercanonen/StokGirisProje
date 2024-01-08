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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StokGirisProje
{
    public partial class Siparisler : Form
    {
        private BindingList<Tedarikciler> disaridanTedarikciListesi;
        public Siparisler()
        {
            InitializeComponent();
            label5.Hide();

        }
        public urunler urunler = new urunler();



        private void buttonsiparis_Click(object sender, EventArgs e)
        {
            string urunAdi = txtad.Text;
            int urunBarkod = int.Parse(txtId.Text);
            int Adet = int.Parse(txtadet.Text);


            ((Ifonksiyonlar)urunler).Isiparis(urunAdi, urunBarkod, Adet);


            label5.Show();
            label5.Text = "Siparişiniz Alındı!";
        }


        private void buttontedarikciler_Click(object sender, EventArgs e)
        {
            Tedarikci tedarikci = new Tedarikci();
            tedarikci.Show();
            Siparisler siparisler = new Siparisler();
            this.Hide();

        }

        private void buttonaddproduct_Click(object sender, EventArgs e)
        {
            Urunekle urunekle = new Urunekle();
            urunekle.Show();
            Siparisler siparisler = new Siparisler();
            this.Hide();
        }

        private void buttoncustomer_Click(object sender, EventArgs e)
        {
            Musterisayfa musterisayfa = new Musterisayfa();
            musterisayfa.Show();
            Siparisler siparisler = new Siparisler();
            this.Hide();
        }

        private void buttongoster_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = urunler.siparisListesi;
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string selectedurunbarkod = selectedRow.Cells["urunbarkod"].Value.ToString();

                urunler selectedurun = urunler.siparisListesi.FirstOrDefault(x => x.urunbarkod == int.Parse(selectedurunbarkod));

                if (selectedurun != null)
                {
                    urunler.siparisListesi.Remove(selectedurun);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = urunler.siparisListesi;
                    label5.Show();
                    label5.Text = "Siparişiniz Başarıyla Silindi!";
                }
                else
                {
                    MessageBox.Show("Silmek istediğiniz müşteriyi seçiniz!");
                }
            }
        }

        private void buttonanasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            Siparisler siparis = new Siparisler();
            this.Hide();
        }

        private void Siparisler_Load(object sender, EventArgs e)
        {



        }

        private void labellogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

        }
    }
}

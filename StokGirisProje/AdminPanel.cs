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
    public partial class AdminPanel : Form
    {


        public AdminPanel()
        {
            InitializeComponent();
        }


        private void buttonkaydet_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            string personelAd = txtkullaniciadi.Text;
            string personelSifre = txtsifre.Text;
            admin.PersonelEkle(personelAd, personelSifre);

            if (dataGridViewpersonel.DataSource == null)
            {
                dataGridViewpersonel.DataSource = new List<Personel> { admin.personels.Last() };
            }
            else
            {
                var existingData = (List<Personel>)dataGridViewpersonel.DataSource;
                existingData.Add(admin.personels.Last());
                dataGridViewpersonel.DataSource = null;
                dataGridViewpersonel.DataSource = existingData;
            }
        }


        private void linkLabelgeri_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            AdminPanel adminPanel = new AdminPanel();
            this.Hide();
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {

            if (dataGridViewpersonel.SelectedRows.Count > 0)
            {
                Personel selectedPersonel = dataGridViewpersonel.SelectedRows[0].DataBoundItem as Personel;

                Admin.personelListesi.Remove(selectedPersonel);

                dataGridViewpersonel.DataSource = null;
                dataGridViewpersonel.DataSource = Admin.personelListesi;
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz veriyi seçiniz!");
            }

        }

        private void buttonanasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            AdminPanel adminPanel = new AdminPanel();
            this.Hide();
        }

        private void buttoncategories_Click(object sender, EventArgs e)
        {
            Tedarikci tedarikci = new Tedarikci();
            tedarikci.Show();
            AdminPanel adminPanel = new AdminPanel();
            this.Hide();
        }

        private void buttonaddproduct_Click(object sender, EventArgs e)
        {
            Urunekle urunekle = new Urunekle();
            urunekle.Show();
            AdminPanel adminPanel = new AdminPanel();
            this.Hide();
        }

        private void buttonorders_Click(object sender, EventArgs e)
        {
            Siparisler siparisler = new Siparisler();
            siparisler.Show();
            AdminPanel adminPanel = new AdminPanel();
            this.Hide();
        }

        private void buttoncustomer_Click(object sender, EventArgs e)
        {
            Musterisayfa musterisayfa = new Musterisayfa();
            musterisayfa.Show();
            AdminPanel adminPanel = new AdminPanel();
            this.Hide();
        }

        private void buttonadmin_Click(object sender, EventArgs e)
        {

        }

        private void labellogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}

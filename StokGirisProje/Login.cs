using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeclass;

namespace StokGirisProje
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textsifre.PasswordChar = '*';

        }

        private void buttongirisyap_Click(object sender, EventArgs e)
        {
            string girilenad = textkadi.Text;
            string girilensifre = textsifre.Text;
            bool BasariliGiris = Admin.GirisKontrol(girilenad, girilensifre);

            if (BasariliGiris)
            {
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Giriş Bilgileri Hatalıdır!");

        }

        private void buttonadmin_Click(object sender, EventArgs e)
        {
            if (textkadi.Text == "admin" ||textsifre.Text == "admin") 
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
                Login login = new Login();
                this.Hide();
            }
        }
    }
}

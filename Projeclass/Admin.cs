using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projeclass
{
    public class Admin:Personel
    {
        public static List<Personel> personelListesi = new List<Personel>();
        public List<Personel> personels = new List<Personel>();

        public void PersonelEkle(string personelAd,string personelSifre)
        {
            Personel personel = new Personel()
            {
                personeladi = personelAd,
                personelsifre = personelSifre
            };
            personelListesi.Add(personel);
            personels.Add(personel);

        }
      
        public static bool GirisKontrol(string personelAd, string personelSifre)
        {
            foreach (Personel personel in personelListesi)
            {
                if (personel.personeladi == personelAd || personel.personelsifre == personelSifre)
                {
                    return true;
                }
            }
            return false;
        }

        
    }
}

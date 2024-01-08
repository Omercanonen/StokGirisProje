using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeclass
{
    public  class Musteri:Ifonksiyonlar
    {
        public BindingList<Musteri> musteriListesi = new BindingList<Musteri>();
        public string musteriadi { get; set; }
        public string musteri_id { get; set; }
        public int musteritelno { get; set; }
        public string musteriadres { get; set; }

     void Ifonksiyonlar.Iekle(string Ad, string Id, int TelNo, string Adres)
        {
            Musteri yeniMusteri = new Musteri()
            {
                musteriadi = Ad,
                musteri_id = Id,
                musteritelno = TelNo,
                musteriadres = Adres

            };
            musteriListesi.Add(yeniMusteri);
        }


        void Ifonksiyonlar.Iekle(string urunAdi, int urunBarkod, int Adet, int alisFiyat, string kategoriName)
        {
            throw new NotImplementedException();
        }

        void Ifonksiyonlar.Isiparis(string urunAdi, int urunBarkod, int Adet)
        {
            throw new NotImplementedException();
        }
    }

}

    


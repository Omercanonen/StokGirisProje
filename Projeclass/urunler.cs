using System.ComponentModel;

namespace Projeclass
{
    public class urunler:Ifonksiyonlar
    {
        public string urunadi {  get; set; }
        public int urunbarkod { get; set; }
        public int adet {  get; set; }
        public int alisfiyat { get; set; }
        public string kategori { get; set; }

        public BindingList<urunler> urunListesi = new BindingList<urunler>();
        public BindingList<urunler> siparisListesi = new BindingList<urunler>();
 
        public void Iekle(string urunAdi, int urunBarkod, int Adet, int alisFiyat, string kategori)
        {
            urunler yeniUrun = new urunler
            {
                urunadi = urunAdi,
                urunbarkod = urunBarkod,
                adet = Adet,
                alisfiyat = alisFiyat,
                kategori = kategori
            };

            urunListesi.Add(yeniUrun);
        }

        void Ifonksiyonlar.Iekle(string Ad, string Id, int TelNo, string Adres)
        {
            throw new NotImplementedException();
        }

        void Ifonksiyonlar.Isiparis(string urunAdi,int urunBarkod,int Adet)
        {
            urunler siparis = new urunler
            {
                urunadi = urunAdi,
                urunbarkod = urunBarkod,
                adet = Adet
            };

            siparisListesi.Add(siparis);

        }
    }
}

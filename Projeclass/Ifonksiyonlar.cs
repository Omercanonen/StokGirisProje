using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeclass
{
    public interface Ifonksiyonlar
    {

        void Iekle(string urunAdi, int urunBarkod, int Adet, int alisFiyat, string kategoriName); // Ürün ekleme fonksiyonu       
        void Iekle(string Ad, string Id, int TelNo, string Adres);//Tedarikçi ve müşteri ekleme fonksiyonu
        void Isiparis(string urunAdi, int urunBarkod, int Adet); //Sipariş verme

    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeclass
{
    public class Tedarikciler:Ifonksiyonlar
    {
        public string tedarikcifirma {  get; set; }
        public string tedarikci_id {  get; set; }

        public int tedarikcitel { get; set; }
        public string tedarikciadres {  get; set; }

        public BindingList<Tedarikciler> tedarikcilistesi = new BindingList<Tedarikciler>();

        void Ifonksiyonlar.Iekle(string Ad, string Id, int TelNo, string Adres)
        {
            Tedarikciler yenitedarikci = new Tedarikciler()
            {
                tedarikcifirma = Ad,
                tedarikci_id = Id,
                tedarikcitel = TelNo,
                tedarikciadres = Adres
            };
            tedarikcilistesi.Add(yenitedarikci);
        }

        void Ifonksiyonlar.Iekle(string urunAdi, int urunBarkod, int Adet, int alisFiyat, string kategoriName)
        {
            throw new NotImplementedException();
        }

        public void Isiparis(string urunAdi, int urunBarkod, int Adet)
        {
            throw new NotImplementedException();
        }
    }
}

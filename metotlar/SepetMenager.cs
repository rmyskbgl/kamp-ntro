using System;
using System.Collections.Generic;
using System.Text;

namespace metotlar
{
    class SepetMenager
    {
        //namıng convention 
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine(" tebrıkler, sepete eklendı: "+urun.Adı);
        }
        public void Ekle2(string urunAdi, string aciklama,double fiyat,int stokadedi)
        {
            Console.WriteLine(" tebrıkler, sepete eklendı: " + urunAdi);
        }
    }
}

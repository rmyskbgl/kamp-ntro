using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demirog";
            musteri1.TcNo = "123456789123";
            musteri1.Id = 1;

            //kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdı = "Kodalama.io";
            musteri2.VergiNo = "1234567890";
            musteri2.Id = 2;


            //GERÇEK MÜŞTERİ-TÜZEL MÜŞTERİ
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManeger musteriManeger = new MusteriManeger();
            musteriManeger.Ekle(musteri1);
            musteriManeger.Ekle(musteri2);

        }
    }
}

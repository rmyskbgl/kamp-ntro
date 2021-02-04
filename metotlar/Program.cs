using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunadi = "elma";
            double fiyati = 15;
            string aciklama = "amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1  = new Urun();  //klasın örnegı
            urun1.Adı = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adı = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "dıyebakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type -saef--tip guvenlıgı 
            foreach (Urun urun  in urunler)//urunlweı tek tek basacak ne kadar uru varsa 
            {
                Console.WriteLine(urun.Adı);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------");
            }

            Console.WriteLine("------------Metotlar------------");
            
            //instance  örnek
            //encapsulation 

            SepetMenager sepetMenager = new SepetMenager();
            sepetMenager.Ekle(urun1);
            sepetMenager.Ekle(urun2);
            sepetMenager.Ekle2("armut", "yesil armut", 12,10);
            sepetMenager.Ekle2("elma ", "yesil elma ", 12,9); 
            sepetMenager.Ekle2("karpuz", "diyrbakır karpuzu", 12,8);

        }
    }
}
//dont repeat yourself - kendını tekrar etme -clean code - best practice
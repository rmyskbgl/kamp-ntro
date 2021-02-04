using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi?? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]=? 999


            //int,decimal,float, doubşe,bool, =deger tip
            //array,class , interface =referans tip 
            //belekte sock ve heap dıye alanlar var deger tipi lanlar 1. kısım olusur sayı1=10, sayi2=20 olur
            //2. kısımda referans tıpler sayılar1 yaz heap ta aşlana olustur süsllü parantezı yaz 
            //sayılar2 de aynı şekılde heapta bellekten yenı adres olusturuyor new aracı lıgı ıle 
            //sayılar 1 i  sayılar2 ye atadık esşittridedıgımzde 
        }
    }
}

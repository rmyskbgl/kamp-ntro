using System;

namespace kampıntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // Do not repeat yourself - kendini tekrarlama
            string katagorietiketi = "katagori";
            int ogrencısayısı = 32000;
            double faizoranı = 1.45;
            bool sistememgirisyapmısmı = true;
            double dolardun = 7.35;
            double dolarbugun = 7.45;

            if (dolardun>dolarbugun)
            {
                Console.WriteLine("azalişbutonu");
            }
            else if (dolardun<dolarbugun)
            {
                Console.WriteLine("artişbutonu");
            }
            else
            {
                Console.WriteLine("değişmedı butonu ");
            }


            if (sistememgirisyapmısmı==true)
            {
                Console.WriteLine("kullanıcı ayarları buutonu");
            }
            else
            {
                    Console.WriteLine("giriş yap butonu");
            }
            
             Console.WriteLine(katagorietiketi);
        }
    }
}

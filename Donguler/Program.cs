using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici kampı";
            string kurs2 = "programlamaya başlangıc için temel kurs";
            string kurs3 = "java";// bu şekılde degıl dızılerde tanımlarız 
            string kurs4 = "python";
            string kurs5 = "c++";
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            //array - dizi
            string[] kurslar = new string[] { "yazılım geliştirme kampı", "programlamaya başlangıc", "java","pyhton","c++" };

            for (int i = 0; i <kurslar.Length; i++) //kurslar.lenght ne kadar kurs varsa o kadar gıt 
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar) //dizileri tek tek dolaşmaya yarar her bır eleman içinde kurs ismini kullanıyoru z
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        } 
    }
}

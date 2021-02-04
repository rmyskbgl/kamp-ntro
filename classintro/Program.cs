using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            kurs kurs1 = new kurs();
            kurs1.kursadı = "c#";
            kurs1.kursuneğitmeni = "engin";
            kurs1.izlenmeoranı = 68;

            kurs kurs2 = new kurs();
            kurs2.kursadı = "java";
            kurs2.kursuneğitmeni = "kerem";
            kurs2.izlenmeoranı = 50;

            kurs kurs3 = new kurs();
            kurs3.kursadı = "python";
            kurs3.kursuneğitmeni = "berkay";
            kurs3.izlenmeoranı = 60;

            kurs[] kurslar = new kurs[] { kurs1,kurs2,kurs3};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursadı+" "+kurs.kursuneğitmeni);
            }
            //Console.WriteLine(kurs.kursadı);

        }
    }

    class kurs
    {
        public string kursadı { get; set; }
        public string kursuneğitmeni { get; set; }
        public int izlenmeoranı { get; set; }
    }
}

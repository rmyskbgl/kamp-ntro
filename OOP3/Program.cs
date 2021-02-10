using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManeger ihtiyacKredi = new IhtiyacKredi();
            IKrediManeger tasitKredi = new TasitKredi();
            IKrediManeger konutKredisi = new KonutKredisi();

            ILoggerService DatabaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            BasvuruManeger basvuruManeger = new BasvuruManeger();
            basvuruManeger.BasvuruYap(konutKredisi, new DatabaseLoggerService());

            List<IKrediManeger> krediler = new List<IKrediManeger>() {ihtiyacKredi,tasitKredi };
           // basvuruManeger.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}

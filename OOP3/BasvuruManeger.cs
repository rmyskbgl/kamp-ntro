using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManeger
    {
        //METHOD İNJECTİON
        public void BasvuruYap(IKrediManeger krediManeger,ILoggerService loggerService)
        {
            //başvuru bilgilerini degerlendırme 
            krediManeger.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManeger>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKredisi : IKrediManeger // interface yı iplemante eden claslar  o kurallar kendıne göre doldurullıdır.
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("konut kredisi ödeme planı hesaplandı");
        }
    }
}

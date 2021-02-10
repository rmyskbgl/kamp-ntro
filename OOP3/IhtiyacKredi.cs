using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKredi : IKrediManeger
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("ihiyaç kredisi ödeme planı hesaplandı");
        }
    }
}

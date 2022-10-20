using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConsoleUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel P1 = new Personel();
            P1.Isim = "Esra";
            P1.Soyisim = "Ozcan";
            P1.Emailadres = "esraozcan911";
            // Şu da olabilirdi : P1.Emailadres = "esraozcan911@" + Personel.domainAders; 
            //** Neden üsttekini kullanmadık : bu işlemleri encapsulation içerisinde yapmak daha mantıklı da ondan.
            P1.Cinsiyet = 717770002;

            Personel P2 = new Personel();
            P2.Isim = "Büşra";
            P2.Soyisim = "Dede";
            P2.Emailadres = "BusraDEDE";
            P2.Cinsiyet = 717770002;


            Helper.emailGonder("ik@firmam.com", "Yeni personel bilgilendirme", P1.Isim + P1.Soyisim);
            Helper.emailGonder("ik@firmam.com", "Yeni personel bilgilendirme", P2.Isim + P2.Soyisim);

            Console.ReadLine();
            // **Standart class'larımızın içine static metot yazabiliyoruz.
        }
    }
}

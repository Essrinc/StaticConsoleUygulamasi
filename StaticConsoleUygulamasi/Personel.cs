using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConsoleUygulamasi
{
    public class Personel
    {
        public static string DomainAdress = "firmam.com";
        public string Isim { get; set; }
        public string Soyisim { get; set; }

        //email adresi kısmına encapsulation yapcaz.
        private string _emailadres;
        public string Emailadres
        {
            get 
            {
                return this._emailadres;
            }
            set 
            { 
                 this._emailadres = value.ToLower() + "@" + Personel.DomainAdress;
            }
        }

        public int Cinsiyet { get; set; }

        public Personel()
        {
            Console.WriteLine("Her örneklemede çalışan metot.");
        }

        // İlk önce static yapıcı method çalıştı sonra yapıcı metot çalıştı. zaten şöyle; standart yapıcı metodumda static yapıcı metodumda
        // değer atadığım bir şeyi göstermek isteyebilirim.
        static Personel()
        {
            DomainAdress = "firmam.com";
        }

    }
}

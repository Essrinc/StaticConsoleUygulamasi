using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConsoleUygulamasi
{
    public static class Helper
    {
        //Normal constructor'lar :
        /*
        public Helper()
        {
        // Her nesne örneği alındığında uygulama standart yapıcı metodu çalıştırır.
        }
        */

        //fakat static Constructor'lar private olmalıdır. 

        //Static constructor'lar :
        /*
        private Static Helper()
        {
        // ilk çağırıldıklarında çalışırlar ve uygulama boyunca ne kadar çağırırsan çağır çalışmazlar.
        }
        */

        //*** Vee yine çok önemli: STATIC CONST'LAR BİR KERE ÇALIŞIR.




        // Static bir class tanımladıktan sonra program.cs'e gidip : 
        // Helper h = new Helper(); diyemem. 
        // =>> Static class'ların nesne örnekleri alınmaz.

        // Static class'lar kendi içlerinde yalnızca static olan field ve mothodları barındırırlar.
        // zaten yazsam da erişmeme çünkü nesne örenğini alamıyorum.
        public static void emailGonder(string aliciEmailAdres, string konu, string icerik)
        {
            //Email gönderme işlmeleri devam edecek... ileri kısımlarda...
            Console.WriteLine("Mail gönderim işlemi başarılı.");
        }
    }
}

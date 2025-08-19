using System.Collections.Generic;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Ahmet", "Mehmet", "Ayşe", "Fatma" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //ctrl+k+c ile yorum satırı yapabilirsiniz.ctrl+k+u ile yorum satırını kaldırabilirsiniz.

            List<string> isimler2 = new List<string> { "ahmet","mehmet","ayşe","fatma"};  // List yazabilmek için "using System.Collections.Generic;" eklemeyi unutmayın. otomatik olarak eklenmez.
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Ali"); // Listeye eleman eklemek için Add metodunu kullanıyoruz.
            Console.WriteLine(isimler2[4]);




        }
    }
}

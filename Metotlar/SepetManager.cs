using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        public void Ekle(Urun urun)//paranez içindekiler parametredir. ilki tipi 2. ise ismi.
        {
            //Console.WriteLine("Sepete eklendi"); // eğerki bunda değişiklik yapılırsa program.cs'de hepsi değişmektedir.
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string Aciklamasi, double Fiyati) //bu demek oluyor ki bir clasın içinde birden fazla metot tanımlayabiliriz. böyle yazılabilir lakin yazmasak daha iyi olurmuş sanırım.
        //Sebebide eğerki isimlerde değişiklik yapılırsa program.cs'de hepsi değişmektedir.
        //bu yüzden pratiklik iptal olmaktadır. 
        // örneğin stok adedi eklersek sorun olucağından ekle biri kullanmak daha doğru olur ve ona eklemek için urun adlı class'a StokAdeti eklemek yeterli olur. buna ENCAPSULATİON denir.
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi); 
        }
    }
}

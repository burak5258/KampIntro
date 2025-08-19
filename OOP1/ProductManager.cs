using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "eklendi.");

        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncenlendi.");
        }


        // "void" return type'ı, metotun bir değer döndürmeyeceğini belirtir.

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;

        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);

        }
        //return ve void arasındaki farkı pek anlamadım. Aklımda kalan elde edilen değeri tekrar kullanmak istiyorsak return, sadece ekrana yazdırmak istiyorsak void kullanılır gibi bir şey var.

    }
}

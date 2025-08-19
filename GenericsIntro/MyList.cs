    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items; //string[] items; denecek olursak, T tipi string olabilir, int olabilir, double olabilir. yani T tipi ne olursa olsun, MyList<T> sınıfı o tipe göre çalışır.
        public MyList() //ctor +tab+tab ile otoomatik olarak constructor oluşturulur.
        {
            items = new T[0]; //T tipi array oluşturduk. Başlangıçta 0 elemanlı bir dizi oluşturduk.

        }// classı new lemek istediğimizde bu constructor çalışır.
        public void Add(T item) //item bir eleman demektir. 
        {
            T[] tempArray = items; //items dizisini geçici bir diziye atıyoruz. items dizisi değiştirilemez, bu yüzden geçici bir diziye atıyoruz. tempArray dizisi items dizisinin referansını tutuyor.
            items = new T[items.Length + 1]; //items dizisini yeniden boyutlandırıyoruz. items dizisinin uzunluğuna 1 ekliyoruz.
            for(int i=0; i<tempArray.Length;i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item; //son elemana item değerini atıyoruz. items dizisinin son elemanına item değerini atıyoruz.


        }
        public int Length
        {
            get { return items.Length; }
        }// burada yazılı olan kod sadece okunabilir. items dizisinin uzunluğunu döndürür. program.cs de Console.WriteLine(isimler.Length); kullanıldığında bu kod çalışır ve items dizisinin uzunluğunu döndürür.

    }
}

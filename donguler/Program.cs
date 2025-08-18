namespace donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Kurs1 = "yazılım geliştirme";
            string Kurs2 = "proglamlamaya başlangıç";
            string Kurs3 = "java";
            //yukarıdaki tek tek olan kursları aşağıda bir dizi olarak koyup hızlı deçildi

            //array =dizi 
            string[] kurslar = new string[] { "yazılım geliştirme", "proglamlamaya başlangıç", "java","python","C#" };// büyük projelerde "String[] kurslar = kurslariGetir()" yazılır ve daha verimli kullanılır.

            for (int i = 0; i < kurslar.Length; i++)// ortada kurslar.Lengyh yerine i<3 de yazılabilir lakin 500 ürün olursa bunu saymak yerine Length ile kendisi saymaktadır.
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine();//boş satır bırakmak için yazıldı
            Console.WriteLine("for bitti");
            Console.WriteLine();


            foreach (string kurs in kurslar) //dizi temelli yapıları tek tek dönmeye yarıyor
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine();
            Console.WriteLine("sayfa sonu");
        }
    }
}

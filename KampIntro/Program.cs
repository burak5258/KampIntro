namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            String katagoriEtiketi = "kategori";
            int ogrencisayısı = 32000;
            double faizoranı = 1.45;
            bool sistemeGirişYapmışMı = false; //javada boolion diye yazılır
            Double dolarDun = 7.55;
            Double dolarbugun = 7.15;

            if (dolarbugun>dolarDun)
            {
                Console.WriteLine("Artış butonu");
            }
            else if (dolarbugun<dolarDun)
            {
                Console.WriteLine("azalış butonu");
            }




            if (sistemeGirişYapmışMı == true)
            {
                Console.WriteLine("Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

                Console.WriteLine("Kategoriler");
            //Console.WriteLine("Katagori");  bu kendini tekrarlama oluyor sürekli bunu yapmak büyük projelerde soron olur
        }
    }
}

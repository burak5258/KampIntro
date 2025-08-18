namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UrunAdi = "Elma";
            double Fiyati = 15.5;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] {"Elma","Karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati= 15.5;
            urun1.Acıklama=" Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Armut";
            urun2.Fiyati = 12.5;
            urun2.Acıklama = "Yeşil Armut";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Acıklama);
                Console.WriteLine("---------------");
            }

            Console.WriteLine();
            Console.WriteLine("-----------------Metotlar-----------------");
            Console.WriteLine();

            //instance oluşturma (yani class örneği oluşturma)
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            Console.WriteLine();
            sepetManager.Ekle2("Armut", "Yeşil Armut", 12.5);
            sepetManager.Ekle2("Elma", "Amasya Elması", 15.5);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 20.5);

        }
    }
}

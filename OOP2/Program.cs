namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo="12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //Gerçek müşteri için TcNo ve VergiNo kullanılırken, tüzel müşteri için SirketAdi kullanılır.
            //SOLİD prensiplerine göre, bir sınıfın tek bir sorumluluğu olmalıdır.
            //tcNo ve VergiNo için string veriliryor çünkü sayısal bir işlem yapılmayacak bu yüzden long veya int olarak tanımlanmasına gerek yok.
            //gerçek ve tüzel müşeri işini dikkatli öğrenmek gerekiyor.

            Musteri musteri3 = new GercekMusteri(); // new GercekMusteri() yerine new Musteri() yazarsak hata alırız çünkü Musteri sınıfı abstract bir sınıf değil.
            Musteri musteri4 = new TuzelMusteri(); // new TuzelMusteri() yerine new Musteri() yazarsak hata alırız çünkü Musteri sınıfı abstract bir sınıf değil.
            //bir yerde new görülürse orada bir referans numarası vardır.

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);



        }
    }
}

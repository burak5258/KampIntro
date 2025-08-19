namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IhtiyaçKrediManager ihtiyacKrediManager = new IhtiyaçKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasıtKrediManager tasıtKrediManager = new TasıtKrediManager();
            //tasıtKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager=new KonutKrediManager();
            //konutKrediManager.Hesapla();

            // yukarıdakilerin hesapla kısmını iptal edip direk aşağıdaki gibi yazarsak zaten interface'ler sayesinde hepsini tek bir referans üzerinden çağırabiliriz.

            //IhtıyacKredisiManager, KonutKredisiManager ve TasıtkrediManager yerine IKrediManager de yazılsada olur yani interface'lerde miras ilişkisini kullanabilmektedir.

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKredisiManager = new EsnafKredisiManager();
            

            ILogerService databaseLoggerService = new DatabaseLoggerService();
            ILogerService fileLoggerService = new FileLoggerService();
            ILogerService smsLogerService = new SmsLogerService();



            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKredisiManager, new List<ILogerService> { new DatabaseLoggerService(), new SmsLogerService() }); //IKrediManager i buraya yazamayız çünkü IKrediManager bir interface ve bu interface'i implement eden sınıflar var. O yüzden ihtiyacKrediManager, tasıtKrediManager ve konutKrediManager sınıflarını kullanabiliriz.

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasıtKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



        }
    }
}

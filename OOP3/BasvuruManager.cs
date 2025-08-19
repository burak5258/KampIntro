using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILogerService> logerService) // buraya list ekleyince logerService.Log(); iptal edilip foreach ile loglama işlemi yapılır.
        {
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();// eğer bu yazılırsa bütün hesaplamalar konutKrediManager işlemi üzerinden hesaplanır
            // ama BaşvuruYap işlemi içerisine hepsini içeren bir referans yazılması en doğru işlem olmaktadır.
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();// bunun yerine sadece hesaplaması yazılsa hepsi en doğru şekilde çalışır

            krediManager.Hesapla();
            //logerService.Log(); // loglama işlemi yapıldı. Loglama işlemi için ILogerService interface'i oluşturuldu ve bu interface'i implement eden sınıflar kullanıldı.

            foreach (var loger in logerService) // burada loglama işlemi için foreach ile loglama işlemi yapılır.
            {
                loger.Log(); // her bir logerService için Log() metodu çağrılır.
            }


        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

        internal void BasvuruYap(IKrediManager krediManager)
        {
            krediManager.Hesapla();
            
        } 
    }
}

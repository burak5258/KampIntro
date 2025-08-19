using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class TuzelMusteri: Musteri// musteri burada inheritance yani miras alır.Gerçek ve tüzel müşteri aynı özellikleri taşıdığı için Musteri sınıfından miras alırız.
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}

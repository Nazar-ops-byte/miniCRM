using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniCRMProje.DOMAİN
{
    public  class Musteri
    {
        public int MusteriId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string UyelikTuru { get; set; }
        public string Adres { get; set; }
    }
}

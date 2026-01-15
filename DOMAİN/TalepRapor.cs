using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniCRMProje.DOMAİN
{
    public class TalepRapor
    {
        public int TalepId { get; set; }
        public string Musteri { get; set; }
        public string Hizmet { get; set; }
        public string TalepTipi { get; set; }
        public string Durum { get; set; }
        public string Personel { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
    }
}

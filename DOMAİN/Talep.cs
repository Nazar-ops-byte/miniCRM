using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniCRMProje.DOMAİN
{
    public  class Talep
    {
        public int TalepId { get; set; }
        public int MusteriId { get; set; }
        public int HizmetId { get; set; }
        public string TalepTipi { get; set; }
        public string Durum { get; set; }
        public int AtananPersonelId { get; set; }
        public string Aciklama { get; set; }
        public int? MemnuniyetPuani { get; set; }
    }
}

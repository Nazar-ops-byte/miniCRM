using miniCRMProje.DAL;
using miniCRMProje.DOMAİN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniCRMProje.BLL
{
    public  class TalepService
    {
        private readonly TaleplerDAL _dal = new TaleplerDAL();

        public List<Talep> Listele() => _dal.GetAll();
        public void Ekle(Talep t) => _dal.Ekle(t);
        public void Guncelle(Talep t) => _dal.Guncelle(t);
        public void Sil(int id) => _dal.Sil(id);

        public void GuncelleDurumVePersonel(Talep t)
        {
            _dal.GuncelleDurumVePersonel(
          t.TalepId,
          t.Durum,
          t.AtananPersonelId,
          t.MemnuniyetPuani
      );
        }
        public void GuncelleTam(Talep t)
        {
            _dal.GuncelleTam(
                t.TalepId,
                t.Durum,
                t.AtananPersonelId,
                t.MemnuniyetPuani
            );
        }
        public int GetTalepSayisi(DateTime start, DateTime end)
        {
            return _dal.GetTalepSayisi(start, end);
        }
    }
}

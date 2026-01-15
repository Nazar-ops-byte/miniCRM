using miniCRMProje.DAL;
using miniCRMProje.DOMAİN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniCRMProje.BLL
{
  public class HizmetService
    {
        private readonly HizmetlerDAL _dal = new HizmetlerDAL();

        public List<Hizmet> Listele() => _dal.GetAll();

        public List<Hizmet> GetAll()
        {
            return _dal.GetAll();
        }

        public void Ekle(Hizmet h)
        {
            _dal.Ekle(h);
        }

        public void Guncelle(Hizmet h)
        {
            _dal.Guncelle(h);
        }

        public void Sil(int id)
        {
            _dal.Sil(id);
        }
        public int GetHizmetSayisi()
        {
            return _dal.GetHizmetSayisi();
        }
    }
}

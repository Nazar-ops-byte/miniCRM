using miniCRMProje.DAL;
using miniCRMProje.DOMAİN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniCRMProje.BLL
{
 public class MusteriService
    {
        private readonly MusterilerDAL _dal = new MusterilerDAL();


        public List<Musteri> Listele()
        {
            return _dal.GetAll();
        }

        public void Ekle(Musteri m)
        {
            _dal.Ekle(m);
        }

        public void Guncelle(Musteri m)
        {
            _dal.Guncelle(m);
        }

        public void Sil(int id)
        {
            _dal.Sil(id);
        }
    }
}


using miniCRMProje.DAL;
using miniCRMProje.DOMAİN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniCRMProje.BLL
{
     public class PersonelService
    {
        private readonly PersonelDAL _dal = new PersonelDAL();

        public List<Personel> Listele() => _dal.GetAll();
        public void Ekle(Personel p) => _dal.Ekle(p);
        public void Guncelle(Personel p) => _dal.Guncelle(p);
        public void Sil(int id) => _dal.Sil(id);
    }
}

using miniCRMProje.DAL;
using miniCRMProje.DOMAİN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniCRMProje.BLL
{
    public class AuthService
    {
        private readonly KullanicilarDAL _dal = new KullanicilarDAL();

        public Kullanici Login(string kullaniciAdi, string sifre)
        {
            return _dal.Login(kullaniciAdi, sifre);
        }

        public void KullaniciEkle(Kullanici kullanici)
        {
            _dal.KullaniciEkle(kullanici);
        }



        public void SifreGuncelle(string kullaniciAdi, string yeniSifre)
        {
            _dal.SifreGuncelle(kullaniciAdi, yeniSifre);
        }
    }
}

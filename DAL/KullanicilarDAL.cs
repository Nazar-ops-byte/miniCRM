using miniCRMProje.DOMAİN;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniCRMProje.DAL
{
    public  class KullanicilarDAL
    {
        public Kullanici Login(string kullaniciAdi, string sifre)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string sql = @"SELECT *   FROM kullanicilar
                           WHERE kullanici_adi = @kadi AND sifre = @sifre
                           LIMIT 1;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kadi", kullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", sifre);

                MySqlDataReader dr = cmd.ExecuteReader();


                if (dr.Read())
                {
                    return new Kullanici
                    {
                        KullaniciId = dr.GetInt32("kullanici_id"),
                        KullaniciAdi = dr.GetString("kullanici_adi"),
                        Sifre = dr.GetString("sifre"),
                        Rol = dr.GetString("rol")
                    };
                }


            }
            return null;
        }
        public void KullaniciEkle(Kullanici kullanici)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string sql = @"INSERT INTO kullanicilar (kullanici_adi, sifre, rol)
                           VALUES (@kadi, @sifre, @rol);";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kadi", kullanici.KullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", kullanici.Sifre);
                cmd.Parameters.AddWithValue("@rol", kullanici.Rol);

                cmd.ExecuteNonQuery();
            }
        }
        public void SifreGuncelle(string kullaniciAdi, string yeniSifre)
        {
            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();

                string sql = @"UPDATE kullanicilar 
                   SET sifre = @sifre 
                   WHERE kullanici_adi = @kadi";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sifre", yeniSifre);
                cmd.Parameters.AddWithValue("@kadi", kullaniciAdi);

                cmd.ExecuteNonQuery();
            }
        }
    }
}

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
    public  class PersonelDAL
    {
        public List<Personel> GetAll()
        {
            var list = new List<Personel>();
            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM kullanicilar", conn);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new Personel
                        {
                            KullaniciId = dr.GetInt32("kullanici_id"),
                            KullaniciAdi = dr.GetString("kullanici_adi"),
                            Sifre = dr.GetString("sifre"),
                            Rol = dr.GetString("rol")
                        });
                    }
                }
            }
            return list;
        }

        public void Ekle(Personel p)
        {
            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();

                var sql = @"INSERT INTO kullanicilar (kullanici_adi, sifre, rol)
                    VALUES (@kadi, @sifre, @rol)";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kadi", p.KullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", p.Sifre);
                cmd.Parameters.AddWithValue("@rol", p.Rol);
                cmd.ExecuteNonQuery();
            }
        }

        public void Guncelle(Personel p)
        {
            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();

                var sql = @"UPDATE kullanicilar
                    SET kullanici_adi=@kadi, sifre=@sifre, rol=@rol
                    WHERE kullanici_id=@id";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kadi", p.KullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", p.Sifre);
                cmd.Parameters.AddWithValue("@rol", p.Rol);
                cmd.Parameters.AddWithValue("@id", p.KullaniciId);
                cmd.ExecuteNonQuery();
            }
        }

        public void Sil(int id)
        {
            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand(
                    "DELETE FROM kullanicilar WHERE kullanici_id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
        public static DataTable GetStaffForCombo()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                // Rol/Yetki kolonun farklıysa düzenle
                string query = @"
      SELECT 
          kullanici_id,
           kullanici_adi
      FROM kullanicilar
      WHERE rol IN ('Support', 'CallCenter')
      
  ";

                using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }
    }
}

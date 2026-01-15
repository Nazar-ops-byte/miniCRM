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
    public  class MusterilerDAL
    {
        public List<Musteri> GetAll()
        {
            List<Musteri> list = new List<Musteri>();

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT musteri_id, ad, soyad, telefon, email, kayit_tarihi, uyelik_turu, adres FROM musteriler",
                    conn
                );

                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(new Musteri
                    {
                        MusteriId = Convert.ToInt32(dr["musteri_id"]),
                        Ad = dr["ad"].ToString(),
                        Soyad = dr["soyad"].ToString(),
                        Telefon = dr["telefon"].ToString(),
                        Email = dr["email"].ToString(),
                        KayitTarihi = Convert.ToDateTime(dr["kayit_tarihi"]),
                        UyelikTuru = dr["uyelik_turu"].ToString(),
                        Adres = dr["adres"].ToString()
                    });
                }
            }

            return list;
        }

        // 🔹 EKLE
        public void Ekle(Musteri m)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string sql = @"INSERT INTO musteriler 
            (ad, soyad, telefon, email, uyelik_turu, adres)
             VALUES (@ad, @soyad, @telefon, @email, @uyelik_turu, @adres)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ad", m.Ad);
                cmd.Parameters.AddWithValue("@soyad", m.Soyad);
                cmd.Parameters.AddWithValue("@telefon", m.Telefon);
                cmd.Parameters.AddWithValue("@email", m.Email);
                cmd.Parameters.AddWithValue("@adres", m.Adres);
                cmd.Parameters.AddWithValue("@uyelik_turu", m.UyelikTuru);
                cmd.ExecuteNonQuery();
            }
        }

        // 🔹 GÜNCELLE
        public void Guncelle(Musteri m)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string sql = @"UPDATE musteriler 
                           SET ad=@ad, soyad=@soyad, telefon=@telefon, email=@email, uyelik_turu=@uyelik_turu, adres =@adres
                           WHERE musteri_id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ad", m.Ad);
                cmd.Parameters.AddWithValue("@soyad", m.Soyad);
                cmd.Parameters.AddWithValue("@telefon", m.Telefon);
                cmd.Parameters.AddWithValue("@email", m.Email);
                cmd.Parameters.AddWithValue("@id", m.MusteriId);
                cmd.Parameters.AddWithValue("@adres", m.Adres);
                cmd.Parameters.AddWithValue("@uyelik_turu", m.UyelikTuru);

                cmd.ExecuteNonQuery();
            }
        }

        // 🔹 SİL
        public void Sil(int id)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM musteriler WHERE musteri_id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
        public static DataTable GetAllCustomersForCombo()
        {
            DataTable dt = new DataTable();

            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();

                string sql =
                    "SELECT musteri_id, CONCAT(ad, ' ', soyad) AS ad_soyad " +
                    "FROM musteriler " +
                    "ORDER BY ad, soyad";

                using (var da = new MySqlDataAdapter(sql, conn))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

    }
}


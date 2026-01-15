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
    public class HizmetlerDAL
    {
        public List<Hizmet> GetAll()
        {
            var list = new List<Hizmet>();
            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM hizmetler", conn);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new Hizmet
                        {
                            HizmetId = dr.GetInt32("hizmet_id"),
                            HizmetAdi = dr.GetString("hizmet_adi"),
                            Aciklama = dr["aciklama"]?.ToString(),
                            Ucret = dr.GetDecimal("ucret")
                        });
                    }
                }
            }
            return list;
        }
        public void Ekle(Hizmet h)
        {
            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();
                var sql = @"INSERT INTO hizmetler (hizmet_adi, aciklama, ucret)
                     VALUES (@adi, @aciklama, @ucret)";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@adi", h.HizmetAdi);
                cmd.Parameters.AddWithValue("@aciklama", h.Aciklama);
                cmd.Parameters.AddWithValue("@ucret", h.Ucret);
                cmd.ExecuteNonQuery();
            }
        }

        public void Guncelle(Hizmet h)
        {
            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();
                var sql = @"UPDATE hizmetler
                     SET hizmet_adi=@adi, aciklama=@aciklama, ucret=@ucret
                     WHERE hizmet_id=@id";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@adi", h.HizmetAdi);
                cmd.Parameters.AddWithValue("@aciklama", h.Aciklama);
                cmd.Parameters.AddWithValue("@ucret", h.Ucret);
                cmd.Parameters.AddWithValue("@id", h.HizmetId);
                cmd.ExecuteNonQuery();
            }
        }

        public void Sil(int id)
        {
            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("DELETE FROM hizmetler WHERE hizmet_id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetAllServices()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                string query = "SELECT hizmet_id, hizmet_adi FROM hizmetler";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
            }

            return dt;
        }
        public int GetHizmetSayisi()
        {
            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();

                string sql = "SELECT COUNT(*) FROM hizmetler";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
    }
}

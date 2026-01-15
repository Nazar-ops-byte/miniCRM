using miniCRMProje.DOMAİN;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniCRMProje.DAL
{
    public  class TaleplerDAL
    {
        public List<Talep> GetAll()
        {
            var list = new List<Talep>();
            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM talepler", conn);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new Talep
                        {
                            TalepId = dr.GetInt32("talep_id"),
                            MusteriId = dr.GetInt32("musteri_id"),
                            HizmetId = dr.GetInt32("hizmet_id"),
                            TalepTipi = dr["talep_tipi"]?.ToString(),
                            Durum = dr["durum"]?.ToString(),
                            AtananPersonelId = dr.GetInt32("atanan_personel_id"),
                            Aciklama = dr["aciklama"]?.ToString(),
                            MemnuniyetPuani = dr["MemnuniyetPuani"] == DBNull.Value
    ? (int?)null
    : Convert.ToInt32(dr["MemnuniyetPuani"])
                        });
                    }
                }
            }
            return list;
        }

        public void Ekle(Talep t)
        {
            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();

                var sql = @"
            INSERT INTO talepler
            (musteri_id, hizmet_id, talep_tipi, durum, atanan_personel_id, aciklama, MemnuniyetPuani)
            VALUES
            (@musteri, @hizmet, @tip, @durum, @personel, @aciklama, @memnuniyet)";

                var cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@musteri", t.MusteriId);
                cmd.Parameters.AddWithValue("@hizmet", t.HizmetId);
                cmd.Parameters.AddWithValue("@tip", t.TalepTipi);
                cmd.Parameters.AddWithValue("@durum", t.Durum);
                cmd.Parameters.AddWithValue("@personel", t.AtananPersonelId);
                cmd.Parameters.AddWithValue("@aciklama", t.Aciklama);
                cmd.Parameters.AddWithValue("@memnuniyet", t.MemnuniyetPuani);

                cmd.ExecuteNonQuery();
            }
        }

        public void Guncelle(Talep t)
        {
            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();
                var sql = @"UPDATE talepler SET
                            musteri_id=@musteri,
                            hizmet_id=@hizmet,
                            talep_tipi=@tip,
                            durum=@durum,
                            atanan_personel_id=@personel,
                            aciklama=@aciklama
                            MemnuniyetPuani=@memnuniyet
                            WHERE talep_id=@id";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@musteri", t.MusteriId);
                cmd.Parameters.AddWithValue("@hizmet", t.HizmetId);
                cmd.Parameters.AddWithValue("@tip", t.TalepTipi);
                cmd.Parameters.AddWithValue("@durum", t.Durum);
                cmd.Parameters.AddWithValue("@personel", t.AtananPersonelId);
                cmd.Parameters.AddWithValue("@aciklama", t.Aciklama);
                cmd.Parameters.AddWithValue("@memnuniyet", (object)t.MemnuniyetPuani ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@id", t.TalepId);
                cmd.ExecuteNonQuery();
            }
        }

        public void Sil(int id)
        {
            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand(
                    "DELETE FROM talepler WHERE talep_id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public void GuncelleDurumVePersonel(
    int talepId,
    string durum,
    int atananPersonelId,
    int? memnuniyetPuani
)
        {
            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();

                string sql = @"
        UPDATE talepler
        SET
            durum = @durum,
            atanan_personel_id = @personel,
            memnuniyet_puani = @memnuniyet
        WHERE talep_id = @id";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@durum", durum);
                    cmd.Parameters.AddWithValue("@personel", atananPersonelId);
                    cmd.Parameters.AddWithValue("@memnuniyet", (object)memnuniyetPuani ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", talepId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void GuncelleTam(int talepId, string durum, int personelId, int? puan)
        {
            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();

                string sql = @"
        UPDATE talepler
        SET 
            durum = @durum,
            atanan_personel_id = @personel,
            memnuniyet_puani = @puan
        WHERE talep_id = @id";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@durum", durum);
                    cmd.Parameters.AddWithValue("@personel", personelId);
                    cmd.Parameters.AddWithValue("@puan", (object)puan ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", talepId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public int GetTalepSayisi(DateTime start, DateTime end)
        {
            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();

                string sql = @"
        SELECT COUNT(*) 
        FROM talepler
        WHERE olusturma_tarihi BETWEEN @start AND @end";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@start", start);
                    cmd.Parameters.AddWithValue("@end", end);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
    }
}

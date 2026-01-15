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
    public class RaporDAL
    {
        private MySqlConnection conn;

        public List<TalepRapor> GetRapor(
            DateTime start,
            DateTime end,
            int? hizmetId,
            string durum)
        {
            var list = new List<TalepRapor>();

            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();

                string sql = @"
          SELECT 
              t.talep_id,
              CONCAT(m.ad, ' ', m.soyad) AS musteri,
              h.hizmet_adi AS hizmet,
              t.talep_tipi,
              t.durum,
              k.kullanici_adi AS personel,
              t.olusturma_tarihi
          FROM talepler t
          JOIN musteriler m ON m.musteri_id = t.musteri_id
          JOIN hizmetler h ON h.hizmet_id = t.hizmet_id
          LEFT JOIN kullanicilar k ON k.kullanici_id = t.atanan_personel_id
          WHERE t.olusturma_tarihi BETWEEN @start AND @end";

                if (hizmetId.HasValue)
                    sql += " AND h.hizmet_id = @hid";

                if (!string.IsNullOrEmpty(durum))
                    sql += " AND t.durum = @durum";

                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@start", start);
                cmd.Parameters.AddWithValue("@end", end);

                if (hizmetId.HasValue)
                    cmd.Parameters.AddWithValue("@hid", hizmetId.Value);

                if (!string.IsNullOrEmpty(durum))
                    cmd.Parameters.AddWithValue("@durum", durum);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new TalepRapor
                        {
                            TalepId = dr.GetInt32("talep_id"),
                            Musteri = dr["musteri"].ToString(),
                            Hizmet = dr["hizmet"].ToString(),
                            TalepTipi = dr["talep_tipi"].ToString(),
                            Durum = dr["durum"].ToString(),
                            Personel = dr["personel"]?.ToString(),
                            OlusturmaTarihi = Convert.ToDateTime(dr["olusturma_tarihi"])
                        });
                    }
                }
            }
            return list;
        }
        public DataTable GetTalepTuruYogunlugu(DateTime start, DateTime end)
        {
            DataTable dt = new DataTable();

            using (var conn = DbConnection.GetConnection())


            {
                string sql = @"
           SELECT talep_tipi, COUNT(*) AS adet
            FROM talepler
            WHERE olusturma_tarihi BETWEEN @start AND @end
            GROUP BY talep_tipi
            ORDER BY adet DESC";

                using (var cmd = new MySqlCommand(sql, conn))

                {
                    cmd.Parameters.AddWithValue("@start", start);
                    cmd.Parameters.AddWithValue("@end", end);
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }
        public DataTable GetPersonelPerformans(DateTime start, DateTime end)
        {
            DataTable dt = new DataTable();

            using (var conn = DbConnection.GetConnection())
            {
                conn.Open(); // 🔴 BU ŞART

                string sql = @"
  SELECT 
      p.PersonelAdi AS personelAdi,   -- ⚠️ ALIAS ŞART
      COUNT(t.talep_id) AS tamamlanan
  FROM talepler t
  INNER JOIN personeller p ON p.PersonelId = t.atanan_personel_id
  WHERE t.durum = 'Tamamlandı'
    AND t.olusturma_tarihi BETWEEN @start AND @end
  GROUP BY p.PersonelAdi
  ORDER BY tamamlanan DESC;
  ";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@start", start);
                    cmd.Parameters.AddWithValue("@end", end);

                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt; // 🔴 BUNU UNUTMA
        }

        public DataTable GetMemnuniyetOrtalamasi(DateTime start, DateTime end)
        {
            DataTable dt = new DataTable();

            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();

                string sql = @"
      SELECT AVG(MemnuniyetPuani) AS ortalamaPuan
      FROM talepler
      WHERE MemnuniyetPuani IS NOT NULL
        AND olusturma_tarihi BETWEEN @start AND @end
  ";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@start", start);
                    cmd.Parameters.AddWithValue("@end", end);

                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }
        public DataTable GetMusteriBazliTalep(DateTime start, DateTime end)
        {
            DataTable dt = new DataTable();

            using (var conn = DbConnection.GetConnection())
            {
                string sql = @"
  SELECT 
      CONCAT(m.ad, ' ', m.soyad) AS musteri,
      COUNT(t.talep_id) AS adet
  FROM talepler t
  JOIN musteriler m ON m.musteri_id = t.musteri_id
  WHERE t.olusturma_tarihi BETWEEN @start AND @end
  GROUP BY m.musteri_id
  ORDER BY adet DESC";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@start", start);
                    cmd.Parameters.AddWithValue("@end", end);

                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }
        public DataTable GetDurumaGoreTalep()
        {
            DataTable dt = new DataTable();

            using (var conn = DbConnection.GetConnection())
            {
                string sql = @"
      SELECT durum, COUNT(*) adet
      FROM talepler
      GROUP BY durum";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }
        public DataTable GetPersonelOrtalamaMemnuniyet()
        {
            DataTable dt = new DataTable();

            using (var conn = DbConnection.GetConnection())
            {
                string sql = @"
      SELECT 
          p.PersonelAdi,
          ROUND(AVG(t.MemnuniyetPuani), 2) AS ortalama
      FROM talepler t
      JOIN personeller p ON p.PersonelId = t.atanan_personel_id
      WHERE t.MemnuniyetPuani IS NOT NULL
      GROUP BY p.PersonelAdi
      ORDER BY ortalama DESC";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }
        public DataTable GetZamanIcindeTalep(DateTime start, DateTime end, int? hizmetId)
        {
            DataTable dt = new DataTable();

            using (var conn = DbConnection.GetConnection())
            {
                string sql = @"
      SELECT 
          DATE(t.olusturma_tarihi) AS tarih,
          COUNT(*) AS adet
      FROM talepler t
      WHERE t.olusturma_tarihi BETWEEN @start AND @end
        AND (@hizmetId IS NULL OR t.hizmet_id = @hizmetId)
      GROUP BY DATE(t.olusturma_tarihi)
      ORDER BY tarih;
  ";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@start", start);
                    cmd.Parameters.AddWithValue("@end", end);
                    cmd.Parameters.AddWithValue("@hizmetId", (object)hizmetId ?? DBNull.Value);

                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }


            return dt;
        }
      
    }
}

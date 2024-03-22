using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBLOGRENCI (OgrAd, OgrSoyad, OgrNo, OgrFoto, OgrSifre)" +
                "values (@p1, @p2, @p3, @p4, @p5)", Baglanti.baglanti);

            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }

            komut1.Parameters.AddWithValue("@p1", parametre.AD);
            komut1.Parameters.AddWithValue("@p2", parametre.SOYAD);
            komut1.Parameters.AddWithValue("@p3", parametre.NUMARA);
            komut1.Parameters.AddWithValue("@p4", parametre.FOTOGRAF);
            komut1.Parameters.AddWithValue("@p5", parametre.SIFRE);

            return komut1.ExecuteNonQuery();
        }

        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();

            SqlCommand komut2 = new SqlCommand("Select *from TBLOGRENCI", Baglanti.baglanti);

            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }

            SqlDataReader dataReader = komut2.ExecuteReader();

            while (dataReader.Read())
            {
                EntityOgrenci entityOgrenci = new EntityOgrenci();

                entityOgrenci.ID = Convert.ToInt32(dataReader["OgrID"].ToString());
                entityOgrenci.AD = dataReader["OgrAd"].ToString();
                entityOgrenci.SOYAD = dataReader["OgrSoyad"].ToString();
                entityOgrenci.NUMARA = dataReader["OgrNo"].ToString();
                entityOgrenci.FOTOGRAF = dataReader["OgrFoto"].ToString();
                entityOgrenci.SIFRE = dataReader["OgrSifre"].ToString();
                entityOgrenci.BAKIYE = Convert.ToDouble(dataReader["OgrBakiye"].ToString());

                degerler.Add(entityOgrenci);
            }

            dataReader.Close();
            return degerler;
        }
        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut3 = new SqlCommand("DELETE FROM TBLOGRENCI where OgrID=@P1", Baglanti.baglanti);

            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }

            komut3.Parameters.AddWithValue("@P1", parametre);
            return komut3.ExecuteNonQuery() > 0;
        }
        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut4 = new SqlCommand("Select *from TBLOGRENCI where OGRID=@P1", Baglanti.baglanti);
            komut4.Parameters.AddWithValue("@P1", id);

            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }

            SqlDataReader dataReader = komut4.ExecuteReader();
            while (dataReader.Read())
            {
                EntityOgrenci entityOgrenci = new EntityOgrenci();

                entityOgrenci.AD = dataReader["OgrAd"].ToString();
                entityOgrenci.SOYAD = dataReader["OgrSoyad"].ToString();
                entityOgrenci.NUMARA = dataReader["OgrNo"].ToString();
                entityOgrenci.FOTOGRAF = dataReader["OgrFoto"].ToString();
                entityOgrenci.SIFRE = dataReader["OgrSifre"].ToString();
                entityOgrenci.BAKIYE = Convert.ToDouble(dataReader["OgrBakiye"].ToString());
                degerler.Add(entityOgrenci);
            }

            dataReader.Close();
            return degerler;
        }
        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komut5 = new SqlCommand("Update TBLOGRENCI Set OgrAd=@P1, OgrSoyad=@P2, OgrNo=@P3, OgrFoto=@P4, OgrSifre=@P5 WHERE OGRID=@P6", Baglanti.baglanti);

            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }

            komut5.Parameters.AddWithValue("@P1", deger.AD);
            komut5.Parameters.AddWithValue("@P2", deger.SOYAD);
            komut5.Parameters.AddWithValue("@P3", deger.NUMARA);
            komut5.Parameters.AddWithValue("@P4", deger.FOTOGRAF);
            komut5.Parameters.AddWithValue("@P5", deger.SIFRE);
            komut5.Parameters.AddWithValue("@P6", deger.ID);

            return komut5.ExecuteNonQuery() > 0;

        }
    }
}

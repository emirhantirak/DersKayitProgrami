using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALDers
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> degerler = new List<EntityDers>();

            SqlCommand komut = new SqlCommand("Select * From TBLDERSLER", Baglanti.baglanti);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                EntityDers entityOgrenci = new EntityDers();

                entityOgrenci.ID = Convert.ToInt32(dataReader["DersID"].ToString());
                entityOgrenci.DERSAD = dataReader["DersAd"].ToString();
                entityOgrenci.MIN = int.Parse(dataReader["DersMinKontenjan"].ToString());
                entityOgrenci.MAX = int.Parse(dataReader["DersMaxKontenjan"].ToString());
                degerler.Add(entityOgrenci);
            }
            dataReader.Close();
            return degerler;
        }
        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand komut2 = new SqlCommand("insert into TBLBASVURUFORM (OgrenciID,DersID) values (@P1, @P2)", Baglanti.baglanti);

            komut2.Parameters.AddWithValue("@P1", parametre.BASOGRID);
            komut2.Parameters.AddWithValue("@P2", parametre.BASDERSID);

            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            return komut2.ExecuteNonQuery();

        }

    }
}

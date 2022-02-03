using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OgrenciBL
    {
        public bool OgrenciEkle(Ogrenci ogr)
        {
            if (ogr == null)
            {
                throw new NullReferenceException("Öğrenci Eklenirken Referans Null Geldi");
            }
            try
            {
                Helper hlp = new Helper();
                int sonuc = hlp.ExecuteNonQuery($"Insert Into tblOgrenciler (Ad,Soyad,Numara,TcKimlik,SinifId) values ('{ogr.OgrenciAd}','{ogr.OgrenciSoyad}','{ogr.OgrenciNumara}','{ogr.OgrenciTckimlik}',{ogr.OgrenciSinif})");
                return sonuc > 0;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public bool OgrenciGuncelle(Ogrenci ogr) 
        {
            if (ogr == null)
            {
                throw new NullReferenceException("Öğrenci Güncellenirken Referans Null Geldi");
            }
            try
            {
                Helper hlp = new Helper();
                int sonuc = hlp.ExecuteNonQuery($"Update tblOgrenciler set Ad = '{ogr.OgrenciAd}', Soyad = '{ogr.OgrenciSoyad}', Numara = '{ogr.OgrenciNumara}', SinifId = {ogr.OgrenciSinif} Where OgrenciID = {ogr.OgrenciId}");
                return sonuc > 0;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public bool OgrenciSil (int id)
        {
            try
            {
                Helper hlp = new Helper();
                int sonuc = hlp.ExecuteNonQuery($"Delete from tblOgrenciler where OgrenciID ={id}");
                return sonuc > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Ogrenci OgrenciGetir(string numara) 
        {

            Ogrenci ogr = null;
            Helper hlp = new Helper();
            SqlDataReader dr = hlp.ExecuteReader($"Select * From tblOgrenciler where Numara = {numara}");
            if (dr.Read())
            {
                ogr = new Ogrenci();
                ogr.OgrenciAd=dr["Ad"].ToString();
                ogr.OgrenciSoyad = dr["Soyad"].ToString();
                ogr.OgrenciNumara = dr["Numara"].ToString();
                ogr.OgrenciTckimlik = dr["TcKimlik"].ToString();
                ogr.OgrenciSinif = Convert.ToInt32(dr["SinifId"]);
                ogr.OgrenciId = Convert.ToInt32(dr["OgrenciID"]);
            }
            dr.Close();
            return ogr;
        }

    }
}

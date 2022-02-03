
using BLL;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okulfinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtOgrenciID.Visible = false;
            SqlConnection cn = null;
            try
            {
                using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString)) 
                {
                    if (cn != null)
                    {
                        cn.Open();
                    }
                    SqlCommand cmd = new SqlCommand($"Select SINIFID,SINIFAD,KONTEJYAN from tblSiniflar",cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<Sinif> Siniflar = new List<Sinif>();
                    while (dr.Read())
                    {
                        Siniflar.Add(new Sinif { SinifId = Convert.ToInt32(dr["SINIFID"]), Kontenjan = Convert.ToInt32(dr["KONTEJYAN"]), 
                            SinifAd = dr["SINIFAD"].ToString()});
                    }
                    dr.Close();

                    cBSinif.DisplayMember = "sinifad";
                    cBSinif.ValueMember = "sinifid";
                    cBSinif.DataSource = Siniflar;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cn!=null && cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                    cn.Dispose();

                }

            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                OgrenciBL obl = new OgrenciBL();
                MessageBox.Show(obl.OgrenciEkle(new Ogrenci { OgrenciAd = txtAd.Text, OgrenciSoyad = txtSoyad.Text, 
                    OgrenciNumara = txtNumara.Text, OgrenciSinif = (int)cBSinif.SelectedValue, OgrenciTckimlik = txtTcKimlik.Text }) ? "Ekleme Başarılı" : "Ekleme Başarısız");

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SqlException )
            {
                MessageBox.Show("Veri Tabanı Hatası");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu");
            }

        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            OgrenciBL obl = new OgrenciBL();
            Ogrenci ogr = obl.OgrenciGetir(txtArama.Text.Trim());
            if (ogr==null)
            {
                MessageBox.Show("Öğrenci Bulunamadı");
            }
            else
            {
                txtAd.Text = ogr.OgrenciAd;
                txtSoyad.Text = ogr.OgrenciSoyad;
                txtNumara.Text = ogr.OgrenciNumara;
                txtTcKimlik.Text = ogr.OgrenciTckimlik;
                cBSinif.SelectedValue = ogr.OgrenciSinif;
                txtOgrenciID.Text = ogr.OgrenciId.ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            OgrenciBL ogr = new OgrenciBL();
            ogr.OgrenciSil(Convert.ToInt32(txtOgrenciID.Text));
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            OgrenciBL ogr = new OgrenciBL();
            ogr.OgrenciGuncelle(new Ogrenci { OgrenciAd = txtAd.Text, OgrenciSoyad = txtSoyad.Text,
                OgrenciNumara = txtNumara.Text, OgrenciTckimlik = txtTcKimlik.Text, 
                OgrenciSinif = (int)cBSinif.SelectedValue , OgrenciId = Convert.ToInt32(txtOgrenciID.Text)});
        
        }
    }
}

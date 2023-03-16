using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sifremi_unuttum
{
    internal class Kullanici_Formu
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-I5A7DU4B;Initial Catalog=Kullanici_girisi;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;
        frmYeni yeni = new frmYeni();
        public SqlDataReader kullanici(TextBox kullaniciadi , TextBox sifre)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select *from tbl_Kullanici where kullaniciadi='"+kullaniciadi.Text+"'";
            read = komut.ExecuteReader();
            if (read.Read()==true)
            {
                if (sifre.Text == read["sifre"].ToString())
                {
                    MessageBox.Show("Giriş başarılı");
                    yeni.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Şifrenizi kontrol ediniz", " Hata1");
                }
            }
            else
            {
                MessageBox.Show("Bilgilerinizi kontrol ediniz", "Hata2");
            }
            baglanti.Close();
            return read;    
        }
        public void yenikullanici(TextBox adsoyad,TextBox kullaniciadi ,TextBox sifre, TextBox SifreTekrar, TextBox soru, TextBox cevap, GroupBox grup)
        {
            if (sifre.Text == SifreTekrar.Text)
            {
                baglanti.Open();
                komut=new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = " insert into tbl_Kullanici values('"+adsoyad.Text+"','"+kullaniciadi.Text+"','"+sifre.Text+"','"+soru.Text+"','"+cevap.Text+"')";
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("üye Kaydedildi");
                foreach (Control item in grup.Controls) if (item is TextBox) item.Text = "";
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor", " Hata");
            }
        }
    }
}
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sifremi_unuttum
{
    public partial class frmKullanıcı : Form
    {
        public frmKullanıcı()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmŞifre şifre = new frmŞifre();
            şifre.ShowDialog();
        }
        Kullanici_Formu k = new Kullanici_Formu();
        private void button1_Click(object sender, EventArgs e)
        {
            k.kullanici(txtKullaniciAdi, txtSifre);

        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            k.yenikullanici(AdSoyadtxt, KullaniciAditxt, Sifretxt, SifreTekrartxt, Sorutxt, Cevaptxt, groupBox2);
        }

        private void AdSoyadtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PazzoCafe.UI
{
    public partial class FrmSiparis : Form
    {
        public FrmSiparis()
        {
            InitializeComponent();
        }
        public musteri Musteri { get; set; }
        public urun Urun { get; set; }
        public siparis Siparis { get; set; }
        public calisanlar Calisanlar { get; set; } 
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FrmSiparis_Load(object sender, EventArgs e)
        {
            
            
            //txtUrun.Text = Urun.ToString();
            //txtCalisan.Text = Calisanlar.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(nmFiyat.Value == 0)
            {
                errorProvider1.SetError(nmFiyat, "Lütfen Fiyat Giriniz");
                nmFiyat.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmFiyat, "");
            }

            Siparis.adet = (int)nmAdet.Value;
            Siparis.tutar = (int)nmFiyat.Value;
            Siparis.urunID = Urun.ID;
            Siparis.musteriID = Musteri.ID;
            Siparis.calisanlarID = Calisanlar.ID;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }

        private void btnMüşteriSeç_Click(object sender, EventArgs e)
        {
            Müşteriler frm = new Müşteriler();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                Musteri = frm.musteri;
                txtMusteri.Text = Musteri.ToString();
            }
        }

        private void btnÜrünSeç_Click(object sender, EventArgs e)
        {
            Ürünler frme = new Ürünler();
            if (frme.ShowDialog() == DialogResult.OK)
            {
                Urun = frme.urun;
                txtID.Text = Siparis.ID.ToString();
            }
        }

        private void btnÇalışanSeç_Click(object sender, EventArgs e)
        {
            Çalışanlar frm = new Çalışanlar();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                calisanlar calisanlar = new calisanlar();  
            }
        }
    }
}

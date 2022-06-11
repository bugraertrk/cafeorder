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
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public musteri musteri { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtAdSoy)) return;
            if (!ErrorControl(txtMail)) return;
            if (!ErrorControl(txtAdres)) return;
            if (!ErrorControl(txtSehir)) return;
            if (!ErrorControl(txtTel)) return;

            musteri.AdSoy = txtAdSoy.Text;
            musteri.Mail = txtMail.Text;
            musteri.Adres = txtAdres.Text;
            musteri.Sehir = txtSehir.Text;
            musteri.Tel = txtTel.Text;

            DialogResult = DialogResult.OK;
        }
        private bool ErrorControl(Control c)
        {
            if (c is TextBox) { 
                if (c.Text == "")
                {
                  errorProvider1.SetError(c, "Eksik veya Hatalı Bilgi");
                  c.Focus();
                  return false;
                }
                else
                {
                  errorProvider1.SetError(c, "");
                  return true;
                }
            }

            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
                {
                    errorProvider1.SetError(c, "Eksik veya Hatalı Bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            return true;
        }

        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            txtID.Text = musteri.ID.ToString();
            if (Güncelleme)
            {
                txtAdSoy.Text = musteri.AdSoy;
                 txtMail.Text = musteri.Mail;
                 txtAdres.Text = musteri.Adres;
                 txtSehir.Text = musteri.Sehir;
                 txtTel.Text = musteri.Tel;
            }
            
        }
    }
}

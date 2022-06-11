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
    public partial class FrmCalisan : Form
    {
        public FrmCalisan()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public calisanlar calisanlar { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtAdSoy)) return;
            if (!ErrorControl(txtMail)) return;
            if (!ErrorControl(txtTel)) return;

            calisanlar.AdSoy = txtAdSoy.Text;
            calisanlar.Mail = txtMail.Text;
            calisanlar.Tel = txtTel.Text;
            DialogResult =DialogResult.OK;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
            {
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

        private void FrmCalisan_Load(object sender, EventArgs e)
        {
            txtID.Text = calisanlar.ID.ToString();

            if (Güncelleme)
            {
                txtAdSoy.Text = calisanlar.AdSoy;
                txtMail.Text = calisanlar.Mail;
                txtTel.Text = calisanlar.Tel;
            }
        }

            
    }
}

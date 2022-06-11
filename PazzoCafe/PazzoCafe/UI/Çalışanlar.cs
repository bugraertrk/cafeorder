using PazzoCafe.BL;
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
    public partial class Çalışanlar : Form
    {
        public Çalışanlar()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView3.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi Onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ÇalışanSil(ID);
                if (b)
                {

                    DataSet ds = BLogic.ÇalışanGetir("");
                    if (ds != null)
                        dataGridView3.DataSource = ds.Tables[0];
                }

            }
        }
        private void btnÇalışanEkle_Click(object sender, EventArgs e)
        {

            FrmCalisan frm = new FrmCalisan()
            {
                Text = "Müşteri Ekle",

                calisanlar = new calisanlar() { ID = Guid.NewGuid() },
            };
        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ÇalışanEkle(frm.calisanlar);
                if (b)
                {

                    DataSet ds = BLogic.ÇalışanGetir("");
                    if (ds != null)
                        dataGridView3.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;

            }
        }

        private void btnÇalışanDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView3.SelectedRows[0];
            FrmCalisan frm = new FrmCalisan()
            {
                Text = "Çalışan Güncelle",
                Güncelleme = true,
                calisanlar = new calisanlar()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    AdSoy = row.Cells[1].Value.ToString(),
                    Tel = row.Cells[2].Value.ToString(),
                    Mail = row.Cells[3].Value.ToString(),

                },
            };
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ÇalışanGüncelle(frm.calisanlar);
                if (b)
                {

                    row.Cells[1].Value = frm.calisanlar.AdSoy;
                    row.Cells[2].Value = frm.calisanlar.Tel;
                    row.Cells[3].Value = frm.calisanlar.Mail;


                }

            }
        }

        private void Çalışanlar_Load(object sender, EventArgs e)
        {
            DataSet ds2 = BLogic.ÇalışanGetir("");
            if (ds2 != null)
                dataGridView3.DataSource = ds2.Tables[0];
        }
    }
}

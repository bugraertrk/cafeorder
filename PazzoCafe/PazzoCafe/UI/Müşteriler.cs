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
    public partial class Müşteriler : Form
    {
        public Müşteriler()
        {
            InitializeComponent();
        }
        private void btnMüşteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteri frmMusteri = new FrmMusteri()
            {
                Text = "Müşteri Ekle",
                Güncelleme = true,
                musteri = new musteri() { ID = Guid.NewGuid() },
            };
        tekrar:
            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriEkle(frmMusteri.musteri);
                if (b)
                {

                    DataSet ds = BLogic.MüşteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;
            }
        }

        private void btnMüşteriDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            FrmMusteri frmMusteri = new FrmMusteri()
            {
                Text = "Müşteri Güncelle",
                musteri = new musteri()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    AdSoy = row.Cells[1].Value.ToString(),
                    Tel = row.Cells[2].Value.ToString(),
                    Mail = row.Cells[3].Value.ToString(),
                    Adres = row.Cells[4].Value.ToString(),
                    Sehir = row.Cells[5].Value.ToString(),
                },
            };
            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriGüncelle(frmMusteri.musteri);
                if (b)
                {

                    row.Cells[1].Value = frmMusteri.musteri.AdSoy;
                    row.Cells[2].Value = frmMusteri.musteri.Tel;
                    row.Cells[3].Value = frmMusteri.musteri.Mail;
                    row.Cells[4].Value = frmMusteri.musteri.Adres;
                    row.Cells[5].Value = frmMusteri.musteri.Sehir;

                }

            }

        }

        private void btnMüşteriBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.MüşteriGetir(toolStripTextBox1.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }


        private void btnMüşteriSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi Onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriSil(ID);
                if (b)
                {

                    DataSet ds = BLogic.MüşteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }

            }
        }

        private void Müşteriler_Load(object sender, EventArgs e)
        {

            DataSet ds1 = BLogic.MüşteriGetir("");
            if (ds1 != null)
                dataGridView1.DataSource = ds1.Tables[0];
        }

        public musteri musteri { get; set; }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            musteri = new musteri()
            {
                ID = Guid.Parse(row.Cells[0].Value.ToString()),
                AdSoy = row.Cells[1].Value.ToString(),
                Tel = row.Cells[2].Value.ToString(),
                Mail = row.Cells[3].Value.ToString(),
                Adres = row.Cells[4].Value.ToString(),
                Sehir = row.Cells[5].Value.ToString(),
            };

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

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
    public partial class Ürünler : Form
    {
        internal urun urun;

        public Ürünler()
        {
            InitializeComponent();
        }

        private void btnÜrünEkle_Click(object sender, EventArgs e)
        {
            FrmUrun frme = new FrmUrun()
            {
                Text = "Ürün Ekle",

                urun = new urun() { ID = Guid.NewGuid() },
            };
        tekrar:
            var sonuc = frme.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunEkle(frme.urun);
                if (b)
                {

                    DataSet ds3 = BLogic.UrunGetir("");
                    if (ds3 != null)
                        dataGridView2.DataSource = ds3.Tables[0];
                }
                else
                    goto tekrar;

            }
        }

        private void btnÜrünSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi Onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunSil(ID);
                if (b)
                {

                    DataSet ds3 = BLogic.UrunGetir("");
                    if (ds3 != null)
                        dataGridView2.DataSource = ds3.Tables[0];
                }

            }
        }

        private void Ürünler_Load(object sender, EventArgs e)
        {
            DataSet ds3 = BLogic.UrunGetir("");
            if (ds3 != null)
                dataGridView2.DataSource = ds3.Tables[0];
        }
        public urun Urun { get; set; }
        private void btnOK_Click(object sender, EventArgs e)
        {
             FrmUrun frme = new FrmUrun();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

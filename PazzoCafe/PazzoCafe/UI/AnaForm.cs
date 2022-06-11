using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PazzoCafe.BL;
using PazzoCafe.UI;

namespace PazzoCafe
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        Müşteriler mf = new Müşteriler();
        Ürünler uf = new Ürünler();
        Çalışanlar ca = new Çalışanlar();
        private void btnMüşteriler_Click(object sender, EventArgs e)
        {
            mf.ShowDialog();
        }

        private void btnÜrünler_Click(object sender, EventArgs e)
        {
           uf.ShowDialog();
        }

        private void btnÇalışanlar_Click(object sender, EventArgs e)
        {
            ca.ShowDialog();
        }

        private void btnSiparişVer_Click(object sender, EventArgs e)
        {
            FrmSiparis frm = new FrmSiparis()
            {
                Text = "Sipariş Ver",
                Siparis = new siparis()
                {
                    ID = Guid.NewGuid(),
                }
            };

            
            tekrar:
                var sonuc = frm.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                    bool b = BLogic.SiparişEkle(frm.Siparis);
                    if (b)
                    {

                         DataSet ds1 = BLogic.SiparisDetay();
                         if (ds1 != null)
                            dataGridView1.DataSource = ds1.Tables[0];
                }
                    else
                        goto tekrar;
                }
            
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.SiparisDetay();
            if (ds1 != null)
                dataGridView1.DataSource = ds1.Tables[0];
        }

        private void btnSiparisSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi Onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SiparişSil(ID);
                if (b)
                {

                    DataSet ds1 = BLogic.SiparisDetay();
                    if (ds1 != null)
                        dataGridView1.DataSource = ds1.Tables[0];
                }

            }
        }
    }
}

using PazzoCafe.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PazzoCafe.BL
{
    public static class BLogic
    {
        public static bool MüşteriEkle(musteri m)
        {
            try
            {
                int res = DataLayer.MüşteriEkle(m);
                return (res > 0);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu:" + ex.Message);  
                return false;
            }
            
        }

        internal static DataSet MüşteriGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.MüşteriGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool MüşteriGüncelle(musteri m)
        {
            try
            {
                int res = DataLayer.MüşteriGüncelle(m);
                return (res > 0);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool ÇalışanSil(string id)
        {
            try
            {
                int res = DataLayer.ÇalışanSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool SiparişEkle(siparis s)
        {
            try
            {
                int res = DataLayer.SiparişEkle(s);
                return (res > 0);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool MüşteriSil(string id)
        {
            try
            {
                int res = DataLayer.MüşteriSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet SiparisDetay()
        {

            try
            {
                DataSet ds = DataLayer.SiparisDetay();
                return ds;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool SiparişSil(string id)
        {
            try
            {
                int res = DataLayer.SiparisSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool ÇalışanEkle(calisanlar ca)
        {
            try
            {
                int res = DataLayer.ÇalışanEkle(ca);
                return (res > 0);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet ÇalışanGetir(string filtre)
        {
            try
            {
                DataSet ds2 = DataLayer.ÇalışanGetir(filtre);
                return ds2;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool ÇalışanGüncelle(calisanlar ca)
        {
            try
            {
                int res = DataLayer.ÇalışanGüncelle(ca);
                return (res > 0);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool UrunEkle(urun u)
        {
            try
            {
                int res = DataLayer.UrunEkle(u);
                return (res > 0);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet UrunGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.UrunGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool UrunSil(string id)
        {
            try
            {
                int res = DataLayer.UrunSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return false;
            }
        }
    }
}

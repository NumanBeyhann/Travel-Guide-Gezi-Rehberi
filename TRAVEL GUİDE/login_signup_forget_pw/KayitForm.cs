using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KullaniciUygulamasi
{
    public partial class KayitForm : Form
    {
        public KayitForm()
        {
            InitializeComponent();
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            string isim = txtIsim.Text;
            string soyisim = txtSoyisim.Text;
            string tcKimlikNo = txtTCKimlikNo.Text;
            string telefonNo = txtTelefonNo.Text;
            string eposta = txtEposta.Text;
            string sifre = txtSifre.Text;

            // zorunlu alanların dolu olup olmadığını kontrol eden kod
            if (string.IsNullOrWhiteSpace(isim) || string.IsNullOrWhiteSpace(soyisim) || string.IsNullOrWhiteSpace(tcKimlikNo) || string.IsNullOrWhiteSpace(eposta))
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz.");
                return;
            }

            // DATABASE BAĞLANTI BÖLÜMÜ. DATABASE'İ İÇE AKTARDIKTAN SONRA "SOURCE" KISMINI BURAYA GİRMELİSİNİZ.
            using (SqlConnection conn = new SqlConnection(""))
            {
                conn.Open();
                string query = "INSERT INTO Kullanici (Isim, Soyisim, TCKimlikNo, TelefonNo, Eposta, Sifre) VALUES (@Isim, @Soyisim, @TCKimlikNo, @TelefonNo, @Eposta, @Sifre)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Isim", isim);
                cmd.Parameters.AddWithValue("@Soyisim", soyisim);
                cmd.Parameters.AddWithValue("@TCKimlikNo", tcKimlikNo);
                cmd.Parameters.AddWithValue("@TelefonNo", telefonNo);
                cmd.Parameters.AddWithValue("@Eposta", eposta);
                cmd.Parameters.AddWithValue("@Sifre", sifre);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarılı! Giriş Sayfasına Yönlendiriliyorsunuz!");
                GirisForm girisForm = new GirisForm();
                girisForm.Show();
                this.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

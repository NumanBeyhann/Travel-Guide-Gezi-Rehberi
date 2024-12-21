using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KullaniciUygulamasi
{
    public partial class SifremiUnuttumForm : Form
    {
        public SifremiUnuttumForm()
        {
            InitializeComponent();
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            string tcKimlikNo = txtTCKimlikNo.Text;
            string eposta = txtEposta.Text;

            // DATABASE BAĞLANTI BÖLÜMÜ. DATABASE'İ İÇE AKTARDIKTAN SONRA "SOURCE" KISMINI BURAYA GİRMELİSİNİZ.
            using (SqlConnection conn = new SqlConnection(""))
            {
                conn.Open();
                string query = "SELECT COUNT(1) FROM Kullanici WHERE TCKimlikNo=@TCKimlikNo AND Eposta=@Eposta";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TCKimlikNo", tcKimlikNo);
                cmd.Parameters.AddWithValue("@Eposta", eposta);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 1)
                {
                    string updateQuery = "UPDATE Kullanici SET Sifre='0000' WHERE TCKimlikNo=@TCKimlikNo AND Eposta=@Eposta";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@TCKimlikNo", tcKimlikNo);
                    updateCmd.Parameters.AddWithValue("@Eposta", eposta);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Şifreniz sıfırlanmıştır. Yeni şifreniz: 0000");
                    GirisForm girisForm = new GirisForm();
                    girisForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bilgiler eşleşmiyor. Lütfen tekrar deneyiniz.");
                }
            }
        }
    }
}

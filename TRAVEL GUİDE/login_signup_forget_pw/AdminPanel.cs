using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HavaDurumuUygulamasi
{
    public partial class AdminPanel : Form
    {
        private SqlConnection kullaniciDbConnection;
        private SqlConnection adminPaneliDbConnection;

        public AdminPanel()
        {
            InitializeComponent();

            // DATABASE BAĞLANTI BÖLÜMÜ. DATABASE'İ İÇE AKTARDIKTAN SONRA "SOURCE" KISMINI BURAYA GİRMELİSİNİZ.HER İKİ KISMADA.
            kullaniciDbConnection = new SqlConnection("");
            adminPaneliDbConnection = new SqlConnection("");

            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT KullaniciID, Isim, Soyisim, TCKimlikNo, TelefonNo, Eposta, Sifre FROM dbo.Kullanici", kullaniciDbConnection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewUsers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Kullanici (Isim, Soyisim, TCKimlikNo, TelefonNo, Eposta, Sifre) VALUES (@Isim, @Soyisim, @TCKimlikNo, @TelefonNo, @Eposta, @Sifre)", kullaniciDbConnection))
                {
                    cmd.Parameters.AddWithValue("@Isim", textBoxIsim.Text);
                    cmd.Parameters.AddWithValue("@Soyisim", textBoxSoyisim.Text);
                    cmd.Parameters.AddWithValue("@TCKimlikNo", textBoxTCKimlikNo.Text);
                    cmd.Parameters.AddWithValue("@TelefonNo", textBoxTelefonNo.Text);
                    cmd.Parameters.AddWithValue("@Eposta", textBoxEposta.Text);
                    cmd.Parameters.AddWithValue("@Sifre", textBoxSifre.Text);

                    kullaniciDbConnection.Open();
                    cmd.ExecuteNonQuery();
                    kullaniciDbConnection.Close();

                    LoadUserData();
                    ClearTextBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı eklenirken hata oluştu: " + ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE dbo.Kullanici SET Isim=@Isim, Soyisim=@Soyisim, TCKimlikNo=@TCKimlikNo, TelefonNo=@TelefonNo, Eposta=@Eposta, Sifre=@Sifre WHERE KullaniciID=@KullaniciID", kullaniciDbConnection))
                {
                    cmd.Parameters.AddWithValue("@KullaniciID", int.Parse(textBoxKullaniciID.Text));
                    cmd.Parameters.AddWithValue("@Isim", textBoxIsim.Text);
                    cmd.Parameters.AddWithValue("@Soyisim", textBoxSoyisim.Text);
                    cmd.Parameters.AddWithValue("@TCKimlikNo", textBoxTCKimlikNo.Text);
                    cmd.Parameters.AddWithValue("@TelefonNo", textBoxTelefonNo.Text);
                    cmd.Parameters.AddWithValue("@Eposta", textBoxEposta.Text);
                    cmd.Parameters.AddWithValue("@Sifre", textBoxSifre.Text);

                    kullaniciDbConnection.Open();
                    cmd.ExecuteNonQuery();
                    kullaniciDbConnection.Close();

                    LoadUserData();
                    ClearTextBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı güncellenirken hata oluştu: " + ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM dbo.Kullanici WHERE KullaniciID=@KullaniciID", kullaniciDbConnection))
                {
                    cmd.Parameters.AddWithValue("@KullaniciID", int.Parse(textBoxKullaniciID.Text));

                    kullaniciDbConnection.Open();
                    cmd.ExecuteNonQuery();
                    kullaniciDbConnection.Close();

                    LoadUserData();
                    ClearTextBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı silinirken hata oluştu: " + ex.Message);
            }
        }

        private void ClearTextBoxes()
        {
            textBoxKullaniciID.Clear();
            textBoxIsim.Clear();
            textBoxSoyisim.Clear();
            textBoxTCKimlikNo.Clear();
            textBoxTelefonNo.Clear();
            textBoxEposta.Clear();
            textBoxSifre.Clear();
        }
    }
}

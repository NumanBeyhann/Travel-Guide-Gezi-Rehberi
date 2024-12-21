
using HavaDurumuUygulamasi;
using login_signup_forget_pw;
using MesafeHesaplayici;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KullaniciUygulamasi
{
    public partial class GirisForm : Form
    {
        private int girisHakki = 5;

        public GirisForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string eposta = txtEposta.Text;
            string sifre = txtSifre.Text;

            // DATABASE BAÐLANTI BÖLÜMÜ. DATABASE'Ý ÝÇE AKTARDIKTAN SONRA "SOURCE" KISMINI BURAYA GÝRMELÝSÝNÝZ.
            using (SqlConnection conn = new SqlConnection(""))
            {
                conn.Open();
                string query = "SELECT COUNT(1) FROM Kullanici WHERE Eposta=@Eposta AND Sifre=@Sifre";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Eposta", eposta);
                cmd.Parameters.AddWithValue("@Sifre", sifre);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 1)
                {
                    MessageBox.Show("Giriþ baþarýlý!");
                    Menü1 FormMenu1 = new Menü1();
                    FormMenu1.Show();
                    this.Hide();
                }
                else
                        {
                            girisHakki--;
                            MessageBox.Show($"Hatalý giriþ. Kalan hakkýnýz: {girisHakki}");

                            if (girisHakki == 0)
                            {
                                MessageBox.Show("5 kez hatalý giriþ yaptýnýz. Kayýt sayfasýna yönlendiriliyorsunuz.");
                                KayitForm kayitForm = new KayitForm();
                                kayitForm.Show();
                                this.Hide();
                            }
                        }
            }
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttumForm sifremiUnuttumForm = new SifremiUnuttumForm();
            sifremiUnuttumForm.Show();
            this.Hide();
        }

        private void btnKayýtOl_Click(object sender, EventArgs e)
        {
            KayitForm kayitForm = new KayitForm();
            kayitForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();

        }
    }
}

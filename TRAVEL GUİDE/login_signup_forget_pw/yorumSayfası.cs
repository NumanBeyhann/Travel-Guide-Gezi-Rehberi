using HavaDurumuUygulamasi;
using KullaniciUygulamasi;
using login_signup_forget_pw;
using System;
using System.Windows.Forms;

namespace RestoranUygulamasi
{
    public partial class CommentsForm : Form
    {
        private string restaurantName;

        public CommentsForm(string restaurantName)
        {
            InitializeComponent();
            this.restaurantName = restaurantName;
            lblRestaurantName.Text = restaurantName;
            LoadComments();
        }

        private void LoadComments()
        {

            listBoxComments.Items.Add("Yorum 1: Mükemmel bir yer!");
            listBoxComments.Items.Add("Yorum 2: Hizmet harikaydı.");
            listBoxComments.Items.Add("Yorum 3: Yemekler çok lezzetliydi.");
        }

        private void btnSubmitComment_Click(object sender, EventArgs e)
        {
            string comment = txtComment.Text;
            if (!string.IsNullOrWhiteSpace(comment))
            {
                listBoxComments.Items.Add($"Yorum: {comment}");
                txtComment.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen bir yorum girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void labelHesap_Click(object sender, EventArgs e)
        {
            SifreSifirlama ŞifreSıfırlamaForm = new SifreSifirlama();
            ŞifreSıfırlamaForm.Show();
            this.Hide();
        }

        private void labelRestorantlar_Click(object sender, EventArgs e)
        {
            Restorantlar RestorantForm = new Restorantlar();
            RestorantForm.Show();
            this.Hide();
        }

        private void labelHavaD_Click(object sender, EventArgs e)
        {
            HavaDurumu havaDurumuForm = new HavaDurumu();
            havaDurumuForm.Show();
            this.Hide();
        }

        private void labelGeri_Click(object sender, EventArgs e)
        {
            Menü1 Menü1Form = new Menü1();
            Menü1Form.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

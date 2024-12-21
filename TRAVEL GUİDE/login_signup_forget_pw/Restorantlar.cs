using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using HavaDurumuUygulamasi;
using KullaniciUygulamasi;
using login_signup_forget_pw;
using Newtonsoft.Json.Linq;

namespace RestoranUygulamasi
{
    public partial class Restorantlar : Form
    {
        private const string apiKey = ""; // Apinizi bu satıra koyun. güvenlik gereği kendi API'mı çıkardım. Koymamanız durumunda kod hata verir.

        public Restorantlar()
        {
            InitializeComponent();
            LoadCities();
        }

        private void LoadCities()
        {
            string[] cities = { "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkâri", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" };
            comboBoxCities.Items.AddRange(cities);
        }

        private async void buttonSearchRestaurants_Click(object sender, EventArgs e)
        {
            var selectedCity = comboBoxCities.SelectedItem.ToString();
            await GetRestaurants(selectedCity);
        }

        private async Task GetRestaurants(string city)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://maps.googleapis.com/maps/api/place/textsearch/json?query=restaurants+in+{city}&key={apiKey}";
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var jsonResponse = await response.Content.ReadAsStringAsync();
                var data = JObject.Parse(jsonResponse);

                listBoxRestaurants.Items.Clear();
                foreach (var result in data["results"])
                {
                    var name = result["name"].ToString();
                    var address = result["formatted_address"].ToString();
                    var restaurant = new Restaurant { Name = name, Address = address };
                    listBoxRestaurants.Items.Add(restaurant);
                }
            }
        }

        private void buttonGetDirections_Click(object sender, EventArgs e)
        {
            if (listBoxRestaurants.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir restoran seçiniz.");
                return;
            }

            var selectedRestaurant = listBoxRestaurants.SelectedItem as Restaurant;
            labelAddress.Text = "Adres: " + selectedRestaurant.Address;
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLeaveReview_Click(object sender, EventArgs e)
        {
            if (listBoxRestaurants.SelectedItem != null)
            {
                // Seçilen restoranın adını alan kod
                var selectedRestaurant = listBoxRestaurants.SelectedItem as Restaurant;
                string restaurantName = selectedRestaurant.Name;

                
                CommentsForm yorumSayfası = new CommentsForm(restaurantName);
                yorumSayfası.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen bir restoran seçiniz.");
            }
        }
    }

    public class Restaurant
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

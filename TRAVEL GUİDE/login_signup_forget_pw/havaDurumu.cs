using System;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using login_signup_forget_pw;
using Newtonsoft.Json.Linq;
using RestoranUygulamasi;
using System.Globalization;
using KullaniciUygulamasi;

namespace HavaDurumuUygulamasi
{
    public partial class HavaDurumu : Form
    {
        private const string apiKey = "fa19d79596c43f9e34ae6fd98c2f3c26";
        private const string apiBaseUrl = "https://api.openweathermap.org/data/2.5/forecast";

        public HavaDurumu()
        {
            InitializeComponent();
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("tr-TR");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("tr-TR");
        }

        private async void buttonGetWeather_Click(object sender, EventArgs e)
        {
            if (comboBoxCities.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir il seçiniz.");
                return;
            }

            string selectedCity = comboBoxCities.SelectedItem.ToString();
            try
            {
                await GetWeatherForecast(selectedCity);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmedik bir hata oluştu: {ex.Message}");
            }
        }

        private async Task GetWeatherForecast(string city)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = $"{apiBaseUrl}?q={city}&units=metric&cnt=7&appid={apiKey}";
                    HttpResponseMessage response = null;

                    try
                    {
                        response = await client.GetAsync(url);
                        response.EnsureSuccessStatusCode();
                    }
                    catch (HttpRequestException httpEx)
                    {
                        MessageBox.Show($"HTTP isteği başarısız oldu: {httpEx.Message}");
                        return;
                    }

                    string jsonResponse = null;
                    try
                    {
                        jsonResponse = await response.Content.ReadAsStringAsync();
                    }
                    catch (Exception readEx)
                    {
                        MessageBox.Show($"Yanıt okunurken hata oluştu: {readEx.Message}");
                        return;
                    }

                    JObject data = null;
                    try
                    {
                        data = JObject.Parse(jsonResponse);
                    }
                    catch (Exception parseEx)
                    {
                        MessageBox.Show($"JSON verisi ayrıştırılamadı: {parseEx.Message}");
                        return;
                    }

                    var list = data["list"];
                    if (list == null)
                    {
                        MessageBox.Show("Beklenen 'list' verisi bulunamadı.");
                        return;
                    }

                    flowLayoutPanelWeather.Controls.Clear();

                    foreach (var item in list)
                    {
                        try
                        {
                            var date = UnixTimeStampToDateTime((long)item["dt"]);
                            var temp = item["main"]["temp"].ToString();
                            var description = item["weather"][0]["description"].ToString();
                            var iconCode = item["weather"][0]["icon"].ToString();

                            var weatherPanel = CreateWeatherPanel(date, temp, description, iconCode);
                            flowLayoutPanelWeather.Controls.Add(weatherPanel);
                        }
                        catch (Exception itemEx)
                        {
                            MessageBox.Show($"Veri işlenirken hata oluştu: {itemEx.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"API çağrısı sırasında genel bir hata oluştu: {ex.Message}");
            }
        }

        private Panel CreateWeatherPanel(DateTime date, string temp, string description, string iconCode)
        {
            var panel = new Panel
            {
                Width = 100,
                Height = 150,
                Margin = new Padding(10)
            };

            var labelDate = new Label
            {
                Text = date.ToString("dddd", new CultureInfo("tr-TR")),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter
            };

            var labelTemp = new Label
            {
                Text = $"{temp} °C",
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter
            };

            var labelDesc = new Label
            {
                Text = TranslateWeatherDescription(description),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter
            };

            var pictureBox = new PictureBox
            {
                Width = 50,
                Height = 50,
                Dock = DockStyle.Top,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            string iconUrl = $"http://openweathermap.org/img/wn/{iconCode}@2x.png";
            var image = InvertImageColors(iconUrl);
            pictureBox.Image = image;

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(labelDesc);
            panel.Controls.Add(labelTemp);
            panel.Controls.Add(labelDate);

            return panel;
        }

        private string TranslateWeatherDescription(string description)
        {
            
            switch (description.ToLower())
            {
                case "clear sky":
                    return "Açık";
                case "few clouds":
                    return "Az Bulutlu";
                case "scattered clouds":
                    return "Parçalı Bulutlu";
                case "broken clouds":
                    return "Çok Bulutlu";
                case "shower rain":
                    return "Sağanak Yağışlı";
                case "rain":
                    return "Yağmurlu";
                case "thunderstorm":
                    return "Gök Gürültülü Fırtına";
                case "snow":
                    return "Karlı";
                case "mist":
                    return "Sisli";
                default:
                    return description;
            }
        }

        private Image InvertImageColors(string imageUrl)
        {
            using (var wc = new System.Net.WebClient())
            {
                byte[] bytes = wc.DownloadData(imageUrl);
                using (var ms = new System.IO.MemoryStream(bytes))
                {
                    Bitmap originalBitmap = new Bitmap(ms);
                    for (int y = 0; y < originalBitmap.Height; y++)
                    {
                        for (int x = 0; x < originalBitmap.Width; x++)
                        {
                            Color originalColor = originalBitmap.GetPixel(x, y);
                            Color invertedColor = Color.FromArgb(originalColor.A, 255 - originalColor.R, 255 - originalColor.G, 255 - originalColor.B);
                            originalBitmap.SetPixel(x, y, invertedColor);
                        }
                    }
                    return originalBitmap;
                }
            }
        }

        private DateTime UnixTimeStampToDateTime(long unixTimeStamp)
        {
            // Unix zaman damgasını DateTime nesnesine çevirir
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
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

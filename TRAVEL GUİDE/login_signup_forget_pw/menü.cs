using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using HavaDurumuUygulamasi;
using KullaniciUygulamasi;
using login_signup_forget_pw;
using Newtonsoft.Json.Linq;
using RestoranUygulamasi;

namespace MesafeHesaplayici
{
    public partial class Form1 : Form
    {
        private const string apiKey = "";// Apinizi bu satıra koyun. güvenlik gereği kendi API'mı çıkardım. Koymamanız durumunda kod hata verir.
        //RESİM HATASI ALIRSANIZ EĞER HER RESİM İÇİN "SAĞ TIK ,ÖZELLİKLER, GENEL, RESİM YOLU" KISMINDAKİ YOLU KOPYALAYIP TEK TEK BURAYA YAPIŞTIRIN.
        private string[] imagePaths = { "C:\\Users\\NUMAN\\source\\repos\\login_signup_forget_pw\\foto\\ist2.png", "C:\\Users\\NUMAN\\source\\repos\\login_signup_forget_pw\\foto\\ist1.png", "C:\\Users\\NUMAN\\source\\repos\\login_signup_forget_pw\\foto\\images.jpeg", "C:\\Users\\NUMAN\\source\\repos\\login_signup_forget_pw\\foto\\images (1).jpeg", "C:\\Users\\NUMAN\\source\\repos\\login_signup_forget_pw\\foto\\efes1.jpg.png", "C:\\Users\\NUMAN\\source\\repos\\login_signup_forget_pw\\foto\\efes3.jpg.png", "C:\\Users\\NUMAN\\source\\repos\\login_signup_forget_pw\\foto\\efes3.jpg", "C:\\Users\\NUMAN\\source\\repos\\login_signup_forget_pw\\foto\\efes3.jpg.png", "C:\\Users\\NUMAN\\source\\repos\\login_signup_forget_pw\\foto\\canakkale-truva-heykeli.jpg", "C:\\Users\\NUMAN\\source\\repos\\login_signup_forget_pw\\foto\\canak2.png", "C:\\Users\\NUMAN\\source\\repos\\login_signup_forget_pw\\foto\\40178824_57181_canakkale-de-bugun-hava-d.jpg" }; // resim dosya yolları
        private int currentImageIndex = 0;

        public Form1()
        {
            InitializeComponent();
            LoadCities();
            StartImageSlider();
        }

        private void LoadCities()
        {
            //  iller 
            string[] cities = { "Istanbul", "Ankara", "Izmir", "Bursa", "Antalya", "Malatya", "Elazığ", "Kovancılar", "Adıyaman", "Samsun", "Kocaeli", "Aydın", "Muğla", "Kütahya", "Antalya", "Manisa", "Denizli", "Burdur", "Tekirdağ", "Kırklareli", "Edirne", "Muş", "Van", "Uşak", "Eskişehir", "Bilecik", "Bolu", "Isparta", "Konya", "Mersin", "Adana", "Şanlıurfa", "Osmaniye", "Niğde", "Nevşehir", "Kayseri", "Sivas", "Kırşehir", "Tokat", "Amasya", "Yozgat", "Çorum", "Sinop", "Trabzon", "Karabük", "Ordu", "Isparta", "Kahramanmaraş", "Tunceli", "Diyarbakır", "Erzincan", "Gaziantep", "Bitlis", "Mardin", "Ağrı", "Kars" };
            comboBoxStart.Items.AddRange(cities);
            comboBoxEnd.Items.AddRange(cities);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (comboBoxStart.SelectedItem == null || comboBoxEnd.SelectedItem == null)
            {
                MessageBox.Show("Lütfen başlangıç ve varış illerini seçin.");
                return;
            }

            string startCity = comboBoxStart.SelectedItem.ToString();
            string endCity = comboBoxEnd.SelectedItem.ToString();

            GetDistanceBetweenCities(startCity, endCity)
                .ContinueWith(task =>
                {
                    if (task.Exception != null)
                    {
                        // UI thread'ine dönerek hata mesajını göster
                        this.Invoke(new Action(() =>
                        {
                            MessageBox.Show($"Mesafe hesaplanırken bir hata oluştu: {task.Exception.InnerException.Message}");
                        }));
                    }
                    else
                    {
                        double distance = task.Result;
                        // UI thread'ine dönerek sonucu göster
                        this.Invoke(new Action(() =>
                        {
                            labelResult.Text = $"{startCity} ile {endCity} arası mesafe {distance} km.";
                        }));
                    }
                });
        }

        private Task<double> GetDistanceBetweenCities(string startCity, string endCity)
        {
            var tcs = new TaskCompletionSource<double>();
            var client = new HttpClient();

            string url = $"https://maps.googleapis.com/maps/api/distancematrix/json?origins={startCity}&destinations={endCity}&key={apiKey}&units=metric";

            client.GetAsync(url)
                .ContinueWith(getTask =>
                {
                    if (getTask.Exception != null)
                    {
                        tcs.SetException(new Exception("HTTP isteği sırasında bir hata oluştu.", getTask.Exception.InnerException));
                        return;
                    }

                    var response = getTask.Result;

                    response.Content.ReadAsStringAsync()
                        .ContinueWith(readTask =>
                        {
                            if (readTask.Exception != null)
                            {
                                tcs.SetException(new Exception("Yanıt içeriği okunurken bir hata oluştu.", readTask.Exception.InnerException));
                                return;
                            }

                            var responseContent = readTask.Result;

                            if (!response.IsSuccessStatusCode)
                            {
                                tcs.SetException(new Exception($"API isteği başarısız oldu. Durum Kodu: {response.StatusCode}, İçerik: {responseContent}"));
                                return;
                            }

                            try
                            {
                                var data = JObject.Parse(responseContent);

                                // Hata önleme için eklenen güvenli indeks erişimleri
                                var rows = data["rows"] as JArray;
                                if (rows == null || rows.Count == 0)
                                {
                                    tcs.SetException(new Exception($"API yanıtında 'rows' verisi bulunamadı. Yanıt: {responseContent}"));
                                    return;
                                }

                                var elements = rows[0]["elements"] as JArray;
                                if (elements == null || elements.Count == 0)
                                {
                                    tcs.SetException(new Exception($"API yanıtında 'elements' verisi bulunamadı. Yanıt: {responseContent}"));
                                    return;
                                }

                                var distanceToken = elements[0]["distance"];
                                if (distanceToken == null)
                                {
                                    tcs.SetException(new Exception($"API yanıtında 'distance' verisi bulunamadı. Yanıt: {responseContent}"));
                                    return;
                                }

                                var distanceText = distanceToken["text"].ToString();
                                distanceText = distanceText.Replace(" km", "").Replace(",", "."); // Mesafeyi km olarak almak ve , yerine . koymak
                                double distance = Convert.ToDouble(distanceText);
                                tcs.SetResult(distance);
                            }
                            catch (Exception ex)
                            {
                                tcs.SetException(new Exception($"JSON yanıtı ayrıştırılırken bir hata oluştu. Yanıt: {responseContent}", ex));
                            }
                        });
                });

            return tcs.Task;
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

        private void StartImageSlider()
        {
            pictureBoxSlider.ImageLocation = imagePaths[currentImageIndex];
            sliderTimer.Start();
        }

        private void sliderTimer_Tick(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;
            pictureBoxSlider.ImageLocation = imagePaths[currentImageIndex];
        }

        private void btnNextImage_Click(object sender, EventArgs e)
        {
            sliderTimer.Stop();
            currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;
            pictureBoxSlider.ImageLocation = imagePaths[currentImageIndex];
            sliderTimer.Start();
        }

        private void btnPreviousImage_Click(object sender, EventArgs e)
        {
            sliderTimer.Stop();
            currentImageIndex = (currentImageIndex - 1 + imagePaths.Length) % imagePaths.Length;
            pictureBoxSlider.ImageLocation = imagePaths[currentImageIndex];
            sliderTimer.Start();
        }

        private void pictureBoxSlider_Click(object sender, EventArgs e)
        {

        }
    }
}

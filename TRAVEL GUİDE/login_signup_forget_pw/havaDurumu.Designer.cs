namespace HavaDurumuUygulamasi
{
    partial class HavaDurumu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.Label labelSelectCity;
        private System.Windows.Forms.Button buttonGetWeather;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelWeather;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            comboBoxCities = new ComboBox();
            labelSelectCity = new Label();
            buttonGetWeather = new Button();
            flowLayoutPanelWeather = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            label8 = new Label();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxCities
            // 
            comboBoxCities.FormattingEnabled = true;
            comboBoxCities.Items.AddRange(new object[] { "Istanbul", "Ankara", "Izmir", "Bursa", "Antalya" });
            comboBoxCities.Location = new Point(217, 45);
            comboBoxCities.Name = "comboBoxCities";
            comboBoxCities.Size = new Size(187, 28);
            comboBoxCities.TabIndex = 0;
            // 
            // labelSelectCity
            // 
            labelSelectCity.AutoSize = true;
            labelSelectCity.Location = new Point(217, 22);
            labelSelectCity.Name = "labelSelectCity";
            labelSelectCity.Size = new Size(70, 20);
            labelSelectCity.TabIndex = 1;
            labelSelectCity.Text = "Il Seçiniz:";
            // 
            // buttonGetWeather
            // 
            buttonGetWeather.Location = new Point(430, 45);
            buttonGetWeather.Name = "buttonGetWeather";
            buttonGetWeather.Size = new Size(137, 28);
            buttonGetWeather.TabIndex = 2;
            buttonGetWeather.Text = "Getir";
            buttonGetWeather.UseVisualStyleBackColor = true;
            buttonGetWeather.Click += buttonGetWeather_Click;
            // 
            // flowLayoutPanelWeather
            // 
            flowLayoutPanelWeather.Location = new Point(217, 94);
            flowLayoutPanelWeather.Name = "flowLayoutPanelWeather";
            flowLayoutPanelWeather.Size = new Size(555, 355);
            flowLayoutPanelWeather.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = login_signup_forget_pw.Properties.Resources._222;
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(794, 459);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(192, 192, 0);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(65, 292);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 7;
            label9.Text = "Çıkış";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(192, 192, 0);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(65, 252);
            label8.Name = "label8";
            label8.Size = new Size(36, 20);
            label8.TabIndex = 8;
            label8.Text = "Geri";
            label8.Click += labelGeri_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 192, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(65, 207);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 9;
            label4.Text = "Hava Durumu";
            label4.Click += labelHavaD_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(192, 192, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(65, 161);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 10;
            label6.Text = "Restorantlar";
            label6.Click += labelRestorantlar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 192, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(65, 109);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 11;
            label3.Text = "Hesap";
            label3.Click += labelHesap_Click;
            // 
            // HavaDurumu
            // 
            ClientSize = new Size(794, 461);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(flowLayoutPanelWeather);
            Controls.Add(buttonGetWeather);
            Controls.Add(labelSelectCity);
            Controls.Add(comboBoxCities);
            Controls.Add(pictureBox1);
            Name = "HavaDurumu";
            Text = "Hava Durumu Uygulaması";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private Label label9;
        private Label label8;
        private Label label4;
        private Label label6;
        private Label label3;
    }
}

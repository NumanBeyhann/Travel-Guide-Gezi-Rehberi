namespace RestoranUygulamasi
{
    partial class Restorantlar
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBoxCities;
        private Label labelSelectCity;
        private ListBox listBoxRestaurants;
        private Button buttonGetDirections;
        private Button buttonLeaveReview;
        private Label labelAddress;
        private Button buttonSearchRestaurants; // Yeni buton

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
            listBoxRestaurants = new ListBox();
            buttonGetDirections = new Button();
            buttonLeaveReview = new Button();
            labelAddress = new Label();
            buttonSearchRestaurants = new Button();
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
            comboBoxCities.BackColor = SystemColors.InactiveBorder;
            comboBoxCities.FormattingEnabled = true;
            comboBoxCities.Location = new Point(259, 57);
            comboBoxCities.Name = "comboBoxCities";
            comboBoxCities.Size = new Size(200, 28);
            comboBoxCities.TabIndex = 0;
            // 
            // labelSelectCity
            // 
            labelSelectCity.AutoSize = true;
            labelSelectCity.Location = new Point(259, 25);
            labelSelectCity.Name = "labelSelectCity";
            labelSelectCity.Size = new Size(70, 20);
            labelSelectCity.TabIndex = 1;
            labelSelectCity.Text = "Il Seçiniz:";
            // 
            // listBoxRestaurants
            // 
            listBoxRestaurants.BackColor = SystemColors.InactiveBorder;
            listBoxRestaurants.FormattingEnabled = true;
            listBoxRestaurants.Location = new Point(259, 104);
            listBoxRestaurants.Name = "listBoxRestaurants";
            listBoxRestaurants.Size = new Size(406, 244);
            listBoxRestaurants.TabIndex = 2;
            // 
            // buttonGetDirections
            // 
            buttonGetDirections.BackColor = SystemColors.ButtonFace;
            buttonGetDirections.Location = new Point(259, 384);
            buttonGetDirections.Name = "buttonGetDirections";
            buttonGetDirections.Size = new Size(140, 30);
            buttonGetDirections.TabIndex = 4;
            buttonGetDirections.Text = "Yol Tarifi Al";
            buttonGetDirections.UseVisualStyleBackColor = false;
            buttonGetDirections.Click += buttonGetDirections_Click;
            // 
            // buttonLeaveReview
            // 
            buttonLeaveReview.BackColor = SystemColors.ButtonFace;
            buttonLeaveReview.Location = new Point(519, 384);
            buttonLeaveReview.Name = "buttonLeaveReview";
            buttonLeaveReview.Size = new Size(146, 30);
            buttonLeaveReview.TabIndex = 5;
            buttonLeaveReview.Text = "Yorum Yap";
            buttonLeaveReview.UseVisualStyleBackColor = false;
            buttonLeaveReview.Click += buttonLeaveReview_Click;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(259, 451);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(54, 20);
            labelAddress.TabIndex = 6;
            labelAddress.Text = "Adres: ";
            // 
            // buttonSearchRestaurants
            // 
            buttonSearchRestaurants.BackColor = SystemColors.ButtonFace;
            buttonSearchRestaurants.Location = new Point(492, 56);
            buttonSearchRestaurants.Name = "buttonSearchRestaurants";
            buttonSearchRestaurants.Size = new Size(173, 28);
            buttonSearchRestaurants.TabIndex = 3;
            buttonSearchRestaurants.Text = "Restoranları Listele";
            buttonSearchRestaurants.UseVisualStyleBackColor = false;
            buttonSearchRestaurants.Click += buttonSearchRestaurants_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 192, 0);
            pictureBox1.Image = login_signup_forget_pw.Properties.Resources._222;
            pictureBox1.Location = new Point(-1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(943, 504);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(192, 192, 0);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(73, 328);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 8;
            label9.Text = "Çıkış";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(192, 192, 0);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(73, 282);
            label8.Name = "label8";
            label8.Size = new Size(36, 20);
            label8.TabIndex = 9;
            label8.Text = "Geri";
            label8.Click += labelGeri_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 192, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(73, 234);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 10;
            label4.Text = "Hava Durumu";
            label4.Click += labelHavaD_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(192, 192, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(73, 173);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 11;
            label6.Text = "Restorantlar";
            label6.Click += labelRestorantlar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 192, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(73, 121);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 12;
            label3.Text = "Hesap";
            label3.Click += labelHesap_Click;
            // 
            // Restorantlar
            // 
            ClientSize = new Size(942, 501);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(labelAddress);
            Controls.Add(buttonLeaveReview);
            Controls.Add(buttonGetDirections);
            Controls.Add(buttonSearchRestaurants);
            Controls.Add(listBoxRestaurants);
            Controls.Add(labelSelectCity);
            Controls.Add(comboBoxCities);
            Controls.Add(pictureBox1);
            Name = "Restorantlar";
            Text = "Restorantlar";
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

namespace KullaniciUygulamasi
{
    partial class GirisForm
    {
        private System.ComponentModel.IContainer components = null;

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
            txtEposta = new TextBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            btnSifremiUnuttum = new Button();
            label1 = new Label();
            label2 = new Label();
            btnKayıtOl = new Button();
            label7 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtEposta
            // 
            txtEposta.BackColor = SystemColors.Control;
            txtEposta.Location = new Point(349, 139);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(226, 27);
            txtEposta.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = SystemColors.Control;
            txtSifre.Location = new Point(349, 189);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(226, 27);
            txtSifre.TabIndex = 1;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(349, 244);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(90, 38);
            btnGiris.TabIndex = 2;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnSifremiUnuttum
            // 
            btnSifremiUnuttum.Location = new Point(445, 244);
            btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            btnSifremiUnuttum.Size = new Size(130, 38);
            btnSifremiUnuttum.TabIndex = 3;
            btnSifremiUnuttum.Text = "Şifremi Unuttum";
            btnSifremiUnuttum.UseVisualStyleBackColor = true;
            btnSifremiUnuttum.Click += btnSifremiUnuttum_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(244, 142);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 8;
            label1.Text = "E POSTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(244, 192);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 9;
            label2.Text = "ŞİFRE";
            // 
            // btnKayıtOl
            // 
            btnKayıtOl.Location = new Point(415, 351);
            btnKayıtOl.Name = "btnKayıtOl";
            btnKayıtOl.Size = new Size(94, 38);
            btnKayıtOl.TabIndex = 10;
            btnKayıtOl.Text = "Kayıt Ol";
            btnKayıtOl.UseVisualStyleBackColor = true;
            btnKayıtOl.Click += btnKayıtOl_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.Cursor = Cursors.No;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(175, 9);
            label7.Name = "label7";
            label7.Size = new Size(478, 101);
            label7.TabIndex = 11;
            label7.Text = "GEZİ REHBERİ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Cursor = Cursors.No;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(200, 285);
            label3.Name = "label3";
            label3.Size = new Size(418, 30);
            label3.TabIndex = 12;
            label3.Text = "---------------------------------------------";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Cursor = Cursors.No;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Calibri", 10.2F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(349, 315);
            label4.Name = "label4";
            label4.Size = new Size(226, 33);
            label4.TabIndex = 13;
            label4.Text = "Hesabın Yok Mu?";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(231, 351);
            button1.Name = "button1";
            button1.Size = new Size(134, 38);
            button1.TabIndex = 14;
            button1.Text = "ADMİN PANELİ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GirisForm
            // 
            BackColor = Color.FromArgb(192, 192, 0);
            ClientSize = new Size(852, 470);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(btnKayıtOl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSifremiUnuttum);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtEposta);
            ForeColor = SystemColors.ControlText;
            Name = "GirisForm";
            Text = "Giriş Yap";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnSifremiUnuttum;
        private Label label1;
        private Label label2;
        private Button btnKayıtOl;
        private Label label7;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}

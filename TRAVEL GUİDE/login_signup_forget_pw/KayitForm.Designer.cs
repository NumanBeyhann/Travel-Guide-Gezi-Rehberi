namespace KullaniciUygulamasi
{
    partial class KayitForm
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
            txtIsim = new TextBox();
            txtSoyisim = new TextBox();
            txtTCKimlikNo = new TextBox();
            txtTelefonNo = new TextBox();
            txtEposta = new TextBox();
            txtSifre = new TextBox();
            btnKaydol = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtIsim
            // 
            txtIsim.Location = new Point(203, 146);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(200, 27);
            txtIsim.TabIndex = 0;
            // 
            // txtSoyisim
            // 
            txtSoyisim.Location = new Point(203, 189);
            txtSoyisim.Name = "txtSoyisim";
            txtSoyisim.Size = new Size(200, 27);
            txtSoyisim.TabIndex = 1;
            // 
            // txtTCKimlikNo
            // 
            txtTCKimlikNo.Location = new Point(203, 232);
            txtTCKimlikNo.Name = "txtTCKimlikNo";
            txtTCKimlikNo.Size = new Size(200, 27);
            txtTCKimlikNo.TabIndex = 2;
            // 
            // txtTelefonNo
            // 
            txtTelefonNo.Location = new Point(579, 146);
            txtTelefonNo.Name = "txtTelefonNo";
            txtTelefonNo.Size = new Size(200, 27);
            txtTelefonNo.TabIndex = 3;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(579, 192);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(200, 27);
            txtEposta.TabIndex = 4;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(579, 240);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(200, 27);
            txtSifre.TabIndex = 5;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // btnKaydol
            // 
            btnKaydol.Location = new Point(379, 320);
            btnKaydol.Name = "btnKaydol";
            btnKaydol.Size = new Size(133, 46);
            btnKaydol.TabIndex = 6;
            btnKaydol.Text = "Kaydol";
            btnKaydol.UseVisualStyleBackColor = true;
            btnKaydol.Click += btnKaydol_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(74, 146);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 7;
            label1.Text = "İSİM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(71, 189);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 8;
            label2.Text = "SOYİSİM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(71, 235);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 8;
            label3.Text = "TC KİMLİK NO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(447, 146);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 8;
            label4.Text = "TELEFON NO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(447, 192);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 8;
            label5.Text = "E POSTA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(447, 240);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 8;
            label6.Text = "ŞİFRE";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.Cursor = Cursors.No;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(216, 9);
            label7.Name = "label7";
            label7.Size = new Size(478, 101);
            label7.TabIndex = 9;
            label7.Text = "GEZİ REHBERİ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KayitForm
            // 
            BackColor = Color.FromArgb(192, 192, 0);
            ClientSize = new Size(892, 454);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKaydol);
            Controls.Add(txtSifre);
            Controls.Add(txtEposta);
            Controls.Add(txtTelefonNo);
            Controls.Add(txtTCKimlikNo);
            Controls.Add(txtSoyisim);
            Controls.Add(txtIsim);
            Name = "KayitForm";
            Text = "Kaydol";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtTCKimlikNo;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnKaydol;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}

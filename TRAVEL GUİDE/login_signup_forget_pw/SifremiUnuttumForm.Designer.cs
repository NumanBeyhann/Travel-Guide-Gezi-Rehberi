namespace KullaniciUygulamasi
{
    partial class SifremiUnuttumForm
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
            txtTCKimlikNo = new TextBox();
            txtEposta = new TextBox();
            btnSifirla = new Button();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtTCKimlikNo
            // 
            txtTCKimlikNo.Location = new Point(336, 150);
            txtTCKimlikNo.Name = "txtTCKimlikNo";
            txtTCKimlikNo.Size = new Size(200, 27);
            txtTCKimlikNo.TabIndex = 0;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(336, 200);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(200, 27);
            txtEposta.TabIndex = 1;
            // 
            // btnSifirla
            // 
            btnSifirla.Location = new Point(379, 264);
            btnSifirla.Name = "btnSifirla";
            btnSifirla.Size = new Size(157, 46);
            btnSifirla.TabIndex = 2;
            btnSifirla.Text = "Şifremi Sıfırla";
            btnSifirla.UseVisualStyleBackColor = true;
            btnSifirla.Click += btnSifirla_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(208, 157);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 9;
            label3.Text = "TC KİMLİK NO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(208, 207);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 10;
            label5.Text = "E POSTA";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.Cursor = Cursors.No;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(152, 9);
            label7.Name = "label7";
            label7.Size = new Size(478, 101);
            label7.TabIndex = 11;
            label7.Text = "GEZİ REHBERİ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SifremiUnuttumForm
            // 
            BackColor = Color.FromArgb(192, 192, 0);
            ClientSize = new Size(764, 425);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btnSifirla);
            Controls.Add(txtEposta);
            Controls.Add(txtTCKimlikNo);
            Name = "SifremiUnuttumForm";
            Text = "Şifremi Unuttum";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtTCKimlikNo;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Button btnSifirla;
        private Label label3;
        private Label label5;
        private Label label7;
    }
}

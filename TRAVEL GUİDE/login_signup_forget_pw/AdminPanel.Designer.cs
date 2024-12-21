namespace HavaDurumuUygulamasi
{
    partial class AdminPanel
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
            dataGridViewUsers = new DataGridView();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            textBoxKullaniciID = new TextBox();
            textBoxIsim = new TextBox();
            textBoxSoyisim = new TextBox();
            textBoxTCKimlikNo = new TextBox();
            textBoxTelefonNo = new TextBox();
            textBoxEposta = new TextBox();
            textBoxSifre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(14, 16);
            dataGridViewUsers.Margin = new Padding(3, 4, 3, 4);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.Size = new Size(887, 333);
            dataGridViewUsers.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(303, 531);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(86, 31);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Ekle";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(395, 531);
            buttonUpdate.Margin = new Padding(3, 4, 3, 4);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(86, 31);
            buttonUpdate.TabIndex = 2;
            buttonUpdate.Text = "Güncelle";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(488, 531);
            buttonDelete.Margin = new Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(86, 31);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Sil";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxKullaniciID
            // 
            textBoxKullaniciID.Location = new Point(14, 357);
            textBoxKullaniciID.Margin = new Padding(3, 4, 3, 4);
            textBoxKullaniciID.Name = "textBoxKullaniciID";
            textBoxKullaniciID.PlaceholderText = "Kullanıcı ID";
            textBoxKullaniciID.Size = new Size(114, 27);
            textBoxKullaniciID.TabIndex = 4;
            // 
            // textBoxIsim
            // 
            textBoxIsim.Location = new Point(199, 390);
            textBoxIsim.Margin = new Padding(3, 4, 3, 4);
            textBoxIsim.Name = "textBoxIsim";
            textBoxIsim.PlaceholderText = "İsim";
            textBoxIsim.Size = new Size(190, 27);
            textBoxIsim.TabIndex = 5;
            // 
            // textBoxSoyisim
            // 
            textBoxSoyisim.Location = new Point(199, 429);
            textBoxSoyisim.Margin = new Padding(3, 4, 3, 4);
            textBoxSoyisim.Name = "textBoxSoyisim";
            textBoxSoyisim.PlaceholderText = "Soyisim";
            textBoxSoyisim.Size = new Size(190, 27);
            textBoxSoyisim.TabIndex = 6;
            // 
            // textBoxTCKimlikNo
            // 
            textBoxTCKimlikNo.Location = new Point(199, 467);
            textBoxTCKimlikNo.Margin = new Padding(3, 4, 3, 4);
            textBoxTCKimlikNo.Name = "textBoxTCKimlikNo";
            textBoxTCKimlikNo.PlaceholderText = "TC Kimlik No";
            textBoxTCKimlikNo.Size = new Size(190, 27);
            textBoxTCKimlikNo.TabIndex = 7;
            // 
            // textBoxTelefonNo
            // 
            textBoxTelefonNo.Location = new Point(488, 467);
            textBoxTelefonNo.Margin = new Padding(3, 4, 3, 4);
            textBoxTelefonNo.Name = "textBoxTelefonNo";
            textBoxTelefonNo.PlaceholderText = "Telefon No";
            textBoxTelefonNo.Size = new Size(190, 27);
            textBoxTelefonNo.TabIndex = 8;
            // 
            // textBoxEposta
            // 
            textBoxEposta.Location = new Point(488, 390);
            textBoxEposta.Margin = new Padding(3, 4, 3, 4);
            textBoxEposta.Name = "textBoxEposta";
            textBoxEposta.PlaceholderText = "E-posta";
            textBoxEposta.Size = new Size(190, 27);
            textBoxEposta.TabIndex = 9;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(488, 429);
            textBoxSifre.Margin = new Padding(3, 4, 3, 4);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.PlaceholderText = "Şifre";
            textBoxSifre.Size = new Size(190, 27);
            textBoxSifre.TabIndex = 10;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 0);
            ClientSize = new Size(914, 600);
            Controls.Add(textBoxSifre);
            Controls.Add(textBoxEposta);
            Controls.Add(textBoxTelefonNo);
            Controls.Add(textBoxTCKimlikNo);
            Controls.Add(textBoxSoyisim);
            Controls.Add(textBoxIsim);
            Controls.Add(textBoxKullaniciID);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewUsers);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminPanel";
            Text = "Admin Panel";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxKullaniciID;
        private System.Windows.Forms.TextBox textBoxIsim;
        private System.Windows.Forms.TextBox textBoxSoyisim;
        private System.Windows.Forms.TextBox textBoxTCKimlikNo;
        private System.Windows.Forms.TextBox textBoxTelefonNo;
        private System.Windows.Forms.TextBox textBoxEposta;
        private System.Windows.Forms.TextBox textBoxSifre;
    }
}

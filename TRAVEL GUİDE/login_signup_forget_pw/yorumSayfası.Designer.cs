using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RestoranUygulamasi
{
    partial class CommentsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblRestaurantName;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnSubmitComment;

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
            lblRestaurantName = new Label();
            listBoxComments = new ListBox();
            txtComment = new TextBox();
            btnSubmitComment = new Button();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            label8 = new Label();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblRestaurantName
            // 
            lblRestaurantName.AutoSize = true;
            lblRestaurantName.BackColor = Color.White;
            lblRestaurantName.Location = new Point(241, 21);
            lblRestaurantName.Name = "lblRestaurantName";
            lblRestaurantName.Size = new Size(158, 20);
            lblRestaurantName.TabIndex = 0;
            lblRestaurantName.Text = "Size Yakın Restorantlar";
            // 
            // listBoxComments
            // 
            listBoxComments.BackColor = SystemColors.InactiveCaption;
            listBoxComments.FormattingEnabled = true;
            listBoxComments.Location = new Point(241, 54);
            listBoxComments.Name = "listBoxComments";
            listBoxComments.Size = new Size(379, 264);
            listBoxComments.TabIndex = 1;
            // 
            // txtComment
            // 
            txtComment.BackColor = SystemColors.InactiveCaption;
            txtComment.Location = new Point(241, 363);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(260, 27);
            txtComment.TabIndex = 2;
            // 
            // btnSubmitComment
            // 
            btnSubmitComment.Location = new Point(530, 363);
            btnSubmitComment.Name = "btnSubmitComment";
            btnSubmitComment.Size = new Size(90, 27);
            btnSubmitComment.TabIndex = 3;
            btnSubmitComment.Text = "Yorum Yap";
            btnSubmitComment.UseVisualStyleBackColor = true;
            btnSubmitComment.Click += btnSubmitComment_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = login_signup_forget_pw.Properties.Resources._222;
            pictureBox1.Location = new Point(-3, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(882, 508);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(192, 192, 0);
            label9.ForeColor = Color.Gainsboro;
            label9.Location = new Point(65, 328);
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
            label8.ForeColor = Color.Gainsboro;
            label8.Location = new Point(65, 284);
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
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(65, 227);
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
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(65, 175);
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
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(65, 123);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 11;
            label3.Text = "Hesap";
            label3.Click += labelHesap_Click;
            // 
            // CommentsForm
            // 
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(878, 506);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(btnSubmitComment);
            Controls.Add(txtComment);
            Controls.Add(listBoxComments);
            Controls.Add(lblRestaurantName);
            Controls.Add(pictureBox1);
            Name = "CommentsForm";
            Text = "Yorumlar";
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

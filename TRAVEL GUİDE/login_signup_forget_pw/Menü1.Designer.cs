namespace login_signup_forget_pw
{
    partial class Menü1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MenuGR = new Button();
            MenuRestornt = new Button();
            MenuWether = new Button();
            SuspendLayout();
            // 
            // MenuGR
            // 
            MenuGR.Location = new Point(126, 100);
            MenuGR.Name = "MenuGR";
            MenuGR.Size = new Size(130, 59);
            MenuGR.TabIndex = 3;
            MenuGR.Text = "Gezi Rehberi";
            MenuGR.UseVisualStyleBackColor = true;
            MenuGR.Click += MenuGR_Click;
            // 
            // MenuRestornt
            // 
            MenuRestornt.Location = new Point(314, 305);
            MenuRestornt.Name = "MenuRestornt";
            MenuRestornt.Size = new Size(130, 58);
            MenuRestornt.TabIndex = 4;
            MenuRestornt.Text = "Restorantlar";
            MenuRestornt.UseVisualStyleBackColor = true;
            MenuRestornt.Click += MenuRestornt_Click;
            // 
            // MenuWether
            // 
            MenuWether.Location = new Point(489, 100);
            MenuWether.Name = "MenuWether";
            MenuWether.Size = new Size(133, 59);
            MenuWether.TabIndex = 5;
            MenuWether.Text = "Hava Durumu";
            MenuWether.UseVisualStyleBackColor = true;
            MenuWether.Click += MenuWether_Click;
            // 
            // Menü1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(MenuWether);
            Controls.Add(MenuRestornt);
            Controls.Add(MenuGR);
            Name = "Menü1";
            Text = "Menü1";
            ResumeLayout(false);
        }

        #endregion

        private Button MenuGR;
        private Button MenuRestornt;
        private Button MenuWether;
    }
}
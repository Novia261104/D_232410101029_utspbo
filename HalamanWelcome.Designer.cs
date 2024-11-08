namespace _1029_Novia_UTSPBO
{
    partial class HalamanWelcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnLihatBuku = new Button();
            btnDaftarAnggota = new Button();
            btnLoginAdmin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(146, 39);
            label1.Name = "label1";
            label1.Size = new Size(485, 33);
            label1.TabIndex = 0;
            label1.Text = "Selamat Datang di Library";
            label1.Click += label1_Click;
            // 
            // btnLihatBuku
            // 
            btnLihatBuku.BackColor = SystemColors.ActiveCaption;
            btnLihatBuku.Font = new Font("Segoe UI Historic", 10F);
            btnLihatBuku.Location = new Point(272, 120);
            btnLihatBuku.Name = "btnLihatBuku";
            btnLihatBuku.Size = new Size(200, 41);
            btnLihatBuku.TabIndex = 1;
            btnLihatBuku.Text = "Lihat Buku";
            btnLihatBuku.UseVisualStyleBackColor = false;
            btnLihatBuku.Click += button1_Click;
            // 
            // btnDaftarAnggota
            // 
            btnDaftarAnggota.BackColor = SystemColors.ActiveCaption;
            btnDaftarAnggota.Font = new Font("Segoe UI Historic", 10F);
            btnDaftarAnggota.Location = new Point(231, 199);
            btnDaftarAnggota.Name = "btnDaftarAnggota";
            btnDaftarAnggota.Size = new Size(278, 41);
            btnDaftarAnggota.TabIndex = 2;
            btnDaftarAnggota.Text = "Mendaftar Anggota";
            btnDaftarAnggota.UseVisualStyleBackColor = false;
            btnDaftarAnggota.Click += btnDaftarAnggota_Click;
            // 
            // btnLoginAdmin
            // 
            btnLoginAdmin.BackColor = SystemColors.ActiveCaption;
            btnLoginAdmin.Font = new Font("Segoe UI Historic", 10F);
            btnLoginAdmin.Location = new Point(298, 280);
            btnLoginAdmin.Name = "btnLoginAdmin";
            btnLoginAdmin.Size = new Size(160, 36);
            btnLoginAdmin.TabIndex = 3;
            btnLoginAdmin.Text = "Login Admin";
            btnLoginAdmin.UseVisualStyleBackColor = false;
            // 
            // HalamanWelcome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoginAdmin);
            Controls.Add(btnDaftarAnggota);
            Controls.Add(btnLihatBuku);
            Controls.Add(label1);
            Name = "HalamanWelcome";
            Text = "Halaman Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLihatBuku;
        private Button btnDaftarAnggota;
        private Button btnLoginAdmin;
    }
}

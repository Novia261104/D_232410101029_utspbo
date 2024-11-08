namespace _1029_Novia_UTSPBO
{
    partial class DaftarAnggota
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            namabox = new TextBox();
            asalbox = new TextBox();
            ttlbox = new DateTimePicker();
            btnDaftarAnggota = new Button();
            btnBatal = new Button();
            label5 = new Label();
            label6 = new Label();
            emailbox = new TextBox();
            pwbox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 29);
            label1.Name = "label1";
            label1.Size = new Size(348, 25);
            label1.TabIndex = 0;
            label1.Text = "FORM PENDAFTARAN ANGGOTA LIBRARY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 172);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 222);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 2;
            label3.Text = "Asal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 274);
            label4.Name = "label4";
            label4.Size = new Size(38, 25);
            label4.TabIndex = 3;
            label4.Text = "TTL";
            // 
            // namabox
            // 
            namabox.Location = new Point(260, 172);
            namabox.Name = "namabox";
            namabox.Size = new Size(395, 31);
            namabox.TabIndex = 4;
            // 
            // asalbox
            // 
            asalbox.Location = new Point(260, 222);
            asalbox.Name = "asalbox";
            asalbox.Size = new Size(395, 31);
            asalbox.TabIndex = 5;
            // 
            // ttlbox
            // 
            ttlbox.Location = new Point(260, 274);
            ttlbox.Name = "ttlbox";
            ttlbox.Size = new Size(300, 31);
            ttlbox.TabIndex = 6;
            // 
            // btnDaftarAnggota
            // 
            btnDaftarAnggota.BackColor = Color.FromArgb(128, 255, 128);
            btnDaftarAnggota.Location = new Point(566, 340);
            btnDaftarAnggota.Name = "btnDaftarAnggota";
            btnDaftarAnggota.Size = new Size(112, 34);
            btnDaftarAnggota.TabIndex = 7;
            btnDaftarAnggota.Text = "Daftar";
            btnDaftarAnggota.UseVisualStyleBackColor = false;
            btnDaftarAnggota.Click += btnDaftarAnggota_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.FromArgb(255, 128, 128);
            btnBatal.Location = new Point(417, 340);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(112, 34);
            btnBatal.TabIndex = 8;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 78);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 9;
            label5.Text = "E-mail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(105, 123);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 10;
            label6.Text = "password";
            // 
            // emailbox
            // 
            emailbox.Location = new Point(260, 75);
            emailbox.Name = "emailbox";
            emailbox.Size = new Size(395, 31);
            emailbox.TabIndex = 11;
            // 
            // pwbox
            // 
            pwbox.Location = new Point(260, 120);
            pwbox.Name = "pwbox";
            pwbox.Size = new Size(395, 31);
            pwbox.TabIndex = 12;
            // 
            // DaftarAnggota
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pwbox);
            Controls.Add(emailbox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnBatal);
            Controls.Add(btnDaftarAnggota);
            Controls.Add(ttlbox);
            Controls.Add(asalbox);
            Controls.Add(namabox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DaftarAnggota";
            Text = "DaftarAnggota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox namabox;
        private TextBox asalbox;
        private DateTimePicker ttlbox;
        private Button btnDaftarAnggota;
        private Button btnBatal;
        private Label label5;
        private Label label6;
        private TextBox emailbox;
        private TextBox pwbox;
    }
}
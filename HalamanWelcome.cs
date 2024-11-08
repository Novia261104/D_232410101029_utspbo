using _1029_Novia_UTSPBO.models;
using System.Windows.Forms;

namespace _1029_Novia_UTSPBO
{
    public partial class HalamanWelcome : Form
    {
        public HalamanWelcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnLihatBuku.Click += BtnLihatBuku_Click;
        }

        private void BtnLihatBuku_Click(object? sender, EventArgs e)
        {
            this.Hide();
            DaftarBuku daftarbuku = new DaftarBuku();

            if (daftarbuku.ShowDialog() == DialogResult.OK)
            {

            }

            this.Show();
        }

        private void btnDaftarAnggota_Click(object sender, EventArgs e)
        {
            using (DaftarAnggota frmdataanggota = new DaftarAnggota())
            {
                if (frmdataanggota.ShowDialog() == DialogResult.OK)
                {
                    Anggota anggota = frmdataanggota.GetAnggota();
                }
            }
        }
    }
}

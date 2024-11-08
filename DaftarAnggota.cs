using _1029_Novia_UTSPBO.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1029_Novia_UTSPBO
{
    public partial class DaftarAnggota : Form
    {
        public DaftarAnggota()
        {
            InitializeComponent();
        }

        public Anggota GetAnggota()
        {
            Anggota anggota = new Anggota();
            anggota.email = emailbox.Text;
            anggota.password = pwbox.Text;
            anggota.nama = namabox.Text;
            anggota.asal = asalbox.Text;
            anggota.Ttl = DateOnly.Parse(ttlbox.Value.ToShortDateString());
            return anggota;
        }

        private void btnDaftarAnggota_Click(object sender, EventArgs e)
        {
            btnDaftarAnggota.Click += BtnDaftarAnggota_Click;
        }

        private void BtnDaftarAnggota_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

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
    public partial class DataAnggota : Form
    {
        List<Anggota> listanggota = new List<Anggota>();
        public DataAnggota()
        {
            InitializeComponent();
            Anggota anggota = new Anggota();
            anggota.email = "novia@gmail.com";
            anggota.password = "22222";
            anggota.nama = "novia";
            anggota.asal = " lumajang";
            anggota.Ttl = new DateOnly(2003, 11, 24);

            dataGridView1.DataSource = listanggota;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

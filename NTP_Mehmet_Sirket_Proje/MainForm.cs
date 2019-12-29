using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_Mehmet_Sirket_Proje
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            

        }

        private void SatisBtn_Click(object sender, EventArgs e)
        {
            Satis_Form frm = new Satis_Form();
            frm.Show();

        }

        private void UrunIslembtn_Click(object sender, EventArgs e)
        {
            Urunler_Form frm = new Urunler_Form();
            frm.Show();
        }

        private void Musteribtn_Click(object sender, EventArgs e)
        {
            Musteri_Form frm = new Musteri_Form();
            frm.Show();
        }

        private void YapilanSatisbtn_Click(object sender, EventArgs e)
        {
            Yapilan_Satislar_Form frm = new Yapilan_Satislar_Form();
            frm.Show();
        }

        private void Yoneticibtn_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel_Form frm =new Personel_Form();
            frm.Show();
        }
    }
}

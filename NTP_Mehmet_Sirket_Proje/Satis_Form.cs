using Sirket.BLL;
using Sirket.MODEL;
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
    public partial class Satis_Form : Form
    {
        public Satis_Form()
        {
            InitializeComponent();
            dgvUrunTablo.AutoGenerateColumns = false;
            dgvMusteriTablo.AutoGenerateColumns = false;
        }
        
        

        private void satisButton_Click(object sender, EventArgs e)
        {
            SatisBL stbl = new SatisBL();


            Satis satis = new Satis();
           // satis.Satis_kod=t
        }
        // DataTable urunler_tablo,musteri_tablo;
        DataTable dt;
          

        private void Satis_Form_Load(object sender, EventArgs e)
        { 
            txtSatisTarih.Text = DateTime.Now.ToString();
            
            UrunBL urunGoster = new UrunBL(); //ürünleri listele
            dt = urunGoster.Urun_Tablo();
            dgvUrunTablo.DataSource = dt;

            MusteriBL musteriGoster = new MusteriBL();//müşteri listele
            dt = musteriGoster.Musteri_Tablo();
            dgvMusteriTablo.DataSource = dt;

            
        }

        private void button1_Click(object sender, EventArgs e) //yeni müşteri ekle butonu
        {
            Musteri_Form frm = new Musteri_Form();
            frm.Show();
            
            
        }

        private void dgvMusteriTablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMusteriKod.Text = dgvMusteriTablo.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvUrunTablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           txtSatisUrunKod.Text= dgvUrunTablo.CurrentRow.Cells[0].Value.ToString();
        }

        private void TabloYenilebtn_Click(object sender, EventArgs e)
        {
            dgvMusteriTablo.Refresh(); //çalışmıyor
            dgvMusteriTablo.Update();
        }

      

        

       

        private void pnlYeniMusteri_MouseHover(object sender, EventArgs e)
        {
            grpboxSatis.Width = 310;
            lblMusteriInfo.Text = "mstr yoksa";
            pnlmusteriButon.Visible = true;
                
        }

        private void pnlYeniMusteri_MouseLeave(object sender, EventArgs e)
        {
            grpboxSatis.Width = 229;
            pnlmusteriButon.Visible = false;
        }
    }
}

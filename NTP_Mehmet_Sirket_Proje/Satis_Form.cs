using Sirket.BLL;
using Sirket.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            dgvPersonelTablo.AutoGenerateColumns = false;
        }



        private void satisButton_Click(object sender, EventArgs e)
        {
            SatisBL stbl = new SatisBL();


           

                Satis satis= new Satis();
                satis.Satis_kod = txtSatisKod.Text;
                satis.Personel_id = int.Parse(txtPersonelId.Text);
                satis.Musteri_id = int.Parse(txtMusteriKod.Text);
                satis.Urun_id= int.Parse(txtSatisUrunKod.Text);
                satis.Tarih = DateTime.Now.ToString("d MMM yyyy");
                satis.Satilan_adet = int.Parse(txtSatisAdet.Text);
                satis.Fiyat = int.Parse(txtSatisFiyat.Text);

                if (stbl.Satis_Ekle(satis))
                {

                    MessageBox.Show("1 Adet Satış Yapıldı");


                }
                else
                {
                    MessageBox.Show("Bir Hata Oluştu");

                }




        }
       
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

            PersonelBL personelGoster = new PersonelBL();//personel listele
            dt = personelGoster.Personel_ad_goster();
            dgvPersonelTablo.DataSource = dt;


        }

        private void button1_Click(object sender, EventArgs e) //yeni müşteri ekle butonu
        {
            Musteri_Form frm = new Musteri_Form();
            frm.Show();


        }

        private void dgvMusteriTablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMusteriKod.Text = dgvMusteriTablo.CurrentRow.Cells[0].Value.ToString(); //aldığı değer id aslında
        }

        private void dgvUrunTablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSatisUrunKod.Text = dgvUrunTablo.CurrentRow.Cells[0].Value.ToString();
        }
        private void dgvPersonelTablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonelId.Text = dgvPersonelTablo.CurrentRow.Cells[0].Value.ToString();
        }
        private void TabloYenilebtn_Click(object sender, EventArgs e)
        {
            MusteriBL musteriGoster = new MusteriBL();
            dt = musteriGoster.Musteri_Tablo();
            dgvMusteriTablo.DataSource = dt;
        }







        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

           
        }
    }
}

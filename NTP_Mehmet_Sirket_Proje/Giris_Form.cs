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
    public partial class Giris_Form : Form
    {
        public Giris_Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
        
        private void GirisButton_Click(object sender, EventArgs e)
        {
            GirisBL girisbl = new GirisBL();
           
            if (girisbl.Giris_Control(idTxt.Text, sifreTxt.Text))
            {
                MainForm frm = new MainForm();
                frm.Show();

                this.Hide(); //yeni form açılınca bu form kapanır
            }
             else
           {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı");
              
            }
        }

        private void Giris_Form_Load(object sender, EventArgs e)
        {
        
            

        }

        private void Cikis_Button_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}

using Sirket.BLL;
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
    public partial class Yapilan_Satislar_Form : Form
    {
        public Yapilan_Satislar_Form()
        {
            InitializeComponent();
           
            dgvSatislar.AutoGenerateColumns = false;
        }
        DataTable dt;
        private void Yapilan_Satislar_Form_Load(object sender, EventArgs e)
        {
            SatislarBL satislari_göster = new SatislarBL();
            dt = satislari_göster.Satislar_Tablosu();
            dgvSatislar.DataSource = dt;
            satislari_göster.Dispose();
        }
    }
}

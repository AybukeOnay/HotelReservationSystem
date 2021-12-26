using OtelRezervasyonSistemi.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyonSistemi.Formlar.Personel
{
    public partial class FrmPersonelListesi : Form
    {
        public FrmPersonelListesi()
        {
            InitializeComponent();
        }

        DbOtelRezervasyonSistemiEntities db = new DbOtelRezervasyonSistemiEntities();
        private void FrmPersonelListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblPersonels
                                       select new
                                       {
                                           x.PersonelID,
                                           x.PersonelAdSoyad,
                                           x.PersonelTC,
                                           x.PersonelTelefon,
                                           x.PersonelMail,
                                           x.TblDepartman.DepartmanAd,
                                           x.TblGorev.GorevAd,
                                           x.TblDurum.DurumAd
                                       }).ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmPersonelKarti frKart = new FrmPersonelKarti();
            frKart.id = int.Parse(gridView1.GetFocusedRowCellValue("PersonelID").ToString());
            frKart.Show();
        }
    }
}

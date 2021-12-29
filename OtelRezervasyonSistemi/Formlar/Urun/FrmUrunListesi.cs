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

namespace OtelRezervasyonSistemi.Formlar.Urun
{
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }
        
        DbOtelRezervasyonSistemiEntities db = new DbOtelRezervasyonSistemiEntities();

        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            gridControlUrun.DataSource = (from x in db.TblUruns
                                          select new
                                          {
                                              x.UrunID,
                                              x.TblUrunGrup.UrunGrupAd,
                                              x.UrunAd,
                                              x.UrunFiyat,
                                              x.UrunBirim,
                                              x.UrunToplam
                                          }).ToList();
        }
    }
}

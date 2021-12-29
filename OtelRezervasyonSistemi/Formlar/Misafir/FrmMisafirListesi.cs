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

namespace OtelRezervasyonSistemi.Formlar.Misafir
{
    public partial class FrmMisafirListesi : Form
    {
        public FrmMisafirListesi()
        {
            InitializeComponent();
        }
        DbOtelRezervasyonSistemiEntities db = new DbOtelRezervasyonSistemiEntities();

        private void FrmMisafirListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblMusteris
                                       select new
                                       {
                                           x.MusteriID,
                                           x.MusteriAdSoyad,
                                           x.MusteriTC,
                                           x.MusteriTelefon,
                                           x.MusteriMail,
                                           x.MusteriSehir,
                                           x.MusteriIlce
                                       }).ToList();
        }

        private void gridView1_DoubleClick_1(object sender, EventArgs e)
        {
            FrmMisafirKarti fr = new FrmMisafirKarti();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("MusteriID").ToString());
            fr.Show();
        }
    }
}

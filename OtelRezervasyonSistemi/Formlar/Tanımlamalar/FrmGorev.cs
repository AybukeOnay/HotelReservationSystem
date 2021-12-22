using DevExpress.XtraEditors;
using OtelRezervasyonSistemi.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyonSistemi.Formlar.Tanımlamalar
{
    public partial class FrmGorev : Form
    {
        public FrmGorev()
        {
            InitializeComponent();
        }
        DbOtelRezervasyonSistemiEntities db = new DbOtelRezervasyonSistemiEntities();
        private void FrmGorev_Load(object sender, EventArgs e)
        {
            db.TblGorevs.Load();
            bindingSource1.DataSource = db.TblGorevs.Local;
            repositoryItemLookUpEditDurum.DataSource = (from x in db.TblDurums
                                                        select new
                                                        {
                                                            x.DurumID,
                                                            x.DurumAd
                                                        }).ToList();
            
            repositoryItemLookUpEditDepartman.DataSource= (from x in db.TblDepartmen
                                                           select new
                                                           {
                                                               x.DepartmanID,
                                                               x.DepartmanAd
                                                           }).ToList();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Bilgiler kaydedilirken hata oluştu", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

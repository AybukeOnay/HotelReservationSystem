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
using DevExpress.XtraEditors;
using OtelRezervasyonSistemi.Entity;

namespace OtelRezervasyonSistemi.Formlar.Tanımlamalar
{
    public partial class FrmDurum : Form
    {
        public FrmDurum()
        {
            InitializeComponent();
        }
        

        DbOtelRezervasyonSistemiEntities db = new DbOtelRezervasyonSistemiEntities();

        private void FrmDurum_Load(object sender, EventArgs e)
        {
            db.TblDurums.Load();
            bindingSource1.DataSource = db.TblDurums.Local;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Lütfen değerleri kontrol edip yeniden giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void vazgeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void durumuSilToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }
    }
}

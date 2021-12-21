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
    public partial class FrmBirim : Form
    {
        public FrmBirim()
        {
            InitializeComponent();
        }
        DbOtelRezervasyonSistemiEntities db = new DbOtelRezervasyonSistemiEntities();

        private void FrmBirim_Load(object sender, EventArgs e)
        {
            db.TblBirims.Load();
            bindingSource1.DataSource = db.TblBirims.Local;
        }
    }
}

using DevExpress.XtraEditors;
using OtelRezervasyonSistemi.Entity;
using OtelRezervasyonSistemi.Repositories;
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
    public partial class FrmPersonelKarti : Form
    {

        public FrmPersonelKarti()
        {
            InitializeComponent();
        }
        DbOtelRezervasyonSistemiEntities db = new DbOtelRezervasyonSistemiEntities();
        Repository<TblPersonel> repo = new Repository<TblPersonel>();
        public int id;

        private void FrmPersonelKarti_Load(object sender, EventArgs e)
        {
            this.Text = id.ToString();

            lookUpEditDepartman.Properties.DataSource = (from x in db.TblDepartmen
                                                         select new
                                                         {
                                                             x.DepartmanID,
                                                             x.DepartmanAd
                                                         }).ToList();

            lookUpEditGorev.Properties.DataSource = (from x in db.TblGorevs
                                                     select new
                                                     {
                                                         x.GorevID,
                                                         x.GorevAd
                                                     }).ToList(); ;
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            TblPersonel personel = new TblPersonel();
            personel.PersonelAdSoyad = txt_AdSoyad.Text;
            personel.PersonelTC = txt_TcNo.Text;
            personel.PersonelAdres = memoEditAdres.Text;
            personel.PersonelTelefon = txt_Telefon.Text;
            personel.PersonelMail = txt_Mail.Text;
            personel.PersonelIseGirisTarihi = DateTime.Parse(date_Giris.Text);
            //t.PersonelIstenCikisTarihi = DateTime.Parse(date_Cikis.Text);
            personel.PersonelDepartman = int.Parse(lookUpEditDepartman.EditValue.ToString());
            personel.PersonelGorev = int.Parse(lookUpEditGorev.EditValue.ToString());
            personel.PersonelAciklama = memoEditAciklama.Text;
            personel.PersonelKimlikOn = pictureKimlikOn.GetLoadedImageLocation();
            personel.PersonelKimlikArka = pictureKimlikArka.GetLoadedImageLocation();
            personel.PersonelDurum = 1;
            repo.TAdd(personel);
            XtraMessageBox.Show("Personel başarılı bir şekilde sisteme kaydedildi","Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            var deger = repo.TFind(x => x.PersonelID == id);
            deger.PersonelAdSoyad = txt_AdSoyad.Text;
            deger.PersonelTC = txt_TcNo.Text;
            deger.PersonelAdres = memoEditAdres.Text;
            deger.PersonelTelefon = txt_Telefon.Text;
            deger.PersonelMail = txt_Mail.Text;
            deger.PersonelIseGirisTarihi = DateTime.Parse(date_Giris.Text);           
            deger.PersonelDepartman = int.Parse(lookUpEditDepartman.EditValue.ToString());
            deger.PersonelGorev = int.Parse(lookUpEditGorev.EditValue.ToString());
            deger.PersonelAciklama = memoEditAciklama.Text;
            deger.PersonelKimlikOn = pictureKimlikOn.GetLoadedImageLocation();
            deger.PersonelKimlikArka = pictureKimlikArka.GetLoadedImageLocation();
            repo.TUpdate(deger);
            XtraMessageBox.Show("Personel başarılı bir şekilde güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

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

namespace OtelRezervasyonSistemi.Formlar.Misafir
{
    public partial class FrmMisafirKarti : Form
    {
        public FrmMisafirKarti()
        {
            InitializeComponent();
        }
       
        
        public int id;
        string resim1, resim2;
        DbOtelRezervasyonSistemiEntities db = new DbOtelRezervasyonSistemiEntities();
        Repository<TblMusteri> repo = new Repository<TblMusteri>();
        TblMusteri musteri = new TblMusteri();

        private void FrmMisafirKarti_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                var misafir = repo.TFind(x => x.MusteriID == id);
                txt_AdSoyad.Text = misafir.MusteriAdSoyad;
                txt_TcNo.Text = misafir.MusteriTC;
                txt_Telefon.Text = misafir.MusteriTelefon;
                txt_Mail.Text = misafir.MusteriMail;
                memoEditAciklama.Text = misafir.MusteriAciklama;
                memoEditAdres.Text = misafir.MusteriAdres;
                pictureKimlikOn.Image = Image.FromFile(misafir.MusteriKimlikFoto1);
                pictureKimlikArka.Image = Image.FromFile(misafir.MusteriKimlikFoto2);
                resim1 = misafir.MusteriKimlikFoto1;
                resim2 = misafir.MusteriKimlikFoto2;
                lookUpEditSehir.EditValue = misafir.MusteriSehir;
                lookUpEditUlke.EditValue = misafir.MusteriUlke;
                lookUpEditIlce.EditValue = misafir.MusteriIlce;
                
            }

            lookUpEditUlke.Properties.DataSource = (from x in db.TblUlkes
                                                    select new
                                                    {
                                                        x.UlkeID,
                                                        x.UlkeAd
                                                    }).ToList();

            lookUpEditSehir.Properties.DataSource = (from x in db.TblSehirlers
                                                     select new
                                                     {
                                                         Id = x.id,
                                                         Şehir = x.sehir
                                                     }).ToList();
        }

        private void lookUpEditSehir_EditValueChanged(object sender, EventArgs e)
        {
            int secilen;
            secilen = int.Parse(lookUpEditSehir.EditValue.ToString());
            lookUpEditIlce.Properties.DataSource = (from x in db.TblIlcelers
                                                    select new
                                                    {
                                                        Id = x.id,
                                                        Ilce = x.ilce,
                                                        Sehir = x.sehir
                                                    }).Where(y => y.Sehir == secilen).ToList();
        }
       

        private void pictureKimlikOn_EditValueChanged(object sender, EventArgs e)
        {
            resim1 = pictureKimlikOn.GetLoadedImageLocation().ToString();
        }

        private void pictureKimlikArka_EditValueChanged(object sender, EventArgs e)
        {
            resim2 = pictureKimlikArka.GetLoadedImageLocation().ToString();
        }

        private void btn_Vazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            var deger = repo.TFind(x => x.MusteriID == id);
            deger.MusteriAdSoyad = txt_AdSoyad.Text;
            deger.MusteriTC = txt_TcNo.Text;
            deger.MusteriAdres = memoEditAdres.Text;
            deger.MusteriTelefon = txt_Telefon.Text;
            deger.MusteriMail = txt_Mail.Text;
            deger.MusteriUlke = int.Parse(lookUpEditUlke.EditValue.ToString());
            deger.MusteriSehir = int.Parse(lookUpEditSehir.EditValue.ToString());
            deger.MusteriIlce = int.Parse(lookUpEditIlce.EditValue.ToString());
            deger.MusteriAciklama = memoEditAciklama.Text;
            deger.MusteriKimlikFoto1 = resim1;
            deger.MusteriKimlikFoto2 = resim2;
            deger.MusteriDurum = 1;
            repo.TUpdate(deger);
            XtraMessageBox.Show("Misafir başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            
            musteri.MusteriAdSoyad = txt_AdSoyad.Text;
            musteri.MusteriTC = txt_TcNo.Text;
            musteri.MusteriTelefon = txt_Telefon.Text;
            musteri.MusteriMail = txt_Mail.Text;
            musteri.MusteriAdres = memoEditAdres.Text;
            musteri.MusteriAciklama = memoEditAciklama.Text;
            musteri.MusteriSehir = int.Parse(lookUpEditSehir.EditValue.ToString());
            musteri.MusteriIlce = int.Parse(lookUpEditIlce.EditValue.ToString());
            musteri.MusteriUlke =int.Parse(lookUpEditUlke.EditValue.ToString());
            musteri.MusteriKimlikFoto1 = resim1;
            musteri.MusteriKimlikFoto2 = resim2;
            repo.TAdd(musteri);
            XtraMessageBox.Show("Misafir sisteme başarılı bir şekilde kaydedildi","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}

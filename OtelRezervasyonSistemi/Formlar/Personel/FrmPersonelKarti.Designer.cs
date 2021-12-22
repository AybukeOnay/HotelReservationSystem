
namespace OtelRezervasyonSistemi.Formlar.Personel
{
    partial class FrmPersonelKarti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelKarti));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txt_AdSoyad = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEditDepartman = new DevExpress.XtraEditors.LookUpEdit();
            this.lbl_AdSoyad = new System.Windows.Forms.Label();
            this.grpCntrl_PersonelKarti = new DevExpress.XtraEditors.GroupControl();
            this.lbl_TcNo = new System.Windows.Forms.Label();
            this.txt_TcNo = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.txt_Sifre = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.lbl_Departman = new System.Windows.Forms.Label();
            this.pictureEdit5 = new DevExpress.XtraEditors.PictureEdit();
            this.lbl_Gorev = new System.Windows.Forms.Label();
            this.pictureEdit6 = new DevExpress.XtraEditors.PictureEdit();
            this.lbl_GirisTarihi = new System.Windows.Forms.Label();
            this.txt_GirisTarihi = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit7 = new DevExpress.XtraEditors.PictureEdit();
            this.lbl_CikisTarihi = new System.Windows.Forms.Label();
            this.txt_CikisTarihi = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEditGorev = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AdSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDepartman.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCntrl_PersonelKarti)).BeginInit();
            this.grpCntrl_PersonelKarti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TcNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GirisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CikisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditGorev.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(5, 7);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(20, 20);
            this.pictureEdit1.TabIndex = 0;
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(90, 11);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(479, 20);
            this.txt_AdSoyad.TabIndex = 1;
            // 
            // lookUpEditDepartman
            // 
            this.lookUpEditDepartman.Location = new System.Drawing.Point(90, 63);
            this.lookUpEditDepartman.Name = "lookUpEditDepartman";
            this.lookUpEditDepartman.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDepartman.Size = new System.Drawing.Size(194, 20);
            this.lookUpEditDepartman.TabIndex = 2;
            // 
            // lbl_AdSoyad
            // 
            this.lbl_AdSoyad.AutoSize = true;
            this.lbl_AdSoyad.Location = new System.Drawing.Point(31, 14);
            this.lbl_AdSoyad.Name = "lbl_AdSoyad";
            this.lbl_AdSoyad.Size = new System.Drawing.Size(53, 13);
            this.lbl_AdSoyad.TabIndex = 3;
            this.lbl_AdSoyad.Text = "Ad Soyad";
            // 
            // grpCntrl_PersonelKarti
            // 
            this.grpCntrl_PersonelKarti.Controls.Add(this.lookUpEditGorev);
            this.grpCntrl_PersonelKarti.Controls.Add(this.pictureEdit7);
            this.grpCntrl_PersonelKarti.Controls.Add(this.lookUpEditDepartman);
            this.grpCntrl_PersonelKarti.Controls.Add(this.lbl_CikisTarihi);
            this.grpCntrl_PersonelKarti.Controls.Add(this.txt_CikisTarihi);
            this.grpCntrl_PersonelKarti.Controls.Add(this.pictureEdit6);
            this.grpCntrl_PersonelKarti.Controls.Add(this.lbl_GirisTarihi);
            this.grpCntrl_PersonelKarti.Controls.Add(this.txt_GirisTarihi);
            this.grpCntrl_PersonelKarti.Controls.Add(this.pictureEdit5);
            this.grpCntrl_PersonelKarti.Controls.Add(this.lbl_Gorev);
            this.grpCntrl_PersonelKarti.Controls.Add(this.pictureEdit4);
            this.grpCntrl_PersonelKarti.Controls.Add(this.lbl_Departman);
            this.grpCntrl_PersonelKarti.Controls.Add(this.pictureEdit2);
            this.grpCntrl_PersonelKarti.Controls.Add(this.lbl_Sifre);
            this.grpCntrl_PersonelKarti.Controls.Add(this.txt_Sifre);
            this.grpCntrl_PersonelKarti.Controls.Add(this.pictureEdit3);
            this.grpCntrl_PersonelKarti.Controls.Add(this.lbl_TcNo);
            this.grpCntrl_PersonelKarti.Controls.Add(this.txt_TcNo);
            this.grpCntrl_PersonelKarti.Controls.Add(this.pictureEdit1);
            this.grpCntrl_PersonelKarti.Controls.Add(this.lbl_AdSoyad);
            this.grpCntrl_PersonelKarti.Controls.Add(this.txt_AdSoyad);
            this.grpCntrl_PersonelKarti.Location = new System.Drawing.Point(5, 5);
            this.grpCntrl_PersonelKarti.Name = "grpCntrl_PersonelKarti";
            this.grpCntrl_PersonelKarti.ShowCaption = false;
            this.grpCntrl_PersonelKarti.Size = new System.Drawing.Size(574, 178);
            this.grpCntrl_PersonelKarti.TabIndex = 4;
            this.grpCntrl_PersonelKarti.Text = "groupControl1";
            // 
            // lbl_TcNo
            // 
            this.lbl_TcNo.AutoSize = true;
            this.lbl_TcNo.Location = new System.Drawing.Point(31, 40);
            this.lbl_TcNo.Name = "lbl_TcNo";
            this.lbl_TcNo.Size = new System.Drawing.Size(36, 13);
            this.lbl_TcNo.TabIndex = 6;
            this.lbl_TcNo.Text = "TC No";
            // 
            // txt_TcNo
            // 
            this.txt_TcNo.Location = new System.Drawing.Point(90, 37);
            this.txt_TcNo.Name = "txt_TcNo";
            this.txt_TcNo.Size = new System.Drawing.Size(194, 20);
            this.txt_TcNo.TabIndex = 5;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(5, 33);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(20, 20);
            this.pictureEdit3.TabIndex = 7;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(290, 40);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(20, 20);
            this.pictureEdit2.TabIndex = 10;
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Location = new System.Drawing.Point(316, 44);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(29, 13);
            this.lbl_Sifre.TabIndex = 9;
            this.lbl_Sifre.Text = "Şifre";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(375, 40);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(182, 20);
            this.txt_Sifre.TabIndex = 8;
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(5, 59);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit4.Size = new System.Drawing.Size(20, 20);
            this.pictureEdit4.TabIndex = 13;
            // 
            // lbl_Departman
            // 
            this.lbl_Departman.AutoSize = true;
            this.lbl_Departman.Location = new System.Drawing.Point(31, 66);
            this.lbl_Departman.Name = "lbl_Departman";
            this.lbl_Departman.Size = new System.Drawing.Size(60, 13);
            this.lbl_Departman.TabIndex = 12;
            this.lbl_Departman.Text = "Departman";
            // 
            // pictureEdit5
            // 
            this.pictureEdit5.EditValue = ((object)(resources.GetObject("pictureEdit5.EditValue")));
            this.pictureEdit5.Location = new System.Drawing.Point(5, 85);
            this.pictureEdit5.Name = "pictureEdit5";
            this.pictureEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit5.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit5.Size = new System.Drawing.Size(20, 20);
            this.pictureEdit5.TabIndex = 16;
            // 
            // lbl_Gorev
            // 
            this.lbl_Gorev.AutoSize = true;
            this.lbl_Gorev.Location = new System.Drawing.Point(31, 92);
            this.lbl_Gorev.Name = "lbl_Gorev";
            this.lbl_Gorev.Size = new System.Drawing.Size(36, 13);
            this.lbl_Gorev.TabIndex = 15;
            this.lbl_Gorev.Text = "Görev";
            // 
            // pictureEdit6
            // 
            this.pictureEdit6.EditValue = ((object)(resources.GetObject("pictureEdit6.EditValue")));
            this.pictureEdit6.Location = new System.Drawing.Point(290, 63);
            this.pictureEdit6.Name = "pictureEdit6";
            this.pictureEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit6.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit6.Size = new System.Drawing.Size(20, 20);
            this.pictureEdit6.TabIndex = 19;
            // 
            // lbl_GirisTarihi
            // 
            this.lbl_GirisTarihi.AutoSize = true;
            this.lbl_GirisTarihi.Location = new System.Drawing.Point(316, 70);
            this.lbl_GirisTarihi.Name = "lbl_GirisTarihi";
            this.lbl_GirisTarihi.Size = new System.Drawing.Size(56, 13);
            this.lbl_GirisTarihi.TabIndex = 18;
            this.lbl_GirisTarihi.Text = "Giriş Tarihi";
            // 
            // txt_GirisTarihi
            // 
            this.txt_GirisTarihi.Location = new System.Drawing.Point(375, 63);
            this.txt_GirisTarihi.Name = "txt_GirisTarihi";
            this.txt_GirisTarihi.Size = new System.Drawing.Size(185, 20);
            this.txt_GirisTarihi.TabIndex = 17;
            // 
            // pictureEdit7
            // 
            this.pictureEdit7.EditValue = ((object)(resources.GetObject("pictureEdit7.EditValue")));
            this.pictureEdit7.Location = new System.Drawing.Point(292, 89);
            this.pictureEdit7.Name = "pictureEdit7";
            this.pictureEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit7.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit7.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit7.Size = new System.Drawing.Size(20, 20);
            this.pictureEdit7.TabIndex = 22;
            // 
            // lbl_CikisTarihi
            // 
            this.lbl_CikisTarihi.AutoSize = true;
            this.lbl_CikisTarihi.Location = new System.Drawing.Point(318, 96);
            this.lbl_CikisTarihi.Name = "lbl_CikisTarihi";
            this.lbl_CikisTarihi.Size = new System.Drawing.Size(57, 13);
            this.lbl_CikisTarihi.TabIndex = 21;
            this.lbl_CikisTarihi.Text = "Çıkış Tarihi";
            // 
            // txt_CikisTarihi
            // 
            this.txt_CikisTarihi.Location = new System.Drawing.Point(375, 89);
            this.txt_CikisTarihi.Name = "txt_CikisTarihi";
            this.txt_CikisTarihi.Size = new System.Drawing.Size(185, 20);
            this.txt_CikisTarihi.TabIndex = 20;
            // 
            // lookUpEditGorev
            // 
            this.lookUpEditGorev.Location = new System.Drawing.Point(90, 89);
            this.lookUpEditGorev.Name = "lookUpEditGorev";
            this.lookUpEditGorev.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditGorev.Size = new System.Drawing.Size(194, 20);
            this.lookUpEditGorev.TabIndex = 23;
            // 
            // FrmPersonelKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 461);
            this.Controls.Add(this.grpCntrl_PersonelKarti);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPersonelKarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Kartı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AdSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDepartman.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCntrl_PersonelKarti)).EndInit();
            this.grpCntrl_PersonelKarti.ResumeLayout(false);
            this.grpCntrl_PersonelKarti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TcNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GirisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CikisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditGorev.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit txt_AdSoyad;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditDepartman;
        private System.Windows.Forms.Label lbl_AdSoyad;
        private DevExpress.XtraEditors.GroupControl grpCntrl_PersonelKarti;
        private System.Windows.Forms.Label lbl_TcNo;
        private DevExpress.XtraEditors.TextEdit txt_TcNo;
        private DevExpress.XtraEditors.PictureEdit pictureEdit7;
        private System.Windows.Forms.Label lbl_CikisTarihi;
        private DevExpress.XtraEditors.TextEdit txt_CikisTarihi;
        private DevExpress.XtraEditors.PictureEdit pictureEdit6;
        private System.Windows.Forms.Label lbl_GirisTarihi;
        private DevExpress.XtraEditors.TextEdit txt_GirisTarihi;
        private DevExpress.XtraEditors.PictureEdit pictureEdit5;
        private System.Windows.Forms.Label lbl_Gorev;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private System.Windows.Forms.Label lbl_Departman;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private System.Windows.Forms.Label lbl_Sifre;
        private DevExpress.XtraEditors.TextEdit txt_Sifre;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditGorev;
    }
}

namespace OtelRezervasyonSistemi.Formlar.Tanımlamalar
{
    partial class FrmOda
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
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grd_OdaNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_OdaKat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_OdaKapasite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_OdaTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_Durum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditDurum = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEditDepartman = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ctext_Oda = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditDurum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditDepartman)).BeginInit();
            this.ctext_Oda.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditDurum,
            this.repositoryItemLookUpEditDepartman});
            this.gridControl1.Size = new System.Drawing.Size(634, 491);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grd_OdaNo,
            this.grd_OdaKat,
            this.grd_OdaKapasite,
            this.grd_OdaTelefon,
            this.grd_Durum});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // grd_OdaNo
            // 
            this.grd_OdaNo.Caption = "Oda No";
            this.grd_OdaNo.FieldName = "OdaNo";
            this.grd_OdaNo.Name = "grd_OdaNo";
            this.grd_OdaNo.Visible = true;
            this.grd_OdaNo.VisibleIndex = 0;
            // 
            // grd_OdaKat
            // 
            this.grd_OdaKat.Caption = "Kat";
            this.grd_OdaKat.FieldName = "OdaKat";
            this.grd_OdaKat.Name = "grd_OdaKat";
            this.grd_OdaKat.Visible = true;
            this.grd_OdaKat.VisibleIndex = 1;
            // 
            // grd_OdaKapasite
            // 
            this.grd_OdaKapasite.Caption = "Kapasite";
            this.grd_OdaKapasite.FieldName = "OdaKapasite";
            this.grd_OdaKapasite.Name = "grd_OdaKapasite";
            this.grd_OdaKapasite.Visible = true;
            this.grd_OdaKapasite.VisibleIndex = 2;
            // 
            // grd_OdaTelefon
            // 
            this.grd_OdaTelefon.Caption = "Telefon";
            this.grd_OdaTelefon.FieldName = "OdaTelefon";
            this.grd_OdaTelefon.Name = "grd_OdaTelefon";
            this.grd_OdaTelefon.Visible = true;
            this.grd_OdaTelefon.VisibleIndex = 3;
            // 
            // grd_Durum
            // 
            this.grd_Durum.Caption = "Durum";
            this.grd_Durum.ColumnEdit = this.repositoryItemLookUpEditDurum;
            this.grd_Durum.FieldName = "OdaDurum";
            this.grd_Durum.Name = "grd_Durum";
            this.grd_Durum.Visible = true;
            this.grd_Durum.VisibleIndex = 4;
            // 
            // repositoryItemLookUpEditDurum
            // 
            this.repositoryItemLookUpEditDurum.AutoHeight = false;
            this.repositoryItemLookUpEditDurum.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditDurum.DisplayMember = "DurumAd";
            this.repositoryItemLookUpEditDurum.Name = "repositoryItemLookUpEditDurum";
            this.repositoryItemLookUpEditDurum.NullText = "Durumu Seçiniz";
            this.repositoryItemLookUpEditDurum.ValueMember = "DurumID";
            // 
            // repositoryItemLookUpEditDepartman
            // 
            this.repositoryItemLookUpEditDepartman.AutoHeight = false;
            this.repositoryItemLookUpEditDepartman.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditDepartman.DisplayMember = "DepartmanAd";
            this.repositoryItemLookUpEditDepartman.Name = "repositoryItemLookUpEditDepartman";
            this.repositoryItemLookUpEditDepartman.NullText = "Departman Seçiniz";
            this.repositoryItemLookUpEditDepartman.ValueMember = "DepartmanID";
            // 
            // ctext_Oda
            // 
            this.ctext_Oda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.ctext_Oda.Name = "ctext_Oda";
            this.ctext_Oda.Size = new System.Drawing.Size(181, 48);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // FrmOda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 491);
            this.Controls.Add(this.gridControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oda Tanımları";
            this.Load += new System.EventHandler(this.FrmOda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditDurum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditDepartman)).EndInit();
            this.ctext_Oda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn grd_OdaNo;
        private DevExpress.XtraGrid.Columns.GridColumn grd_OdaKat;
        private DevExpress.XtraGrid.Columns.GridColumn grd_OdaKapasite;
        private DevExpress.XtraGrid.Columns.GridColumn grd_OdaTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn grd_Durum;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditDurum;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditDepartman;
        private System.Windows.Forms.ContextMenuStrip ctext_Oda;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}
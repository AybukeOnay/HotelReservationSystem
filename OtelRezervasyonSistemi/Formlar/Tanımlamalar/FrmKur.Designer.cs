
namespace OtelRezervasyonSistemi.Formlar.Tanımlamalar
{
    partial class FrmKur
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grd_KurAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_KurSembol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_KurDeger = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_Tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_Durum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditDurum = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEditDepartman = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contextSil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditDurum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditDepartman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.contextSil.SuspendLayout();
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
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grd_KurAd,
            this.grd_KurSembol,
            this.grd_KurDeger,
            this.grd_Tarih,
            this.grd_Durum});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // grd_KurAd
            // 
            this.grd_KurAd.Caption = "Kur Adı";
            this.grd_KurAd.FieldName = "KurAd";
            this.grd_KurAd.Name = "grd_KurAd";
            this.grd_KurAd.Visible = true;
            this.grd_KurAd.VisibleIndex = 0;
            // 
            // grd_KurSembol
            // 
            this.grd_KurSembol.Caption = "Kur Sembol";
            this.grd_KurSembol.FieldName = "KurSembol";
            this.grd_KurSembol.Name = "grd_KurSembol";
            this.grd_KurSembol.Visible = true;
            this.grd_KurSembol.VisibleIndex = 1;
            // 
            // grd_KurDeger
            // 
            this.grd_KurDeger.Caption = "Kur Değeri";
            this.grd_KurDeger.FieldName = "KurDeger";
            this.grd_KurDeger.Name = "grd_KurDeger";
            this.grd_KurDeger.Visible = true;
            this.grd_KurDeger.VisibleIndex = 2;
            // 
            // grd_Tarih
            // 
            this.grd_Tarih.Caption = "Kur Tarihi";
            this.grd_Tarih.FieldName = "KurTarih";
            this.grd_Tarih.Name = "grd_Tarih";
            this.grd_Tarih.Visible = true;
            this.grd_Tarih.VisibleIndex = 3;
            // 
            // grd_Durum
            // 
            this.grd_Durum.Caption = "Durum";
            this.grd_Durum.ColumnEdit = this.repositoryItemLookUpEditDurum;
            this.grd_Durum.FieldName = "KurDurum";
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
            // contextSil
            // 
            this.contextSil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextSil.Name = "contextSil";
            this.contextSil.Size = new System.Drawing.Size(181, 48);
            this.contextSil.Click += new System.EventHandler(this.contextSil_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // FrmKur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 491);
            this.ContextMenuStrip = this.contextSil;
            this.Controls.Add(this.gridControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kur Tanımları";
            this.Load += new System.EventHandler(this.FrmKur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditDurum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditDepartman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.contextSil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn grd_KurAd;
        private DevExpress.XtraGrid.Columns.GridColumn grd_KurSembol;
        private DevExpress.XtraGrid.Columns.GridColumn grd_KurDeger;
        private DevExpress.XtraGrid.Columns.GridColumn grd_Tarih;
        private DevExpress.XtraGrid.Columns.GridColumn grd_Durum;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditDurum;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditDepartman;
        private System.Windows.Forms.ContextMenuStrip contextSil;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}
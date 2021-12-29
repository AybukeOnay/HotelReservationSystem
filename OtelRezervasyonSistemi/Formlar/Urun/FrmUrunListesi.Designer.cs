
namespace OtelRezervasyonSistemi.Formlar.Urun
{
    partial class FrmUrunListesi
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
            this.gridControlUrun = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlUrun
            // 
            this.gridControlUrun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUrun.Location = new System.Drawing.Point(0, 0);
            this.gridControlUrun.MainView = this.gridView1;
            this.gridControlUrun.Name = "gridControlUrun";
            this.gridControlUrun.Size = new System.Drawing.Size(1184, 461);
            this.gridControlUrun.TabIndex = 2;
            this.gridControlUrun.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlUrun;
            this.gridView1.Name = "gridView1";
            // 
            // FrmUrunListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.gridControlUrun);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUrunListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listesi";
            this.Load += new System.EventHandler(this.FrmUrunListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlUrun;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
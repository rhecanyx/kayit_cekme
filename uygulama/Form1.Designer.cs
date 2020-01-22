namespace uygulama
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.grdGoster = new DevExpress.XtraGrid.GridControl();
            this.gvGoster = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.telefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGtr = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grdGoster);
            this.layoutControl1.Controls.Add(this.btnGtr);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(698, 568);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // grdGoster
            // 
            this.grdGoster.Location = new System.Drawing.Point(12, 38);
            this.grdGoster.MainView = this.gvGoster;
            this.grdGoster.Name = "grdGoster";
            this.grdGoster.Size = new System.Drawing.Size(674, 518);
            this.grdGoster.TabIndex = 7;
            this.grdGoster.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGoster});
            // 
            // gvGoster
            // 
            this.gvGoster.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.ad,
            this.soyad,
            this.telefon});
            this.gvGoster.GridControl = this.grdGoster;
            this.gvGoster.Name = "gvGoster";
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "Id";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // ad
            // 
            this.ad.Caption = "İsim";
            this.ad.FieldName = "ad";
            this.ad.Name = "ad";
            this.ad.Visible = true;
            this.ad.VisibleIndex = 1;
            // 
            // soyad
            // 
            this.soyad.Caption = "Soyisim";
            this.soyad.FieldName = "soyad";
            this.soyad.Name = "soyad";
            this.soyad.Visible = true;
            this.soyad.VisibleIndex = 2;
            // 
            // telefon
            // 
            this.telefon.Caption = "Telefon";
            this.telefon.FieldName = "telefon";
            this.telefon.Name = "telefon";
            this.telefon.Visible = true;
            this.telefon.VisibleIndex = 3;
            // 
            // btnGtr
            // 
            this.btnGtr.Location = new System.Drawing.Point(12, 12);
            this.btnGtr.Name = "btnGtr";
            this.btnGtr.Size = new System.Drawing.Size(674, 22);
            this.btnGtr.StyleController = this.layoutControl1;
            this.btnGtr.TabIndex = 5;
            this.btnGtr.Text = "Kayıtları Getir";
            this.btnGtr.Click += new System.EventHandler(this.btnGtr_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(698, 568);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnGtr;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(678, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdGoster;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(678, 522);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 568);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Form1.IconOptions.Image")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RHECANYX";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdGoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl grdGoster;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGoster;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.SimpleButton btnGtr;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn ad;
        private DevExpress.XtraGrid.Columns.GridColumn soyad;
        private DevExpress.XtraGrid.Columns.GridColumn telefon;
    }
}



namespace QLDSVTC_CSDLPT
{
    partial class frmMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonHoc));
            this.maMHLabel = new System.Windows.Forms.Label();
            this.tenMHLabel = new System.Windows.Forms.Label();
            this.soTIET_LTLabel = new System.Windows.Forms.Label();
            this.soTIET_THLabel = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.QLDSV_TC = new QLDSVTC_CSDLPT.QLDSV_TC();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.MONHOCTableAdapter = new QLDSVTC_CSDLPT.QLDSV_TCTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new QLDSVTC_CSDLPT.QLDSV_TCTableAdapters.TableAdapterManager();
            this.MonHocGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaMonHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTietLT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTietTH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.speSoTietTH = new DevExpress.XtraEditors.SpinEdit();
            this.speSoTietLT = new DevExpress.XtraEditors.SpinEdit();
            this.txbTenMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.txbMaMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bdsLopTinChi = new System.Windows.Forms.BindingSource(this.components);
            this.LOPTINCHITableAdapter = new QLDSVTC_CSDLPT.QLDSV_TCTableAdapters.LOPTINCHITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLDSV_TC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speSoTietTH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speSoTietLT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopTinChi)).BeginInit();
            this.SuspendLayout();
            // 
            // maMHLabel
            // 
            this.maMHLabel.AutoSize = true;
            this.maMHLabel.Location = new System.Drawing.Point(380, 78);
            this.maMHLabel.Name = "maMHLabel";
            this.maMHLabel.Size = new System.Drawing.Size(83, 17);
            this.maMHLabel.TabIndex = 0;
            this.maMHLabel.Text = "Mã Môn Học";
            // 
            // tenMHLabel
            // 
            this.tenMHLabel.AutoSize = true;
            this.tenMHLabel.Location = new System.Drawing.Point(380, 110);
            this.tenMHLabel.Name = "tenMHLabel";
            this.tenMHLabel.Size = new System.Drawing.Size(89, 17);
            this.tenMHLabel.TabIndex = 0;
            this.tenMHLabel.Text = "Tên Môn Học";
            // 
            // soTIET_LTLabel
            // 
            this.soTIET_LTLabel.AutoSize = true;
            this.soTIET_LTLabel.Location = new System.Drawing.Point(380, 146);
            this.soTIET_LTLabel.Name = "soTIET_LTLabel";
            this.soTIET_LTLabel.Size = new System.Drawing.Size(117, 17);
            this.soTIET_LTLabel.TabIndex = 0;
            this.soTIET_LTLabel.Text = "Số Tiết Lý Thuyết";
            // 
            // soTIET_THLabel
            // 
            this.soTIET_THLabel.AutoSize = true;
            this.soTIET_THLabel.Location = new System.Drawing.Point(380, 182);
            this.soTIET_THLabel.Name = "soTIET_THLabel";
            this.soTIET_THLabel.Size = new System.Drawing.Size(122, 17);
            this.soTIET_THLabel.TabIndex = 0;
            this.soTIET_THLabel.Text = "Số Tiết Thực Hành";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnPhucHoi,
            this.btnGhi,
            this.btnHuy,
            this.btnLamMoi,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHuy),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLamMoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục Hồi";
            this.btnPhucHoi.Id = 3;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 5;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm Mới";
            this.btnLamMoi.Id = 6;
            this.btnLamMoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLamMoi.ImageOptions.SvgImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(905, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 612);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(905, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 561);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(905, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 561);
            // 
            // QLDSV_TC
            // 
            this.QLDSV_TC.DataSetName = "QLDSV_TC";
            this.QLDSV_TC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.QLDSV_TC;
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.MONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSVTC_CSDLPT.QLDSV_TCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MonHocGridControl
            // 
            this.MonHocGridControl.DataSource = this.bdsMonHoc;
            this.MonHocGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MonHocGridControl.Location = new System.Drawing.Point(0, 51);
            this.MonHocGridControl.MainView = this.gridView1;
            this.MonHocGridControl.MenuManager = this.barManager1;
            this.MonHocGridControl.Name = "MonHocGridControl";
            this.MonHocGridControl.Size = new System.Drawing.Size(905, 305);
            this.MonHocGridControl.TabIndex = 4;
            this.MonHocGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaMonHoc,
            this.colMonHoc,
            this.colSoTietLT,
            this.colSoTietTH});
            this.gridView1.GridControl = this.MonHocGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // colMaMonHoc
            // 
            this.colMaMonHoc.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colMaMonHoc.AppearanceHeader.Options.UseBackColor = true;
            this.colMaMonHoc.Caption = "Mã Môn Học";
            this.colMaMonHoc.FieldName = "MAMH";
            this.colMaMonHoc.MinWidth = 25;
            this.colMaMonHoc.Name = "colMaMonHoc";
            this.colMaMonHoc.Visible = true;
            this.colMaMonHoc.VisibleIndex = 0;
            this.colMaMonHoc.Width = 94;
            // 
            // colMonHoc
            // 
            this.colMonHoc.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colMonHoc.AppearanceHeader.Options.UseBackColor = true;
            this.colMonHoc.Caption = "Tên Môn Học";
            this.colMonHoc.FieldName = "TENMH";
            this.colMonHoc.MinWidth = 25;
            this.colMonHoc.Name = "colMonHoc";
            this.colMonHoc.Visible = true;
            this.colMonHoc.VisibleIndex = 1;
            this.colMonHoc.Width = 94;
            // 
            // colSoTietLT
            // 
            this.colSoTietLT.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colSoTietLT.AppearanceHeader.Options.UseBackColor = true;
            this.colSoTietLT.Caption = "Số Tiết Lý Thuyết";
            this.colSoTietLT.FieldName = "SOTIET_LT";
            this.colSoTietLT.MinWidth = 25;
            this.colSoTietLT.Name = "colSoTietLT";
            this.colSoTietLT.Visible = true;
            this.colSoTietLT.VisibleIndex = 2;
            this.colSoTietLT.Width = 94;
            // 
            // colSoTietTH
            // 
            this.colSoTietTH.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colSoTietTH.AppearanceHeader.Options.UseBackColor = true;
            this.colSoTietTH.Caption = "Số Tiết Thực Hành";
            this.colSoTietTH.FieldName = "SOTIET_TH";
            this.colSoTietTH.MinWidth = 25;
            this.colSoTietTH.Name = "colSoTietTH";
            this.colSoTietTH.Visible = true;
            this.colSoTietTH.VisibleIndex = 3;
            this.colSoTietTH.Width = 94;
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl1.Controls.Add(this.speSoTietTH);
            this.panelControl1.Controls.Add(this.speSoTietLT);
            this.panelControl1.Controls.Add(this.txbTenMonHoc);
            this.panelControl1.Controls.Add(this.txbMaMonHoc);
            this.panelControl1.Controls.Add(this.soTIET_THLabel);
            this.panelControl1.Controls.Add(this.soTIET_LTLabel);
            this.panelControl1.Controls.Add(this.tenMHLabel);
            this.panelControl1.Controls.Add(this.maMHLabel);
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 356);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(905, 256);
            this.panelControl1.TabIndex = 5;
            // 
            // speSoTietTH
            // 
            this.speSoTietTH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "SOTIET_TH", true));
            this.speSoTietTH.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.speSoTietTH.Location = new System.Drawing.Point(546, 173);
            this.speSoTietTH.MenuManager = this.barManager1;
            this.speSoTietTH.Name = "speSoTietTH";
            this.speSoTietTH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speSoTietTH.Size = new System.Drawing.Size(189, 24);
            this.speSoTietTH.TabIndex = 4;
            // 
            // speSoTietLT
            // 
            this.speSoTietLT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "SOTIET_LT", true));
            this.speSoTietLT.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.speSoTietLT.Location = new System.Drawing.Point(546, 143);
            this.speSoTietLT.MenuManager = this.barManager1;
            this.speSoTietLT.Name = "speSoTietLT";
            this.speSoTietLT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speSoTietLT.Size = new System.Drawing.Size(189, 24);
            this.speSoTietLT.TabIndex = 3;
            // 
            // txbTenMonHoc
            // 
            this.txbTenMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "TENMH", true));
            this.txbTenMonHoc.Location = new System.Drawing.Point(546, 110);
            this.txbTenMonHoc.MenuManager = this.barManager1;
            this.txbTenMonHoc.Name = "txbTenMonHoc";
            this.txbTenMonHoc.Size = new System.Drawing.Size(189, 22);
            this.txbTenMonHoc.TabIndex = 2;
            // 
            // txbMaMonHoc
            // 
            this.txbMaMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "MAMH", true));
            this.txbMaMonHoc.Location = new System.Drawing.Point(546, 78);
            this.txbMaMonHoc.MenuManager = this.barManager1;
            this.txbMaMonHoc.Name = "txbMaMonHoc";
            this.txbMaMonHoc.Size = new System.Drawing.Size(189, 22);
            this.txbMaMonHoc.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLDSVTC_CSDLPT.Properties.Resources.monhoc;
            this.pictureBox1.Location = new System.Drawing.Point(154, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(127, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nhập thông tin chi tiết môn học";
            // 
            // bdsLopTinChi
            // 
            this.bdsLopTinChi.DataMember = "FK_LOPTINCHI_MONHOC";
            this.bdsLopTinChi.DataSource = this.bdsMonHoc;
            // 
            // LOPTINCHITableAdapter
            // 
            this.LOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 632);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.MonHocGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMonHoc";
            this.Text = "Môn Học";
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLDSV_TC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speSoTietTH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speSoTietLT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopTinChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private QLDSV_TC QLDSV_TC;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private QLDSV_TCTableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private QLDSV_TCTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl MonHocGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaMonHoc;
        private DevExpress.XtraGrid.Columns.GridColumn colMonHoc;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTietLT;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTietTH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit speSoTietTH;
        private DevExpress.XtraEditors.SpinEdit speSoTietLT;
        private DevExpress.XtraEditors.TextEdit txbTenMonHoc;
        private DevExpress.XtraEditors.TextEdit txbMaMonHoc;
        private System.Windows.Forms.BindingSource bdsLopTinChi;
        private QLDSV_TCTableAdapters.LOPTINCHITableAdapter LOPTINCHITableAdapter;
        private System.Windows.Forms.Label maMHLabel;
        private System.Windows.Forms.Label tenMHLabel;
        private System.Windows.Forms.Label soTIET_LTLabel;
        private System.Windows.Forms.Label soTIET_THLabel;
    }
}
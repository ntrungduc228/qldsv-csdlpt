
namespace QLDSVTC_CSDLPT
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.LopHocbarButton = new DevExpress.XtraBars.BarButtonItem();
            this.MonHocButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.LopTinChibarButton = new DevExpress.XtraBars.BarButtonItem();
            this.DiemButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.HocPhibarButton = new DevExpress.XtraBars.BarButtonItem();
            this.DangKibarButton = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.InDSLTCbarButton = new DevExpress.XtraBars.BarButtonItem();
            this.DSDKbarButton = new DevExpress.XtraBars.BarButtonItem();
            this.BDHMbarButton = new DevExpress.XtraBars.BarButtonItem();
            this.phieuDiembarButton = new DevExpress.XtraBars.BarButtonItem();
            this.DSHPbarButton = new DevExpress.XtraBars.BarButtonItem();
            this.BDTKbarButton = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMK = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.rpQuanTri = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpCauHinh = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MAGV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnSinhVien,
            this.LopHocbarButton,
            this.MonHocButtonItem,
            this.LopTinChibarButton,
            this.DiemButtonItem,
            this.HocPhibarButton,
            this.DangKibarButton,
            this.barButtonGroup1,
            this.InDSLTCbarButton,
            this.DSDKbarButton,
            this.BDHMbarButton,
            this.phieuDiembarButton,
            this.DSHPbarButton,
            this.BDTKbarButton,
            this.btnTaoTK,
            this.btnDoiMK,
            this.btnDangXuat});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 18;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpQuanTri,
            this.rpBaoCao,
            this.rpCauHinh});
            this.ribbon.Size = new System.Drawing.Size(966, 209);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Caption = "SINH VIÊN";
            this.btnSinhVien.Id = 1;
            this.btnSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSinhVien.ImageOptions.Image")));
            this.btnSinhVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSinhVien.ImageOptions.LargeImage")));
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSinhVien_ItemClick);
            // 
            // LopHocbarButton
            // 
            this.LopHocbarButton.Caption = "LỚP HỌC";
            this.LopHocbarButton.Id = 2;
            this.LopHocbarButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("LopHocbarButton.ImageOptions.Image")));
            this.LopHocbarButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("LopHocbarButton.ImageOptions.LargeImage")));
            this.LopHocbarButton.Name = "LopHocbarButton";
            this.LopHocbarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.LopHocbarButton_ItemClick);
            // 
            // MonHocButtonItem
            // 
            this.MonHocButtonItem.Caption = "MÔN HỌC";
            this.MonHocButtonItem.Id = 3;
            this.MonHocButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("MonHocButtonItem.ImageOptions.Image")));
            this.MonHocButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("MonHocButtonItem.ImageOptions.LargeImage")));
            this.MonHocButtonItem.Name = "MonHocButtonItem";
            this.MonHocButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MonHocButtonItem_ItemClick);
            // 
            // LopTinChibarButton
            // 
            this.LopTinChibarButton.Caption = "LỚP TC";
            this.LopTinChibarButton.Id = 4;
            this.LopTinChibarButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("LopTinChibarButton.ImageOptions.Image")));
            this.LopTinChibarButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("LopTinChibarButton.ImageOptions.LargeImage")));
            this.LopTinChibarButton.Name = "LopTinChibarButton";
            this.LopTinChibarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.LopTinChibarButton_ItemClick);
            // 
            // DiemButtonItem
            // 
            this.DiemButtonItem.Caption = "ĐIỂM";
            this.DiemButtonItem.Id = 5;
            this.DiemButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DiemButtonItem.ImageOptions.Image")));
            this.DiemButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DiemButtonItem.ImageOptions.LargeImage")));
            this.DiemButtonItem.Name = "DiemButtonItem";
            this.DiemButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DiemButtonItem_ItemClick);
            // 
            // HocPhibarButton
            // 
            this.HocPhibarButton.Caption = "HỌC PHÍ";
            this.HocPhibarButton.Id = 6;
            this.HocPhibarButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("HocPhibarButton.ImageOptions.Image")));
            this.HocPhibarButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("HocPhibarButton.ImageOptions.LargeImage")));
            this.HocPhibarButton.Name = "HocPhibarButton";
            // 
            // DangKibarButton
            // 
            this.DangKibarButton.Caption = "ĐĂNG KÝ";
            this.DangKibarButton.Id = 7;
            this.DangKibarButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DangKibarButton.ImageOptions.Image")));
            this.DangKibarButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DangKibarButton.ImageOptions.LargeImage")));
            this.DangKibarButton.Name = "DangKibarButton";
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "GV";
            this.barButtonGroup1.Id = 8;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // InDSLTCbarButton
            // 
            this.InDSLTCbarButton.Caption = "In DSLTC";
            this.InDSLTCbarButton.Id = 9;
            this.InDSLTCbarButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("InDSLTCbarButton.ImageOptions.Image")));
            this.InDSLTCbarButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("InDSLTCbarButton.ImageOptions.LargeImage")));
            this.InDSLTCbarButton.Name = "InDSLTCbarButton";
            // 
            // DSDKbarButton
            // 
            this.DSDKbarButton.Caption = "In DSSV  ĐKLTC";
            this.DSDKbarButton.Id = 10;
            this.DSDKbarButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DSDKbarButton.ImageOptions.Image")));
            this.DSDKbarButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DSDKbarButton.ImageOptions.LargeImage")));
            this.DSDKbarButton.Name = "DSDKbarButton";
            // 
            // BDHMbarButton
            // 
            this.BDHMbarButton.Caption = "In BDHM";
            this.BDHMbarButton.Id = 11;
            this.BDHMbarButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BDMHbarButton.ImageOptions.Image")));
            this.BDHMbarButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BDMHbarButton.ImageOptions.LargeImage")));
            this.BDHMbarButton.Name = "BDHMbarButton";
            // 
            // phieuDiembarButton
            // 
            this.phieuDiembarButton.Caption = "In Phiếu Điểm SV";
            this.phieuDiembarButton.Id = 12;
            this.phieuDiembarButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("phieuDiembarButton.ImageOptions.Image")));
            this.phieuDiembarButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("phieuDiembarButton.ImageOptions.LargeImage")));
            this.phieuDiembarButton.Name = "phieuDiembarButton";
            // 
            // DSHPbarButton
            // 
            this.DSHPbarButton.Caption = "In Danh Sách HP của Lớp";
            this.DSHPbarButton.Id = 13;
            this.DSHPbarButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DSHPbarButton.ImageOptions.Image")));
            this.DSHPbarButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DSHPbarButton.ImageOptions.LargeImage")));
            this.DSHPbarButton.Name = "DSHPbarButton";
            // 
            // BDTKbarButton
            // 
            this.BDTKbarButton.Caption = "In Bảng điểm TK";
            this.BDTKbarButton.Id = 14;
            this.BDTKbarButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BDTKbarButton.ImageOptions.Image")));
            this.BDTKbarButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BDTKbarButton.ImageOptions.LargeImage")));
            this.BDTKbarButton.Name = "BDTKbarButton";
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Caption = "Tạo tài khoản";
            this.btnTaoTK.Id = 15;
            this.btnTaoTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoTK.ImageOptions.Image")));
            this.btnTaoTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaoTK.ImageOptions.LargeImage")));
            this.btnTaoTK.Name = "btnTaoTK";
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Caption = "Đổi mật khẩu";
            this.btnDoiMK.Id = 16;
            this.btnDoiMK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMK.ImageOptions.Image")));
            this.btnDoiMK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDoiMK.ImageOptions.LargeImage")));
            this.btnDoiMK.Name = "btnDoiMK";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 17;
            this.btnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.Image")));
            this.btnDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.LargeImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            // 
            // rpQuanTri
            // 
            this.rpQuanTri.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rpQuanTri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rpQuanTri.ImageOptions.Image")));
            this.rpQuanTri.Name = "rpQuanTri";
            this.rpQuanTri.Text = "QUẢN TRỊ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSinhVien);
            this.ribbonPageGroup1.ItemLinks.Add(this.LopHocbarButton);
            this.ribbonPageGroup1.ItemLinks.Add(this.MonHocButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.LopTinChibarButton);
            this.ribbonPageGroup1.ItemLinks.Add(this.DiemButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.HocPhibarButton);
            this.ribbonPageGroup1.ItemLinks.Add(this.DangKibarButton);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "QUẢN LÝ DỮ LIỆU";
            // 
            // rpBaoCao
            // 
            this.rpBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rpBaoCao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rpBaoCao.ImageOptions.Image")));
            this.rpBaoCao.Name = "rpBaoCao";
            this.rpBaoCao.Text = "BÁO CÁO";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.InDSLTCbarButton);
            this.ribbonPageGroup2.ItemLinks.Add(this.DSDKbarButton);
            this.ribbonPageGroup2.ItemLinks.Add(this.BDHMbarButton);
            this.ribbonPageGroup2.ItemLinks.Add(this.phieuDiembarButton);
            this.ribbonPageGroup2.ItemLinks.Add(this.DSHPbarButton);
            this.ribbonPageGroup2.ItemLinks.Add(this.BDTKbarButton);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // rpCauHinh
            // 
            this.rpCauHinh.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rpCauHinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rpCauHinh.ImageOptions.Image")));
            this.rpCauHinh.Name = "rpCauHinh";
            this.rpCauHinh.Text = "CẤU HÌNH";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnTaoTK);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDoiMK);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Chức năng";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MAGV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 541);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(966, 26);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MAGV
            // 
            this.MAGV.Name = "MAGV";
            this.MAGV.Size = new System.Drawing.Size(51, 20);
            this.MAGV.Text = "MAGV";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(57, 20);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(55, 20);
            this.NHOM.Text = "NHOM";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 567);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.Text = "Quản Lý";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpQuanTri;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnSinhVien;
        private DevExpress.XtraBars.BarButtonItem LopHocbarButton;
        private DevExpress.XtraBars.BarButtonItem MonHocButtonItem;
        private DevExpress.XtraBars.BarButtonItem LopTinChibarButton;
        private DevExpress.XtraBars.BarButtonItem DiemButtonItem;
        private DevExpress.XtraBars.BarButtonItem HocPhibarButton;
        private DevExpress.XtraBars.BarButtonItem DangKibarButton;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MAGV;
        private System.Windows.Forms.ToolStripStatusLabel HOTEN;
        private System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.BarButtonItem InDSLTCbarButton;
        private DevExpress.XtraBars.BarButtonItem DSDKbarButton;
        private DevExpress.XtraBars.BarButtonItem BDHMbarButton;
        private DevExpress.XtraBars.BarButtonItem phieuDiembarButton;
        private DevExpress.XtraBars.BarButtonItem DSHPbarButton;
        private DevExpress.XtraBars.BarButtonItem BDTKbarButton;
        private DevExpress.XtraBars.BarButtonItem btnTaoTK;
        private DevExpress.XtraBars.BarButtonItem btnDoiMK;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpCauHinh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}
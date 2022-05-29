﻿using DevExpress.XtraBars;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSVTC_CSDLPT
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            HienThiMenu();
            PhanQuyen();
            this.MAGV.Text = "MA " + Program.username;
            this.HOTEN.Text = "HOTEN " + Program.mHoten;
            this.NHOM.Text = "NHOM " + Program.mGroup;
        }

        public void HienThiMenu()
        {
            rpQuanTri.Visible = rpBaoCao.Visible = true;
        }

        void PhanQuyen()
        {
            if (Program.mGroup.Equals("SV"))
            {
                DangKibarButton.Enabled = true;
                DiemButtonItem.Enabled = HocPhibarButton.Enabled = LopHocbarButton.Enabled = LopTinChibarButton.Enabled = MonHocButtonItem.Enabled = btnSinhVien.Enabled = btnTaoTK.Enabled = false;
                rpBaoCao.Visible = false;
            }
            if (Program.mGroup.Equals("PKT"))
            {
                HocPhibarButton.Enabled = true;
                DiemButtonItem.Enabled = LopHocbarButton.Enabled = LopTinChibarButton.Enabled = MonHocButtonItem.Enabled = btnSinhVien.Enabled = DangKibarButton.Enabled = false;
                rpBaoCao.Visible = false;
            }
            if (Program.mGroup.Equals("PGV") || Program.mGroup.Equals("KHOA"))
            {
                DangKibarButton.Enabled = HocPhibarButton.Enabled = false;
            }
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void LopHocbarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLopHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmLopHoc f = new frmLopHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void HocPhibarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                frmHocPhi f = new frmHocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            Form frmDangNhap = new frmDangNhap();

            this.Close();
        }
    }
}
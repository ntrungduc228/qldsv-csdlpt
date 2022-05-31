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
            
            if (Program.mGroup.Equals("PGV") || Program.mGroup.Equals("KHOA"))
            {
                DangKibarButton.Enabled = HocPhibarButton.Enabled = false;
            }
        }

       

        private void MonHocButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSinhVien_ItemClick(object sender, ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(frmSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }
        private void DiemButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmDiem f = new frmDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void LopTinChibarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLopTinChi));
            if (frm != null) frm.Activate();
            else
            {
                frmLopTinChi f = new frmLopTinChi();
                f.MdiParent = this;
                f.Show();
            }
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

        private void BDHMbarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Frpt_BDHM));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_BDHM f = new Frpt_BDHM();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void phieuDiembarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Frpt_PhieuDiem_SV));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_PhieuDiem_SV f = new Frpt_PhieuDiem_SV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void InDSLTCbarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Frpt_DSLTC));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_DSLTC f = new Frpt_DSLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void DSDKbarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Frpt_DSSVDKLTC));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_DSSVDKLTC f = new Frpt_DSSVDKLTC();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
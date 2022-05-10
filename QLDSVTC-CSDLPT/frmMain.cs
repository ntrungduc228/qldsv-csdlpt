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

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

       
    }
}
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class Frpt_BDHM : DevExpress.XtraEditors.XtraForm
    {
        public Frpt_BDHM()
        {
            InitializeComponent();
        }

        private void Frpt_BDHM_Load(object sender, EventArgs e)
        {
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MONHOCTableAdapter.Fill(this.qLDSV_TC.MONHOC);

            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENCN";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mKhoa;

            if (Program.mGroup == "KHOA")
            {
                cbKhoa.Enabled = false;
            }
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cbKhoa.SelectedValue.ToString();
            if (cbKhoa.SelectedIndex != Program.mKhoa)
            {
                Program.login = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.login = Program.mLogin;
                Program.password = Program.mPassword;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.MONHOCTableAdapter.Fill(this.qLDSV_TC.MONHOC);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi load dữ liệu từ sever này!", "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnXemTruoc_Click(object sender, EventArgs e)
        {
            Xrpt_BDHM rpt = new Xrpt_BDHM(cbNienKhoa.Text, int.Parse(cbHocKi.Text), int.Parse(cbNhom.Text), cbMonHoc.Text);

            rpt.lblTieuDe.Text = "BẢNG ĐIỂM HẾT MÔN " +cbKhoa.Text.ToUpper();
            rpt.lblNienKhoa.Text = cbNienKhoa.Text;
            rpt.lblHocKi.Text = cbHocKi.Text;
            rpt.lblMonHoc.Text = cbMonHoc.Text;
            rpt.lblNhom.Text = cbNhom.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
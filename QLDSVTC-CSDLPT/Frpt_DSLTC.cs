using DevExpress.XtraBars;
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
    public partial class Frpt_DSLTC : DevExpress.XtraEditors.XtraForm
    {
        public Frpt_DSLTC()
        {
            InitializeComponent();
        }

        private void frptDSLTC_Load(object sender, EventArgs e)
        {
            cbkhoa.DataSource = Program.bds_dspm;
            cbkhoa.DisplayMember = "TENCN";
            cbkhoa.ValueMember = "TENSERVER";
            cbkhoa.SelectedIndex = Program.mKhoa;
            if (Program.mGroup == "KHOA")
            {
                cbkhoa.Enabled = false;
            }
            loadcbnienkhoa();
            cbnienkhoa.SelectedIndex = 0;
        }
        private void cbkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cbkhoa.SelectedValue.ToString();
            if (cbkhoa.SelectedIndex != Program.mKhoa)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mLogin;
                Program.password = Program.mPassword;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                loadcbnienkhoa();
                cbnienkhoa.SelectedIndex = 0;
            }
        }
        void loadcbnienkhoa()
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.GetAllNienKhoa";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsNienKhoa = new BindingSource();
            bdsNienKhoa.DataSource = dt;
            cbnienkhoa.DataSource = bdsNienKhoa;
            cbnienkhoa.DisplayMember = "NIENKHOA";
            cbnienkhoa.ValueMember = "NIENKHOA";
        }
        void loadcbhocky(string nienkhoa)
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.GetAllHocKy '" + nienkhoa + "'";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsHocKi = new BindingSource();
            bdsHocKi.DataSource = dt;
            cbhocky.DataSource = bdsHocKi;
            cbhocky.DisplayMember = "HOCKY";
            cbhocky.ValueMember = "HOCKY";
        }
        

        private void btnxemtruoc_Click(object sender, EventArgs e)
        {
            string nienkhoa = cbnienkhoa.Text;
            int hocky = Int32.Parse(cbhocky.Text);
            string khoa = cbkhoa.Text;
            Xrpt_DSLTC rpt = new Xrpt_DSLTC(nienkhoa, hocky);
            rpt.lbkhoa.Text = khoa;
            rpt.lbhocky.Text = hocky.ToString();
            rpt.lbnienkhoa.Text = nienkhoa;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }


        private void cbnienkhoa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            loadcbhocky(cbnienkhoa.Text);
            cbhocky.SelectedIndex = 0;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
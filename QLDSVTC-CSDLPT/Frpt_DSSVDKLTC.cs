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
    public partial class Frpt_DSSVDKLTC : DevExpress.XtraEditors.XtraForm
    {
        public Frpt_DSSVDKLTC()
        {
            InitializeComponent();
        }


        private void Frpt_DSSVDKLTC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_TC.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLDSV_TC.MONHOC);
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.qLDSV_TC.MONHOC);
            cbkhoa.DataSource = Program.bds_dspm;
            cbkhoa.DisplayMember = "TENCN";
            cbkhoa.ValueMember = "TENSERVER";
            cbkhoa.SelectedIndex = Program.mKhoa;
            if (Program.mGroup == "KHOA")
            {
                cbkhoa.Enabled = false;
            }
            cbmonhoc.DataSource = bdsmonhoc;
            cbmonhoc.DisplayMember = "TENMH";
            cbmonhoc.ValueMember = "TENMH";


            loadcbnienkhoa();
            cbnienkhoa.SelectedIndex = 0;
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
        void loadnhom(string nienkhoa, string hocki)
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.GetAllNhom '" + nienkhoa + "', " + hocki;
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsNhom = new BindingSource();
            bdsNhom.DataSource = dt;
            cbnhom.DataSource = bdsNhom;
            cbnhom.DisplayMember = "NHOM";
            cbnhom.ValueMember = "NHOM";
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

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbnienkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadcbhocky(cbnienkhoa.Text);
            cbhocky.SelectedIndex = 0;
        }

        private void cbhocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadnhom(cbnienkhoa.Text, cbhocky.Text);
            cbnhom.SelectedIndex = 0;
        }

        private void btnxemtruoc_Click(object sender, EventArgs e)
        {
            string nienkhoa = cbnienkhoa.Text;
            int hocky = Int32.Parse(cbhocky.Text);
            int nhom = Int32.Parse(cbnhom.Text);
            string monhoc = cbmonhoc.SelectedValue.ToString();
            string khoa = cbkhoa.Text;
            Xrpt_DSSVDKLTC rpt = new Xrpt_DSSVDKLTC(nienkhoa, hocky, nhom, monhoc);
            rpt.lbmonhoc.Text = monhoc;
            rpt.lbhocky.Text = hocky.ToString();
            rpt.lbnhom.Text = nhom.ToString();
            rpt.lbnienkhoa.Text = nienkhoa;
            rpt.lbkhoa.Text = khoa;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
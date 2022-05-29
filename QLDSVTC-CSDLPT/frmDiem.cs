using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSVTC_CSDLPT
{
    public partial class frmDiem : DevExpress.XtraEditors.XtraForm
    {     
        public frmDiem()
        {
            InitializeComponent();
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            QLDSV_TC.EnforceConstraints = false;
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MONHOCTableAdapter.Fill(this.QLDSV_TC.MONHOC);

            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENCN";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mKhoa;

            cbMH.DataSource = bdsMonHoc;
            cbMH.DisplayMember = "TENMH";
            cbMH.ValueMember = "TENMH";

            if (Program.mGroup == "KHOA")
            {
                cbKhoa.Enabled = false;
            }
            loadcbNienkhoa();
            cbNienKhoa.SelectedIndex = 0;
        }
        void loadcbNienkhoa()
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.GetAllNienKhoa";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsNienKhoa = new BindingSource();
            bdsNienKhoa.DataSource = dt;
            cbNienKhoa.DataSource = bdsNienKhoa;
            cbNienKhoa.DisplayMember = "NIENKHOA";
            cbNienKhoa.ValueMember = "NIENKHOA";
        }
        void loadcbHocKi(string nienkhoa)
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.GetAllHocKy '" + nienkhoa + "'";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsHocKi = new BindingSource();
            bdsHocKi.DataSource = dt;
            cbHocKi.DataSource = bdsHocKi;
            cbHocKi.DisplayMember = "HOCKY";
            cbHocKi.ValueMember = "HOCKY";
        }
        void loadNhom(string nienkhoa, string hocki)
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.GetAllNhom '" + nienkhoa + "', " + hocki;
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsNhom = new BindingSource();
            bdsNhom.DataSource = dt;
            cbNhom.DataSource = bdsNhom;
            cbNhom.DisplayMember = "NHOM";
            cbNhom.ValueMember = "NHOM";
        }
        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cbKhoa.SelectedValue.ToString();
            if (cbKhoa.SelectedIndex != Program.mKhoa)
            {
                Program.mLogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                loadcbNienkhoa();
                cbNienKhoa.SelectedIndex = 0;
            }
        }
        void load_SV_DangKy()
        {
            try
            {
                this.SP_LAY_DSSV_DANGKYTableAdapter.Fill(this.QLDSV_TC.SP_LAY_DSSV_DANGKY,
                    cbNienKhoa.Text, int.Parse(cbHocKi.Text), int.Parse(cbNhom.Text), cbMH.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            load_SV_DangKy();
        }

        private void cbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadcbHocKi(cbNienKhoa.Text);
        }

        private void cbHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadNhom(cbNienKhoa.Text, cbHocKi.Text);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGhiDiem_Click(object sender, EventArgs e)
        {
            BindingSource bdsTemp = (BindingSource)this.DiemGridControl.DataSource;
            if (bdsTemp == null)
            {
                MessageBox.Show("Chưa có thông tin để ghi điểm!", "", MessageBoxButtons.OK);
                return;
            }
            bdsTemp.EndEdit();

            SqlConnection conn = new SqlConnection(Program.connstr);
            conn.Open();
            SqlTransaction tran = conn.BeginTransaction();

            DataTable dt = new DataTable();
            dt.Columns.Add("MALTC", typeof(int));
            dt.Columns.Add("MASV", typeof(string));
            dt.Columns.Add("DIEM_CC", typeof(float));
            dt.Columns.Add("DIEM_GK", typeof(float));
            dt.Columns.Add("DIEM_CK", typeof(float));

            try
            {
                for(int i=0; i< bdsTemp.Count; i++)
                {

                    float diemcc = 0;
                    float diemgk = 0;
                    float diemck = 0;
                    if (((DataRowView)bdsTemp[i])["DIEM_CC"].ToString() != "")
                    {
                        diemcc = float.Parse(((DataRowView)bdsTemp[i])["DIEM_CC"].ToString());
                    }
                    if (((DataRowView)bdsTemp[i])["DIEM_GK"].ToString() != "")
                    {
                        diemgk = float.Parse(((DataRowView)bdsTemp[i])["DIEM_GK"].ToString());
                    }
                    if (((DataRowView)bdsTemp[i])["DIEM_CK"].ToString() != "")
                    {
                        diemck = float.Parse(((DataRowView)bdsTemp[i])["DIEM_CK"].ToString());
                    }
                    if (diemcc < 0 || diemcc > 10 || diemck < 0 || diemck > 10 || diemgk < 0 || diemgk > 10)
                    {
                        tran.Rollback();
                        XtraMessageBox.Show("Điểm số chỉ được nhập từ 0 đến 10! Xin vui lòng nhập lại");
                        conn.Close();
                        load_SV_DangKy();
                        return;
                    }

                    dt.Rows.Add(((DataRowView)bdsTemp[i])["MALTC"], ((DataRowView)bdsTemp[i])["MASV"],
                        diemcc, diemgk, diemck);
                }
                SqlParameter para = new SqlParameter();
                para.SqlDbType = SqlDbType.Structured;
                para.TypeName = "dbo.TYPE_DANGKY";
                para.ParameterName = "@DIEMTHI";
                para.Value = dt;
                Program.KetNoi();

                SqlCommand Sqlcmd = new SqlCommand("SP_UPDATE_DIEM", conn);
                Sqlcmd.Connection = conn;
                Sqlcmd.Transaction = tran;
                Sqlcmd.Parameters.Clear();
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                Sqlcmd.Parameters.Add(para);
                Sqlcmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch(SqlException ex)
            {
                tran.Rollback();
                XtraMessageBox.Show("Lỗi ghi toàn bộ điểm vào Database. Bạn hãy xem lại ! " + ex.Message, "", MessageBoxButtons.OK);
                load_SV_DangKy();
            }
            finally
            {
                conn.Close();
            }
            XtraMessageBox.Show("Thao tác thành công!", "", MessageBoxButtons.OK);
            return;
        }
    }
}
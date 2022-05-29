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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection conn_publisher = new SqlConnection();
        private bool isSinhVien = false;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cbChiNhanh.DataSource = Program.bds_dspm;
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";
        }

        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publicsher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. \nBạn xem lại tên Sever của Publisher, và tên CSDL trong chuỗi kết nối.\n" + e.Message);
                return 0;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("SELECT * FROM [dbo].[V_DS_PHANMANH]");
            cbChiNhanh.SelectedIndex = 1;
            cbChiNhanh.SelectedIndex = 0;
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            Program.mainForm.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(isSinhVien == true)
            {
                Program.mLogin = "SVKN";
                Program.mPassword = "123456";
                if (Program.KetNoi() == 0) return;
            }

            if (txbTaiKhoan.Text.Trim() == "" || txbMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật khẩu không được trống", "", MessageBoxButtons.OK);
                return;
            }

            Program.mLogin = txbTaiKhoan.Text; Program.mPassword = txbMatKhau.Text;
           
            if (Program.KetNoi() == 0) return;

            

            Program.mKhoa = cbChiNhanh.SelectedIndex;
            string strLenh = "EXEC dbo.SP_Lay_Thong_Tin_GV_Tu_Login '" + Program.mLogin + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read(); // Đọc 1 dòng nếu dữ liệu có nhiều dùng thì dùng for lặp nếu null thì break
            Program.mGroup = Program.myReader.GetString(2);
            Program.username = Program.myReader.GetString(0);
            Program.mHoten = Program.myReader.GetString(1);
            Program.myReader.Close();

            Program.conn.Close();
           
           // MessageBox.Show("Đăng nhập thành công !!!");
            //Form f = new frmMain();
            //f.ShowDialog();
            // truy cập vào frm main 
            Program.mainForm = new frmMain();

            // hiện thông tin tài khoản
           

            Program.mainForm.Show();
            Program.dangNhapForm.Visible = false;
        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cbChiNhanh.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isSinhVien = !isSinhVien;
        }
    }
}
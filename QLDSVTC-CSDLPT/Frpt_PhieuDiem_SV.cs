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
    public partial class Frpt_PhieuDiem_SV : DevExpress.XtraEditors.XtraForm
    {
        public Frpt_PhieuDiem_SV()
        {
            InitializeComponent();
        }

        private void Frpt_PhieuDiem_SV_Load(object sender, EventArgs e)
        {
            qLDSV_TC.EnforceConstraints = false;
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.qLDSV_TC.SINHVIEN);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidatorSV()
        {
            if (cbMaSV.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã sinh viên không để trống", "", MessageBoxButtons.OK);
                cbMaSV.Focus();
                return false;
            }
            string query1 = " DECLARE @return_value INT " +

                            " EXEC @return_value = [dbo].[SP_CHECKID] " +

                            " @Code = N'" + cbMaSV.Text.Trim() + "',  " +

                            " @Type = N'MASV' " +

                            " SELECT  'Return Value' = @return_value ";

            int resultMa = Program.CheckDataHelper(query1);
            if (resultMa == -1)
            {
                XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                this.Close();
            }
            if (resultMa == 1)
            {
                //  XtraMessageBox.Show("Mã Sinh Viên đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (resultMa == 2 && Program.mGroup == "KHOA")
            {
                XtraMessageBox.Show("Sinh viên thuộc khoa khác, Bạn không có quyền truy cập. Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (resultMa == 2)
            {

                return false;
            }
            else
            {
                XtraMessageBox.Show("Mã Sinh Viên không tồn tại. Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

        }

        private void btnXemTruoc_Click(object sender, EventArgs e)
        {
            if (ValidatorSV() == false)
            {
                String mssv = cbMaSV.Text.Trim();
                int type = -1;
                if (Program.mGroup.Equals("KHOA"))
                {
                    type = 1;
                }
                if (Program.mGroup.Equals("PGV"))
                {
                    type = 0;
                }
                Xrpt_PhieuDiem_SV rpt = new Xrpt_PhieuDiem_SV(mssv, type);

                rpt.lblMSSV.Text = cbMaSV.Text.Trim();
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
            else return;
        }
    }
}
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
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
    public partial class frmSinhVien : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        string macn = "";
        private string _flagOptionSinhVien;
        private string _oldMaSV;
        public frmSinhVien()
        {
            InitializeComponent();
            panelControl1.Enabled = false;
        }

        

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_TC.DANGKY' table. You can move, or remove it, as needed.
            //this.dANGKYTableAdapter.Fill(this.qLDSV_TC.DANGKY);
            // TODO: This line of code loads data into the 'qLDSV_TC.DANGKY' table. You can move, or remove it, as needed.
            //this.dANGKYTableAdapter.Fill(this.qLDSV_TC.DANGKY);
            // TODO: This line of code loads data into the 'qLDSV_TC.SINHVIEN' table. You can move, or remove it, as needed.
            //this.sINHVIENTableAdapter.Fill(this.qLDSV_TC.SINHVIEN);
            // TODO: This line of code loads data into the 'qLDSV_TC.LOP' table. You can move, or remove it, as needed.
           // this.lOPTableAdapter.Fill(this.qLDSV_TC.LOP);
            // TODO: This line of code loads data into the 'qLDSV_TC.KHOA' table. You can move, or remove it, as needed.

            qLDSV_TC.EnforceConstraints = false;

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TC.SINHVIEN);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TC.LOP);

            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.qLDSV_TC.DANGKY);



            macn = ((DataRowView)bdsLop[0])["MAKHOA"].ToString();
            cobKhoa.DataSource = Program.bds_dspm;
            cobKhoa.DisplayMember = "TENCN";
            cobKhoa.ValueMember = "TENSERVER";
            cobKhoa.SelectedIndex = Program.mKhoa;
            if (Program.mGroup == "KHOA")
            {
                cobKhoa.Enabled = false;
            }

        }

        private bool validatorSinhVien()
        {
            if (tedMasv.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                tedMalop.Focus();
                return false;
            }
            if (tedHo.Text.Trim() == "")
            {
                MessageBox.Show("họ không được thiếu!", "", MessageBoxButtons.OK);
                tedHo.Focus();
                return false;
            }
            if (tedTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được thiếu!", "", MessageBoxButtons.OK);
                tedTen.Focus();
                return false;
            }
            if (tedDiachi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được thiếu!", "", MessageBoxButtons.OK);
                tedDiachi.Focus();
                return false;
            }
            if (tedMalop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                tedDiachi.Focus();
                return false;
            }
            if (cedPhai.Checked == null)
            {
                MessageBox.Show("Phái không được thiếu!", "", MessageBoxButtons.OK);
                cedPhai.Focus();
                return false;
            }
            if (cedDangnghihoc.Checked == null)
            {
                MessageBox.Show("Đang nghỉ học không được thiếu!", "", MessageBoxButtons.OK);
                cedDangnghihoc.Focus();
                return false;
            }
            if (_flagOptionSinhVien == "ADD")
            {
                string query1 = " DECLARE @return_value INT " +

                            " EXEC @return_value = [dbo].[SP_CHECKID] " +

                            " @Code = N'" + tedMasv.Text.Trim() + "',  " +

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
                    XtraMessageBox.Show("Mã Sinh Viên đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (resultMa == 2)
                {
                    XtraMessageBox.Show("Mã Sinh Viên đã tồn tại ở Khoa khác. Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (_flagOptionSinhVien == "UPDATE")
            {
                if (!this.tedMasv.Text.Trim().ToString().Equals(_oldMaSV))
                {
                    string query2 = " DECLARE @return_value INT " +

                            " EXEC @return_value = [dbo].[SP_CHECKID] " +

                            " @code = N'" + tedMasv.Text.Trim() + "',  " +

                            " @Type = N'MASV' " +

                            " SELECT  'Return Value' = @return_value ";

                    int resultMa = Program.CheckDataHelper(query2);
                    if (resultMa == -1)
                    {
                        XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    if (resultMa == 1)
                    {
                        XtraMessageBox.Show("Mã Sinh Viên đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    if (resultMa == 2)
                    {
                        XtraMessageBox.Show("Mã Sinh Viên đã tồn tại ở Khoa khác. Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

            }
            return true;
        }



       

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            vitri = bdsSinhvien.Position;
            _flagOptionSinhVien = "ADD";

            panelControl1.Enabled = true;
            bdsSinhvien.AddNew();
            tedMalop.Text = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnQuaylai.Enabled = true;
            sINHVIENGridControl.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            vitri = bdsSinhvien.Position;
            _flagOptionSinhVien = "UPDATE";
            _oldMaSV = tedMasv.Text.Trim();

            panelControl1.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnQuaylai.Enabled = false;
            btnLuu.Enabled = true;
            tedMasv.Enabled = false;
            sINHVIENGridControl.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            string masv = "";
            if (bdsDangky.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì sinh viên đã đăng kí lớp tín chỉ", "", MessageBoxButtons.OK);
                return;
            }


            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên khỏi lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masv = ((DataRowView)bdsSinhvien[bdsSinhvien.Position])["MASV"].ToString();
                    bdsSinhvien.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.qLDSV_TC.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh vieen: " + ex.Message, "", MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Fill(this.qLDSV_TC.SINHVIEN);
                    bdsSinhvien.Position = bdsLop.Find("MASV", masv);
                    return;
                }
            }
            if (bdsSinhvien.Count == 0) btnXoa.Enabled = false;
        }

        private void btnQuaylai_ItemClick(object sender, ItemClickEventArgs e)
        {
            bdsSinhvien.CancelEdit();
            if (btnThem.Enabled == false) bdsLop.Position = vitri;
            sINHVIENGridControl.Enabled = true;
            panelControl1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = btnQuaylai.Enabled = false;
            frmSinhVien_Load(sender, e);

            // load lại cả form...


            if (vitri > 0)
            {
                bdsSinhvien.Position = vitri;
            }
        }

        private void btnLammoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.lOPTableAdapter.Fill(this.qLDSV_TC.LOP);
                this.sINHVIENTableAdapter.Fill(this.qLDSV_TC.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

        }

        private void btnLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (validatorSinhVien() == true)
            {
                try
                {
                    bdsSinhvien.EndEdit();
                    bdsSinhvien.ResetCurrentItem();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.qLDSV_TC.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                sINHVIENGridControl.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                btnLuu.Enabled = btnQuaylai.Enabled = false;
                panelControl1.Enabled = false;
            }
            else
            {
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cobKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cobKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cobKhoa.SelectedValue.ToString();
            if (cobKhoa.SelectedIndex != Program.mKhoa)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.qLDSV_TC.SINHVIEN);

                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.qLDSV_TC.LOP);

                this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dANGKYTableAdapter.Fill(this.qLDSV_TC.DANGKY);


                macn = ((DataRowView)bdsLop[0])["MAKHOA"].ToString();
            }
        }
    }
}
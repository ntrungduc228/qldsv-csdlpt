using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSVTC_CSDLPT
{
    public partial class Xrpt_BDHM : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_BDHM()
        {
        }
        public Xrpt_BDHM(string nienKhoa, int hocKi, int nhom, string monHoc)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienKhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocKi;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = nhom;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = monHoc;
        }
    }
}

using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSVTC_CSDLPT
{
    public partial class Xrpt_PhieuDiem_SV : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_PhieuDiem_SV()
        {
        }
        public Xrpt_PhieuDiem_SV(String mssv, int type)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = mssv;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = type;
        }
    }
}

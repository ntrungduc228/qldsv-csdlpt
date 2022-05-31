using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSVTC_CSDLPT
{
    public partial class Xrpt_DSLTC : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DSLTC()
        {
            InitializeComponent();
        }
        public Xrpt_DSLTC(string nienkhoa, int hocky)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienkhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocky;
            this.sqlDataSource1.Fill();
        }
    }
}

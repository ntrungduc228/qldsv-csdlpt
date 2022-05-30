
namespace QLDSVTC_CSDLPT
{
    partial class Frpt_PhieuDiem_SV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mASVLabel;
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXemTruoc = new DevExpress.XtraEditors.SimpleButton();
            this.cbMaSV = new System.Windows.Forms.ComboBox();
            this.bdsSINHVIEN = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_TC = new QLDSVTC_CSDLPT.QLDSV_TC();
            this.SINHVIENTableAdapter = new QLDSVTC_CSDLPT.QLDSV_TCTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new QLDSVTC_CSDLPT.QLDSV_TCTableAdapters.TableAdapterManager();
            mASVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSINHVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TC)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.BackColor = System.Drawing.Color.Transparent;
            mASVLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            mASVLabel.Location = new System.Drawing.Point(414, 40);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(118, 23);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "Nhập MSSV:";
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Controls.Add(this.btnThoat);
            this.panelControl2.Controls.Add(this.btnXemTruoc);
            this.panelControl2.Controls.Add(mASVLabel);
            this.panelControl2.Controls.Add(this.cbMaSV);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1136, 101);
            this.panelControl2.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(895, 37);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXemTruoc
            // 
            this.btnXemTruoc.Location = new System.Drawing.Point(770, 38);
            this.btnXemTruoc.Name = "btnXemTruoc";
            this.btnXemTruoc.Size = new System.Drawing.Size(94, 29);
            this.btnXemTruoc.TabIndex = 8;
            this.btnXemTruoc.Text = "Xem trước";
            this.btnXemTruoc.Click += new System.EventHandler(this.btnXemTruoc_Click);
            // 
            // cbMaSV
            // 
            this.cbMaSV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSINHVIEN, "MASV", true));
            this.cbMaSV.DataSource = this.bdsSINHVIEN;
            this.cbMaSV.DisplayMember = "MASV";
            this.cbMaSV.FormattingEnabled = true;
            this.cbMaSV.Location = new System.Drawing.Point(538, 42);
            this.cbMaSV.Name = "cbMaSV";
            this.cbMaSV.Size = new System.Drawing.Size(169, 24);
            this.cbMaSV.TabIndex = 1;
            this.cbMaSV.ValueMember = "MASV";
            // 
            // bdsSINHVIEN
            // 
            this.bdsSINHVIEN.DataMember = "SINHVIEN";
            this.bdsSINHVIEN.DataSource = this.qLDSV_TC;
            // 
            // qLDSV_TC
            // 
            this.qLDSV_TC.DataSetName = "QLDSV_TC";
            this.qLDSV_TC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SINHVIENTableAdapter
            // 
            this.SINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.SINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSVTC_CSDLPT.QLDSV_TCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Frpt_PhieuDiem_SV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 278);
            this.Controls.Add(this.panelControl2);
            this.Name = "Frpt_PhieuDiem_SV";
            this.Text = "In Phiếu Điểm SV";
            this.Load += new System.EventHandler(this.Frpt_PhieuDiem_SV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSINHVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private QLDSV_TC qLDSV_TC;
        private System.Windows.Forms.BindingSource bdsSINHVIEN;
        private QLDSV_TCTableAdapters.SINHVIENTableAdapter SINHVIENTableAdapter;
        private QLDSV_TCTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbMaSV;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXemTruoc;
    }
}
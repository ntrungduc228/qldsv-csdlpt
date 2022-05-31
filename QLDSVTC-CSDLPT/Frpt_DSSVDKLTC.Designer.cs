
namespace QLDSVTC_CSDLPT
{
    partial class Frpt_DSSVDKLTC
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbmonhoc = new System.Windows.Forms.ComboBox();
            this.bdsmonhoc = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVTCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_TC = new QLDSVTC_CSDLPT.QLDSV_TC();
            this.button2 = new System.Windows.Forms.Button();
            this.btnxemtruoc = new System.Windows.Forms.Button();
            this.cbnhom = new System.Windows.Forms.ComboBox();
            this.cbhocky = new System.Windows.Forms.ComboBox();
            this.cbnienkhoa = new System.Windows.Forms.ComboBox();
            this.cbkhoa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mONHOCTableAdapter = new QLDSVTC_CSDLPT.QLDSV_TCTableAdapters.MONHOCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsmonhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVTCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TC)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbmonhoc);
            this.panelControl1.Controls.Add(this.button2);
            this.panelControl1.Controls.Add(this.btnxemtruoc);
            this.panelControl1.Controls.Add(this.cbnhom);
            this.panelControl1.Controls.Add(this.cbhocky);
            this.panelControl1.Controls.Add(this.cbnienkhoa);
            this.panelControl1.Controls.Add(this.cbkhoa);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Location = new System.Drawing.Point(1, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1092, 323);
            this.panelControl1.TabIndex = 4;
            // 
            // cbmonhoc
            // 
            this.cbmonhoc.DataSource = this.bdsmonhoc;
            this.cbmonhoc.DisplayMember = "TENMH";
            this.cbmonhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmonhoc.FormattingEnabled = true;
            this.cbmonhoc.Location = new System.Drawing.Point(389, 200);
            this.cbmonhoc.Name = "cbmonhoc";
            this.cbmonhoc.Size = new System.Drawing.Size(221, 24);
            this.cbmonhoc.TabIndex = 11;
            // 
            // bdsmonhoc
            // 
            this.bdsmonhoc.DataMember = "MONHOC";
            this.bdsmonhoc.DataSource = this.qLDSVTCBindingSource;
            // 
            // qLDSVTCBindingSource
            // 
            this.qLDSVTCBindingSource.DataSource = this.qLDSV_TC;
            this.qLDSVTCBindingSource.Position = 0;
            // 
            // qLDSV_TC
            // 
            this.qLDSV_TC.DataSetName = "QLDSV_TC";
            this.qLDSV_TC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(503, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnxemtruoc
            // 
            this.btnxemtruoc.Location = new System.Drawing.Point(389, 237);
            this.btnxemtruoc.Name = "btnxemtruoc";
            this.btnxemtruoc.Size = new System.Drawing.Size(95, 33);
            this.btnxemtruoc.TabIndex = 9;
            this.btnxemtruoc.Text = "Xem trước";
            this.btnxemtruoc.UseVisualStyleBackColor = true;
            this.btnxemtruoc.Click += new System.EventHandler(this.btnxemtruoc_Click);
            // 
            // cbnhom
            // 
            this.cbnhom.FormattingEnabled = true;
            this.cbnhom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbnhom.Location = new System.Drawing.Point(389, 169);
            this.cbnhom.Name = "cbnhom";
            this.cbnhom.Size = new System.Drawing.Size(221, 24);
            this.cbnhom.TabIndex = 8;
            // 
            // cbhocky
            // 
            this.cbhocky.FormattingEnabled = true;
            this.cbhocky.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbhocky.Location = new System.Drawing.Point(389, 135);
            this.cbhocky.Name = "cbhocky";
            this.cbhocky.Size = new System.Drawing.Size(221, 24);
            this.cbhocky.TabIndex = 7;
            this.cbhocky.SelectedIndexChanged += new System.EventHandler(this.cbhocky_SelectedIndexChanged);
            // 
            // cbnienkhoa
            // 
            this.cbnienkhoa.FormattingEnabled = true;
            this.cbnienkhoa.Items.AddRange(new object[] {
            "2017-2018",
            "2018-2019",
            "2019-2020",
            "2020-2021",
            "2021-2022",
            "2022-2023",
            "2023-2024",
            "2024-2025",
            "2025-2026"});
            this.cbnienkhoa.Location = new System.Drawing.Point(389, 97);
            this.cbnienkhoa.Name = "cbnienkhoa";
            this.cbnienkhoa.Size = new System.Drawing.Size(221, 24);
            this.cbnienkhoa.TabIndex = 6;
            this.cbnienkhoa.SelectedIndexChanged += new System.EventHandler(this.cbnienkhoa_SelectedIndexChanged);
            // 
            // cbkhoa
            // 
            this.cbkhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkhoa.FormattingEnabled = true;
            this.cbkhoa.Location = new System.Drawing.Point(389, 65);
            this.cbkhoa.Name = "cbkhoa";
            this.cbkhoa.Size = new System.Drawing.Size(221, 24);
            this.cbkhoa.TabIndex = 5;
            this.cbkhoa.SelectedIndexChanged += new System.EventHandler(this.cbkhoa_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Môn Học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhóm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Học Kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Niên Khóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa";
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // Frpt_DSSVDKLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 501);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frpt_DSSVDKLTC";
            this.Text = "Danh sách sinh viên";
            this.Load += new System.EventHandler(this.Frpt_DSSVDKLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsmonhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVTCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbkhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbnhom;
        private System.Windows.Forms.ComboBox cbhocky;
        private System.Windows.Forms.ComboBox cbnienkhoa;
        private System.Windows.Forms.ComboBox cbmonhoc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnxemtruoc;
        private System.Windows.Forms.BindingSource qLDSVTCBindingSource;
        private QLDSV_TC qLDSV_TC;
        private System.Windows.Forms.BindingSource bdsmonhoc;
        private QLDSV_TCTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
    }
}
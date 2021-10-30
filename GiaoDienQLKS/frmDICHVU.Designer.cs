
namespace GiaoDienQLKS
{
    partial class frmDICHVU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDICHVU));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnBoQua = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.gcdichvu = new DevExpress.XtraGrid.GridControl();
            this.gvdichvu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MADV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcthongtin = new DevExpress.XtraEditors.GroupControl();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcdichvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdichvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcthongtin)).BeginInit();
            this.gcthongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnBoQua,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(50, 44);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(38, 44);
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(39, 44);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(37, 44);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Image = ((System.Drawing.Image)(resources.GetObject("btnBoQua.Image")));
            this.btnBoQua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(62, 44);
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(51, 44);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gcdichvu
            // 
            this.gcdichvu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcdichvu.Location = new System.Drawing.Point(0, 47);
            this.gcdichvu.MainView = this.gvdichvu;
            this.gcdichvu.Name = "gcdichvu";
            this.gcdichvu.Size = new System.Drawing.Size(800, 269);
            this.gcdichvu.TabIndex = 0;
            this.gcdichvu.TabStop = false;
            this.gcdichvu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvdichvu});
            // 
            // gvdichvu
            // 
            this.gvdichvu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MADV,
            this.TENDV,
            this.DONGIA});
            this.gvdichvu.GridControl = this.gcdichvu;
            this.gvdichvu.Name = "gvdichvu";
            this.gvdichvu.OptionsSelection.MultiSelect = true;
            this.gvdichvu.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvdichvu.OptionsView.ShowGroupPanel = false;
            this.gvdichvu.Click += new System.EventHandler(this.gvdichvu_Click);
            // 
            // MADV
            // 
            this.MADV.Caption = "Mã Dịch Vụ";
            this.MADV.FieldName = "MADV";
            this.MADV.MinWidth = 25;
            this.MADV.Name = "MADV";
            this.MADV.Visible = true;
            this.MADV.VisibleIndex = 1;
            this.MADV.Width = 94;
            // 
            // TENDV
            // 
            this.TENDV.Caption = "Tên Dịch Vụ";
            this.TENDV.FieldName = "TENDV";
            this.TENDV.MinWidth = 25;
            this.TENDV.Name = "TENDV";
            this.TENDV.Visible = true;
            this.TENDV.VisibleIndex = 2;
            this.TENDV.Width = 94;
            // 
            // DONGIA
            // 
            this.DONGIA.Caption = "Đơn Giá";
            this.DONGIA.FieldName = "DONGIA";
            this.DONGIA.MinWidth = 25;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Visible = true;
            this.DONGIA.VisibleIndex = 3;
            this.DONGIA.Width = 94;
            // 
            // gcthongtin
            // 
            this.gcthongtin.Controls.Add(this.txtDonGia);
            this.gcthongtin.Controls.Add(this.label3);
            this.gcthongtin.Controls.Add(this.txtTenDV);
            this.gcthongtin.Controls.Add(this.label2);
            this.gcthongtin.Controls.Add(this.txtMaDV);
            this.gcthongtin.Controls.Add(this.label1);
            this.gcthongtin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcthongtin.Location = new System.Drawing.Point(0, 305);
            this.gcthongtin.Name = "gcthongtin";
            this.gcthongtin.Size = new System.Drawing.Size(800, 145);
            this.gcthongtin.TabIndex = 2;
            this.gcthongtin.Text = "Thông Tin";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(130, 102);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(352, 23);
            this.txtDonGia.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn Giá";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(130, 73);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(352, 23);
            this.txtTenDV.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Dịch Vụ";
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(130, 44);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(352, 23);
            this.txtMaDV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Dịch Vụ";
            // 
            // frmDICHVU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gcthongtin);
            this.Controls.Add(this.gcdichvu);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDICHVU";
            this.Text = "frmDICHVU";
            this.Load += new System.EventHandler(this.frmDICHVU_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcdichvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdichvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcthongtin)).EndInit();
            this.gcthongtin.ResumeLayout(false);
            this.gcthongtin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnBoQua;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private DevExpress.XtraGrid.GridControl gcdichvu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvdichvu;
        private DevExpress.XtraEditors.GroupControl gcthongtin;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn MADV;
        private DevExpress.XtraGrid.Columns.GridColumn TENDV;
        private DevExpress.XtraGrid.Columns.GridColumn DONGIA;
    }
}
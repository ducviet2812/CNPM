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
using BussinessLayer;
using DataLayer;
using DevExpress.XtraGrid.Views.Grid;

namespace GiaoDienQLKS
{
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }


        KHACHHANG _khachhang;

        bool _them;
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            _khachhang = new KHACHHANG();
            loadData();
            showHideControl(true);
            enabled(false);
            txtMaKhachHang.Enabled = false;
        }


        void showHideControl(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnThoat.Visible = t;
            btnLuu.Visible = !t;
            btnBoQua.Visible = !t;
        }

        void loadData()
        {
            gcKhachHang.DataSource = _khachhang.getall();
            gvKhachHang.OptionsBehavior.Editable = false;
        }

        void clear()
        {
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtCCCD.Text = "";
            txtSDT.Text = "";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }    
        }
        void enabled(bool f)
        {
            txtCCCD.Enabled = f;
            txtTenKhachHang.Enabled = f;
            txtSDT.Enabled = f;
            txtDiaChi.Enabled = f;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            showHideControl(false);
            clear();
            enabled(true);
            txtTenKhachHang.Focus();
            txtMaKhachHang.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            txtMaKhachHang.Enabled = false;
            showHideControl(false);
            enabled(true);
            txtTenKhachHang.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < gvKhachHang.RowCount; i++)
                {
                    bool mutiselect = gvKhachHang.IsRowSelected(i);
                    if(mutiselect)
                    {
                        _khachhang.delete(int.Parse(gvKhachHang.GetRowCellValue(i, "MAKH").ToString()));
                        clear();
                    }
                }
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text.Length == 0 || txtDiaChi.Text.Length == 0 || txtCCCD.Text.Length == 0 || txtTenKhachHang.Text.Length == 0 || txtSDT.Text.Length == 0)
            {
                MessageBox.Show("Mời bạn nhập dữ liêu", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            else 
            { 
                if (_them)
                {
                    if (MessageBox.Show("Bạn có muốn lưu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        tb_KHACHHANG kh = new tb_KHACHHANG();
                        kh.MAKH = int.Parse((txtMaKhachHang.Text).ToString());
                        kh.TENKH = txtTenKhachHang.Text;
                        kh.DIACHI = txtDiaChi.Text;
                        kh.CCCD_CMND = txtCCCD.Text;
                        kh.SDT = txtSDT.Text;
                        for (int i = 0; i < gvKhachHang.RowCount; i++)
                        {
                            if ((gvKhachHang.GetRowCellValue(i, "MAKH").ToString()) == txtMaKhachHang.Text)
                            {
                                MessageBox.Show("Mã khách hàng bị trùng mời bạn nhập mã khác!", "Thông Báo", MessageBoxButtons.OK);
                                txtMaKhachHang.Text = "";
                                txtMaKhachHang.Focus();
                                return;
                            }
                        }
                        _khachhang.add(kh);
                        clear();
                    }
                    else
                    {
                        return;
                    }
                }
               else
                {
                    if (MessageBox.Show("Bạn có muốn lưu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        tb_KHACHHANG kh = _khachhang.getItem(int.Parse(gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "MAKH").ToString()));
                        kh.MAKH = int.Parse((txtMaKhachHang.Text).ToString());
                        kh.TENKH = txtTenKhachHang.Text;
                        kh.DIACHI = txtDiaChi.Text;
                        kh.CCCD_CMND = txtCCCD.Text;
                        kh.SDT = txtSDT.Text;
                        _khachhang.update(kh);
                        clear();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            _them = false;
            loadData();
            showHideControl(true);
            enabled(false);
            txtMaKhachHang.Enabled = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn bỏ qua không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _them = false;
                showHideControl(true);
                enabled(false);
                txtMaKhachHang.Enabled = false;
                clear();
            }
            else 
            { 
                return; 
            }
        }

        private void gvKhachHang_Click(object sender, EventArgs e)
        {
            if (gvKhachHang.RowCount>0)
            {
                txtMaKhachHang.Text =gvKhachHang.GetFocusedRowCellValue("MAKH").ToString();
                txtTenKhachHang.Text = gvKhachHang.GetFocusedRowCellValue("TENKH").ToString();
                txtDiaChi.Text = gvKhachHang.GetFocusedRowCellValue("DIACHI").ToString();
                txtCCCD.Text = gvKhachHang.GetFocusedRowCellValue("CCCD_CMND").ToString();
                txtSDT.Text = gvKhachHang.GetFocusedRowCellValue("SDT").ToString();   
            }
        }

        private void txtMaKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Mã khách hàng không được nhập chữ!!!", "Thông Báo", MessageBoxButtons.OK);
                e.Handled = true;
            }    
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("CCCD không được nhập chữ!!!", "Thông báo", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("SDT không được nhập chữ !!!","Thông Báo",MessageBoxButtons.OK);
                e.Handled = true;
            }
        }
    }
}
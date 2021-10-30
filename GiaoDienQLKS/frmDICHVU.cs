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

namespace GiaoDienQLKS
{
    public partial class frmDICHVU : Form
    {
        public frmDICHVU()
        {
            InitializeComponent();
        }

        DICHVU _DICHVU;
        bool _them;
        private void frmDICHVU_Load(object sender, EventArgs e)
        {
            _DICHVU = new DICHVU();
            loaddata();
            showHideControl(true);
            enabled(false);
            txtMaDV.Enabled = false;

        }

        void enabled(bool e)
        {
            txtTenDV.Enabled = e;
            txtDonGia.Enabled = e;
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

        void clear()
        {
            txtMaDV.Text = "";
            txtTenDV.Text = "";
            txtDonGia.Text = "";
        }

        void loaddata()
        {
            gcdichvu.DataSource = _DICHVU.getall();
            gvdichvu.OptionsBehavior.Editable = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            showHideControl(false);
            clear();
            enabled(true);
            txtMaDV.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            txtMaDV.Enabled = false;
            showHideControl(false);
            enabled(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < gvdichvu.RowCount; i++)
                {
                    bool mutiselect = gvdichvu.IsRowSelected(i);
                    if (mutiselect)
                    {
                        _DICHVU.delete(int.Parse(gvdichvu.GetRowCellValue(i, "MAKH").ToString()));
                        clear();
                    }
                }
            }
            loaddata();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaDV.Text.Length == 0 || txtTenDV.Text.Length == 0 || txtDonGia.Text.Length == 0 )
            {
                MessageBox.Show("Mời bạn nhập dữ liêu", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                if (_them)
                {
                    if (MessageBox.Show("Bạn có muốn lưu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        tb_DICHVU dv = new tb_DICHVU();
                        dv.MADV = int.Parse((txtMaDV.Text).ToString());
                        dv.TENDV = txtTenDV.Text;
                        dv.DONGIA = float.Parse(txtDonGia.Text);
                        for (int i = 0; i < gvdichvu.RowCount; i++)
                        {
                            if ((gvdichvu.GetRowCellValue(i, "MADV").ToString()) == txtMaDV.Text)
                            {
                                MessageBox.Show("Mã khách hàng bị trùng mời bạn nhập mã khác!", "Thông Báo", MessageBoxButtons.OK);
                                txtMaDV.Text = "";
                                txtMaDV.Focus();
                                return;
                            }
                        }
                        _DICHVU.add(dv);
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
                        tb_DICHVU dv = _DICHVU.getItem(int.Parse(gvdichvu.GetRowCellValue(gvdichvu.FocusedRowHandle, "MADV").ToString()));
                        dv.MADV = int.Parse((txtMaDV.Text).ToString());
                        dv.TENDV = txtTenDV.Text;
                        dv.DONGIA = float.Parse(txtDonGia.Text);
                        _DICHVU.update(dv);
                        clear();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            _them = false;
            loaddata();
            showHideControl(true);
            enabled(false);
            txtMaDV.Enabled = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideControl(true);
            enabled(false);
            txtMaDV.Enabled = false;
            clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hay không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                return;
            }    
        }

        private void gvdichvu_Click(object sender, EventArgs e)
        {
            if (gvdichvu.RowCount > 0)
            {
                txtMaDV.Text = gvdichvu.GetFocusedRowCellValue("MADV").ToString();
                txtTenDV.Text = gvdichvu.GetFocusedRowCellValue("TENDV").ToString();
                txtDonGia.Text = gvdichvu.GetFocusedRowCellValue("DONGIA").ToString();

            }
        }
    }
}

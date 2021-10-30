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
using System.Data.SqlClient;
using QuanLyKhachSan.SQLdatabase;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.OAuth.Provider;

namespace QuanLyKhachSan
{
    public partial class frmPhieuDatPhong : DevExpress.XtraEditors.XtraForm
    {
        List<OBJ_DSSP> lstDSSP;
        SQL_database.tb_LOAIPHONG lp;
        SQL_database.tb_PHONG p;
        OBJ_PHONG _phonghientai;
        
        public frmPhieuDatPhong()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }
        void loadKH()
        {
            var provider = new ConnectDB();
            var kh = provider.ExecuteQuery("SELECT MAKH,TENKH FROM tb_KHACHHANG");
            searchKH.Properties.DataSource = kh;
            searchKH.Properties.ValueMember = "MAKH" as string;
            searchKH.Properties.DisplayMember = "TENKH" as string;

        }
        void loadSP()
        {
            var provider = new ConnectDB();
            var sp = provider.ExecuteQuery("SELECT * FROM tb_DICHVU");
            gcSP.DataSource = sp;
            gvSP.OptionsBehavior.Editable = false;

        }
        void loadPhong()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DUYDUY\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT TENPHONG FROM tb_PHONG", con))
                {
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string name = dr["TENPHONG"].ToString();
                        //string city = dr["City"].ToString();
                        lbTT.Text = name;


                    }
                    con.Close();
                }
            }
        }


        private void frmPhieuDatPhong_Load(object sender, EventArgs e)
        {
            lstDSSP = new List<OBJ_DSSP>();
            p = new SQL_database.tb_PHONG();
            lp = new SQL_database.tb_LOAIPHONG();
            lblP.Text = p.TENPHONG + " - Đơn giá: " +lp.DonGia.ToString() + "VND";



            dtNgayNhan.Value = DateTime.Now;
            dtNgayTra.Value = DateTime.Now.AddDays(1);

            loadKH();
            loadSP();
        }

        private void gcSP_DoubleClick(object sender, EventArgs e)
        {
            if(gvSP.GetFocusedRowCellValue("MADV") != null)
            {
                OBJ_DSSP dssp = new OBJ_DSSP();
                dssp.IDSP = int.Parse(gvSP.GetFocusedRowCellValue("MADV").ToString());
                dssp.TENDV = gvSP.GetFocusedRowCellValue("TENDV").ToString();
                dssp.BANGGIADV = float.Parse(gvSP.GetFocusedRowCellValue("BANGGIADV").ToString());
                dssp.SOLUONG = 1;
                dssp.THANHTIEN = dssp.SOLUONG * dssp.BANGGIADV;
                foreach(var item in lstDSSP)
                {
                    if(item.IDSP == dssp.IDSP)
                    {
                        item.SOLUONG = item.SOLUONG + 1;
                        item.THANHTIEN = item.SOLUONG * item.BANGGIADV;
                        loadDSSP();
                        return;
                    }

                }
                lstDSSP.Add(dssp);
            }
            loadDSSP();
            txtTongTien.Text = gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString();
        }
        void loadDSSP()
        {
            List<OBJ_DSSP> DSSP = new List<OBJ_DSSP>();

            foreach(var item in lstDSSP)
            {
                DSSP.Add(item);
            }

            gcSPDV.DataSource = DSSP;

        }

        private void gvSPDV_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "SOLUONG") {
                int sl = int.Parse(e.Value.ToString());
                if (sl > 0)
                {
                    double gia = double.Parse(gvSPDV.GetRowCellValue(gvSPDV.FocusedRowHandle, "BANGGIADV").ToString());
                    gvSPDV.SetRowCellValue(gvSPDV.FocusedRowHandle, "THANHTIEN", sl*gia);
                }
                else
                {
                    gvSPDV.SetRowCellValue(gvSPDV.FocusedRowHandle, "THANHTIEN", 0);
                }
            }

            gvSPDV.UpdateTotalSummary();
            txtTongTien.Text = gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString();
        }
        void laygiatien()
        {
            var provider = new ConnectDB();
            var tienphong = provider.ExecuteQuery("SELECT MAKH,TENKH FROM tb_KHACHHANG");
            SQL_database.tb_LOAIPHONG lp;
           
        }

        private void gvSPDV_HiddenEditor(object sender, EventArgs e)
        {
            gvSPDV.UpdateCurrentRow();
        }
    }
}
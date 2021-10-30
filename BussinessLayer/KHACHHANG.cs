using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BussinessLayer
{
   public class KHACHHANG
    {
        Entities db;
        
        public KHACHHANG()
        {
            connect cn = new connect();
            string connectString = cn.getConnect();
            db = new Entities(connectString);   

        }
        public tb_KHACHHANG getItem(int MaKH)
        {            
           
            return db.kh.FirstOrDefault(x=>x.MAKH == MaKH);
        }
        public List<tb_KHACHHANG> getall()
        {
            return db.kh.ToList();
        }
        public void add(tb_KHACHHANG kh)
        {
            try
            {
                db.kh.Add(kh);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }
        public void update(tb_KHACHHANG kh)
        {
            tb_KHACHHANG _kh = db.kh.FirstOrDefault(x=>x.MAKH==kh.MAKH);
            _kh.TENKH = kh.TENKH;
            _kh.SDT = kh.SDT;
            _kh.CCCD_CMND = kh.CCCD_CMND;
            _kh.DIACHI = kh.DIACHI;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }
        public void delete(int MAKH)
        {
            tb_KHACHHANG _kh = db.kh.FirstOrDefault(x => x.MAKH == MAKH);
            try
            {
                db.kh.Remove(_kh);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }
    }
}

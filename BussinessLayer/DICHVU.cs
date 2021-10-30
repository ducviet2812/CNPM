using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BussinessLayer
{
    public class DICHVU
    {
        Entities db;
        public DICHVU()
        {
            connect cn = new connect();
            string connectString = cn.getConnect();
            db = new Entities(connectString);
        }
        public tb_DICHVU getItem(int MaDV)
        {

            return db.dv.FirstOrDefault(x => x.MADV == MaDV);
        }
        public List<tb_DICHVU> getall()
        {
            return db.dv.ToList();
        }
        public void add(tb_DICHVU dv)
        {
            try
            {
                db.dv.Add(dv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }
        public void update(tb_DICHVU dv)
        {
            tb_DICHVU _dv = db.dv.FirstOrDefault(x => x.MADV == dv.MADV);
            _dv.TENDV = dv.TENDV;
            _dv.DONGIA = dv.DONGIA;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }
        public void delete(int MADV)
        {
            tb_DICHVU _dv = db.dv.FirstOrDefault(x => x.MADV == MADV);
            try
            {
                db.dv.Remove(_dv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }
    }
}

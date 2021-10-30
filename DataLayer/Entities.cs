using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   
    public partial class Entities : DbContext
    {
        public Entities(string connection)
            :base(connection) { }
            
        public  DbSet<tb_KHACHHANG> kh { get; set; }
        public  DbSet<tb_DICHVU> dv { get; set; }
       
    }
}

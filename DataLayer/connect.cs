using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    
    public class connect
    {
        public string getConnect()
        {

            SqlConnectionStringBuilder sqlConnectBuiler = new SqlConnectionStringBuilder();
            sqlConnectBuiler.DataSource = @"MSI\SQLEXPRESS";
            sqlConnectBuiler.InitialCatalog = "QLKS2";
            sqlConnectBuiler.PersistSecurityInfo = true;
            sqlConnectBuiler.UserID = "viet";
            sqlConnectBuiler.Password = "viet281200";
            sqlConnectBuiler.MultipleActiveResultSets = true;
            sqlConnectBuiler.ApplicationName = "EntityFramework";


            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();
            entityBuilder.Provider = "System.Data.SqlClient";
            entityBuilder.ProviderConnectionString = sqlConnectBuiler.ConnectionString; 
            entityBuilder.Metadata = @"res://*/KHACHSAN.csdl|res://*/KHACHSAN.ssdl|res://*/KHACHSAN.msl";
            return entityBuilder.ConnectionString;
        }
    }
}

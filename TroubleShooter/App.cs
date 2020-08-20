using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PublicAdo;
using System.Data.SqlClient;
using System.Data;
namespace TroubleShooter
{
    
    class App
    {
        public string Name { set; get; }
        public int ID { set; get; }
        public int Add()
        {
            SqlParameter[] Param=new SqlParameter[2];
            Param[0] = SqlAdo.AddParameter("name", SqlDbType.VarChar, 50, Name);
            Param[1] = SqlAdo.AddParameter("ID", SqlDbType.Int, ID);
            return SqlAdo.ExcuteQueryStatement("TSH_Add_App", Param);
            
        }
    }
}

using System;
using System.Collections.Generic;

using System.Text;

using PublicAdo;
using System.Data;
using System.Data.SqlClient;
namespace TroubleShooter
{
    class Implementor
    {

        #region Fields with thier properties

        string name;
        public string Name
        {
          get { return name; }
          set { name = value; }
        }


        string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public static string Dev_User_Name;
        #endregion


        #region Functions
        public bool LogIn() 
        {
            SqlParameter[] Params = new SqlParameter[2];
            Params[0] = SqlAdo.AddParameter("user_name", SqlDbType.VarChar, 50, userName);
            Params[1] = SqlAdo.AddParameter("password", SqlDbType.VarChar, 50, password);
            object obj = SqlAdo.ExcuteScalarStatement("TSH_Log_In", Params);


            if (obj==null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public int AddDeveloper(int type)
        {
            SqlParameter[] Params = new SqlParameter[3];
            Params[0] = SqlAdo.AddParameter("Name", SqlDbType.VarChar, 50, name);
            Params[1] = SqlAdo.AddParameter("user_name", SqlDbType.VarChar, 50, userName);
            Params[2] = SqlAdo.AddParameter("password", SqlDbType.VarChar, 50, password);
            if (type == 1)
                return SqlAdo.ExcuteQueryStatement("TSH_Add_developer", Params);
            else if (type == 2)
                return SqlAdo.ExcuteQueryStatement("TSH_Add_tester", Params);
            else
                return SqlAdo.ExcuteQueryStatement("TSH_Add_implemetor", Params);            
        }

        
        #endregion
    }
}

using System;
using System.Collections.Generic;

using System.Text;

using System.Data.SqlClient;
namespace PublicAdo
{
    public class DBConnection
    {
        
 
        SqlConnection con;
        string userName = "ahmed.abdo", password = "ahmed1234";

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }


        #region Constructors


        /// <summary>
        /// makes connection on dev server on database troubleshooter enables you to choose DataBase and User
        /// </summary>
        /// <param name="UserName">the user that modifies the data</param>
        /// <param name="Password">password of the above user</param>

        public DBConnection()
        {
            con = new SqlConnection(@"Data Source=10.5.5.120;Initial Catalog=TroubleShooter;User ID=" + userName + ";Password=" + password);
        }

        public DBConnection(string Con_String)
        {
            con = new SqlConnection();
            con.ConnectionString = Con_String;
        }

        /// <summary>
        /// makes connection on the Local server enables you to choose DataBase and User
        /// </summary>
        /// <param name="DataBaseName">the name of database you're working on</param>
        /// <param name="UserName">the user that modifies the data</param>
        /// <param name="Password">password of the above user</param>

        public DBConnection(string DataBaseName, string UserName, string Password)
        {
            
            con = new SqlConnection(@"Data Source=devserver;Initial Catalog=" + DataBaseName + ";User ID=" + UserName + ";Password=" + Password);
        }

        /// <summary>
        /// makes connection to the Server that you want on the database that you want 
        /// </summary>
        /// <param name="ServerName">the name of server where the database is stored</param>
        /// <param name="DataBaseName">the name of database you're working on</param>
        /// <param name="UserName">the user that modifies the data</param>
        /// <param name="Password">password of the above user</param>
        public DBConnection(string ServerName, string DataBaseName, string UserName, string Password)
        {
            con = new SqlConnection(@"Data Source=" + ServerName + ";Initial Catalog=" + DataBaseName + ";User ID=" + UserName + ";Password=" + Password);
        }

        #endregion


        public SqlConnection Con
        {
            get { return con; }
            set { con = value; }
        }

    }

}

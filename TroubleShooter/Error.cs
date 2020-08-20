using System;
using System.Collections.Generic;

using System.Text;

using PublicAdo;
using System.Data.SqlClient;
using System.Data;
namespace TroubleShooter
{
    class Error
    {

        #region Fields With Properties
        
        
        public int App_ID { set; get; }
        public string Summary { set; get; }
        public byte[] img { set; get; }
        public byte[] thumb { set; get; }
        public string IP { set; get; }
        public int category { set; get; }
        public int user_id { set; get; }
        public string Mac_IP { set; get; }
        public string OS { set; get; }
        public string Computer_Name { set; get; }
        public string App_name { set; get; }
        public string User_name { set; get; }


        #endregion


        public Error(int User_ID,string User_Name,int App_ID,string App_Name,string IP,string Mac,string OS,string Computer_Name,int Category,string Summary,byte[] Img,byte[] Thumb)
        {
            user_id = User_ID;
            User_name = User_Name;
            this.App_ID = App_ID;
            this.App_name = App_Name;
            this.IP = IP;
            this.Mac_IP = Mac;
            this.OS = OS;
            this.Computer_Name = Computer_Name;
            this.category = Category;
            this.Summary = Summary;
            this.img = Img;
            this.thumb = Thumb;
        }

        public int Send_Err()
        {
            SqlParameter[] Params = new SqlParameter[12];
            Params[0] = SqlAdo.AddParameter("app_id", SqlDbType.Int, App_ID);
            Params[1] = SqlAdo.AddParameter("IP", SqlDbType.VarChar, 20,IP);
            Params[2] = SqlAdo.AddParameter("Summary", SqlDbType.NVarChar, 100,Summary);
            Params[3] = SqlAdo.AddParameter("cat_id", SqlDbType.Int,category );
            Params[4] = SqlAdo.AddParameter("user_id", SqlDbType.Int,user_id);
            Params[5] = SqlAdo.AddParameter("img", SqlDbType.VarBinary,img);
            Params[6] = SqlAdo.AddParameter("small_img", SqlDbType.VarBinary,thumb);
            Params[7] = SqlAdo.AddParameter("Mac_address", SqlDbType.VarChar,50, Mac_IP);
            Params[8] = SqlAdo.AddParameter("Operating_system", SqlDbType.VarChar,50, OS);
            Params[9] = SqlAdo.AddParameter("Computer_name", SqlDbType.NVarChar, Computer_Name);
            Params[10] = SqlAdo.AddParameter("username", SqlDbType.NVarChar, 50, User_name);
            Params[11] = SqlAdo.AddParameter("app_name", SqlDbType.NVarChar, 50, App_name);

            return SqlAdo.ExcuteQueryStatement("TSH_Insert_Err", Params);
            
        }
    }
}

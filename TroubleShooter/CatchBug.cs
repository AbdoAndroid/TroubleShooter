using System;
using System.Collections.Generic;

using System.Text;

using System.Drawing;
using PublicAdo;
using System.Data;
using System.Data.SqlClient;

namespace TroubleShooter
    
{
    public class CatchBug
    {
        #region Fields
        int AppID;
        string IP;
        string ErrorMessage;
        string ErrorType;
        string Errorsrc;
        string StackTrace;
        byte[] image;
        byte[] thumbnaile;
        string Mac;
        string OS;
        string Computer_Name;
        int User_ID;
        string User_Name;
        string App_Name;
        #endregion
       
        public CatchBug(string IP, Exception ex, byte[] image, byte[] thumbnaile,string Mac_Address,string Op_Sys,string Com_Name)
        {

            this.AppID = askforhelp.__App_id;
            this.IP = IP;
            this.ErrorMessage = ex.Message;
            this.ErrorType = ex.GetType().Name;
            this.Errorsrc = ex.Source;
            this.StackTrace = ex.StackTrace;
            this.image = image;
            this.thumbnaile = thumbnaile;
            Mac = Mac_Address;
            OS = Op_Sys;
            Computer_Name = Com_Name;
            this.User_Name = askforhelp.__User_name;
            this.User_ID = askforhelp.__User_id;
            this.App_Name = askforhelp.__App_name;
            
        }



        public static void Catch(Exception ex)
        {
            PublicAdo.SqlAdo._connectionString = askforhelp.__ConnectionString;
            PublicAdo.SqlAdo ado = new PublicAdo.SqlAdo();


            Image img;
            Image thumbimg;
            ScreenCapture sc = new ScreenCapture();
            img = sc.CaptureScreen();
            thumbimg = sc.CreateThumbnail(img, 150, 150);
            byte[] image = sc.Img2Arr(img);
            byte[] thumbnaile = sc.Img2Arr(thumbimg);
            

            Computer_config C = new Computer_config();
            string IP = C.get_IP();
            string Computer_Name = C.get_username();
            string Mac = C.get_mac();
            string OS = C.get_OS();


            CatchBug Bug = new CatchBug(IP, ex, image, thumbnaile,Mac,OS,Computer_Name);
            int Aff = Bug.SaveBug();
            if (Aff > 0)
            {
                System.Windows.Forms.MessageBox.Show("some error has happened and a message sent to the it");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("some error has happened but failed to send a message to the it");
            }
        }

        int SaveBug()
        {
            SqlParameter[] Params = new SqlParameter[14];
            Params[0] = SqlAdo.AddParameter("app_id", SqlDbType.Int, AppID);
            Params[1] = SqlAdo.AddParameter("IP", SqlDbType.VarChar, 20, IP);
            Params[2] = SqlAdo.AddParameter("message", SqlDbType.VarChar, 100, ErrorMessage);
            Params[3] = SqlAdo.AddParameter("type", SqlDbType.VarChar, 20, ErrorType);
            Params[4] = SqlAdo.AddParameter("Errsrc", SqlDbType.VarChar, 20, Errorsrc);
            Params[5] = SqlAdo.AddParameter("trace", SqlDbType.Text, StackTrace);
            Params[6] = SqlAdo.AddParameter("img", SqlDbType.VarBinary, image);
            Params[7] = SqlAdo.AddParameter("small_img", SqlDbType.VarBinary, thumbnaile);
            Params[8] = SqlAdo.AddParameter("Mac_address", SqlDbType.VarChar, 50, this.Mac);
            Params[9] = SqlAdo.AddParameter("Operating_system", SqlDbType.VarChar, 50, this.OS);
            Params[10] = SqlAdo.AddParameter("Computer_name", SqlDbType.NVarChar,50, this.Computer_Name);
            Params[11] = SqlAdo.AddParameter("username", SqlDbType.NVarChar, 50, this.User_Name);
            Params[12] = SqlAdo.AddParameter("app_name", SqlDbType.NVarChar, 50, App_Name);
            Params[13] = SqlAdo.AddParameter("user_id", SqlDbType.Int, User_ID);

            return SqlAdo.ExcuteQueryStatement("TSH_Insert_BUG", Params);

        }
    }
}

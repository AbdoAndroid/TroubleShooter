using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using System.Data.SqlClient;

namespace TroubleShooter
{
     public partial class askforhelp: UserControl
     {

         #region Members With Properties
         
         
         public static Image __img;
         public static Image __thumbimg;
         public static int __User_id=0;
         public static int __App_id=0;
         public static string __User_name="unknown";
         public static string __App_name = "unknown";
         public static string __ConnectionString = @"Data Source=10.5.5.120;Initial Catalog=TroubleShooter;User ID=ahmed.abdo;Password=ahmed1234";
         List<int> _Solution;


         public int user_id
         {
             get { return __User_id; }
             set { __User_id = value; }
         }
         public int app_id
         {
             get { return __App_id; }
             set { __App_id = value; }
         }
         public string app_name
         {
             get { return __App_name; }
             set { __App_name = value; }
         } 
        public string user_name
        {
            get { return __User_name; }
            set { __User_name = value; }
        }
        public Image img
        {
            get { return __img; }
            set { __img = value; }
        }
        public Image thumb
        {
            get { return __thumbimg; }
            set { __thumbimg = value; }
        }
        public string connectionstring
        {
            get { return __ConnectionString; }
            set { __ConnectionString = value; }
        }

         #endregion



        public askforhelp()
        {
            InitializeComponent();
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        
            ScreenCapture sc = new ScreenCapture();
            img = sc.CaptureScreen();
            thumb = sc.CreateThumbnail(img, 150, 150);
            //imgThumb.Save("E:\\Ahmed.emf");
            frmUserError help = new frmUserError();
            help.ShowDialog();
        }

        private void askforhelp_Load(object sender, EventArgs e)
        {
            PublicAdo.SqlAdo._connectionString = connectionstring;
            PublicAdo.SqlAdo ado = new PublicAdo.SqlAdo();
            //ado.ConnectionString = ;
            SqlParameter[] param = new SqlParameter[1];
            param[0] = PublicAdo.SqlAdo.AddParameter("user_id", SqlDbType.Int, user_id);
            DataTable DT = PublicAdo.SqlAdo.ReturnDataTableFromDataBase("TSH_get_solution_to_user", param);
            int i=0;
            _Solution= new List<int>();
            string Noti;
            while (DT.Rows.Count>i)
            {
                _Solution.Add(Convert.ToInt16(DT.Rows[i][0]));
                int Sol_ID = int.Parse((DT.Rows[0][0]).ToString());
                Noti = DT.Rows[i][1].ToString();
                frm_Notification Notify = new frm_Notification(Noti,Sol_ID);
                Notify.Show();
                i++;
            }
        }

        private void tmrupdatenotify_Tick(object sender, EventArgs e)
        {
            
            SqlParameter param = PublicAdo.SqlAdo.AddParameter("user_id", SqlDbType.Int, user_id);
            DataTable DT = PublicAdo.SqlAdo.ReturnDataTableFromDataBase("TSH_get_solution_to_user", param);


            string Noti;
            int counter = 0;
            while (DT.Rows.Count > counter)
            {
                int Sol_ID = int.Parse((DT.Rows[counter][0]).ToString());
                if (!(_Solution.Contains(Sol_ID)))
                {
                    _Solution.Add(Sol_ID);
                    Noti = DT.Rows[counter][1].ToString();
                    frm_Notification Notify = new frm_Notification(Noti, Sol_ID);
                    Notify.Show();
                }
                counter++;
            }
        }
    }
}


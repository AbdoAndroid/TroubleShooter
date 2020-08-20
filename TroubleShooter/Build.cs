using PublicAdo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using System.Text;

using System.Windows.Forms;
using System.Data;

namespace TroubleShooter
{
    class Build
    {
        //int _App_ID;
        //int _Developer_ID;
        //int _Tester_ID;
        //int _Build_ID;




        public int SaveDetails(DataGridView dgv,int Build_No)
        {
            int counter = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                {
                    if (!row.IsNewRow)
                    {
                        SqlParameter[] param=new SqlParameter[6];
                        param[0] = SqlAdo.AddParameter("app_id", SqlDbType.Int, row.Cells["APP Name"].Value);
                        param[1] = SqlAdo.AddParameter("developer_id", SqlDbType.Int, row.Cells["Developer Name"].Value);
                        param[2] = SqlAdo.AddParameter("tester_id", SqlDbType.Int, row.Cells["Tester _Name"].Value);
                        param[3] = SqlAdo.AddParameter("build_no", SqlDbType.Int, Build_No);
                        param[4] = SqlAdo.AddParameter("build_type_id", SqlDbType.Int, row.Cells["Build Type"].Value);
                        param[5] = SqlAdo.AddParameter("details", SqlDbType.Int, row.Cells["Build Details"].Value);
                        counter+=SqlAdo.ExcuteQueryStatement("TSH_Add_Build_Details",param);
                    }
                    

                }
            }
            return counter;
        }


    }
}

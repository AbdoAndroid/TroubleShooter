using PublicAdo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using System.Text;

using System.Windows.Forms;

namespace TroubleShooter
{
    class Solution
    {
        public string Message { set; get; }
        public string Summary { set; get; }
        public int Err_id { set; get; }



        public int Add_solution(int I, int BuildDetailsID)
        {
            SqlParameter[] Params = new SqlParameter[6];
            Params[0] = SqlAdo.AddParameter("err_id", SqlDbType.Int, this.Err_id);
            Params[1] = SqlAdo.AddParameter("messagge", SqlDbType.NVarChar, 50, this.Message);
            Params[2] = SqlAdo.AddParameter("Solution", SqlDbType.NVarChar, 100, this.Summary);
            Params[3] = SqlAdo.AddParameter("Imp_id", SqlDbType.Int, 1);
            Params[4] = SqlAdo.AddParameter("ISNew", SqlDbType.Bit, I);
            if (BuildDetailsID == -1)
            {
                Params[5] = PublicAdo.SqlAdo.AddParameter("build_detailsid", SqlDbType.Int, DBNull.Value);

            }
            else
            {
                Params[5] = PublicAdo.SqlAdo.AddParameter("build_detailsid", SqlDbType.Int, BuildDetailsID);

            }
            int affrows = SqlAdo.ExcuteQueryStatement("TSH_Insert_Solution", Params);
            return affrows;
        }

        public static int Rating(int Rate, int ID)
        {
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = SqlAdo.AddParameter("rate", SqlDbType.Int, Rate);
            Param[1] = SqlAdo.AddParameter("id", SqlDbType.Int, ID);
            return SqlAdo.ExcuteQueryStatement("TSH_Rating", Param);

        }
        public static int GetDetailsID(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (Convert.ToBoolean(((row.Cells[0]) as DataGridViewCheckBoxCell).Value))
                {
                    return Convert.ToInt32(row.Cells[1].Value);
                }
            }
            return -1;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace TroubleShooter
{
    public partial class frm_Solution_Summary : Form
    {
        bool iSFormLoad = false;
        private int error_id { set; get; }
        public frm_Solution_Summary()
        {
            InitializeComponent();
        }
        public frm_Solution_Summary(int s)
        {
            InitializeComponent();
            error_id = s;
        }
        

        private void btn_submit_Click(object sender, EventArgs e)
        {
            Solution SOL = new Solution();
            SOL.Summary = txt_summary.Text;
            SOL.Message = txt_message.Text;
            SOL.Err_id = error_id;
            int BuildDetailsID = Solution.GetDetailsID(dataGridView1);
            //SqlParameter[] param1 = new SqlParameter[3]; 
            //param1[0] = PublicAdo.SqlAdo.AddParameter("buildno", SqlDbType.Int, CB_BuildNumber.SelectedValue);
            //param1[1] = PublicAdo.SqlAdo.AddParameter("hotfixno", SqlDbType.Int, CB_HotFix.SelectedValue);
            //param1[2] = PublicAdo.SqlAdo.AddParameter("Appid", SqlDbType.Int, App.SelectedValue);
           
            SOL.Add_solution(1, BuildDetailsID);
            MessageBox.Show("تم اضافة الحل");
            this.Close();
        }
        
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Solution_Summary_Load(object sender, EventArgs e)
        {
            iSFormLoad = true;

            App.DataSource = PublicAdo.SqlAdo.ReturnDataTableFromDataBase("TSH_GetApps");
            App.DisplayMember = "App_Name";
            App.ValueMember = "ID";

            CB_BuildNumber.DataSource = PublicAdo.SqlAdo.ReturnDataTableFromDataBase("TSH_view_buildno");
            CB_BuildNumber.ValueMember = "build_no";
            CB_BuildNumber.DisplayMember = "build_no";
            CB_BuildNumber.Text = "";
            CB_HotFix.Text = "";
            App.Text = "";
            iSFormLoad = false;
            //CB_BuildNumber_SelectedIndexChanged(sender, e);
        }

        private void CB_BuildNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!iSFormLoad)
            {
                CB_HotFix.Enabled = true;
                SqlParameter Param = PublicAdo.SqlAdo.AddParameter("buildno", SqlDbType.Int, CB_BuildNumber.SelectedValue);
                CB_HotFix.DataSource = PublicAdo.SqlAdo.ReturnDataTableFromDataBase("TSH_view_hotfix", Param);
                CB_HotFix.ValueMember = "hotfix_num";
                CB_HotFix.DisplayMember = "hotfix_num";
            }
        }

        private void CB_HotFix_SelectedIndexChanged(object sender, EventArgs e)
        {
            App.Enabled = true;
            
        }

        private void App_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!iSFormLoad)
            {
                SqlParameter[] param = new SqlParameter[3];
                param[0] = PublicAdo.SqlAdo.AddParameter("buildno", SqlDbType.Int, CB_BuildNumber.SelectedValue);
                param[1] = PublicAdo.SqlAdo.AddParameter("hotfixno", SqlDbType.Int, CB_HotFix.SelectedValue);
                param[2] = PublicAdo.SqlAdo.AddParameter("appid", SqlDbType.Int, App.SelectedValue);
                dataGridView1.DataSource = PublicAdo.SqlAdo.ReturnDataTableFromDataBase("TSH_get_builddetails", param);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = 0;
            for (int r = 0; r < dataGridView1.Rows.Count; r++)
                if (r != e.RowIndex && e.ColumnIndex == col)
                    dataGridView1[col, r].Value = false;
        }
    }
}

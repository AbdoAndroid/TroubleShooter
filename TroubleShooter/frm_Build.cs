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
    public partial class frm_Build : Form
    {
        bool iSFormLoad = false;
        public frm_Build()
        {
            InitializeComponent();
        }
        private void Build_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
             iSFormLoad = true;
            CB_Target.DataSource = PublicAdo.SqlAdo.ReturnDataTableFromDataBase("TSH_GetTarget");
            CB_Target.DisplayMember = "Name";
            CB_Target.ValueMember = "ID";

            App.DataSource = PublicAdo.SqlAdo.ReturnDataTableFromDataBase("TSH_GetApps");
            App.DisplayMember = "App_Name";
            App.ValueMember = "ID";

            Build_Type.DataSource = PublicAdo.SqlAdo.ReturnDataTableFromDataBase("TSH_GetBuildType");
            Build_Type.DisplayMember = "Name";
            Build_Type.ValueMember = "ID";
            
            Developer_Name.DataSource = PublicAdo.SqlAdo.ReturnDataTableFromDataBase("TSH_GetDeveloper");
            Developer_Name.DisplayMember = "Name";
            Developer_Name.ValueMember = "ID";
            
            Tester_Name.DataSource = PublicAdo.SqlAdo.ReturnDataTableFromDataBase("TSH_GetTester");
            Tester_Name.DisplayMember = "Name";
            Tester_Name.ValueMember = "ID";
            iSFormLoad = false;
            CB_Target_SelectedIndexChanged(sender, e);
        }

        private void CB_Target_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!iSFormLoad) { 
            SqlParameter param = new SqlParameter();
            param = PublicAdo.SqlAdo.AddParameter("ID", SqlDbType.Int, CB_Target.SelectedValue);
            var x = PublicAdo.SqlAdo.ExcuteScalarStatement("TSH_GetCode", param);
            txt_Code.Text = x.ToString() + DTP_date.Value.Date.ToString("yyyyMMdd"); 
            }
        }

        private void txt_Buildno_TextChanged(object sender, EventArgs e)
        {
            if (txt_Buildno.Text != "")
            { 

            SqlParameter param = new SqlParameter();
            param = PublicAdo.SqlAdo.AddParameter("buildno", SqlDbType.Int, Convert.ToInt32(txt_Buildno.Text));
            var x = PublicAdo.SqlAdo.ExcuteScalarStatement("TSH_gethotfix", param);
            txt_Hotfix.Text = x.ToString();
        }

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            SqlParameter[] param = new SqlParameter[4];
            param[0] = PublicAdo.SqlAdo.AddParameter("buildno", SqlDbType.Int, Convert.ToInt32(txt_Buildno.Text));
            param[1] = PublicAdo.SqlAdo.AddParameter("code", SqlDbType.VarChar, txt_Code.Text);
            param[2] = PublicAdo.SqlAdo.AddParameter("date", SqlDbType.DateTime, DTP_date.Value);
            param[3] = PublicAdo.SqlAdo.AddParameter("target", SqlDbType.Int, CB_Target.SelectedValue);
            var x = PublicAdo.SqlAdo.ExcuteScalarStatement("TSH_insert_Build", param);
            int y = dataGridView1.RowCount;

            for (int z = 0; ((z < y) && !(dataGridView1.Rows[z].IsNewRow)); z++)
            {
                
                SqlParameter[] param1 = new SqlParameter[7];
                param1[0] = PublicAdo.SqlAdo.AddParameter("buildno", SqlDbType.Int, Convert.ToInt32(txt_Buildno.Text));
                param1[1] = PublicAdo.SqlAdo.AddParameter("hotfix", SqlDbType.Int, Convert.ToInt32(x));
                param1[2] = PublicAdo.SqlAdo.AddParameter("Appid", SqlDbType.Int, int.Parse(dataGridView1.Rows[z].Cells[0].Value.ToString()));
                param1[3] = PublicAdo.SqlAdo.AddParameter("developerid", SqlDbType.Int, int.Parse(dataGridView1.Rows[z].Cells[3].Value.ToString()));

                if (dataGridView1.Rows[z].Cells[4].Value == null)
                {
                    param1[4] = PublicAdo.SqlAdo.AddParameter("testerid", SqlDbType.Int, DBNull.Value);

                }
                else
                {
                    param1[4] = PublicAdo.SqlAdo.AddParameter("testerid", SqlDbType.Int, dataGridView1.Rows[z].Cells[4].Value.ToString());

                }


                param1[5] = PublicAdo.SqlAdo.AddParameter("typeid", SqlDbType.Int, int.Parse(dataGridView1.Rows[z].Cells[1].Value.ToString()));
                param1[6] = PublicAdo.SqlAdo.AddParameter("details", SqlDbType.Text, dataGridView1.Rows[z].Cells[2].Value);
                PublicAdo.SqlAdo.ExcuteQueryStatement("TSH_ADD_BuildDetails", param1);
            }
            this.Close();

        }

        
    }
}

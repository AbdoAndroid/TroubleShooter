using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;
using PublicAdo;
using System.Data.SqlClient;

namespace TroubleShooter
{
    public partial class FrmNotSolvedProblems : Form
    {
        public FrmNotSolvedProblems()
        {
            InitializeComponent();
        }

        private void FrmNotSolvedProblems_Load(object sender, EventArgs e)
        {
            TmrProblems.Start();
            dataGridView1.DataSource = SqlAdo.ReturnDataTableFromDataBase("TSH_Get_Err");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.ColumnIndex == 0)
            {
                int s =Convert.ToInt32 (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value);
                string Type = (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 4].Value).ToString();
                Frm_Details so = new Frm_Details(s,Type);
                so.ShowDialog();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
               e.ColumnIndex == 1)
            {
                int s = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value);
                frm_Solution_Summary sm = new frm_Solution_Summary(s);
                sm.ShowDialog();
                //this.Refresh();
            }
            
        }

        private void addDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddStaff Add_Dev = new frmAddStaff(1);
            Add_Dev.ShowDialog();
        }

        private void TmrProblems_Tick(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SqlAdo.ReturnDataTableFromDataBase("TSH_Get_Err");
        }

        private void addBuildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Build b = new frm_Build();
            b.ShowDialog();
        }

        private void addTesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddStaff Add_tester = new frmAddStaff(2);
            Add_tester.ShowDialog();
        }

        private void addImplementorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddStaff Add_Implementor = new frmAddStaff(3);
            Add_Implementor.ShowDialog();
        }

        private void addAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd_App app = new frmAdd_App();
            app.ShowDialog();
        }


    }
}
    
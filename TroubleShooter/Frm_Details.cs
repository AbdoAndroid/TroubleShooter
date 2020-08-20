using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;
using PublicAdo;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace TroubleShooter
{
    public partial class Frm_Details : Form
    {
        int ID;
        public byte[] Thumb { set; get; }
        DataTable DT;
        string Type;
        bool Bug;

        #region Reports Parameters Feilds

        string companyNameAr;
        public string CompanyNameAr
        {
            get { return companyNameAr; }
            set { companyNameAr = value; }
        }

       /* string companyLogo;
        public string CompanyLogo
        {
            get { return companyLogo; }
            set { companyLogo = value; }
        }
        */
        string companyShortcutAr;
        public string CompanyShortcutAr
        {
            get { return companyShortcutAr; }
            set { companyShortcutAr = value; }
        }

        

        #endregion


        public Frm_Details(int ID,string Type)
        {
            this.ID = ID;
            this.Type = Type;
            InitializeComponent();
        }

        private void Frm_Details_Load(object sender, EventArgs e)
        {
            checkType();
            // TODO: This line of code loads data into the 'TroubleShooterDataSet2.Get_Details' table. You can move, or remove it, as needed.
            if (Bug)
            {
                reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rpt_Bug.rdlc";
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DtSetErrorRpt",SqlAdo.ReturnDataTableFromDataBase("TSH_Get_Details",SqlAdo.AddParameter("id",SqlDbType.Int,ID))));
                AddReportParams();
               
                
            }
            else
            {
                reportViewer1.LocalReport.ReportPath = Application.StartupPath +  @"\Reports\rpt_Error.rdlc";
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetErrorRpt", SqlAdo.ReturnDataTableFromDataBase("TSH_GetErrdetails", SqlAdo.AddParameter("id", SqlDbType.Int, ID))));
                AddReportParams();
            }
            this.reportViewer1.RefreshReport();
        }
        private void ViewBug(string Pro_name)
        {
            View(Pro_name);
            tbxdesc.Text = ("Error Message:" + DT.Rows[0][5].ToString()+ Environment.NewLine+ "Error Type:" + DT.Rows[0][7].ToString() +Environment.NewLine+ "Error Source:" + DT.Rows[0][8].ToString() + Environment.NewLine+"Stack Trace:" + DT.Rows[0][6].ToString());
        }
        private void ViewError(string Pro_name)
        {
            View(Pro_name);
            tbxdesc.Text = DT.Rows[0][5].ToString();
        }
        private void View(string ProName)
        {
            SqlParameter X = SqlAdo.AddParameter("id", SqlDbType.Int, ID);
            DT = SqlAdo.ReturnDataTableFromDataBase(ProName, X);
            if (DT.Rows.Count > 0)
            {
                Thumb = (byte[])(DT.Rows[0][4]);
                lblIP.Text = DT.Rows[0][0].ToString();
                lblOS.Text = DT.Rows[0][1].ToString();
                lblusername.Text = DT.Rows[0][2].ToString();
                ScreenCapture sc = new ScreenCapture();
                Pic_thumb.Image = sc.Arr2Img(Thumb);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            frm_Solution_Summary sm = new frm_Solution_Summary(ID);
            sm.ShowDialog();
        }


        private void checkType()
        {
            if(Type=="Bug")
            {
                Bug = true;
                ViewBug("Get_Details");

            }
            else
            {
                Bug = false;
                ViewError("Geterrdetails");
            }
        }


        private void AddReportParams()
        {
            Computer_config config=new Computer_config();
            

            Microsoft.Reporting.WinForms.ReportParameter _CompanyNameAr = new Microsoft.Reporting.WinForms.ReportParameter("CompanyNameAr", CompanyNameAr);
            Microsoft.Reporting.WinForms.ReportParameter _CompanyLogo = new Microsoft.Reporting.WinForms.ReportParameter("CompanyLogo", "zzz");
            Microsoft.Reporting.WinForms.ReportParameter _CompanyShortcutAr = new Microsoft.Reporting.WinForms.ReportParameter("CompanyShortcutAr", CompanyShortcutAr);
            Microsoft.Reporting.WinForms.ReportParameter _AppUser = new Microsoft.Reporting.WinForms.ReportParameter("AppUser", Implementor.Dev_User_Name);
            Microsoft.Reporting.WinForms.ReportParameter _DeviceUser = new Microsoft.Reporting.WinForms.ReportParameter("DeviceUser", config.get_username());

            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { _CompanyNameAr, _CompanyLogo, _CompanyShortcutAr, _AppUser, _DeviceUser });
            
        }
    }
}

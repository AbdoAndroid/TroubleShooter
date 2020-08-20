using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;
using TroubleShooter.DeveloperSide;

namespace TroubleShooter
{
    public partial class frmUserError : Form
    {
        
        public frmUserError()
        {
            InitializeComponent();
        }


        private void rdbtnUserError_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int rdBtnStatus = 0;
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is RadioButton)
                {
                    if (rdbtnUserError.Checked)
                        rdBtnStatus = Convert.ToInt32(rdbtnUserError.Tag);
                    else if (rdbtnEditData.Checked)
                        rdBtnStatus = Convert.ToInt32(rdbtnEditData.Tag);
                    else
                        rdBtnStatus = Convert.ToInt32(rdbtnAddProperty.Tag);
                }
            }
            ScreenCapture s = new ScreenCapture();
            Computer_config C = new Computer_config();
            Error E = new Error(askforhelp.__User_id,askforhelp.__User_name,askforhelp.__App_id,askforhelp.__App_name,C.get_IP(),C.get_mac(),C.get_OS(),C.get_username(),rdBtnStatus,textBox1.Text,s.Img2Arr(askforhelp.__img),s.Img2Arr(askforhelp.__thumbimg));
            int aff = E.Send_Err();
            if (aff > 0)
                MessageBox.Show("تم ارسال الشكوى بنجاح");
            else
                MessageBox.Show("حدث خطأ فى ارسال الشكوى");
            this.Close();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkLblDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSignIn SignIn = new FrmSignIn();
            SignIn.Show();
            this.Close();
        }
    }
}

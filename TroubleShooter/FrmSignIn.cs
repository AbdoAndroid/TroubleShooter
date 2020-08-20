using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace TroubleShooter.DeveloperSide
{
    public partial class FrmSignIn : Form
    {
        Implementor dev;

        public FrmSignIn()
        {
            InitializeComponent();
            tbxUserName.Select();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (check())
            {
                dev = new Implementor();
                dev.UserName = tbxUserName.Text;
                dev.Password = tbxPassword.Text;

                if (dev.LogIn())
                {
                    Implementor.Dev_User_Name = dev.UserName;
                    FrmNotSolvedProblems Problems = new FrmNotSolvedProblems();
                    Problems.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid User Name or password");
                    tbxUserName.Clear();
                    tbxPassword.Clear();
                }
            }
        }

        private bool check()
        {
            if (tbxUserName.Text == string.Empty && tbxPassword.Text != string.Empty )
            {
                MessageBox.Show("Please inter your user Name");
            }
            else if (tbxUserName.Text != string.Empty && tbxPassword.Text == string.Empty)
            {
                MessageBox.Show("Please inter your password");
            }
            else if (tbxUserName.Text == string.Empty && tbxPassword.Text == string.Empty)
            {
                MessageBox.Show("please inter your userName and password");
            }
            else
            {
                return true;
            }
            return false;
        }
    }
}

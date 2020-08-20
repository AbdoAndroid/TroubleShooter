using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace TroubleShooter
{
    public partial class frmAddStaff : Form
    {


        int type;
        public frmAddStaff()
        {
            InitializeComponent();
        }
        public frmAddStaff(int type)
        {
            InitializeComponent();
            this.type = type;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (check())
            {
                Implementor Add = new Implementor();
                Add.Name = tbxName.Text;
                Add.Password = tbxPassword.Text;
                Add.UserName = tbxUserName.Text;
                int AffectedRows = Add.AddDeveloper(this.type);
                if (AffectedRows>0)
                {
                    MessageBox.Show("Developer Added successfully","Successfully Added",MessageBoxButtons.OK);
                }
                else if (AffectedRows==0)
                {
                    MessageBox.Show("This developer is already exist","Already exist",MessageBoxButtons.OK);
                }
                     
                else
                {
                    MessageBox.Show("Adding Develoer procees failed\nYou can try again later", "Adding Failed", MessageBoxButtons.OK);
                }
                tbxName.Clear();
                tbxPassword.Clear();
                tbxUserName.Clear();
            }
            
            
        }
        /// <summary>
        /// function makes sure that the information has been already intered
        /// </summary>
        /// <returns>true if all information intered, else false</returns>
        private bool check()
        {
            if (tbxUserName.Text==string.Empty&&tbxPassword.Text!=string.Empty&&tbxName.Text!=string.Empty)
            {
                MessageBox.Show("Please inter the User Name you wanna login with later");
            }
            else if (tbxUserName.Text != string.Empty && tbxPassword.Text == string.Empty && tbxName.Text != string.Empty)
            {
                MessageBox.Show("it's important to inter a password");
            }
            else if (tbxUserName.Text != string.Empty && tbxPassword.Text != string.Empty && tbxName.Text == string.Empty)
            {
                MessageBox.Show("please inter your name");
            }
            else if (tbxUserName.Text == string.Empty && tbxPassword.Text == string.Empty && tbxName.Text == string.Empty)
            {
                MessageBox.Show("Complete All information");
            }
            else if(!(tbxUserName.Text == string.Empty || tbxPassword.Text != string.Empty || tbxName.Text != string.Empty))
            {
                MessageBox.Show("Please inter your Name and a password");
            }
            else if (!(tbxUserName.Text != string.Empty || tbxPassword.Text == string.Empty || tbxName.Text != string.Empty))
            {
                MessageBox.Show("please inter your Name and the user Name");
            }
            else if (!(tbxUserName.Text != string.Empty || tbxPassword.Text != string.Empty || tbxName.Text == string.Empty))
            {
                MessageBox.Show("please inter your User name and password");
            }
            else
            {
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TroubleShooter
{
    public partial class frmAdd_App: Form
    {
        public frmAdd_App()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.ID = int.Parse(tbxID.Text);
            app.Name = tbxName.Text;
            int Aff= app.Add();
            if (Aff>0)
            {
                MessageBox.Show("App Added Successfuly");
            }
        }
    }
}

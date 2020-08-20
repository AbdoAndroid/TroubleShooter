using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;
using System.Data.SqlClient;
using TroubleShooter;
namespace Testapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            askforhelp ask = new askforhelp();
            
            ToolStripControlHost tsch = new ToolStripControlHost(ask);
            statusStrip1.Items.Add(tsch);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        private bool ExistError()
        {
            
           /* if (object == DBNull.Value)
            {
                return false;
            }*/
            return true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        static void trial()
        {
            
        }


    }
}

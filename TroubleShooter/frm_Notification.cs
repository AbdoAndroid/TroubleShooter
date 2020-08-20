using RatingControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace TroubleShooter
{
    
    public partial class frm_Notification : Form
    {
        string Noti_message = "";
        int Solution_ID;
        private StarRatingControl m_starRatingControl = new StarRatingControl();
        public frm_Notification()
        {
            InitializeComponent();
            m_starRatingControl.StarCount = 10;
            m_starRatingControl.Top = 50;
            m_starRatingControl.Left = 20;
            m_starRatingControl.Width = 300;
            m_starRatingControl.StarSpacing = 10;
            Controls.Add(m_starRatingControl);
        }
        public frm_Notification(string Noti, int Sol_id)
        {
            InitializeComponent();
            Noti_message = Noti;
            Solution_ID = Sol_id;
            m_starRatingControl.StarCount = 10;
            m_starRatingControl.Top = 150;
            m_starRatingControl.Left = 20;
            m_starRatingControl.Width = 250;
            m_starRatingControl.StarSpacing = 7;
            Controls.Add(m_starRatingControl);
        }
        Rectangle screenWorkingArea;
        private void frm_Notification_Load(object sender, EventArgs e)
        {
            textBox1.Text = Noti_message;
            screenWorkingArea = System.Windows.Forms.Screen.GetWorkingArea(new Point(0, 0));

            this.Location = new Point(screenWorkingArea.Width - this.Width, screenWorkingArea.Height);
            timerShowMessage.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerShowMessage.Interval = 1;
            if (this.Location.Y <= ((screenWorkingArea.Height - 20) - this.Height))
            {
                timerShowMessage.Enabled = false;
                return;
            }
            this.Location = new Point(this.Location.X, this.Location.Y - 1);
        }

        private void btnrate_Click(object sender, EventArgs e)
        {
            int rate = m_starRatingControl.SelectedStar;
            Solution.Rating(rate,Solution_ID);
            this.Close();
        }
    }
}

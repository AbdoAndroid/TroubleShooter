using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TroubleShooter;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                MessageBox.Show((num1+num2).ToString());
            }
            catch (Exception)
            {
                  Image img ;
                  Image thumbimg ;
                  ScreenCapture sc = new ScreenCapture();
                  img = sc.CaptureScreen();
                  thumbimg = sc.CreateThumbnail(img, 150, 150);
                  byte[] image = sc.Img2Arr(img);
                  byte[] thumbnaile = sc.Img2Arr(thumbimg);
                  CatchBug Bug = new CatchBug(20, "iokh", "wehgisdakb", "iwjhskn", "kjhdbkz,c", "huijksvb", image, thumbnaile);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Form33 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
   int nLeftRect,     // x-coordinate of upper-left corner
   int nTopRect,      // y-coordinate of upper-left corner
   int nRightRect,    // x-coordinate of lower-right corner
   int nBottomRect,   // y-coordinate of lower-right corner
   int nWidthEllipse, // height of ellipse
   int nHeightEllipse // width of ellipse
);

        public Form33()
        {
            
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            CProgressBar1.Value = 0;

        }

        //public string[] dots = {"..","...","..." };
        private void timer1_Tick(object sender, EventArgs e)
        {
            CProgressBar1.Value += 5;
            
            if (CProgressBar1.Value < 100)
            {

                CProgressBar1.Text = CProgressBar1.Value.ToString() + "%";
            }
            if(CProgressBar1.Value == 100)
            {
                CProgressBar1.Text = "";
                pictureBox1.Visible = true;
                label2.Text = "TAMAMLANDI";
            }
            if (CProgressBar1.Value == 140)
            {
                this.Close();
            }
            //for (int i=0; i < dots.Length - 1; i++)
            //{
            //    label2.Text = label2.Text + dots[i];

            //    if (i == 2)
            //    {
            //        i = 0;
            //    }
            //}





        }
    }
}

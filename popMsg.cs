using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    public partial class popMsg : Form
    {
        private System.Windows.Forms.Timer loginTimer = new System.Windows.Forms.Timer();
        int loadTime;
        public popMsg(string msg, string pop)
        {
            InitializeComponent();        
            loginMsg.Text = msg;
            msgPop.Text = pop;
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (loadTime < 100)
            {
                loadTime += 1;
            }
            else {
            if (loadTime == 100)
                {
                    timer1.Stop();
                    timer2.Stop();
                    this.Close();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Opacity += .2;
        }
    }
}

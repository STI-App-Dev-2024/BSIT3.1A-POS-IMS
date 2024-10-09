using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           Opacity += .2;
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                progPercent.Text = progressBar1.Value.ToString() + "%";
            }

            else {
                if(progressBar1.Value == 100) 
                {
                    timer2.Stop();

                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
            }
        }
    }
}

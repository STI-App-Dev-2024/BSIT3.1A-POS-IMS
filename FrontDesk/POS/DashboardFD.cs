using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.FrontDesk.POS
{
    public partial class DashboardFD : Form
    {
        bool sidebarExpand = true;
        public Point mouseLocation;
        public DashboardFD()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.mainpanelFD.Controls.Count > 0)
                this.mainpanelFD.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanelFD.Controls.Add(f);
            this.mainpanelFD.Tag = f;
            f.Show();
        }
        private void btnHamFD_Click(object sender, EventArgs e)
        {
            sideBarTransition.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarFD.Width -= 10;
                if (sidebarFD.Width <= 54)
                {
                    sidebarExpand = false;
                    sideBarTransition.Stop();
                }
            }
            else
            {
                sidebarFD.Width += 10;
                if (sidebarFD.Width >= 200)
                {
                    sidebarExpand = true;
                    sideBarTransition.Stop();
                }
            }
        }

        private void btnDashBoardFD_Click(object sender, EventArgs e)
        {
            loadform(new posField());
        }

        private void btnInventoryFD_Click(object sender, EventArgs e)
        {
            loadform(new Inventory());
        }
    }
}


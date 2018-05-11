using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeckAngel
{
    public partial class Form1 : Form
    {
        public static int Interval = 10;
        public static string CustomString = "펴";
        Timer t;
        public Form1()
        {
            InitializeComponent();
            t = new Timer()
            {
                Interval = 1000 * Interval,
                Enabled = true
            };
            t.Tick += T_Tick;
            t.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(3000, "요정", CustomString, ToolTipIcon.None);
        }

        private void 설정SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Settings().ShowDialog();
        }

        private void 종료QToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            설정SToolStripMenuItem_Click(null, null);
        }
    }
}

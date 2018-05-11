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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            this.numericUpDown1.Value = Form1.Interval;
            this.textBox1.Text = Form1.CustomString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Interval = (int)numericUpDown1.Value;
            Form1.CustomString = textBox1.Text;
            this.Close();
        }
    }
}

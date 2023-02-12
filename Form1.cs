using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Cronometro
{
    public partial class Form1 : Form
    {
        private Stopwatch stopwatch;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
            this.CenterToScreen();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = string.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }
    }
}

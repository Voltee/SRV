using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Срв1
{
    public partial class Form1 : Form
    {
        MainTimer mt;
        TimeSpan elapsed;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mt = new MainTimer(pnl_main,ch_divide);
            mt.timer.Tick += OnTick;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            mt.tStart();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            mt.tStop();
           
        }

        private void btn_rand_Click(object sender, EventArgs e)
        {
            mt.rand();
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            mt.tRestart();
            elapsed = new TimeSpan(0, 0, 0, 0, 0);
            label1.Text = string.Format("{0} : {1} : {2}", elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds);
        }

        void OnTick(object sender , EventArgs e) {
            elapsed = elapsed.Add(new TimeSpan(0, 0, 0, 0, mt.timer.Interval));
            
            label1.Text = string.Format("{0} : {1} : {2}",elapsed.Minutes,elapsed.Seconds,elapsed.Milliseconds);
        }

    }
}

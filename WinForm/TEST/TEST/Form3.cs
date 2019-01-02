using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progress_1.Increment(1);
            this.lable_time.Text = this.progress_1.Value.ToString();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.progress_1.Value = 0;
        }
    }
}

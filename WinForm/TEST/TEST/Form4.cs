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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
        Pen red = new Pen(Color.Red);
        Pen green = new Pen(Color.Green);
        System.Drawing.SolidBrush fillRed = new SolidBrush(Color.Red);
        System.Drawing.SolidBrush fillYellow = new SolidBrush(Color.Yellow );
        Rectangle rect = new Rectangle(20,20,220,90);
        Rectangle circle = new Rectangle(20,20,220,90);
        private void Form4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

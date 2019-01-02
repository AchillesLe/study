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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_send_1_Click(object sender, EventArgs e)
        {
            Form2 Child = new Form2();      
            Child.Sender(this.txt_message_1.Text);    
            Child.Show();
        }
    }
}

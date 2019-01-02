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
    public partial class Form2 : Form
    {
        public delegate void SendMessage(string Message);
        public SendMessage Sender;
        public Form2()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }

        private void btn_send_2_Click(object sender, EventArgs e)
        {

        }
        private void GetMessage(string Message)
        {
            this.txt_message_2.Text = Message;
        }
    }
}

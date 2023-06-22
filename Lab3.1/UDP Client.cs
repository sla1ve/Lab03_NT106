using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Lab2
{
    public partial class Form2 : Form
    {
        UdpClient udpClient;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Send(object sender, EventArgs e)
        {
            int Port = Int32.Parse(txtPort.Text);
            UdpClient udpClient = new UdpClient();
            Byte[] sendBytes = Encoding.UTF8.GetBytes(txtMessage.Text);
            udpClient.Send(sendBytes, sendBytes.Length, txtRemoteIP.Text, Port);
            txtMessage.Text = "";
        }
    }
}

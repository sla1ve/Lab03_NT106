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
using System.Threading;

namespace Lab2
{
    public partial class Form1 : Form
    {
        UdpClient udpServer;
        Thread serverThread;

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        public void ServerThread()
        {
            int port = int.Parse(txtPort.Text);
            UdpClient udpClient = new UdpClient(port);
            IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);

            while (true)
            {
                Byte[] receivedBytes = udpClient.Receive(ref remoteEndPoint);
                string mesg = Encoding.UTF8.GetString(receivedBytes);

                txtReceivedMessages.Text += remoteEndPoint.Address + ": " + mesg + "\n";
            }
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            Thread udpServerThread = new Thread(new ThreadStart(ServerThread));
            udpServerThread.Start();
            udpServerThread.IsBackground = true;
        }
    }
}

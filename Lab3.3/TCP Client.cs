using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3._3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        TcpClient tcpClient;
        NetworkStream ns;
        //IPEndPoint ip; 
        //Socket client; 

        void connect()
        {

            //ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            tcpClient.Connect("127.0.0.1", 8080);

            /*
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipEndPoint = new IPEndPoint (ipAddress, 8080);
            tcpClient.Connect (ipEndPoint);
            ns = tcpClient.GetStream ();
            */
        }

        void sendData()
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes("Hello Server\n");
            ns.Write(data, 0, data.Length);
        }

        void closeClient()
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes("Quit\n");
            ns.Write(data, 0, data.Length);
            ns.Close();
            tcpClient.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            tcpClient = new TcpClient();
            connect();
            ns = tcpClient.GetStream();
            sendData();
            closeClient();
        }
    }
}

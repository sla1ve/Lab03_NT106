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

namespace Lab3._2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            btnDisconnect.Enabled = false;
            btnSend.Enabled = false;
        }

        IPEndPoint ip;
        Socket client;

        void connect()
        {
            ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(ip);
            }
            catch
            {
                MessageBox.Show("Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread listen = new Thread(receive);
            listen.IsBackground = true;
            listen.Start();
        }

        void close()
        {
            client.Close();
        }

        void sent()
        {
            if (txtMessages.Text != string.Empty)
                client.Send(Ser(txtMessages.Text));
        }

        void receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)Deser(data);

                }
            }
            catch { close(); }
        }

        byte[] Ser(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        object Deser(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            connect();
            btnConnect.Enabled = false;
            btnSend.Enabled = true;
            btnDisconnect.Enabled = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (btnDisconnect.Enabled == true)
            {
                sent();
                txtMessages.Clear();
            }
            else MessageBox.Show("You not connect, try to connect again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            close();
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
        }
    }
}

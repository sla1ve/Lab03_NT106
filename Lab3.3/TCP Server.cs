using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Windows.Forms.AxHost;


namespace Lab3._3
{
    public partial class Form2 : Form
    {
        IPEndPoint ip;
        Socket sever;
        List<Socket> client_list;

        void connect()
        {
            client_list = new List<Socket>();
            ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            sever.Bind(ip);
            Thread lisiten = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        sever.Listen(100);
                        Socket client = sever.Accept();
                        client_list.Add(client);

                        Thread Receive = new Thread(receive);
                        Receive.IsBackground = true;
                        Receive.Start(client);
                    }
                }
                catch
                {
                    ip = new IPEndPoint(IPAddress.Any, 0);
                    sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }

            });

            lisiten.IsBackground = true;
            lisiten.Start();
        }
        void receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deser(data);

                    foreach (Socket iteam in client_list)
                    {
                        if (iteam != null && iteam != client)
                            iteam.Send(Ser(message));
                    }

                    listMessages.Items.Add(new ListViewItem() { Text = ("From Client: " + message) });

                }
            }
            catch
            {
                client_list.Remove(client);
                client.Close();
            }
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


        public Form2()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            connect();
            listMessages.Items.Add(new ListViewItem() { Text = "Server running on `127.0.0.1`:8080\n" });
            listMessages.Items.Add(new ListViewItem() { Text = "New client connected\n" });
            btnListen.Enabled = false;

        }
    }
}

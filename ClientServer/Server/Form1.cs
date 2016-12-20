using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TcpListener myList;
        private Thread sThread;

        private void bStart_Click(object sender, EventArgs e)
        {
            try
            {
                // Init of IP and port
                string IP = tbIP.Text;
                int Port = int.Parse(tbPort.Text);

                IPAddress hostIP = IPAddress.Parse(IP);
                myList = new TcpListener(hostIP, Port);

                // Start "running" server - TcpListener will listen for incoming connections
                myList.Start();
                WriteToStatus("Server started\r\n");

                // We will handle incoming connections in a thread
                sThread = new Thread(new ThreadStart(ServerRun));
                sThread.IsBackground = true;
                sThread.Start();
            }
            catch (Exception)
            {
                WriteToStatus("Error starting server.\r\n");
            }

        }

        private void bStop_Click(object sender, EventArgs e)
        {
            try
            {
                // Stop thread and listener
                if (sThread != null) sThread.Suspend();
                if (myList != null) myList.Stop();
                WriteToStatus("Server stopped\r\n");
            }
            catch (Exception)
            {
                WriteToStatus("Error stopping server.\r\n");
            }

        }

        public void WriteToStatus(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(WriteToStatus), new object[] { value });
                return;
            }
            tbStatus.AppendText(value);
        }

        private void ServerRun()
        {
            Socket client;
            while (true)
            {
                try
                {
                    // Wait for incoming connection
                    client = myList.AcceptSocket();
                    WriteToStatus("Connection accepted from " + client.RemoteEndPoint + "\r\n");

                    // Handle connection in a thread
                    Task.Factory.StartNew(() =>
                    {
                        Process(client);
                    });
                }
                catch (Exception)
                {
                    WriteToStatus("Error while connecting.\r\n");
                }
            }
        }

        private void Process(Socket socket)
        {
            try
            {
                byte[] bytes = new byte[1024];

                // get data from client
                int bytesRec = socket.Receive(bytes);
                string data = Encoding.ASCII.GetString(bytes, 0, bytesRec);


                // TODO: Handle and store received data
                // TODO: Return chat history data


                // reply to client
                byte[] msg = Encoding.ASCII.GetBytes("Data received");
                socket.Send(msg);

                // stop connection
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
            catch (Exception)
            {
                WriteToStatus("Error communicating with the client.\r\n");
            }

        }
    }
}

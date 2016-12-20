using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private Socket socket;

        private void bConnect_Click(object sender, EventArgs e)
        {
            // TODO: Add timer logic start here
        }

        private void bDisconnect_Click(object sender, EventArgs e)
        {
            // TODO: Add timer stop logic here
        }

        private void GetChatFromServer()
        {
            // TODO: Add request to server for chat history here
            // HINT: messageToSend = "GET_CHAT_DATA" + Some_Time;
        }

        private bool OpenConnection()
        {
            try
            {
                string IP = tbIP.Text;
                int Port = int.Parse(tbPort.Text);

                IPAddress serverIP = IPAddress.Parse(IP);
                IPEndPoint remoteEndPoint = new IPEndPoint(serverIP, Port);

                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                socket.Connect(remoteEndPoint);
                tbChat.AppendText("Connected to" + socket.RemoteEndPoint.ToString() + "\r\n");
                return true;
            }
            catch (Exception exception)
            {
                tbChat.AppendText(exception.ToString());
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                tbChat.AppendText("Disconnected from" + socket.RemoteEndPoint.ToString() + "\r\n");
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                return false;
            }
            catch (Exception exception)
            {
                tbChat.AppendText(exception.ToString());
                return false;
            }
        }

        private bool SendMessage()
        {
            try
            {
                byte[] bytes = new byte[1024];


                // sends the text
                string messageToSend = "[" + tbName.Text + "]: " + tbMessage.Text;

                byte[] msg = Encoding.ASCII.GetBytes(messageToSend);
                int bytesSent = socket.Send(msg);

                // receives text from server
                int bytesRec = socket.Receive(bytes);
                string messageReceived = Encoding.ASCII.GetString(bytes, 0, bytesRec);

                // Updates text box
                tbChat.AppendText(messageToSend + "\r\n");
                tbChat.AppendText(messageReceived + "\r\n");
                return true;
            }
            catch (Exception exception)
            {
                tbChat.AppendText(exception.ToString());
                return false;
            }
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            if (!OpenConnection()) return;
            SendMessage();
            CloseConnection();
            
        }
    }
}

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

namespace SimpleServerHTTP
{
    public partial class RegisteredUsers : Form
    {

        private Socket httpServer;
        private int serverPort = 80;
        private Thread thread;

        public RegisteredUsers()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            registerLog.Text = "";

            try
            {
                httpServer = new Socket(SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    serverPort = int.Parse(serverPortText.Text.ToString());

                    if (serverPort > 65535 || serverPort <= 0)
                    {
                        throw new Exception("Server port not in range");
                    }
                }
                catch (Exception exception)
                {
                    serverPort = 80;
                    registerLog.Text = "Server failed to start in port \n";
                }

                thread = new Thread(new ThreadStart(this.connectionThreadMethod));
                thread.Start();

                startButton.Enabled = false;
                stopButton.Enabled = true;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error starting the server");
                registerLog.Text = "Server failed to start \n";
            }

            registerLog.Text = "Server started";
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            try
            {
                httpServer.Close();

                thread.Abort();

                startButton.Enabled = true;
                stopButton.Enabled = false;

            }
            catch (Exception exception)
            {
                Console.WriteLine("Stopping has failed");
            }
        }

        private void RegisteredUsers_Load(object sender, EventArgs e)
        {
            stopButton.Enabled = false;
        }

        private void connectionThreadMethod()
        {
            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, serverPort);
                httpServer.Bind(endPoint);
                httpServer.Listen(1);
                listenForConnection();
            }
            catch
            {
                Console.WriteLine("Could not start");
            }
        }

        private void listenForConnection()
        {
            while(true)
            {
                DateTime time = DateTime.Now;
                String data = "";
                byte[] bytes = new byte[2048];

                Socket client = httpServer.Accept();

                while(true)
                {
                    int numBytes = client.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, numBytes);

                    if (data.IndexOf("\r\n") > -1)
                        break;
                }

                registerLog.Invoke((MethodInvoker) delegate
                {
                    registerLog.Text += "\r\n\r\n";
                    registerLog.Text += data;
                    registerLog.Text += "\n\n ------- End of Request -------";
                });

                String resHeader = "HTTP/1.1 200 Everything is Fine\nServer: my_csharp_server\nContent-Type: text/html; charset: UTF-8\n\n";
                String resBody = "<!DOCTYE html>" + 
                    "<html><head><title>User Server</title></head>" +
                    "<body>" +
                    "<h4>Server Time is: " + time.ToString() + "</h4>" +
                    "<h5>Registered Users: " + "</h5>" +
                    "</body>" +
                    "</html>";

                String resStr = resHeader + resBody;

                byte[] resData = Encoding.ASCII.GetBytes(resStr);

                client.SendTo(resData, client.RemoteEndPoint);

                client.Close();
            }
        }
    }
}

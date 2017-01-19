using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace SocketChat
{
    public partial class SocketChatForm : Form
    {
        //ip地址
        private static string ipString = "127.0.0.1";
        //端口号
        private static int socketPortNum = 6004;
        private static Socket serverSocket;
        private static Socket clientOfServerSocket;
        private static byte[] serverRcvMsgByte = new byte[1024];

        private static byte[] clientRcvMsgByte = new byte[1024];
        private static Socket clientSocket = null;

        private bool isClient = false;
        private bool isServer = false;

        private string nickName = "";

        public SocketChatForm()
        {
            InitializeComponent();
        }

        private void SocketChatForm_Load(object sender, EventArgs e)
        {
            //获取ip地址
            GetAddressIP();
        }

        private void GetAddressIP()
        {
            ///获取本地的IP地址
            string AddressIP = string.Empty;
            foreach (IPAddress _IPAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (_IPAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    AddressIP = _IPAddress.ToString();
                }
            }

            IPStringLabel.Text = AddressIP;
            ipString = AddressIP;
        }

        private void createServerButton_Click(object sender, EventArgs e)
        {
            //设置ip地址
            IPAddress ip = IPAddress.Parse(ipString);
            //获得端口号
            socketPortNum = Convert.ToInt32(socketPortTextBox.Text);
            //新建服务端
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Bind(new IPEndPoint(ip, socketPortNum));
            serverSocket.Listen(10);

            ServerGroupBox.Enabled = false;
            clientGroupBox.Enabled = false;

            isServer = true;
            isClient = false;

            nickName = serverNickNameTextBox.Text;
            if (nickName == "")
            {
                nickName = ipString;
            }

            serverBgWorker.RunWorkerAsync();
        }

        private void serverBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            clientOfServerSocket = serverSocket.Accept();
            while (true)
            {
                try
                {
                    //通过clientSocket接收数据
                    int receiveNumber = clientOfServerSocket.Receive(serverRcvMsgByte);

                    //如果接收到了数据
                    if (receiveNumber > 0)
                    {
                        ////更新指示灯图片的状态
                        //if (!rcvTimer.Enabled)
                        //{
                        //    Invoke((MethodInvoker)delegate
                        //    {
                        //        rcvPicture.BackgroundImage = Properties.Resources.greenlight;
                        //        rcvTimer.Start();
                        //    });
                        //}

                        Invoke((MethodInvoker)delegate
                        {
                            string rcvString = Encoding.Unicode.GetString(serverRcvMsgByte);
                            rcvMsgTextBox.AppendText(rcvString);
                            rcvMsgTextBox.AppendText("\n");
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    clientOfServerSocket.Shutdown(SocketShutdown.Both);
                    clientOfServerSocket.Close();
                    break;
                }
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl.SelectedTab == createComPage)
            {
                this.Size = new Size(347, 488);
                tabControl.Size = new Size(307, 425);
            }
            else if(tabControl.SelectedTab == msgPage)
            {
                this.Size = new Size(563, 488);
                tabControl.Size = new Size(520, 425); 
            }
        }

        private void createClientButton_Click(object sender, EventArgs e)
        {
            // 设定服务器ip地址
            IPAddress ip = IPAddress.Parse(IPServerTextBox.Text);
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                //配置服务器IP与端口  
                clientSocket.Connect(new IPEndPoint(ip, Convert.ToInt32(serverSocketPortTextBox.Text))); 
            }
            catch
            {
                MessageBox.Show("连接服务器失败!");
                this.Close();
            }

            ServerGroupBox.Enabled = false;
            clientGroupBox.Enabled = false;

            isClient = true;
            isServer = false;

            nickName = clientNickNameTextBox.Text;
            if (nickName == "")
            {
                nickName = ipString;
            }


            clientBgWorker.RunWorkerAsync();
        }

        private void clientBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                int receiveLength = clientSocket.Receive(clientRcvMsgByte);
                if (receiveLength > 0)
                    Invoke((MethodInvoker)delegate
                    {
                        rcvMsgTextBox.AppendText(Encoding.Unicode.GetString(clientRcvMsgByte, 0, receiveLength));
                        rcvMsgTextBox.AppendText("\n");
                    });
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            sendMessage();
        }


        private void sendMessage()
        {
            if (isServer && !isClient)
            {
                string sendMsg = nickName + "\r\n" + "    " + sendTextBox.Text + '\0';
                try
                {
                    clientOfServerSocket.Send(Encoding.Unicode.GetBytes(sendMsg), SocketFlags.None);
                    rcvMsgTextBox.AppendText(sendMsg);
                    rcvMsgTextBox.AppendText("\n");
                    serverRcvMsgByte.Initialize();
                    sendTextBox.Clear();
                }
                catch
                {
                    clientOfServerSocket.Shutdown(SocketShutdown.Both);
                    clientOfServerSocket.Close();
                    MessageBox.Show("发送失败!");
                }
            }
            else if (isClient && !isServer)
            {
                string sendMsg = nickName + "\r\n" + "    " + sendTextBox.Text + '\0';
                try
                {

                    clientSocket.Send(Encoding.Unicode.GetBytes(sendMsg), SocketFlags.None);
                    rcvMsgTextBox.AppendText(sendMsg);
                    rcvMsgTextBox.AppendText("\n");
                    clientRcvMsgByte.Initialize();
                    sendTextBox.Clear();
                }
                catch
                {
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                    MessageBox.Show("发送失败!");
                }
            }
            else if (!isServer && !isClient)
            {
                MessageBox.Show("请先建立连接！");
            }
        }

        private void sendTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                sendMessage();
        }
    }
}

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

            this.Text += "-成功新建聊天！";

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
                    int receiveLength = clientOfServerSocket.Receive(serverRcvMsgByte);

                    //如果接收到了数据
                    if (receiveLength > 0)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            string serverRcvMsg = Encoding.Unicode.GetString(serverRcvMsgByte, 0, receiveLength);
                            if (serverRcvMsg[0] == ' ')
                                rcvMsgTextBox.SelectionColor = Color.Black;
                            else
                                rcvMsgTextBox.SelectionColor = Color.BlueViolet;

                            System.Media.SoundPlayer souderPlayer = new System.Media.SoundPlayer(Properties.Resources.msg);
                            souderPlayer.Play();        

                            rcvMsgTextBox.AppendText(serverRcvMsg);
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
                this.Size = new Size(347, 503);
                tabControl.Size = new Size(307, 425);
            }
            else if(tabControl.SelectedTab == msgPage)
            {
                this.Size = new Size(563, 503);
                tabControl.Size = new Size(520, 425); 
            }
        }

        private void createClientButton_Click(object sender, EventArgs e)
        {
            // 设定服务器ip地址
            IPAddress ip = IPAddress.Parse(IPServerComboBox.Text);
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

            this.Text += "--成功加入聊天！";

            clientBgWorker.RunWorkerAsync();
        }

        private void clientBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                int receiveLength = clientSocket.Receive(clientRcvMsgByte);
                if (receiveLength > 0)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        string clientRcvMsg = Encoding.Unicode.GetString(clientRcvMsgByte, 0, receiveLength);
                        if (clientRcvMsg[0] == ' ')
                            rcvMsgTextBox.SelectionColor = Color.Black;
                        else
                            rcvMsgTextBox.SelectionColor = Color.BlueViolet;

                        System.Media.SoundPlayer souderPlayer = new System.Media.SoundPlayer(Properties.Resources.msg);
                        souderPlayer.Play();

                        rcvMsgTextBox.AppendText(clientRcvMsg);
                        rcvMsgTextBox.AppendText("\n");
                    });
                }
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            sendMessage();
        }


        private void sendMessage()
        {
            int endPointIndex = rcvMsgTextBox.Text.Length;

            string senderInformation = nickName + "    " + DateTime.Now;
            string senderText = "    " + sendTextBox.Text;
            string sendMsg = senderInformation + "\r\n" + senderText + '\0';

            if (isServer && !isClient)
            {          
                try
                {
                    clientOfServerSocket.Send(Encoding.Unicode.GetBytes(senderInformation), SocketFlags.None);
                    clientOfServerSocket.Send(Encoding.Unicode.GetBytes(senderText), SocketFlags.None);
                }
                catch
                {
                    MessageBox.Show("发送失败!请确保已有用户连接！", "错误");
                }
            }
            else if (isClient && !isServer)
            {
                try
                {
                    clientSocket.Send(Encoding.Unicode.GetBytes(senderInformation), SocketFlags.None);
                    clientSocket.Send(Encoding.Unicode.GetBytes(senderText), SocketFlags.None);
                }
                catch
                {
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                    MessageBox.Show("发送失败!");
                }
            }

            if(isClient || isServer)
            {
                rcvMsgTextBox.SelectionColor = Color.ForestGreen;
                rcvMsgTextBox.AppendText (senderInformation);
                rcvMsgTextBox.AppendText("\r\n");
                rcvMsgTextBox.SelectionColor = Color.Black;
                rcvMsgTextBox.AppendText(senderText);
                rcvMsgTextBox.AppendText("\r\n");
                sendTextBox.Clear();
            }

            else if (!isServer && !isClient)
            {
                MessageBox.Show("请先建立连接！", "错误");
            }
        }

        private void sendTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                sendMessage();
        }
    }
}

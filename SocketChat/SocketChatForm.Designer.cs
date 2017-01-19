namespace SocketChat
{
    partial class SocketChatForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CnIPStringLabel = new System.Windows.Forms.Label();
            this.IPStringLabel = new System.Windows.Forms.Label();
            this.cnSocketLabel = new System.Windows.Forms.Label();
            this.socketPortTextBox = new System.Windows.Forms.TextBox();
            this.createServerButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.msgPage = new System.Windows.Forms.TabPage();
            this.sendButton = new System.Windows.Forms.Button();
            this.sendTextBox = new System.Windows.Forms.TextBox();
            this.rcvMsgTextBox = new System.Windows.Forms.TextBox();
            this.createComPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cnlabel = new System.Windows.Forms.Label();
            this.clientGroupBox = new System.Windows.Forms.GroupBox();
            this.clientNickNameTextBox = new System.Windows.Forms.TextBox();
            this.cnclientNickNameLabel = new System.Windows.Forms.Label();
            this.createClientButton = new System.Windows.Forms.Button();
            this.serverSocketPortTextBox = new System.Windows.Forms.TextBox();
            this.cnServerSocketLabel = new System.Windows.Forms.Label();
            this.IPServerTextBox = new System.Windows.Forms.TextBox();
            this.cnIPServeLabel = new System.Windows.Forms.Label();
            this.ServerGroupBox = new System.Windows.Forms.GroupBox();
            this.serverNickNameTextBox = new System.Windows.Forms.TextBox();
            this.cnServerNickNameLabel = new System.Windows.Forms.Label();
            this.serverBgWorker = new System.ComponentModel.BackgroundWorker();
            this.clientBgWorker = new System.ComponentModel.BackgroundWorker();
            this.tabControl.SuspendLayout();
            this.msgPage.SuspendLayout();
            this.createComPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.clientGroupBox.SuspendLayout();
            this.ServerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CnIPStringLabel
            // 
            this.CnIPStringLabel.AutoSize = true;
            this.CnIPStringLabel.Location = new System.Drawing.Point(20, 36);
            this.CnIPStringLabel.Name = "CnIPStringLabel";
            this.CnIPStringLabel.Size = new System.Drawing.Size(47, 12);
            this.CnIPStringLabel.TabIndex = 0;
            this.CnIPStringLabel.Text = "本机IP:";
            // 
            // IPStringLabel
            // 
            this.IPStringLabel.AutoSize = true;
            this.IPStringLabel.Location = new System.Drawing.Point(74, 36);
            this.IPStringLabel.Name = "IPStringLabel";
            this.IPStringLabel.Size = new System.Drawing.Size(59, 12);
            this.IPStringLabel.TabIndex = 1;
            this.IPStringLabel.Text = "127.0.0.1";
            // 
            // cnSocketLabel
            // 
            this.cnSocketLabel.AutoSize = true;
            this.cnSocketLabel.Location = new System.Drawing.Point(20, 61);
            this.cnSocketLabel.Name = "cnSocketLabel";
            this.cnSocketLabel.Size = new System.Drawing.Size(35, 12);
            this.cnSocketLabel.TabIndex = 2;
            this.cnSocketLabel.Text = "房号:";
            // 
            // socketPortTextBox
            // 
            this.socketPortTextBox.Location = new System.Drawing.Point(73, 58);
            this.socketPortTextBox.Name = "socketPortTextBox";
            this.socketPortTextBox.Size = new System.Drawing.Size(79, 21);
            this.socketPortTextBox.TabIndex = 3;
            this.socketPortTextBox.Text = "6004";
            // 
            // createServerButton
            // 
            this.createServerButton.Location = new System.Drawing.Point(177, 58);
            this.createServerButton.Name = "createServerButton";
            this.createServerButton.Size = new System.Drawing.Size(75, 23);
            this.createServerButton.TabIndex = 4;
            this.createServerButton.Text = "新建聊天室";
            this.createServerButton.UseVisualStyleBackColor = true;
            this.createServerButton.Click += new System.EventHandler(this.createServerButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.msgPage);
            this.tabControl.Controls.Add(this.createComPage);
            this.tabControl.Location = new System.Drawing.Point(15, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(520, 425);
            this.tabControl.TabIndex = 5;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // msgPage
            // 
            this.msgPage.Controls.Add(this.sendButton);
            this.msgPage.Controls.Add(this.sendTextBox);
            this.msgPage.Controls.Add(this.rcvMsgTextBox);
            this.msgPage.Location = new System.Drawing.Point(4, 22);
            this.msgPage.Name = "msgPage";
            this.msgPage.Padding = new System.Windows.Forms.Padding(3);
            this.msgPage.Size = new System.Drawing.Size(512, 399);
            this.msgPage.TabIndex = 1;
            this.msgPage.Text = "发送消息";
            this.msgPage.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(392, 292);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(101, 82);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "发送";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // sendTextBox
            // 
            this.sendTextBox.Location = new System.Drawing.Point(17, 292);
            this.sendTextBox.Multiline = true;
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.Size = new System.Drawing.Size(348, 82);
            this.sendTextBox.TabIndex = 1;
            this.sendTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sendTextBox_KeyPress);
            // 
            // rcvMsgTextBox
            // 
            this.rcvMsgTextBox.Location = new System.Drawing.Point(17, 16);
            this.rcvMsgTextBox.Multiline = true;
            this.rcvMsgTextBox.Name = "rcvMsgTextBox";
            this.rcvMsgTextBox.ReadOnly = true;
            this.rcvMsgTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rcvMsgTextBox.Size = new System.Drawing.Size(476, 258);
            this.rcvMsgTextBox.TabIndex = 0;
            // 
            // createComPage
            // 
            this.createComPage.Controls.Add(this.groupBox1);
            this.createComPage.Controls.Add(this.clientGroupBox);
            this.createComPage.Controls.Add(this.ServerGroupBox);
            this.createComPage.Location = new System.Drawing.Point(4, 22);
            this.createComPage.Name = "createComPage";
            this.createComPage.Padding = new System.Windows.Forms.Padding(3);
            this.createComPage.Size = new System.Drawing.Size(512, 399);
            this.createComPage.TabIndex = 0;
            this.createComPage.Text = "建立连接";
            this.createComPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cnlabel);
            this.groupBox1.Location = new System.Drawing.Point(7, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 86);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "常用ip";
            // 
            // cnlabel
            // 
            this.cnlabel.AutoSize = true;
            this.cnlabel.Location = new System.Drawing.Point(21, 26);
            this.cnlabel.Name = "cnlabel";
            this.cnlabel.Size = new System.Drawing.Size(137, 24);
            this.cnlabel.TabIndex = 0;
            this.cnlabel.Text = "曹明----192.168.31.211\r\n刁宏建--192.168.31.140";
            // 
            // clientGroupBox
            // 
            this.clientGroupBox.Controls.Add(this.clientNickNameTextBox);
            this.clientGroupBox.Controls.Add(this.cnclientNickNameLabel);
            this.clientGroupBox.Controls.Add(this.createClientButton);
            this.clientGroupBox.Controls.Add(this.serverSocketPortTextBox);
            this.clientGroupBox.Controls.Add(this.cnServerSocketLabel);
            this.clientGroupBox.Controls.Add(this.IPServerTextBox);
            this.clientGroupBox.Controls.Add(this.cnIPServeLabel);
            this.clientGroupBox.Location = new System.Drawing.Point(7, 147);
            this.clientGroupBox.Name = "clientGroupBox";
            this.clientGroupBox.Size = new System.Drawing.Size(272, 126);
            this.clientGroupBox.TabIndex = 6;
            this.clientGroupBox.TabStop = false;
            this.clientGroupBox.Text = "加入聊天";
            // 
            // clientNickNameTextBox
            // 
            this.clientNickNameTextBox.Location = new System.Drawing.Point(72, 98);
            this.clientNickNameTextBox.Name = "clientNickNameTextBox";
            this.clientNickNameTextBox.Size = new System.Drawing.Size(79, 21);
            this.clientNickNameTextBox.TabIndex = 7;
            // 
            // cnclientNickNameLabel
            // 
            this.cnclientNickNameLabel.AutoSize = true;
            this.cnclientNickNameLabel.Location = new System.Drawing.Point(21, 101);
            this.cnclientNickNameLabel.Name = "cnclientNickNameLabel";
            this.cnclientNickNameLabel.Size = new System.Drawing.Size(35, 12);
            this.cnclientNickNameLabel.TabIndex = 6;
            this.cnclientNickNameLabel.Text = "昵称:";
            // 
            // createClientButton
            // 
            this.createClientButton.Location = new System.Drawing.Point(176, 59);
            this.createClientButton.Name = "createClientButton";
            this.createClientButton.Size = new System.Drawing.Size(75, 23);
            this.createClientButton.TabIndex = 4;
            this.createClientButton.Text = "加入聊天";
            this.createClientButton.UseVisualStyleBackColor = true;
            this.createClientButton.Click += new System.EventHandler(this.createClientButton_Click);
            // 
            // serverSocketPortTextBox
            // 
            this.serverSocketPortTextBox.Location = new System.Drawing.Point(72, 67);
            this.serverSocketPortTextBox.Name = "serverSocketPortTextBox";
            this.serverSocketPortTextBox.Size = new System.Drawing.Size(79, 21);
            this.serverSocketPortTextBox.TabIndex = 3;
            this.serverSocketPortTextBox.Text = "6004";
            // 
            // cnServerSocketLabel
            // 
            this.cnServerSocketLabel.AutoSize = true;
            this.cnServerSocketLabel.Location = new System.Drawing.Point(21, 70);
            this.cnServerSocketLabel.Name = "cnServerSocketLabel";
            this.cnServerSocketLabel.Size = new System.Drawing.Size(35, 12);
            this.cnServerSocketLabel.TabIndex = 2;
            this.cnServerSocketLabel.Text = "房号:";
            // 
            // IPServerTextBox
            // 
            this.IPServerTextBox.Location = new System.Drawing.Point(72, 32);
            this.IPServerTextBox.Name = "IPServerTextBox";
            this.IPServerTextBox.Size = new System.Drawing.Size(79, 21);
            this.IPServerTextBox.TabIndex = 1;
            this.IPServerTextBox.Text = "127.0.0.1";
            // 
            // cnIPServeLabel
            // 
            this.cnIPServeLabel.AutoSize = true;
            this.cnIPServeLabel.Location = new System.Drawing.Point(21, 35);
            this.cnIPServeLabel.Name = "cnIPServeLabel";
            this.cnIPServeLabel.Size = new System.Drawing.Size(47, 12);
            this.cnIPServeLabel.TabIndex = 0;
            this.cnIPServeLabel.Text = "对方IP:";
            // 
            // ServerGroupBox
            // 
            this.ServerGroupBox.Controls.Add(this.serverNickNameTextBox);
            this.ServerGroupBox.Controls.Add(this.cnServerNickNameLabel);
            this.ServerGroupBox.Controls.Add(this.createServerButton);
            this.ServerGroupBox.Controls.Add(this.CnIPStringLabel);
            this.ServerGroupBox.Controls.Add(this.socketPortTextBox);
            this.ServerGroupBox.Controls.Add(this.IPStringLabel);
            this.ServerGroupBox.Controls.Add(this.cnSocketLabel);
            this.ServerGroupBox.Location = new System.Drawing.Point(6, 6);
            this.ServerGroupBox.Name = "ServerGroupBox";
            this.ServerGroupBox.Size = new System.Drawing.Size(273, 115);
            this.ServerGroupBox.TabIndex = 5;
            this.ServerGroupBox.TabStop = false;
            this.ServerGroupBox.Text = "发起聊天";
            // 
            // serverNickNameTextBox
            // 
            this.serverNickNameTextBox.Location = new System.Drawing.Point(73, 86);
            this.serverNickNameTextBox.Name = "serverNickNameTextBox";
            this.serverNickNameTextBox.Size = new System.Drawing.Size(79, 21);
            this.serverNickNameTextBox.TabIndex = 6;
            // 
            // cnServerNickNameLabel
            // 
            this.cnServerNickNameLabel.AutoSize = true;
            this.cnServerNickNameLabel.Location = new System.Drawing.Point(20, 89);
            this.cnServerNickNameLabel.Name = "cnServerNickNameLabel";
            this.cnServerNickNameLabel.Size = new System.Drawing.Size(35, 12);
            this.cnServerNickNameLabel.TabIndex = 5;
            this.cnServerNickNameLabel.Text = "昵称:";
            // 
            // serverBgWorker
            // 
            this.serverBgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.serverBgWorker_DoWork);
            // 
            // clientBgWorker
            // 
            this.clientBgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.clientBgWorker_DoWork);
            // 
            // SocketChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 449);
            this.Controls.Add(this.tabControl);
            this.Name = "SocketChatForm";
            this.Text = "SocketChat-V1.0";
            this.Load += new System.EventHandler(this.SocketChatForm_Load);
            this.tabControl.ResumeLayout(false);
            this.msgPage.ResumeLayout(false);
            this.msgPage.PerformLayout();
            this.createComPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.clientGroupBox.ResumeLayout(false);
            this.clientGroupBox.PerformLayout();
            this.ServerGroupBox.ResumeLayout(false);
            this.ServerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CnIPStringLabel;
        private System.Windows.Forms.Label IPStringLabel;
        private System.Windows.Forms.Label cnSocketLabel;
        private System.Windows.Forms.TextBox socketPortTextBox;
        private System.Windows.Forms.Button createServerButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage msgPage;
        private System.Windows.Forms.TabPage createComPage;
        private System.Windows.Forms.GroupBox ServerGroupBox;
        private System.ComponentModel.BackgroundWorker serverBgWorker;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox sendTextBox;
        private System.Windows.Forms.TextBox rcvMsgTextBox;
        private System.Windows.Forms.GroupBox clientGroupBox;
        private System.Windows.Forms.Label cnServerSocketLabel;
        private System.Windows.Forms.TextBox IPServerTextBox;
        private System.Windows.Forms.Label cnIPServeLabel;
        private System.Windows.Forms.TextBox serverSocketPortTextBox;
        private System.Windows.Forms.Button createClientButton;
        private System.ComponentModel.BackgroundWorker clientBgWorker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label cnlabel;
        private System.Windows.Forms.TextBox clientNickNameTextBox;
        private System.Windows.Forms.Label cnclientNickNameLabel;
        private System.Windows.Forms.TextBox serverNickNameTextBox;
        private System.Windows.Forms.Label cnServerNickNameLabel;
    }
}


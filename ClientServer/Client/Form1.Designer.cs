namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbChat = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bSend = new System.Windows.Forms.Button();
            this.bConnect = new System.Windows.Forms.Button();
            this.bDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(56, 34);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(150, 20);
            this.tbPort.TabIndex = 0;
            this.tbPort.Text = "1234";
            // 
            // tbChat
            // 
            this.tbChat.Location = new System.Drawing.Point(12, 86);
            this.tbChat.Multiline = true;
            this.tbChat.Name = "tbChat";
            this.tbChat.Size = new System.Drawing.Size(275, 137);
            this.tbChat.TabIndex = 1;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(12, 229);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(194, 20);
            this.tbMessage.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(56, 60);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(231, 20);
            this.tbName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port:";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(56, 6);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(150, 20);
            this.tbIP.TabIndex = 6;
            this.tbIP.Text = "192.168.1.69";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name:";
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(212, 226);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(75, 23);
            this.bSend.TabIndex = 8;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(212, 6);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(75, 23);
            this.bConnect.TabIndex = 9;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // bDisconnect
            // 
            this.bDisconnect.Location = new System.Drawing.Point(212, 32);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(75, 23);
            this.bDisconnect.TabIndex = 10;
            this.bDisconnect.Text = "Disconnect";
            this.bDisconnect.UseVisualStyleBackColor = true;
            this.bDisconnect.Click += new System.EventHandler(this.bDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 261);
            this.Controls.Add(this.bDisconnect);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbChat);
            this.Controls.Add(this.tbPort);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbChat;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Button bDisconnect;
    }
}


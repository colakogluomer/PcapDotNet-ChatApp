
namespace ChatApp
{
    partial class ChatScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.listBoxSent = new System.Windows.Forms.ListBox();
            this.listBoxReceived = new System.Windows.Forms.ListBox();
            this.tbxWriteMessage = new System.Windows.Forms.RichTextBox();
            this.btnNewChat = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblYourIP = new System.Windows.Forms.Label();
            this.lblDestinationIP = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSendMessage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSendMessage.FlatAppearance.BorderSize = 100;
            this.btnSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendMessage.Location = new System.Drawing.Point(596, 478);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(127, 23);
            this.btnSendMessage.TabIndex = 0;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.UseVisualStyleBackColor = false;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // listBoxSent
            // 
            this.listBoxSent.BackColor = System.Drawing.Color.FloralWhite;
            this.listBoxSent.FormattingEnabled = true;
            this.listBoxSent.ItemHeight = 15;
            this.listBoxSent.Location = new System.Drawing.Point(376, 151);
            this.listBoxSent.Name = "listBoxSent";
            this.listBoxSent.Size = new System.Drawing.Size(347, 289);
            this.listBoxSent.TabIndex = 1;
            // 
            // listBoxReceived
            // 
            this.listBoxReceived.BackColor = System.Drawing.Color.FloralWhite;
            this.listBoxReceived.FormattingEnabled = true;
            this.listBoxReceived.ItemHeight = 15;
            this.listBoxReceived.Location = new System.Drawing.Point(23, 151);
            this.listBoxReceived.Name = "listBoxReceived";
            this.listBoxReceived.Size = new System.Drawing.Size(347, 289);
            this.listBoxReceived.TabIndex = 2;
            // 
            // tbxWriteMessage
            // 
            this.tbxWriteMessage.BackColor = System.Drawing.Color.FloralWhite;
            this.tbxWriteMessage.Location = new System.Drawing.Point(23, 478);
            this.tbxWriteMessage.Name = "tbxWriteMessage";
            this.tbxWriteMessage.Size = new System.Drawing.Size(567, 23);
            this.tbxWriteMessage.TabIndex = 3;
            this.tbxWriteMessage.Text = "";
            this.tbxWriteMessage.TextChanged += new System.EventHandler(this.tbxWriteMessage_TextChanged);
            // 
            // btnNewChat
            // 
            this.btnNewChat.BackColor = System.Drawing.SystemColors.Info;
            this.btnNewChat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNewChat.FlatAppearance.BorderSize = 100;
            this.btnNewChat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewChat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewChat.Location = new System.Drawing.Point(23, 12);
            this.btnNewChat.Name = "btnNewChat";
            this.btnNewChat.Size = new System.Drawing.Size(73, 42);
            this.btnNewChat.TabIndex = 4;
            this.btnNewChat.Text = "New Chat";
            this.btnNewChat.UseVisualStyleBackColor = false;
            this.btnNewChat.Click += new System.EventHandler(this.btnNewChat_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(143, 18);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(33, 15);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Your IP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Destination IP:";
            // 
            // lblYourIP
            // 
            this.lblYourIP.AutoSize = true;
            this.lblYourIP.Location = new System.Drawing.Point(143, 48);
            this.lblYourIP.Name = "lblYourIP";
            this.lblYourIP.Size = new System.Drawing.Size(33, 15);
            this.lblYourIP.TabIndex = 9;
            this.lblYourIP.Text = "label";
            // 
            // lblDestinationIP
            // 
            this.lblDestinationIP.AutoSize = true;
            this.lblDestinationIP.Location = new System.Drawing.Point(143, 82);
            this.lblDestinationIP.Name = "lblDestinationIP";
            this.lblDestinationIP.Size = new System.Drawing.Size(33, 15);
            this.lblDestinationIP.TabIndex = 10;
            this.lblDestinationIP.Text = "label";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.lblYourIP);
            this.groupBox1.Controls.Add(this.lblDestinationIP);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(481, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 116);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // ChatScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 524);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNewChat);
            this.Controls.Add(this.tbxWriteMessage);
            this.Controls.Add(this.listBoxReceived);
            this.Controls.Add(this.listBoxSent);
            this.Controls.Add(this.btnSendMessage);
            this.Name = "ChatScreen";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.ListBox listBoxSent;
        private System.Windows.Forms.ListBox listBoxReceived;
        private System.Windows.Forms.RichTextBox tbxWriteMessage;
        private System.Windows.Forms.Button btnNewChat;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblYourIP;
        private System.Windows.Forms.Label lblDestinationIP;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


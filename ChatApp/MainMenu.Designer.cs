
namespace ChatApp
{
    partial class MainMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxUdpDestPort = new System.Windows.Forms.TextBox();
            this.tbxUdpSrcPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboDeviceList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxDestinationIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxUdpDestPort);
            this.groupBox1.Controls.Add(this.tbxUdpSrcPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboDeviceList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Controls.Add(this.tbxDestinationIP);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Join Chat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(42, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "UDP Destination Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(68, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "UDP Source Port";
            // 
            // tbxUdpDestPort
            // 
            this.tbxUdpDestPort.Location = new System.Drawing.Point(183, 147);
            this.tbxUdpDestPort.Name = "tbxUdpDestPort";
            this.tbxUdpDestPort.Size = new System.Drawing.Size(100, 24);
            this.tbxUdpDestPort.TabIndex = 8;
            this.tbxUdpDestPort.TextChanged += new System.EventHandler(this.tbxUdpDestPort_TextChanged);
            // 
            // tbxUdpSrcPort
            // 
            this.tbxUdpSrcPort.Location = new System.Drawing.Point(183, 109);
            this.tbxUdpSrcPort.Name = "tbxUdpSrcPort";
            this.tbxUdpSrcPort.Size = new System.Drawing.Size(100, 24);
            this.tbxUdpSrcPort.TabIndex = 7;
            this.tbxUdpSrcPort.TextChanged += new System.EventHandler(this.tbxUdpSrcPort_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(35, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Your Network Adapter";
            // 
            // comboDeviceList
            // 
            this.comboDeviceList.BackColor = System.Drawing.SystemColors.Window;
            this.comboDeviceList.FormattingEnabled = true;
            this.comboDeviceList.Location = new System.Drawing.Point(183, 188);
            this.comboDeviceList.Name = "comboDeviceList";
            this.comboDeviceList.Size = new System.Drawing.Size(403, 23);
            this.comboDeviceList.TabIndex = 5;
            this.comboDeviceList.SelectedIndexChanged += new System.EventHandler(this.comboDeviceList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(82, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination IP";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Coral;
            this.lblName.Location = new System.Drawing.Point(95, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Your Name";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(183, 23);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 24);
            this.tbxName.TabIndex = 2;
            this.tbxName.TextChanged += new System.EventHandler(this.tbxName_TextChanged);
            // 
            // tbxDestinationIP
            // 
            this.tbxDestinationIP.Location = new System.Drawing.Point(183, 65);
            this.tbxDestinationIP.Name = "tbxDestinationIP";
            this.tbxDestinationIP.Size = new System.Drawing.Size(100, 24);
            this.tbxDestinationIP.TabIndex = 1;
            this.tbxDestinationIP.TextChanged += new System.EventHandler(this.tbxDestinationIP_TextChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.GreenYellow;
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.Location = new System.Drawing.Point(511, 229);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 52);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Join";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 310);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxDestinationIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox comboDeviceList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxUdpDestPort;
        private System.Windows.Forms.TextBox tbxUdpSrcPort;
    }
}
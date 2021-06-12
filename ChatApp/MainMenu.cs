using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            btnConnect.Enabled = false;
            DeviceList.EnqueueDevice(); // ethernet adapterleri bir kuyruğa atılır.
            DequeueDeviceList();   // comboBox'da gösterilmek üzere kuyruk okunur.
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve hedef bilgisayarın ip adresi, kullanıcıdan alınır.
            // ve Chat bu bilgiler ile başlatılır.
            ushort udpSourcePort = Convert.ToUInt16(tbxUdpSrcPort.Text);
            ushort udpDestPort = Convert.ToUInt16(tbxUdpDestPort.Text);
            int deviceIndex = comboDeviceList.SelectedIndex;
            string userName = tbxName.Text.ToString();
            string destinationIP = tbxDestinationIP.Text.ToString();           
            ChatScreen chatScreen = new ChatScreen(userName, destinationIP, deviceIndex, udpSourcePort, udpDestPort);
            chatScreen.Show();
            Hide(); //this.Hide()
        }

        private void DequeueDeviceList() // okunan degerler comboBox'a aktarılır.
        {

            for (int i = 0; i < DeviceList.allDevices.Count; i++)
            {
                comboDeviceList.Items.Add(DeviceList.queue.Dequeue());
            }
        }

        // Connect Button active/deactive kontrolleri.
        private void tbxName_TextChanged(object sender, EventArgs e)
        {
            if (tbxName.Text.ToString() == "")
            {
                btnConnect.Enabled = false;
            }
            else if (tbxName.Text.ToString() != "" && tbxDestinationIP.Text.ToString() != "" && comboDeviceList.SelectedItem != null)
            {
                btnConnect.Enabled = true;
            }
        }
        private void tbxDestinationIP_TextChanged(object sender, EventArgs e)
        {
            if (tbxDestinationIP.Text.ToString() == "")
            {
                btnConnect.Enabled = false;
            }
            else if (tbxDestinationIP.Text.ToString() != "" && tbxName.Text.ToString() != "" && tbxUdpSrcPort.Text.ToString() != "" && tbxUdpDestPort.Text.ToString() != "" && comboDeviceList.SelectedItem != null)
            {
                btnConnect.Enabled = true;
            }
        }
        private void comboDeviceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbxDestinationIP.Text.ToString() != "" && tbxName.Text.ToString() != "")
            {
                btnConnect.Enabled = true;
            }
            else
            {
                btnConnect.Enabled = false;
            }
        }
        private void tbxUdpSrcPort_TextChanged(object sender, EventArgs e)
        {
            if (tbxUdpSrcPort.Text.ToString() == "")
            {
                btnConnect.Enabled = false;
            }
            else if (tbxName.Text.ToString() != "" && tbxDestinationIP.Text.ToString() != "" && tbxUdpSrcPort.Text.ToString() != "" && tbxUdpDestPort.Text.ToString() != "" && comboDeviceList.SelectedItem != null)
            {
                btnConnect.Enabled = true;
            }
        }
        private void tbxUdpDestPort_TextChanged(object sender, EventArgs e)
        {
            if (tbxUdpDestPort.Text.ToString() == "")
            {
                btnConnect.Enabled = false;
            }
            else if (tbxName.Text.ToString() != "" && tbxDestinationIP.Text.ToString() != "" && tbxUdpSrcPort.Text.ToString() != "" && tbxUdpDestPort.Text.ToString() != "" && comboDeviceList.SelectedItem != null)
            {
                btnConnect.Enabled = true;
            }
        }
       

        
    }
}

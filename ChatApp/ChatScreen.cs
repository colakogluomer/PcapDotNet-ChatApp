using System;
using System.Windows.Forms;
using System.Threading;

namespace ChatApp
{
    public partial class ChatScreen : Form
    {
        ushort udpSourcePort;
        ushort udpDestPort;
        public ChatScreen(string uName, string destIP, int deviceIndex, ushort _udpSourcePort, ushort _udpDestPort)
        {
            InitializeComponent();
            // Yakalanan paketlerdeki mesajları, lisbox'a ekleyecek olan fonksiyonu bir threade atıyoruz.
            Thread threadShowMessages = new Thread(ShowMessages);
            threadShowMessages.Start();

            udpSourcePort = _udpSourcePort;
            udpDestPort = _udpDestPort;
            btnSendMessage.Enabled = false;

            Initialize.Init(uName,destIP, deviceIndex, udpDestPort); // Chat için gerekli olan ilk atamalar yapılır.

            lblUser.Text = uName;
            lblYourIP.Text = Initialize.sourceStringIP;
            lblDestinationIP.Text = destIP;
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            Initialize.message = tbxWriteMessage.Text.ToString(); // textbox'a yazılan string, mesaj değişkenine atanır. 
            // Gerekli tüm parametreler, UDP paketini oluşturmak üzere Send methoduna gönderilir.
            SendMessage.Send(Initialize.message, Initialize.selectedDevice, Initialize.sourceMAC, Initialize.destinationMAC, Initialize.sourceIP, Initialize.destinationIP, udpSourcePort, udpDestPort);
            listBoxSent.Items.Add(Initialize.userName+": " + Initialize.message + " =======> " + SendMessage.date); // UDP paketi gönderildikten sonra listbox'a gönderilen paketin mesaj içeriği eklenir.
            tbxWriteMessage.Text = "";
        }

        private void tbxWriteMessage_TextChanged(object sender, EventArgs e)
        {
            if (tbxWriteMessage.Text.ToString() == "")
            {
                btnSendMessage.Enabled = false;
            }
            else
            {
                btnSendMessage.Enabled = true;
            }
        }

        public void ShowMessages() //Yakalanan paketlerdeki mesajları, lisbox'a ekleyecek olan method.
        {
            while (true)
            {
                if (MessageProcess.readMessage != "")
                {
                    listBoxReceived.Items.Add(Initialize.destinationIP.ToString()+ ": " + MessageProcess.readMessage + " =======> "+ MessageProcess.now);
                    MessageProcess.readMessage = "";
                }

            }

        }

        private void btnNewChat_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
        }
    }
}

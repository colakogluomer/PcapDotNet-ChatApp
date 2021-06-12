using PcapDotNet.Core;
using PcapDotNet.Core.Extensions;
using PcapDotNet.Packets;
using PcapDotNet.Packets.Ethernet;
using PcapDotNet.Packets.IpV4;
using System;
using System.Collections.Generic;
using System.Threading;

namespace ChatApp
{
    // Chat uygulamasının kalbi.
    public class Initialize
    {
        public static string message = "";
        public static string userName = "";
        public static string sourceStringIP;
        public static Queue<Packet> queue = new Queue<Packet>();
        public static MacAddress sourceMAC;
        public static MacAddress destinationMAC;       
        public static IpV4Address sourceIP;
        public static IpV4Address destinationIP;
        public static LivePacketDevice selectedDevice;
        
        public static void Init(string uName, string destIP, int deviceIndex, ushort udpDestPort)
        {
            userName = uName;        
            IList<LivePacketDevice> allDevices = LivePacketDevice.AllLocalMachine; //network adapterlerini çeker.
            
            selectedDevice = allDevices[deviceIndex]; 
            sourceMAC = selectedDevice.GetMacAddress();
            sourceStringIP = null;

            foreach (DeviceAddress address in selectedDevice.Addresses)
            {
                if (address.Address.Family == SocketAddressFamily.Internet)
                    sourceStringIP = address.Address.ToString().Substring(9, address.Address.ToString().Length - 9);
            }

            sourceIP = new IpV4Address(sourceStringIP); 
            destinationIP = new IpV4Address(destIP);

            FindDestinationMac(); 
            // Mesaj işlemleri threadlere atanır.
            var threadReceiveMessages = new Thread(() => MessageProcess.ReceiveMessages(selectedDevice, queue, udpDestPort));
            var threadReadMessages = new Thread(() => MessageProcess.ReadMessages(queue));

            threadReceiveMessages.Start();
            threadReadMessages.Start();
        }

        public static void FindDestinationMac() //Gateway adresi tespit edilir ve destination MAC adresi olarak atanır.
        {
            FindMac findMac = new FindMac();
            // ICMP işlemleri threadlere aktarılır.
            findMac.threadListen = new Thread(findMac.Listen);
            findMac.threadView = new Thread(findMac.View);

            findMac.threadListen.Start();
            findMac.threadView.Start();

            findMac.Init(); // ICMP paketi oluşturulup hedefe gönderilir.

            string gateway = findMac.gatewayMac;
            destinationMAC = new MacAddress(gateway); // dönen değer destination mace atanır.
            findMac.threadListen.Interrupt();
            findMac.threadView.Interrupt();
        }
    }
}
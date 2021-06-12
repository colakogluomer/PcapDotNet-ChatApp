using PcapDotNet.Core;
using PcapDotNet.Packets.Ethernet;
using PcapDotNet.Packets.IpV4;
using System;

namespace ChatApp
{
    public class SendMessage
    {
        public static DateTime date;
        static ushort ipv4ID = 0;
        public static void Send(string message, LivePacketDevice selectedDevice, MacAddress sourceMAC, MacAddress destinationMAC, IpV4Address sourceIP, IpV4Address destinationIP, ushort udpSourcePort, ushort udpDestPort)
        {
            using (PacketCommunicator communicator = selectedDevice.Open(100, // name of the device
                                                                 PacketDeviceOpenAttributes.Promiscuous, // promiscuous mode
                                                                 1000)) // read timeout
            {
                if (message != "")
                {
                    // Her meaj gönderimi bir udp paketi ile gerçekleştirilir.
                    var paket = UdpPacket.BuildUdpPacket(message, ipv4ID, sourceMAC, destinationMAC, sourceIP, destinationIP, udpSourcePort, udpDestPort);
                    date = paket.Timestamp;
                    communicator.SendPacket(paket);
                    ipv4ID++;
                }
            }
        }
    }
}
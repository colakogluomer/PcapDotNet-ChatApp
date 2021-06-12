using System;
using System.Threading;
using System.Collections.Generic;
using PcapDotNet.Base;
using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.Arp;
using PcapDotNet.Packets.Dns;
using PcapDotNet.Packets.Ethernet;
using PcapDotNet.Packets.Gre;
using PcapDotNet.Packets.Http;
using PcapDotNet.Packets.Icmp;
using PcapDotNet.Packets.Igmp;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.IpV6;
using PcapDotNet.Packets.Transport;
using PcapDotNet.Core.Extensions;
using System.Net;
using System.Net.NetworkInformation;
using System.Timers;
using System.Text;
using System.IO;
namespace ChatApp
{
    // Modem MAC adresimizi öğrenmek için ICMP paketleri oluşturup gönderilir.
    class FindMac
    {
        public Thread threadListen;
        public Thread threadView;
        public string gatewayMac = "";
        Queue<Packet> queue = new Queue<Packet>();      
        MacAddress destinationMAC;       
        IpV4Address destinationIP;
        
        public void Init()
        {
            destinationMAC = new MacAddress("FF:FF:FF:FF:FF:FF");
            destinationIP = new IpV4Address("192.168.1.1");

            foreach (DeviceAddress address in Initialize.selectedDevice.Addresses)
            {
                if (address.Address.Family == SocketAddressFamily.Internet)
                    Initialize.sourceStringIP = address.Address.ToString().Substring(9, address.Address.ToString().Length - 9);
            }

            using (PacketCommunicator communicator = Initialize.selectedDevice.Open(100, // name of the device
                                                                 PacketDeviceOpenAttributes.Promiscuous, // promiscuous mode
                                                                 1000)) // read timeout
            {
                for (int i = 0; i < 4; i++)
                {
                    var paket = BuildIcmpPacket();
                    DateTime date = paket.Timestamp;
                    Thread.Sleep(1000);
                    communicator.SendPacket(paket);
                }    
            }
        }

        public Packet BuildIcmpPacket()

        {
            EthernetLayer ethernetLayer =
                new EthernetLayer
                {
                    Source = Initialize.sourceMAC,
                    Destination = destinationMAC,
                    EtherType = EthernetType.None, // Will be filled automatically.
                };

            IpV4Layer ipV4Layer =
                new IpV4Layer
                {
                    Source = Initialize.sourceIP,
                    CurrentDestination = destinationIP,
                    Fragmentation = IpV4Fragmentation.None,
                    HeaderChecksum = null, // Will be filled automatically.
                    Identification = 123,
                    Options = IpV4Options.None,
                    Protocol = null, // Will be filled automatically.
                    Ttl = 100,
                    TypeOfService = 0,
                };

            IcmpEchoLayer icmpLayer =
                new IcmpEchoLayer
                {
                    Checksum = null, // Will be filled automatically.
                    Identifier = 456,
                    SequenceNumber = 800,
                };

            PacketBuilder builder = new PacketBuilder(ethernetLayer, ipV4Layer, icmpLayer);

            return builder.Build(DateTime.Now);
        }
        public void Listen()
        {
            using (PacketCommunicator communicator =
                Initialize.selectedDevice.Open(65536,                                  // portion of the packet to capture
                                                                            // 65536 guarantees that the whole packet will be captured on all the link layers
                                    PacketDeviceOpenAttributes.Promiscuous, // promiscuous mode
                                    1000))                                  // read timeout
            {
                // Compile the filter
                using (BerkeleyPacketFilter filter = communicator.CreateFilter("icmp and ip and src "+ destinationIP.ToString())) 
                {
                    // Set the filter
                    communicator.SetFilter(filter);
                }
                // Retrieve the packets
                Packet packet;
                do
                {
                    PacketCommunicatorReceiveResult result = communicator.ReceivePacket(out packet);
                    switch (result)
                    {
                        case PacketCommunicatorReceiveResult.Timeout:
                            // Timeout elapsed
                            continue;
                        case PacketCommunicatorReceiveResult.Ok:
                            lock (queue)
                            {
                                queue.Enqueue(packet);                                
                                break;
                            }
                        default:
                            throw new InvalidOperationException("The result " + result + " should never be reached here");
                    
                    }
                } while (true);              
            }
        }

        public void View()
        {
            bool i = true;

            while (i)
            {
                Packet p;

                if (queue.Count > 0)
                    lock (queue)
                    {
                        p = queue.Dequeue();
                    }
                else continue;

                gatewayMac = p.Ethernet.Source.ToString();
                
                if (gatewayMac.Contains(Initialize.sourceMAC.ToString()))
                {
                   continue;
                }

                i = false;               
            }
        }       
    }
}





using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace ChatApp
{
    class MessageProcess
    {
        public static Packet packetReceive;
        public static Packet packetRead;
        public static string readMessage = "";
        public static DateTime now;
        
        //Karşı bilgisayardan gelen mesajlar  yakalanır.
        public static void ReceiveMessages(LivePacketDevice selectedDevice, Queue<Packet> queue, ushort udpDestPort)
        {
            using (PacketCommunicator communicator =
                selectedDevice.Open(65536,                                  // portion of the packet to capture
                                                                            // 65536 guarantees that the whole packet will be captured on all the link layers
                                    PacketDeviceOpenAttributes.Promiscuous, // promiscuous mode
                                    1000))                                  // read timeout
            {
                // Compile the filter
                using (BerkeleyPacketFilter filter = communicator.CreateFilter("ip and src " + Initialize.destinationIP.ToString() + " and udp and src port " + udpDestPort.ToString()))
                {
                    // Set the filter
                    communicator.SetFilter(filter);
                }
                               
                do
                {
                    PacketCommunicatorReceiveResult result = communicator.ReceivePacket(out packetReceive);
                    switch (result)
                    {
                        case PacketCommunicatorReceiveResult.Timeout:
                            // Timeout elapsed
                            continue;
                        case PacketCommunicatorReceiveResult.Ok:
                            lock (queue)
                            {
                                queue.Enqueue(packetReceive);
                                break;
                            }
                        default:
                            throw new InvalidOperationException("The result " + result + " should never be reached here");
                    }
                } while (true);
            }
        }
        
        // Yakalanan paketler soyularak payload değerine ulaşılır.
        public static void ReadMessages(Queue<Packet> queue) 
        {
            while (true)
            {
                if (queue.Count > 0)
                {
                    lock (queue)
                    {                       
                        packetRead = queue.Dequeue();
                    }

                    now = DateTime.Now;
                    IpV4Datagram ip = packetRead.Ethernet.IpV4;
                    UdpDatagram udp = ip.Udp;
                    int payloadLength = udp.Payload.Length;
                    // udp paketinin içindeki payload decode edilir.
                    using (MemoryStream ms = udp.Payload.ToMemoryStream())
                    {
                        byte[] rx_payload = new byte[payloadLength];
                        ms.Read(rx_payload, 0, payloadLength);
                        // udp paketinin payload değeri Chat ekranında gösterilmek üzere değişkene atanır.
                        readMessage = Encoding.UTF8.GetString(rx_payload); 
                    }                
                }            
            }
        }
    }
}
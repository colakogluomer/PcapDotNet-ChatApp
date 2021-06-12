using PcapDotNet.Packets;
using PcapDotNet.Packets.Ethernet;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;
using System;
using System.Text;

namespace ChatApp
{
    class UdpPacket
    {
        // Alınan değerlere göre karşı bilgisayara gönderilmek üzere bir udp paketi hazırlanır ve zaman damgası vurularak döndürülür.
        public static Packet BuildUdpPacket(string message, ushort ipv4ID, MacAddress sourceMAC, MacAddress destinationMAC, IpV4Address sourceIP, IpV4Address destinationIP, ushort udpSourcePort, ushort udpDestPort)
        {
            EthernetLayer ethernetLayer =
                new EthernetLayer
                {
                    Source = sourceMAC,
                    Destination = destinationMAC,
                    EtherType = EthernetType.None, // Will be filled automatically.
                };

            IpV4Layer ipV4Layer =
                new IpV4Layer
                {
                    Source = sourceIP,
                    CurrentDestination = destinationIP,
                    Fragmentation = IpV4Fragmentation.None,
                    HeaderChecksum = null, // Will be filled automatically.
                    Identification = ipv4ID,
                    Options = IpV4Options.None,
                    Protocol = null, // Will be filled automatically.
                    Ttl = 100,
                    TypeOfService = 0,
                };

            UdpLayer udpLayer =
                new UdpLayer
                {
                    SourcePort = udpSourcePort,
                    DestinationPort = udpDestPort,
                    Checksum = null, // Will be filled automatically.
                    CalculateChecksumValue = true,
                };

            PayloadLayer payloadLayer =
                new PayloadLayer
                {

                    Data = new Datagram(Encoding.ASCII.GetBytes(message)),


                };

            PacketBuilder builder = new PacketBuilder(ethernetLayer, ipV4Layer, udpLayer, payloadLayer);

            return builder.Build(DateTime.Now);
        }
    }
}
using System;
using System.Collections.Generic;
using PcapDotNet.Core;

namespace ChatApp
{
    // Ethernet adapterleri ekrana bastırılmak üzere kuyruğa alınır.
    class DeviceList
    {
        public static Queue<string> queue = new Queue<string>();
        public static IList<LivePacketDevice> allDevices;
        public static Queue<string> EnqueueDevice()
        {
            allDevices = LivePacketDevice.AllLocalMachine;

            for (int i = 0; i != allDevices.Count; ++i)
            {
                LivePacketDevice device = allDevices[i];
                queue.Enqueue((i + 1) + ". " + device.Description);
               
            }
            return queue;
        }

    }
}

﻿using System;
using NeoServer.Server.Contracts.Network;

namespace NeoServer.Networking.Packets.Outgoing
{
    public class FirstConnectionPacket : OutgoingPacket
    {
        public override void WriteToMessage(INetworkMessage message)
        {
            message.AddUInt16(0x0006);
            message.AddByte(0x1F);
            message.AddUInt32((uint) DateTimeOffset.UtcNow.ToUnixTimeSeconds());

            var rnd = new Random();
            var randomByte = (byte) rnd.Next(byte.MinValue, byte.MaxValue);
            message.AddByte(randomByte);
        }
    }
}
﻿using Lidgren.Network;

namespace ManateesAgainstCards.Network.Packets
{
	public class GameOver : Packet
	{
		public override PacketType Type
		{
			get
			{
				return PacketType.GameOver;
			}
		}

		public override void Write(NetOutgoingMessage msg)
		{

		}

		public override void Read(NetIncomingMessage msg)
		{

		}
	}
}

﻿using NeoServer.Enums.Creatures.Enums;
using NeoServer.Game.Common;
using NeoServer.Game.Contracts.Creatures;
using NeoServer.Game.Contracts.Spells;
using NeoServer.Networking.Packets.Outgoing;
using NeoServer.Server.Contracts;

namespace NeoServer.Server.Events
{
    public class PlayerCannotUseSpellEventHandler
    {
        private readonly IGameServer game;

        public PlayerCannotUseSpellEventHandler(IGameServer game)
        {
            this.game = game;
        }

        public void Execute(ICreature creature, ISpell spell, InvalidOperation error)
        {
            foreach (var spectator in game.Map.GetPlayersAtPositionZone(creature.Location))
            {
                if (!game.CreatureManager.GetPlayerConnection(spectator.CreatureId, out var connection)) continue;

                connection.OutgoingPackets.Enqueue(new MagicEffectPacket(creature.Location, EffectT.Puff));
                connection.OutgoingPackets.Enqueue(new TextMessagePacket(TextMessageOutgoingParser.Parse(error),
                    TextMessageOutgoingType.MESSAGE_STATUS_DEFAULT));
                connection.Send();
            }
        }
    }
}
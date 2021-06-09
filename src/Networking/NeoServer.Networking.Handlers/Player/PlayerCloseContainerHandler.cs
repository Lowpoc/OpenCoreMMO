﻿using NeoServer.Server.Contracts;
using NeoServer.Server.Contracts.Network;
using NeoServer.Server.Tasks;

namespace NeoServer.Server.Handlers.Player
{
    public class PlayerCloseContainerHandler : PacketHandler
    {
        private readonly IGameServer game;

        public PlayerCloseContainerHandler(IGameServer game)
        {
            this.game = game;
        }

        public override void HandlerMessage(IReadOnlyNetworkMessage message, IConnection connection)
        {
            var containerId = message.GetByte();
            if (!game.CreatureManager.TryGetPlayer(connection.CreatureId, out var player)) return;

            game.Dispatcher.AddEvent(new Event(() => player.Containers.CloseContainer(containerId)));
        }
    }
}
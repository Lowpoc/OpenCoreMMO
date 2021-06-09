﻿using NeoServer.Game.Common.Contracts.Creatures;
using NeoServer.Game.Contracts.World;

namespace NeoServer.Game.DataStore
{
    public class GameToolStore : DataStore<GameToolStore, string, object>
    {
        public static IPathFinder PathFinder
        {
            get => Data.Get(nameof(PathFinder)) is not IPathFinder pathFinder ? null : pathFinder;
            set => Data.Add(nameof(PathFinder), value);
        }

        public static IWalkToMechanism WalkToMechanism
        {
            get => Data.Get(nameof(WalkToMechanism)) is not IWalkToMechanism walkToMechanism ? null : walkToMechanism;
            set => Data.Add(nameof(WalkToMechanism), value);
        }
    }
}
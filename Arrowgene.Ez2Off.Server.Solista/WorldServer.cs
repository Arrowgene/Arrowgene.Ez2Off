﻿/*
 * This file is part of Arrowgene.Ez2Off
 *
 * Arrowgene.Ez2Off is a server implementation for the game "Ez2On".
 * Copyright (C) 2017-2018 Sebastian Heinz
 *
 * Github: https://github.com/Arrowgene/Arrowgene.Ez2Off
 *
 * Arrowgene.Ez2Off is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * Arrowgene.Ez2Off is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with Arrowgene.Ez2Off. If not, see <https://www.gnu.org/licenses/>.
 */

using System.Reflection;
using Arrowgene.Ez2Off.Server.Scripting;
using Arrowgene.Ez2Off.Server.Settings;
using Arrowgene.Ez2Off.Server.Solista.Packets.World;

namespace Arrowgene.Ez2Off.Server.Solista
{
    public class WorldServer : EzWorldServer
    {
        public WorldServer(SettingsContainer settingsContainer, WorldServerSettings settings) : base(settingsContainer,
            settings)
        {
            EzScriptEngine.Instance.AddReference(Assembly.GetAssembly(typeof(WorldServer)));
        }

        public override string Name => "Solista WorldServer";

        protected override void LoadHandles()
        {
            AddHandler(new Enter(this));
            AddHandler(new SinglePlay(this));
            AddHandler(new SelectSong(this));
            AddHandler(new StartGame(this));
            AddHandler(new BackButton(this));
        }
    }
}
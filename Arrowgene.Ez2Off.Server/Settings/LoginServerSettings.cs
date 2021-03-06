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

using System.Net;
using System.Runtime.Serialization;

namespace Arrowgene.Ez2Off.Server.Settings
{
    [DataContract]
    public class LoginServerSettings : EzServerSettings
    {
        public LoginServerSettings(IPAddress publicIpAddress, IPAddress listenIpAddress, ushort port, ushort bridgePort)
            : base(publicIpAddress, listenIpAddress, port, bridgePort)
        {
            ApiSettings = new ApiSettings();
        }

        public LoginServerSettings(LoginServerSettings loginServerSettings) : base(loginServerSettings)
        {
            ApiSettings = new ApiSettings(loginServerSettings.ApiSettings);
        }

        [DataMember(Order = 0)]
        public ApiSettings ApiSettings { get; set; }

        public new object Clone()
        {
            return new LoginServerSettings(this);
        }
    }
}
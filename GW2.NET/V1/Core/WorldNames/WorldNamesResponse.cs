﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WorldNamesResponse.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System;
using Newtonsoft.Json;

namespace GW2DotNET.V1.Core.WorldNames
{
    /// <summary>
    /// Represents a response that is the result of an <see cref="WorldNamesRequest"/>.
    /// </summary>
    /// <remarks>
    /// See <a href="http://wiki.guildwars2.com/wiki/API:1/world_names"/> for more information.
    /// </remarks>
    public class WorldNamesResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorldNamesResponse"/> class.
        /// </summary>
        public WorldNamesResponse()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the JSON representation of this instance.
        /// </summary>
        /// <returns>Returns a JSON <see cref="String"/>.</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

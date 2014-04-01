﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnknownTrinketDetails.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents detailed information about an unknown trinket.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.ItemsDetails.Types.ItemTypes.Trinkets.TrinketTypes
{
    using GW2DotNET.V1.Common.Converters;

    using Newtonsoft.Json;

    /// <summary>Represents detailed information about an unknown trinket.</summary>
    [JsonConverter(typeof(DefaultJsonConverter))]
    public class UnknownTrinketDetails : TrinketDetails
    {
        /// <summary>Initializes a new instance of the <see cref="UnknownTrinketDetails" /> class.</summary>
        public UnknownTrinketDetails()
            : base(TrinketType.Unknown)
        {
        }
    }
}
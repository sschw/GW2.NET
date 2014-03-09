﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PointOfInterest.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a Point of Interest (POI) location.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2DotNET.V1.Core.MapsInformation.Floors.Regions.Subregions.Locations
{
    using System.Drawing;

    using GW2DotNET.V1.Core.Converters;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    ///     Represents a Point of Interest (POI) location.
    /// </summary>
    public class PointOfInterest : JsonObject
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the Point of Interest's coordinates.
        /// </summary>
        [JsonProperty("coord", Order = 4)]
        [JsonConverter(typeof(JsonPointFConverter))]
        public PointF Coordinates { get; set; }

        /// <summary>
        ///     Gets or sets the Point of Interest's floor.
        /// </summary>
        [JsonProperty("floor", Order = 3)]
        public int Floor { get; set; }

        /// <summary>
        ///     Gets or sets the Point of Interest's name.
        /// </summary>
        [JsonProperty("name", Order = 1)]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the Point of Interest's ID.
        /// </summary>
        [JsonProperty("poi_id", Order = 0)]
        public int PoiId { get; set; }

        /// <summary>
        ///     Gets or sets the Point of Interest's type.
        /// </summary>
        [JsonProperty("type", Order = 2)]
        [JsonConverter(typeof(StringEnumConverter))]
        public PointOfInterestType Type { get; set; }

        #endregion
    }
}
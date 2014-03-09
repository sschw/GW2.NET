﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AmuletDetails.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents detailed information about an amulet.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2DotNET.V1.Core.ItemsInformation.Details.Items.Trinkets.Amulets
{
    using GW2DotNET.V1.Core.Converters;

    using Newtonsoft.Json;

    /// <summary>
    ///     Represents detailed information about an amulet.
    /// </summary>
    [JsonConverter(typeof(DefaultJsonConverter))]
    public class AmuletDetails : TrinketDetails
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="AmuletDetails" /> class.
        /// </summary>
        public AmuletDetails()
            : base(TrinketType.Amulet)
        {
        }

        #endregion
    }
}
﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnknownUpgradeComponentDetails.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents detailed information about an unknown upgrade component.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2DotNET.V1.Core.ItemsInformation.Details.Items.UpgradeComponents.Unknown
{
    using GW2DotNET.V1.Core.Converters;

    using Newtonsoft.Json;

    /// <summary>
    ///     Represents detailed information about an unknown upgrade component.
    /// </summary>
    [JsonConverter(typeof(DefaultJsonConverter))]
    public class UnknownUpgradeComponentDetails : UpgradeComponentDetails
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="UnknownUpgradeComponentDetails" /> class.
        /// </summary>
        public UnknownUpgradeComponentDetails()
            : base(UpgradeComponentType.Unknown)
        {
        }

        #endregion
    }
}
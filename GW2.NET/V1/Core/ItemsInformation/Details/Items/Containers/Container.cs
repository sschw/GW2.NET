﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Container.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a container.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2DotNET.V1.Core.ItemsInformation.Details.Items.Containers
{
    using GW2DotNET.V1.Core.Converters;

    using Newtonsoft.Json;

    /// <summary>
    ///     Represents a container.
    /// </summary>
    [JsonConverter(typeof(DefaultJsonConverter))]
    public class Container : Item
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Container" /> class.
        /// </summary>
        public Container()
            : base(ItemType.Container)
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the container's details.
        /// </summary>
        [JsonProperty("container", Order = 100)]
        public ContainerDetails ContainerDetails { get; set; }

        #endregion
    }
}
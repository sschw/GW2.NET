﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DynamicEventCollection.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a collection of dynamic events and their status.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2DotNET.V1.Core.DynamicEventsInformation.Status
{
    using System.Collections.Generic;

    /// <summary>
    ///     Represents a collection of dynamic events and their status.
    /// </summary>
    public class DynamicEventCollection : JsonList<DynamicEvent>
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DynamicEventCollection" /> class.
        /// </summary>
        public DynamicEventCollection()
        {
        }

        /// <summary>Initializes a new instance of the <see cref="DynamicEventCollection"/> class.</summary>
        /// <param name="capacity">The number of elements that the new list can initially store.</param>
        public DynamicEventCollection(int capacity)
            : base(capacity)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="DynamicEventCollection"/> class.</summary>
        /// <param name="collection">The collection whose elements are copied to the new list.</param>
        public DynamicEventCollection(IEnumerable<DynamicEvent> collection)
            : base(collection)
        {
        }

        #endregion
    }
}
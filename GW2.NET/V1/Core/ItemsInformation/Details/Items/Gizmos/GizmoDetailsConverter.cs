﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GizmoDetailsConverter.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Converts an instance of a class that extends <see cref="GizmoDetails" /> from its <see cref="System.String" />
//   representation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2DotNET.V1.Core.ItemsInformation.Details.Items.Gizmos
{
    using System;
    using System.Collections.Generic;

    using GW2DotNET.V1.Core.Converters;
    using GW2DotNET.V1.Core.ItemsInformation.Details.Items.Gizmos.Default;
    using GW2DotNET.V1.Core.ItemsInformation.Details.Items.Gizmos.RentableContractNpcs;
    using GW2DotNET.V1.Core.ItemsInformation.Details.Items.Gizmos.Unknown;
    using GW2DotNET.V1.Core.ItemsInformation.Details.Items.Gizmos.UnlimitedConsumables;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    ///     Converts an instance of a class that extends <see cref="GizmoDetails" /> from its <see cref="System.String" />
    ///     representation.
    /// </summary>
    public class GizmoDetailsConverter : ContentBasedTypeCreationConverter
    {
        #region Static Fields

        /// <summary>
        ///     Backing field. Holds a dictionary of known JSON values and their corresponding type.
        /// </summary>
        private static readonly IDictionary<GizmoType, Type> KnownTypes = new Dictionary<GizmoType, Type>();

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes static members of the <see cref="GizmoDetailsConverter" /> class.
        /// </summary>
        static GizmoDetailsConverter()
        {
            KnownTypes.Add(GizmoType.Unknown, typeof(UnknownGizmoDetails));
            KnownTypes.Add(GizmoType.Default, typeof(DefaultGizmoDetails));
            KnownTypes.Add(GizmoType.RentableContractNpc, typeof(RentableContractNpcDetails));
            KnownTypes.Add(GizmoType.UnlimitedConsumable, typeof(UnlimitedConsumableDetails));
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>Determines whether this instance can convert the specified object type.</summary>
        /// <param name="objectType">locationType of the object.</param>
        /// <returns>Returns <c>true</c> if this instance can convert the specified object type; otherwise <c>false</c>.</returns>
        public override bool CanConvert(Type objectType)
        {
            return KnownTypes.Values.Contains(objectType);
        }

        /// <summary>Gets the object type that will be used by the serializer.</summary>
        /// <param name="objectType">The type of the object.</param>
        /// <param name="content">The JSON content.</param>
        /// <returns>Returns the target type.</returns>
        public override Type GetTargetType(Type objectType, JObject content)
        {
            if (content["type"] == null)
            {
                return typeof(UnknownGizmoDetails);
            }

            var jsonValue = JsonSerializer.Create().Deserialize<GizmoType>(content["type"].CreateReader());

            Type targetType;

            if (!KnownTypes.TryGetValue(jsonValue, out targetType))
            {
                return typeof(UnknownGizmoDetails);
            }

            return targetType;
        }

        #endregion
    }
}
﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObjectiveNameContract.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Defines the ObjectiveNameContract type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2NET.V1.WorldVersusWorld.Json
{
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.Serialization;

    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Not a public API.")]
    internal sealed class ObjectiveNameContract
    {
        [DataMember(Name = "id", Order = 0)]
        internal string Id { get; set; }

        [DataMember(Name = "name", Order = 1)]
        internal string Name { get; set; }
    }
}
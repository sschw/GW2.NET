﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SubregionContract.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Defines the SubregionContract type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2NET.V1.Maps.Json
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.Serialization;

    [DataContract]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Not a public API.")]
    internal sealed class SubregionContract
    {
        [DataMember(Name = "continent_rect", Order = 5)]
        internal double[][] ContinentRectangle { get; set; }

        [DataMember(Name = "default_floor", Order = 3)]
        internal int DefaultFloor { get; set; }

        [DataMember(Name = "map_rect", Order = 4)]
        internal double[][] MapRectangle { get; set; }

        [DataMember(Name = "max_level", Order = 2)]
        internal int MaximumLevel { get; set; }

        [DataMember(Name = "min_level", Order = 1)]
        internal int MinimumLevel { get; set; }

        [DataMember(Name = "name", Order = 0)]
        internal string Name { get; set; }

        [DataMember(Name = "points_of_interest", Order = 6)]
        internal ICollection<PointOfInterestContract> PointsOfInterest { get; set; }

        [DataMember(Name = "sectors", Order = 9)]
        internal ICollection<SectorContract> Sectors { get; set; }

        [DataMember(Name = "skill_challenges", Order = 8)]
        internal ICollection<SkillChallengeContract> SkillChallenges { get; set; }

        [DataMember(Name = "tasks", Order = 7)]
        internal ICollection<RenownTaskContract> Tasks { get; set; }
    }
}
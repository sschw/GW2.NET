﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnknownArmor.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents an unknown armor piece.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Items.Contracts.Armors
{
    using GW2DotNET.Common;

    /// <summary>Represents an unknown armor piece.</summary>
    [TypeDiscriminator(Value = "Unknown", BaseType = typeof(Armor))]
    public class UnknownArmor : Armor
    {
    }
}
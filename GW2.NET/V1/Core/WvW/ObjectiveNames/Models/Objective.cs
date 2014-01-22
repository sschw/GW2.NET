﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Objective.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace GW2DotNET.V1.Core.WvW.ObjectiveNames.Models
{
    /// <summary>
    /// Represents an objective and its localized name.
    /// </summary>
    public class Objective
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Objective"/> class.
        /// </summary>
        public Objective()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Objective"/> class using the specified values.
        /// </summary>
        /// <param name="id">The objective's ID.</param>
        /// <param name="name">The objective's name.</param>
        public Objective(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets the objective's ID.
        /// </summary>
        [JsonProperty("id", Order = 0)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the objective's name.
        /// </summary>
        [JsonProperty("name", Order = 1)]
        public string Name { get; set; }

        /// <summary>
        /// Gets the JSON representation of this instance.
        /// </summary>
        /// <returns>Returns a JSON <see cref="System.String"/>.</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        /// <summary>
        /// Gets the JSON representation of this instance.
        /// </summary>
        /// <param name="indent">A value that indicates whether to indent the output.</param>
        /// <returns>Returns a JSON <see cref="System.String"/>.</returns>
        public string ToString(bool indent)
        {
            return JsonConvert.SerializeObject(this, indent ? Formatting.Indented : Formatting.None);
        }
    }
}
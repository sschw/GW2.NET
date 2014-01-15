﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RecipeDetailsRequest.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2DotNET.V1.Core.RecipeDetails
{
    /// <summary>
    /// Represents a request for information regarding a specific recipe.
    /// </summary>
    /// <remarks>
    /// See <a href="http://wiki.guildwars2.com/wiki/API:1/recipe_details"/> for more information.
    /// </remarks>
    public class RecipeDetailsRequest : ApiRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipeDetailsRequest"/> class using the specified recipe ID.
        /// </summary>
        /// <param name="recipeId">The recipe ID.</param>
        public RecipeDetailsRequest(int recipeId)
            : base(new Uri(Resources.RecipeDetails + "?recipe_id={recipe_id}", UriKind.Relative))
        {
            this.AddUrlSegment("recipe_id", recipeId.ToString());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipeDetailsRequest"/> class using the specified recipe ID and language.
        /// </summary>
        /// <param name="recipeId">The recipe ID.</param>
        /// <param name="language">The output language. Supported values are enumerated in <see cref="SupportedLanguages"/>.</param>
        public RecipeDetailsRequest(int recipeId, CultureInfo language)
            : base(new Uri(Resources.RecipeDetails + "?recipe_id={recipe_id}&lang={language}", UriKind.Relative))
        {
            this.AddUrlSegment("recipe_id", recipeId.ToString());
            this.AddUrlSegment("language", language.TwoLetterISOLanguageName);
        }

        /// <summary>
        /// Sends this request to the specified <see cref="ApiClient"/> and retrieves a response whose content is of type <see cref="RecipeDetailsResponse"/>.
        /// </summary>
        /// <param name="handler">The <see cref="ApiClient"/> that sends the request over a network and returns an instance of type <see cref="ApiResponse{TContent}"/>.</param>
        /// <returns>Returns an instance of type <see cref="RecipeDetailsResponse"/>.</returns>
        public IApiResponse<RecipeDetailsResponse> GetResponse(IApiClient handler)
        {
            return base.GetResponse<RecipeDetailsResponse>(handler);
        }

        /// <summary>
        /// Asynchronously sends this request to the specified <see cref="ApiClient"/> and retrieves a response whose content is of type <see cref="RecipeDetailsResponse"/>.
        /// </summary>
        /// <param name="handler">The <see cref="ApiClient"/> that sends the request over a network and returns an instance of type <see cref="ApiResponse{TContent}"/>.</param>
        /// <returns>Returns an instance of type <see cref="RecipeDetailsResponse"/>.</returns>
        public Task<IApiResponse<RecipeDetailsResponse>> GetResponseAsync(IApiClient handler)
        {
            return base.GetResponseAsync<RecipeDetailsResponse>(handler);
        }
    }
}
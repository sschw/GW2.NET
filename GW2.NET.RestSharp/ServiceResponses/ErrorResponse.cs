﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ErrorResponse.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents an error response.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.RestSharp.ServiceResponses
{
    using System;
    using System.IO;

    using GW2DotNET.Extensions;
    using GW2DotNET.V1.Errors;

    using Newtonsoft.Json;

    using global::RestSharp;

    /// <summary>Represents an error response.</summary>
    public class ErrorResponse : ServiceResponse<ErrorResult>
    {
        /// <summary>Initializes a new instance of the <see cref="ErrorResponse"/> class.</summary>
        /// <param name="restResponse">The <see cref="IRestResponse"/>.</param>
        public ErrorResponse(IRestResponse restResponse)
            : base(restResponse)
        {
        }

        /// <summary>Gets the response content as an instance of the specified type.</summary>
        /// <param name="stream">The response stream.</param>
        /// <returns>The response content.</returns>
        protected override ErrorResult Deserialize(Stream stream)
        {
            if (this.StatusCode.IsSuccessStatusCode())
            {
                // if the service returned a success code
                throw new InvalidOperationException();
            }

            if (!this.IsJsonResponse)
            {
                return new ErrorResult { Text = this.StatusDescription };
            }

            using (var streamReader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(streamReader))
            {
                var serializer = JsonSerializer.Create();
                return serializer.Deserialize<ErrorResult>(jsonReader);
            }
        }
    }
}
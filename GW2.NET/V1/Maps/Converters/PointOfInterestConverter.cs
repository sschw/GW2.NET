﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GW2DotNET.V1.Maps.Converters
{
    using GW2DotNET.Common;
    using GW2DotNET.V1.Maps.Contracts.Regions.Subregions.PointsOfInterest;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>Converts an object to and/or from JSON.</summary>
    public class PointOfInterestConverter : TypeDiscriminatorConverter<PointOfInterest>
    {
        /// <summary>Reads the JSON representation of the object.</summary>
        /// <param name="reader">The <see cref="T:Newtonsoft.Json.JsonReader"/> to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>The object value.</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // Read the entire JSON object into memory
            var content = JObject.Load(reader);

            // Get the type discriminator
            var typeProperty = content.Property("type");
            var discriminator = typeProperty.Value.ToString();

            // Remove the type discriminator from the JSON object
            typeProperty.Remove();

            // Get a corresponding System.Type
            Type type;
            type = this.KnownTypes.TryGetValue(discriminator, out type) ? type : typeof(UnknownPointOfInterest);

            // Try to hand over execution to a more specific converter
            var converter = serializer.Converters.FirstOrDefault(jsonConverter => jsonConverter.CanConvert(type));
            if (converter != null)
            {
                // Let the other converter deserialize the result
                return converter.ReadJson(content.CreateReader(), type, existingValue, serializer);
            }

            // Deserialize the result
            return serializer.Deserialize(content.CreateReader(), type);
        }
    }
}
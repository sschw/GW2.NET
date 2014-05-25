﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChatLinkConverter.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Provides a type converter to convert string objects to and from chat link representations.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2DotNET.ChatLinks
{
    using System;
    using System.ComponentModel;
    using System.Globalization;

    using GW2DotNET.Utilities;

    /// <summary>Provides a type converter to convert string objects to and from chat link representations.</summary>
    /// <typeparam name="T">The type of chat link.</typeparam>
    internal abstract class ChatLinkConverter<T> : ChatLinkConverterBase
        where T : ChatLink, new()
    {
        /// <summary>Gets the chat link header.</summary>
        protected abstract byte Header { get; }

        /// <summary>Gets a value indicating whether this converter can convert an object in the given source type to a string using the specified context.</summary>
        /// <returns>true if this converter can perform the conversion; otherwise, false.</returns>
        /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context. </param>
        /// <param name="sourceType">A <see cref="T:System.Type"/> that represents the type you wish to convert from. </param>
        public override sealed bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType != typeof(string) && !typeof(T).IsAssignableFrom(sourceType))
            {
                return false;
            }

            if (context == null)
            {
                return true;
            }

            var input = context.Instance as string;
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            return this.GetHeader(input) == this.Header;
        }

        /// <summary>Returns whether this converter can convert the object to the specified type, using the specified context.</summary>
        /// <returns>true if this converter can perform the conversion; otherwise, false.</returns>
        /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context. </param>
        /// <param name="destinationType">A <see cref="T:System.Type"/> that represents the type you want to convert to. </param>
        public override sealed bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return typeof(T).IsAssignableFrom(destinationType);
        }

        /// <summary>Converts the specified value object to a <see cref="T:System.String"/> object.</summary>
        /// <returns>An <see cref="T:System.Object"/> that represents the converted value.</returns>
        /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context. </param>
        /// <param name="culture">The <see cref="T:System.Globalization.CultureInfo"/> to use. </param>
        /// <param name="value">The <see cref="T:System.Object"/> to convert. </param>
        /// <exception cref="T:System.NotSupportedException">The conversion could not be performed. </exception>
        public override sealed object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            var buffer = this.GetBytes((string)value);
            Preconditions.Ensure(Buffer.GetByte(buffer, 0) == this.Header);
            var bytes = new byte[buffer.Length - 1];
            Buffer.BlockCopy(buffer, 1, bytes, 0, buffer.Length - 1);
            return this.ConvertFromBytes(bytes);
        }

        /// <summary>Converts the given value object to the specified type, using the specified context and culture information.</summary>
        /// <returns>An <see cref="T:System.Object"/> that represents the converted value.</returns>
        /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context. </param>
        /// <param name="culture">A <see cref="T:System.Globalization.CultureInfo"/>. If null is passed, the current culture is assumed. </param>
        /// <param name="value">The <see cref="T:System.Object"/> to convert. </param>
        /// <param name="destinationType">The <see cref="T:System.Type"/> to convert the <paramref name="value"/> parameter to. </param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="destinationType"/> parameter is null. </exception>
        /// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
        public override sealed object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            var bytes = this.ConvertToBytes((T)value);
            var buffer = new byte[bytes.Length + 1];
            Buffer.SetByte(buffer, 0, this.Header);
            Buffer.BlockCopy(bytes, 0, buffer, 1, bytes.Length);
            var base64 = Convert.ToBase64String(buffer);
            return string.Format(@"[&{0}]", base64);
        }

        /// <summary>Converts the given byte array to the specified chat link type.</summary>
        /// <param name="bytes">The byte array.</param>
        /// <returns>A chat link.</returns>
        protected abstract T ConvertFromBytes(byte[] bytes);

        /// <summary>Converts the given chat link to a byte array.</summary>
        /// <param name="value">The chat link.</param>
        /// <returns>A byte array.</returns>
        protected abstract byte[] ConvertToBytes(T value);
    }
}
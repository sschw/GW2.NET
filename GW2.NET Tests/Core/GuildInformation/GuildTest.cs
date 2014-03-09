﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GuildTest.cs" company="">
//   
// </copyright>
// <summary>
//    The guild test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2DotNET.Core.GuildInformation
{
    using System;

    using GW2DotNET.V1.Core.GuildInformation.Details;

    using Newtonsoft.Json;

    using NUnit.Framework;

    /// <summary>The guild test.</summary>
    [TestFixture]
    public class GuildTest
    {
        #region Fields

        /// <summary>The guild.</summary>
        private Guild guild;

        #endregion

        #region Public Methods and Operators

        /// <summary>The guild_ emblem reflects input.</summary>
        [Test]
        [Category("guild_details.json")]
        public void Guild_EmblemReflectsInput()
        {
            var expected = new Emblem();
            Emblem actual = this.guild.Emblem;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>The guild_ extension data is empty.</summary>
        [Test]
        [Category("guild_details.json")]
        [Category("ExtensionData")]
        public void Guild_ExtensionDataIsEmpty()
        {
            Assert.IsEmpty(this.guild.ExtensionData);
        }

        /// <summary>The guild_ guild id reflects input.</summary>
        [Test]
        [Category("guild_details.json")]
        public void Guild_GuildIdReflectsInput()
        {
            Guid expected = default(Guid);
            Guid actual = this.guild.GuildId;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>The guild_ name reflects input.</summary>
        [Test]
        [Category("guild_details.json")]
        public void Guild_NameReflectsInput()
        {
            string expected = string.Empty;
            string actual = this.guild.Name;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>The guild_ tag reflects input.</summary>
        [Test]
        [Category("guild_details.json")]
        public void Guild_TagReflectsInput()
        {
            string expected = string.Empty;
            string actual = this.guild.Tag;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>The initialize.</summary>
        [SetUp]
        public void Initialize()
        {
            const string input = "{\"guild_id\":\"00000000-0000-0000-0000-000000000000\",\"guild_name\":\"\",\"tag\":\"\",\"emblem\":{}}";
            this.guild = JsonConvert.DeserializeObject<Guild>(input);
        }

        #endregion
    }
}
﻿namespace GW2NET.V2.Colors.Converters
{
    using GW2NET.Common;

    using Xunit;

    public class ColorModelConverterTests
    {
        private readonly ColorConverterMock colorConverter;

        private readonly ColorModelConverter converter;

        public ColorModelConverterTests()
        {
            this.colorConverter = new ColorConverterMock();
            this.converter = new ColorModelConverter(this.colorConverter);
        }

        [Theory]
        [InlineData(15, 1.25, 38, 0.28125, 1.44531, new[] { 124, 108, 83 })]
        [InlineData(-8, 1, 34, 0.3125, 1.09375, new[] { 65, 49, 29 })]
        [InlineData(5, 1.05469, 38, 0.101563, 1.36719, new[] { 96, 91, 83 })]
        public void CanConvert(int brightness, double contrast, int hue, double saturation, double lightness, int[] rgb)
        {
            var value = new ColorModelDataContract
                            {
                                Brightness = brightness,
                                Contrast = contrast,
                                Hue = hue,
                                Saturation = saturation,
                                Lightness = lightness,
                                Rgb = rgb
                            };
            var state = new Response<ColorModelDataContract>
                            {
                                Content = value
                            };
            var result = this.converter.Convert(value, state);
            Assert.NotNull(result);
            Assert.Equal(brightness, result.Brightness);
            Assert.Equal(contrast, result.Contrast);
            Assert.Equal(hue, result.Hue);
            Assert.Equal(saturation, result.Saturation);
            Assert.Equal(lightness, result.Lightness);
            Assert.Equal(1, this.colorConverter.ConvertCount);
        }
    }
}

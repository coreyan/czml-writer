// <auto-generated>
// This file was generated automatically by GenerateFromSchema. Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer
// </auto-generated>

using CesiumLanguageWriter.Advanced;
using System;
using JetBrains.Annotations;
using System.Drawing;
using System.Collections.Generic;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>ImageMaterial</c> to a <see cref="CesiumOutputStream"/>. A <c>ImageMaterial</c> is a material that fills the surface with an image.
    /// </summary>
    public class ImageMaterialCesiumWriter : CesiumPropertyWriter<ImageMaterialCesiumWriter>
    {
        /// <summary>
        /// The name of the <c>image</c> property.
        /// </summary>
        public const string ImagePropertyName = "image";

        /// <summary>
        /// The name of the <c>repeat</c> property.
        /// </summary>
        public const string RepeatPropertyName = "repeat";

        /// <summary>
        /// The name of the <c>color</c> property.
        /// </summary>
        public const string ColorPropertyName = "color";

        /// <summary>
        /// The name of the <c>transparent</c> property.
        /// </summary>
        public const string TransparentPropertyName = "transparent";

        private readonly Lazy<UriCesiumWriter> m_image = new Lazy<UriCesiumWriter>(() => new UriCesiumWriter(ImagePropertyName), false);
        private readonly Lazy<RepeatCesiumWriter> m_repeat = new Lazy<RepeatCesiumWriter>(() => new RepeatCesiumWriter(RepeatPropertyName), false);
        private readonly Lazy<ColorCesiumWriter> m_color = new Lazy<ColorCesiumWriter>(() => new ColorCesiumWriter(ColorPropertyName), false);
        private readonly Lazy<BooleanCesiumWriter> m_transparent = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(TransparentPropertyName), false);

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        public ImageMaterialCesiumWriter([NotNull] string propertyName)
            : base(propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected ImageMaterialCesiumWriter([NotNull] ImageMaterialCesiumWriter existingInstance)
            : base(existingInstance)
        {
        }

        /// <inheritdoc/>
        public override ImageMaterialCesiumWriter Clone()
        {
            return new ImageMaterialCesiumWriter(this);
        }

        /// <summary>
        /// Gets the writer for the <c>image</c> property. The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing. The <c>image</c> property defines the image to display on the surface.
        /// </summary>
        [NotNull]
        public UriCesiumWriter ImageWriter
        {
            get { return m_image.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>image</c> property. The <c>image</c> property defines the image to display on the surface.
        /// </summary>
        [NotNull]
        public UriCesiumWriter OpenImageProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ImageWriter);
        }

        /// <summary>
        /// Writes a value for the <c>image</c> property as a <c>uri</c> value. The <c>image</c> property specifies the image to display on the surface.
        /// </summary>
        /// <param name="resource">A resource object describing external data.</param>
        public void WriteImageProperty(CesiumResource resource)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteUri(resource);
            }
        }

        /// <summary>
        /// Writes a value for the <c>image</c> property as a <c>uri</c> value. The <c>image</c> property specifies the image to display on the surface.
        /// </summary>
        /// <param name="uri">The URI of the data.</param>
        /// <param name="resourceBehavior">An enumeration describing how to include the URI in the document. For even more control, use the overload that takes a ICesiumUriResolver.</param>
        public void WriteImageProperty(Uri uri, CesiumResourceBehavior resourceBehavior)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteUri(uri, resourceBehavior);
            }
        }

        /// <summary>
        /// Writes a value for the <c>image</c> property as a <c>uri</c> value. The <c>image</c> property specifies the image to display on the surface.
        /// </summary>
        /// <param name="uri">The URI of the data.</param>
        /// <param name="resourceBehavior">An enumeration describing how to include the URI in the document. For even more control, use the overload that takes a ICesiumUriResolver.</param>
        public void WriteImageProperty(string uri, CesiumResourceBehavior resourceBehavior)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteUri(uri, resourceBehavior);
            }
        }

        /// <summary>
        /// Writes a value for the <c>image</c> property as a <c>uri</c> value. The <c>image</c> property specifies the image to display on the surface.
        /// </summary>
        /// <param name="uri">The URI of the data. The provided ICesiumUriResolver will be used to build the final URI embedded in the document.</param>
        /// <param name="resolver">An ICesiumUriResolver used to build the final URI that will be embedded in the document.</param>
        public void WriteImageProperty(Uri uri, ICesiumUriResolver resolver)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteUri(uri, resolver);
            }
        }

        /// <summary>
        /// Writes a value for the <c>image</c> property as a <c>uri</c> value. The <c>image</c> property specifies the image to display on the surface.
        /// </summary>
        /// <param name="uri">The URI of the data. The provided ICesiumUriResolver will be used to build the final URI embedded in the document.</param>
        /// <param name="resolver">An ICesiumUriResolver used to build the final URI that will be embedded in the document.</param>
        public void WriteImageProperty(string uri, ICesiumUriResolver resolver)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteUri(uri, resolver);
            }
        }

        /// <summary>
        /// Writes a value for the <c>image</c> property as a <c>uri</c> value. The <c>image</c> property specifies the image to display on the surface.
        /// </summary>
        /// <param name="image">The image. A data URI will be created for this image, using PNG encoding.</param>
        public void WriteImageProperty(Image image)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteUri(image);
            }
        }

        /// <summary>
        /// Writes a value for the <c>image</c> property as a <c>uri</c> value. The <c>image</c> property specifies the image to display on the surface.
        /// </summary>
        /// <param name="image">The image. A data URI will be created for this image.</param>
        /// <param name="imageFormat">The image format to use to encode the image in the data URI.</param>
        public void WriteImageProperty(Image image, CesiumImageFormat imageFormat)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteUri(image, imageFormat);
            }
        }

        /// <summary>
        /// Writes a value for the <c>image</c> property as a <c>reference</c> value. The <c>image</c> property specifies the image to display on the surface.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteImagePropertyReference(Reference value)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>image</c> property as a <c>reference</c> value. The <c>image</c> property specifies the image to display on the surface.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteImagePropertyReference(string value)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>image</c> property as a <c>reference</c> value. The <c>image</c> property specifies the image to display on the surface.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteImagePropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>image</c> property as a <c>reference</c> value. The <c>image</c> property specifies the image to display on the surface.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteImagePropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>repeat</c> property. The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing. The <c>repeat</c> property defines the number of times the image repeats along each axis. If not specified, the default value is [1, 1].
        /// </summary>
        [NotNull]
        public RepeatCesiumWriter RepeatWriter
        {
            get { return m_repeat.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>repeat</c> property. The <c>repeat</c> property defines the number of times the image repeats along each axis. If not specified, the default value is [1, 1].
        /// </summary>
        [NotNull]
        public RepeatCesiumWriter OpenRepeatProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(RepeatWriter);
        }

        /// <summary>
        /// Writes a value for the <c>repeat</c> property as a <c>cartesian2</c> value. The <c>repeat</c> property specifies the number of times the image repeats along each axis. If not specified, the default value is [1, 1].
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteRepeatProperty(Rectangular value)
        {
            using (var writer = OpenRepeatProperty())
            {
                writer.WriteCartesian2(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>repeat</c> property as a <c>cartesian2</c> value. The <c>repeat</c> property specifies the number of times the image repeats along each axis. If not specified, the default value is [1, 1].
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        public void WriteRepeatProperty(double x, double y)
        {
            using (var writer = OpenRepeatProperty())
            {
                writer.WriteCartesian2(x, y);
            }
        }

        /// <summary>
        /// Writes a value for the <c>repeat</c> property as a <c>cartesian2</c> value. The <c>repeat</c> property specifies the number of times the image repeats along each axis. If not specified, the default value is [1, 1].
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteRepeatProperty(IList<JulianDate> dates, IList<Rectangular> values)
        {
            using (var writer = OpenRepeatProperty())
            {
                writer.WriteCartesian2(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>repeat</c> property as a <c>cartesian2</c> value. The <c>repeat</c> property specifies the number of times the image repeats along each axis. If not specified, the default value is [1, 1].
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteRepeatProperty(IList<JulianDate> dates, IList<Rectangular> values, int startIndex, int length)
        {
            using (var writer = OpenRepeatProperty())
            {
                writer.WriteCartesian2(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>repeat</c> property as a <c>reference</c> value. The <c>repeat</c> property specifies the number of times the image repeats along each axis. If not specified, the default value is [1, 1].
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteRepeatPropertyReference(Reference value)
        {
            using (var writer = OpenRepeatProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>repeat</c> property as a <c>reference</c> value. The <c>repeat</c> property specifies the number of times the image repeats along each axis. If not specified, the default value is [1, 1].
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteRepeatPropertyReference(string value)
        {
            using (var writer = OpenRepeatProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>repeat</c> property as a <c>reference</c> value. The <c>repeat</c> property specifies the number of times the image repeats along each axis. If not specified, the default value is [1, 1].
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteRepeatPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenRepeatProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>repeat</c> property as a <c>reference</c> value. The <c>repeat</c> property specifies the number of times the image repeats along each axis. If not specified, the default value is [1, 1].
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteRepeatPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenRepeatProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>color</c> property. The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing. The <c>color</c> property defines the color of the image. This color value is multiplied with the image to produce the final color. If not specified, the default value is white.
        /// </summary>
        [NotNull]
        public ColorCesiumWriter ColorWriter
        {
            get { return m_color.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>color</c> property. The <c>color</c> property defines the color of the image. This color value is multiplied with the image to produce the final color. If not specified, the default value is white.
        /// </summary>
        [NotNull]
        public ColorCesiumWriter OpenColorProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ColorWriter);
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgba</c> value. The <c>color</c> property specifies the color of the image. This color value is multiplied with the image to produce the final color. If not specified, the default value is white.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteColorProperty(Color color)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgba</c> value. The <c>color</c> property specifies the color of the image. This color value is multiplied with the image to produce the final color. If not specified, the default value is white.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 255.</param>
        /// <param name="green">The green component in the range 0 to 255.</param>
        /// <param name="blue">The blue component in the range 0 to 255.</param>
        /// <param name="alpha">The alpha component in the range 0 to 255.</param>
        public void WriteColorProperty(int red, int green, int blue, int alpha)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgba</c> value. The <c>color</c> property specifies the color of the image. This color value is multiplied with the image to produce the final color. If not specified, the default value is white.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteColorProperty(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgba</c> value. The <c>color</c> property specifies the color of the image. This color value is multiplied with the image to produce the final color. If not specified, the default value is white.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteColorProperty(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgbaf</c> value. The <c>color</c> property specifies the color of the image. This color value is multiplied with the image to produce the final color. If not specified, the default value is white.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteColorPropertyRgbaf(Color color)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgbaf</c> value. The <c>color</c> property specifies the color of the image. This color value is multiplied with the image to produce the final color. If not specified, the default value is white.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 1.0.</param>
        /// <param name="green">The green component in the range 0 to 1.0.</param>
        /// <param name="blue">The blue component in the range 0 to 1.0.</param>
        /// <param name="alpha">The alpha component in the range 0 to 1.0.</param>
        public void WriteColorPropertyRgbaf(float red, float green, float blue, float alpha)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgbaf</c> value. The <c>color</c> property specifies the color of the image. This color value is multiplied with the image to produce the final color. If not specified, the default value is white.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgbaf</c> value. The <c>color</c> property specifies the color of the image. This color value is multiplied with the image to produce the final color. If not specified, the default value is white.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>reference</c> value. The <c>color</c> property specifies the color of the image. This color value is multiplied with the image to produce the final color. If not specified, the default value is white.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteColorPropertyReference(Reference value)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>reference</c> value. The <c>color</c> property specifies the color of the image. This color value is multiplied with the image to produce the final color. If not specified, the default value is white.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteColorPropertyReference(string value)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>reference</c> value. The <c>color</c> property specifies the color of the image. This color value is multiplied with the image to produce the final color. If not specified, the default value is white.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteColorPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>reference</c> value. The <c>color</c> property specifies the color of the image. This color value is multiplied with the image to produce the final color. If not specified, the default value is white.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteColorPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>transparent</c> property. The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing. The <c>transparent</c> property defines whether or not the image has transparency. If not specified, the default value is <see langword="false"/>.
        /// </summary>
        [NotNull]
        public BooleanCesiumWriter TransparentWriter
        {
            get { return m_transparent.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>transparent</c> property. The <c>transparent</c> property defines whether or not the image has transparency. If not specified, the default value is <see langword="false"/>.
        /// </summary>
        [NotNull]
        public BooleanCesiumWriter OpenTransparentProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(TransparentWriter);
        }

        /// <summary>
        /// Writes a value for the <c>transparent</c> property as a <c>boolean</c> value. The <c>transparent</c> property specifies whether or not the image has transparency. If not specified, the default value is <see langword="false"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteTransparentProperty(bool value)
        {
            using (var writer = OpenTransparentProperty())
            {
                writer.WriteBoolean(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>transparent</c> property as a <c>reference</c> value. The <c>transparent</c> property specifies whether or not the image has transparency. If not specified, the default value is <see langword="false"/>.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteTransparentPropertyReference(Reference value)
        {
            using (var writer = OpenTransparentProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>transparent</c> property as a <c>reference</c> value. The <c>transparent</c> property specifies whether or not the image has transparency. If not specified, the default value is <see langword="false"/>.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteTransparentPropertyReference(string value)
        {
            using (var writer = OpenTransparentProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>transparent</c> property as a <c>reference</c> value. The <c>transparent</c> property specifies whether or not the image has transparency. If not specified, the default value is <see langword="false"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteTransparentPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenTransparentProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>transparent</c> property as a <c>reference</c> value. The <c>transparent</c> property specifies whether or not the image has transparency. If not specified, the default value is <see langword="false"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteTransparentPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenTransparentProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

    }
}

using System;
using Avalonia.Data.Converters;
using Avalonia.Markup.Xaml;
using System.Globalization;
using Avalonia.Data;

namespace IconPacks.Avalonia.Converter
{
    /// <summary>
    /// MarkupConverter is a MarkupExtension which can be used for IValueConverter.
    /// </summary>
    public abstract class MarkupConverter : MarkupExtension, IValueConverter
    {
        /// <inheritdoc />
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        /// <summary>
        /// Converts a value.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="targetType">The type of the target.</param>
        /// <param name="parameter">A user-defined parameter.</param>
        /// <param name="culture">The culture to use.</param>
        /// <returns>The converted value.</returns>
        /// <remarks>
        /// This method should not throw exceptions. If the value is not convertible, return
        /// a <see cref="BindingNotification"/> in an error state. Any exceptions thrown will be
        /// treated as an application exception.
        /// </remarks>
        protected abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        /// <summary>
        /// Converts a value.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="targetType">The type of the target.</param>
        /// <param name="parameter">A user-defined parameter.</param>
        /// <param name="culture">The culture to use.</param>
        /// <returns>The converted value.</returns>
        /// <remarks>
        /// This method should not throw exceptions. If the value is not convertible, return
        /// a <see cref="BindingNotification"/> in an error state. Any exceptions thrown will be
        /// treated as an application exception.
        /// </remarks>
        protected abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);

        /// <inheritdoc />
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return Convert(value, targetType, parameter, culture);
            }
            catch
            {
                return BindingOperations.DoNothing;
            }
        }

        /// <inheritdoc />
        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return ConvertBack(value, targetType, parameter, culture);
            }
            catch
            {
                return BindingOperations.DoNothing;
            }
        }
    }
}
using System;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.FontAwesome
{
    public class FontAwesomeImageExtension : BasePackIconImageExtension
    {
        public FontAwesomeImageExtension()
        {
        }

        public FontAwesomeImageExtension(PackIconFontAwesomeKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconFontAwesomeKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return CreateImageSource(this.Kind, this.Brush ?? Brushes.Black);
        }

        /// <inheritdoc />
        protected override string GetPathData(object iconKind)
        {
            string data = null;
            if (iconKind is PackIconFontAwesomeKind kind)
            {
                PackIconDataFactory<PackIconFontAwesomeKind>.DataIndex.Value?.TryGetValue(kind, out data);
            }

            return data;
        }
    }
}
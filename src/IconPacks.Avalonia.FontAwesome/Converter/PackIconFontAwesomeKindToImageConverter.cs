using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Converter;

namespace IconPacks.Avalonia.FontAwesome.Converter
{
    public class PackIconFontAwesomeKindToImageConverter : PackIconKindToImageConverterBase
    {
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
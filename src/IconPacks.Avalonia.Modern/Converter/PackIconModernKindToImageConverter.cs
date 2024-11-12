using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Converter;

namespace IconPacks.Avalonia.Modern.Converter
{
    public class PackIconModernKindToImageConverter : PackIconKindToImageConverterBase
    {
        /// <inheritdoc />
        protected override string GetPathData(object iconKind)
        {
            string data = null;
            if (iconKind is PackIconModernKind kind)
            {
                PackIconDataFactory<PackIconModernKind>.DataIndex.Value?.TryGetValue(kind, out data);
            }

            return data;
        }
    }
}
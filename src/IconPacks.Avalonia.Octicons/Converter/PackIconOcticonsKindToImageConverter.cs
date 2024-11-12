using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Converter;

namespace IconPacks.Avalonia.Octicons.Converter
{
    public class PackIconOcticonsKindToImageConverter : PackIconKindToImageConverterBase
    {
        /// <inheritdoc />
        protected override string GetPathData(object iconKind)
        {
            string data = null;
            if (iconKind is PackIconOcticonsKind kind)
            {
                PackIconDataFactory<PackIconOcticonsKind>.DataIndex.Value?.TryGetValue(kind, out data);
            }

            return data;
        }
    }
}
using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Converter;

namespace IconPacks.Avalonia.Microns.Converter
{
    public class PackIconMicronsKindToImageConverter : PackIconKindToImageConverterBase
    {
        /// <inheritdoc />
        protected override string GetPathData(object iconKind)
        {
            string data = null;
            if (iconKind is PackIconMicronsKind kind)
            {
                PackIconDataFactory<PackIconMicronsKind>.DataIndex.Value?.TryGetValue(kind, out data);
            }

            return data;
        }
    }
}
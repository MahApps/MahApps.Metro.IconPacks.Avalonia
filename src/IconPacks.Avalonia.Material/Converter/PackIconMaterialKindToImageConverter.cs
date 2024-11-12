using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Converter;

namespace IconPacks.Avalonia.Material.Converter
{
    public class PackIconMaterialKindToImageConverter : PackIconKindToImageConverterBase
    {
        /// <inheritdoc />
        protected override string GetPathData(object iconKind)
        {
            string data = null;
            if (iconKind is PackIconMaterialKind kind)
            {
                PackIconDataFactory<PackIconMaterialKind>.DataIndex.Value?.TryGetValue(kind, out data);
            }

            return data;
        }
    }
}
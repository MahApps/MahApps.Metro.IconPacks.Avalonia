using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Converter;

namespace IconPacks.Avalonia.MaterialLight.Converter
{
    public class PackIconMaterialLightKindToImageConverter : PackIconKindToImageConverterBase
    {
        /// <inheritdoc />
        protected override string GetPathData(object iconKind)
        {
            string data = null;
            if (iconKind is PackIconMaterialLightKind kind)
            {
                PackIconDataFactory<PackIconMaterialLightKind>.DataIndex.Value?.TryGetValue(kind, out data);
            }

            return data;
        }
    }
}
using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Converter;

namespace IconPacks.Avalonia.Entypo.Converter
{
    public class PackIconEntypoKindToImageConverter : PackIconKindToImageConverterBase
    {
        /// <inheritdoc />
        protected override string GetPathData(object iconKind)
        {
            string data = null;
            if (iconKind is PackIconEntypoKind kind)
            {
                PackIconDataFactory<PackIconEntypoKind>.DataIndex.Value?.TryGetValue(kind, out data);
            }

            return data;
        }
    }
}
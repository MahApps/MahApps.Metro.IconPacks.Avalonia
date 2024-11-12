using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Converter;

namespace IconPacks.Avalonia.RemixIcon.Converter
{
    public class PackIconRemixIconKindToImageConverter : PackIconKindToImageConverterBase
    {
        /// <inheritdoc />
        protected override string GetPathData(object iconKind)
        {
            string data = null;
            if (iconKind is PackIconRemixIconKind kind)
            {
                PackIconDataFactory<PackIconRemixIconKind>.DataIndex.Value?.TryGetValue(kind, out data);
            }

            return data;
        }
    }
}
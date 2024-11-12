using System;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.Octicons
{
    public class OcticonsImageExtension : BasePackIconImageExtension
    {
        public OcticonsImageExtension()
        {
        }

        public OcticonsImageExtension(PackIconOcticonsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconOcticonsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return CreateImageSource(this.Kind, this.Brush ?? Brushes.Black);
        }

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
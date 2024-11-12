using System;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.MaterialLight
{
    public class MaterialLightImageExtension : BasePackIconImageExtension
    {
        public MaterialLightImageExtension()
        {
        }

        public MaterialLightImageExtension(PackIconMaterialLightKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconMaterialLightKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return CreateImageSource(this.Kind, this.Brush ?? Brushes.Black);
        }

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
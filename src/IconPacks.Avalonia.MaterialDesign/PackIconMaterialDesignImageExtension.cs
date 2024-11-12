using System;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.MaterialDesign
{
    public class MaterialDesignImageExtension : BasePackIconImageExtension
    {
        public MaterialDesignImageExtension()
        {
        }

        public MaterialDesignImageExtension(PackIconMaterialDesignKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconMaterialDesignKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return CreateImageSource(this.Kind, this.Brush ?? Brushes.Black);
        }

        /// <inheritdoc />
        protected override string GetPathData(object iconKind)
        {
            string data = null;
            if (iconKind is PackIconMaterialDesignKind kind)
            {
                PackIconDataFactory<PackIconMaterialDesignKind>.DataIndex.Value?.TryGetValue(kind, out data);
            }

            return data;
        }
    }
}
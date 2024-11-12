using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.MaterialDesign
{
    public class MaterialDesignExtension : BasePackIconExtension
    {
        public MaterialDesignExtension()
        {
        }

        public MaterialDesignExtension(PackIconMaterialDesignKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconMaterialDesignKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconMaterialDesign, PackIconMaterialDesignKind>(this.Kind);
        }
    }
}
using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.Material
{
    public class MaterialExtension : BasePackIconExtension
    {
        public MaterialExtension()
        {
        }

        public MaterialExtension(PackIconMaterialKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconMaterialKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconMaterial, PackIconMaterialKind>(this.Kind);
        }
    }
}
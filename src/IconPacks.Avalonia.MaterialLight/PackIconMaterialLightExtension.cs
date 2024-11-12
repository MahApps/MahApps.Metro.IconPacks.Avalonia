using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.MaterialLight
{
    public class MaterialLightExtension : BasePackIconExtension
    {
        public MaterialLightExtension()
        {
        }

        public MaterialLightExtension(PackIconMaterialLightKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconMaterialLightKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconMaterialLight, PackIconMaterialLightKind>(this.Kind);
        }
    }
}
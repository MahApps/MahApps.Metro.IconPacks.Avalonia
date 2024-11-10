using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.BoxIcons
{
    public class BoxIconsExtension : BasePackIconExtension
    {
        public BoxIconsExtension()
        {
        }

        public BoxIconsExtension(PackIconBoxIconsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconBoxIconsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconBoxIcons, PackIconBoxIconsKind>(this.Kind);
        }
    }
}
using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.PixelartIcons
{
    public class PixelartIconsExtension : BasePackIconExtension
    {
        public PixelartIconsExtension()
        {
        }

        public PixelartIconsExtension(PackIconPixelartIconsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconPixelartIconsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconPixelartIcons, PackIconPixelartIconsKind>(this.Kind);
        }
    }
}
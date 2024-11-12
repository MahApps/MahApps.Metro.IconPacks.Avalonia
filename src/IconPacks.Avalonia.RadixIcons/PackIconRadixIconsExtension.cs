using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.RadixIcons
{
    public class RadixIconsExtension : BasePackIconExtension
    {
        public RadixIconsExtension()
        {
        }

        public RadixIconsExtension(PackIconRadixIconsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconRadixIconsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconRadixIcons, PackIconRadixIconsKind>(this.Kind);
        }
    }
}
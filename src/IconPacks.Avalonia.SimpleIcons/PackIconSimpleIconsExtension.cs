using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.SimpleIcons
{
    public class SimpleIconsExtension : BasePackIconExtension
    {
        public SimpleIconsExtension()
        {
        }

        public SimpleIconsExtension(PackIconSimpleIconsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconSimpleIconsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconSimpleIcons, PackIconSimpleIconsKind>(this.Kind);
        }
    }
}
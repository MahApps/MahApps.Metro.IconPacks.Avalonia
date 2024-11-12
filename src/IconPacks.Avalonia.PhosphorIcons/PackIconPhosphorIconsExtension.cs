using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.PhosphorIcons
{
    public class PhosphorIconsExtension : BasePackIconExtension
    {
        public PhosphorIconsExtension()
        {
        }

        public PhosphorIconsExtension(PackIconPhosphorIconsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconPhosphorIconsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconPhosphorIcons, PackIconPhosphorIconsKind>(this.Kind);
        }
    }
}
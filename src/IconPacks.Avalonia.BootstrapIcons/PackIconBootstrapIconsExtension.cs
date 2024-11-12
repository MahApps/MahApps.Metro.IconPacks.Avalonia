using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.BootstrapIcons
{
    public class BootstrapIconsExtension : BasePackIconExtension
    {
        public BootstrapIconsExtension()
        {
        }

        public BootstrapIconsExtension(PackIconBootstrapIconsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconBootstrapIconsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconBootstrapIcons, PackIconBootstrapIconsKind>(this.Kind);
        }
    }
}
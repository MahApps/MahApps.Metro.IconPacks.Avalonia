using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.FeatherIcons
{
    public class FeatherIconsExtension : BasePackIconExtension
    {
        public FeatherIconsExtension()
        {
        }

        public FeatherIconsExtension(PackIconFeatherIconsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconFeatherIconsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconFeatherIcons, PackIconFeatherIconsKind>(this.Kind);
        }
    }
}
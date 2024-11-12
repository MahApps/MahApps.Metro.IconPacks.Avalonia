using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.PicolIcons
{
    public class PicolIconsExtension : BasePackIconExtension
    {
        public PicolIconsExtension()
        {
        }

        public PicolIconsExtension(PackIconPicolIconsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconPicolIconsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconPicolIcons, PackIconPicolIconsKind>(this.Kind);
        }
    }
}
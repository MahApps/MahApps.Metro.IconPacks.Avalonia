using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.VaadinIcons
{
    public class VaadinIconsExtension : BasePackIconExtension
    {
        public VaadinIconsExtension()
        {
        }

        public VaadinIconsExtension(PackIconVaadinIconsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconVaadinIconsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconVaadinIcons, PackIconVaadinIconsKind>(this.Kind);
        }
    }
}
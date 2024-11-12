using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.CircumIcons
{
    public class CircumIconsExtension : BasePackIconExtension
    {
        public CircumIconsExtension()
        {
        }

        public CircumIconsExtension(PackIconCircumIconsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconCircumIconsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconCircumIcons, PackIconCircumIconsKind>(this.Kind);
        }
    }
}
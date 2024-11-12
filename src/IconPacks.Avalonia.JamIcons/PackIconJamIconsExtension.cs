using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.JamIcons
{
    public class JamIconsExtension : BasePackIconExtension
    {
        public JamIconsExtension()
        {
        }

        public JamIconsExtension(PackIconJamIconsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconJamIconsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconJamIcons, PackIconJamIconsKind>(this.Kind);
        }
    }
}
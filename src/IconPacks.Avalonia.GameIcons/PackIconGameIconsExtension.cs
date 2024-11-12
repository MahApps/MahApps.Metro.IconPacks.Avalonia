using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.GameIcons
{
    public class GameIconsExtension : BasePackIconExtension
    {
        public GameIconsExtension()
        {
        }

        public GameIconsExtension(PackIconGameIconsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconGameIconsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconGameIcons, PackIconGameIconsKind>(this.Kind);
        }
    }
}
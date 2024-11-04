using System;
using Avalonia.Markup.Xaml;

namespace IconPacks.Avalonia
{
    public class BoxIconsExtension : BasePackIconExtension
    {
        public BoxIconsExtension()
        {
        }

        public BoxIconsExtension(PackIconBoxIconsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconBoxIconsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconBoxIcons, PackIconBoxIconsKind>(this.Kind);
        }
    }
}
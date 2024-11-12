using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.Modern
{
    public class ModernExtension : BasePackIconExtension
    {
        public ModernExtension()
        {
        }

        public ModernExtension(PackIconModernKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconModernKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconModern, PackIconModernKind>(this.Kind);
        }
    }
}
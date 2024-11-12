using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.Fontisto
{
    public class FontistoExtension : BasePackIconExtension
    {
        public FontistoExtension()
        {
        }

        public FontistoExtension(PackIconFontistoKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconFontistoKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconFontisto, PackIconFontistoKind>(this.Kind);
        }
    }
}
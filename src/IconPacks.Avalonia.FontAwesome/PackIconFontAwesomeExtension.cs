using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.FontAwesome
{
    public class FontAwesomeExtension : BasePackIconExtension
    {
        public FontAwesomeExtension()
        {
        }

        public FontAwesomeExtension(PackIconFontAwesomeKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconFontAwesomeKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconFontAwesome, PackIconFontAwesomeKind>(this.Kind);
        }
    }
}
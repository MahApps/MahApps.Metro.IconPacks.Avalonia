using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.Fontaudio
{
    public class FontaudioExtension : BasePackIconExtension
    {
        public FontaudioExtension()
        {
        }

        public FontaudioExtension(PackIconFontaudioKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconFontaudioKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconFontaudio, PackIconFontaudioKind>(this.Kind);
        }
    }
}
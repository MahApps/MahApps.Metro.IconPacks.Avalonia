using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.RPGAwesome
{
    public class RPGAwesomeExtension : BasePackIconExtension
    {
        public RPGAwesomeExtension()
        {
        }

        public RPGAwesomeExtension(PackIconRPGAwesomeKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconRPGAwesomeKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconRPGAwesome, PackIconRPGAwesomeKind>(this.Kind);
        }
    }
}
using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.Zondicons
{
    public class ZondiconsExtension : BasePackIconExtension
    {
        public ZondiconsExtension()
        {
        }

        public ZondiconsExtension(PackIconZondiconsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconZondiconsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconZondicons, PackIconZondiconsKind>(this.Kind);
        }
    }
}
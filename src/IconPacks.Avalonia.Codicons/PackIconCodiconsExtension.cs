using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.Codicons
{
    public class CodiconsExtension : BasePackIconExtension
    {
        public CodiconsExtension()
        {
        }

        public CodiconsExtension(PackIconCodiconsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconCodiconsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconCodicons, PackIconCodiconsKind>(this.Kind);
        }
    }
}
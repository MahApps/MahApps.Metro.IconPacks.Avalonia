using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.Ionicons
{
    public class IoniconsExtension : BasePackIconExtension
    {
        public IoniconsExtension()
        {
        }

        public IoniconsExtension(PackIconIoniconsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconIoniconsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconIonicons, PackIconIoniconsKind>(this.Kind);
        }
    }
}
using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.ForkAwesome
{
    public class ForkAwesomeExtension : BasePackIconExtension
    {
        public ForkAwesomeExtension()
        {
        }

        public ForkAwesomeExtension(PackIconForkAwesomeKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconForkAwesomeKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconForkAwesome, PackIconForkAwesomeKind>(this.Kind);
        }
    }
}
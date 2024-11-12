using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.Coolicons
{
    public class CooliconsExtension : BasePackIconExtension
    {
        public CooliconsExtension()
        {
        }

        public CooliconsExtension(PackIconCooliconsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconCooliconsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconCoolicons, PackIconCooliconsKind>(this.Kind);
        }
    }
}
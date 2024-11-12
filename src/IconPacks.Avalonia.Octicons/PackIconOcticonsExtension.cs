using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.Octicons
{
    public class OcticonsExtension : BasePackIconExtension
    {
        public OcticonsExtension()
        {
        }

        public OcticonsExtension(PackIconOcticonsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconOcticonsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconOcticons, PackIconOcticonsKind>(this.Kind);
        }
    }
}
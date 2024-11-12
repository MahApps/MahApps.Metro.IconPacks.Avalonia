using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.Microns
{
    public class MicronsExtension : BasePackIconExtension
    {
        public MicronsExtension()
        {
        }

        public MicronsExtension(PackIconMicronsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconMicronsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconMicrons, PackIconMicronsKind>(this.Kind);
        }
    }
}
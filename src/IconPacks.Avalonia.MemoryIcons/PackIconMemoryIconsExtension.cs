using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.MemoryIcons
{
    public class MemoryIconsExtension : BasePackIconExtension
    {
        public MemoryIconsExtension()
        {
        }

        public MemoryIconsExtension(PackIconMemoryIconsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconMemoryIconsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconMemoryIcons, PackIconMemoryIconsKind>(this.Kind);
        }
    }
}
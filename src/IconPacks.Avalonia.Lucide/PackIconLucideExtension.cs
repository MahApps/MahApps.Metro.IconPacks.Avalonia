using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.Lucide
{
    public class LucideExtension : BasePackIconExtension
    {
        public LucideExtension()
        {
        }

        public LucideExtension(PackIconLucideKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconLucideKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconLucide, PackIconLucideKind>(this.Kind);
        }
    }
}
using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.Typicons
{
    public class TypiconsExtension : BasePackIconExtension
    {
        public TypiconsExtension()
        {
        }

        public TypiconsExtension(PackIconTypiconsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconTypiconsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconTypicons, PackIconTypiconsKind>(this.Kind);
        }
    }
}
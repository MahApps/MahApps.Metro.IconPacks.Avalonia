using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.Unicons
{
    public class UniconsExtension : BasePackIconExtension
    {
        public UniconsExtension()
        {
        }

        public UniconsExtension(PackIconUniconsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconUniconsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconUnicons, PackIconUniconsKind>(this.Kind);
        }
    }
}
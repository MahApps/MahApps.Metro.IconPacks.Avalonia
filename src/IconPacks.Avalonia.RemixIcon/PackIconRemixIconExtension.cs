using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.RemixIcon
{
    public class RemixIconExtension : BasePackIconExtension
    {
        public RemixIconExtension()
        {
        }

        public RemixIconExtension(PackIconRemixIconKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconRemixIconKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconRemixIcon, PackIconRemixIconKind>(this.Kind);
        }
    }
}
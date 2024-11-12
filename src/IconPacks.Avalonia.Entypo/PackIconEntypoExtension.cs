using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.Entypo
{
    public class EntypoExtension : BasePackIconExtension
    {
        public EntypoExtension()
        {
        }

        public EntypoExtension(PackIconEntypoKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconEntypoKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconEntypo, PackIconEntypoKind>(this.Kind);
        }
    }
}
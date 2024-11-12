using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.FileIcons
{
    public class FileIconsExtension : BasePackIconExtension
    {
        public FileIconsExtension()
        {
        }

        public FileIconsExtension(PackIconFileIconsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconFileIconsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconFileIcons, PackIconFileIconsKind>(this.Kind);
        }
    }
}
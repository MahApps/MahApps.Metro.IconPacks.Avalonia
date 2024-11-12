using System;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.RemixIcon
{
    public class RemixIconImageExtension : BasePackIconImageExtension
    {
        public RemixIconImageExtension()
        {
        }

        public RemixIconImageExtension(PackIconRemixIconKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconRemixIconKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return CreateImageSource(this.Kind, this.Brush ?? Brushes.Black);
        }

        /// <inheritdoc />
        protected override string GetPathData(object iconKind)
        {
            string data = null;
            if (iconKind is PackIconRemixIconKind kind)
            {
                PackIconDataFactory<PackIconRemixIconKind>.DataIndex.Value?.TryGetValue(kind, out data);
            }

            return data;
        }
    }
}
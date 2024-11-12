using Avalonia;
using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Attributes;

namespace IconPacks.Avalonia.PixelartIcons
{
    /// <summary>
    /// PixelartIcons are licensed under the [MIT license](<see><cref>https://github.com/halfmage/pixelarticons?tab=MIT-1-ov-file#readme</cref></see>).
    /// Contributions, corrections and requests can be made on GitHub <see><cref>https://pixelarticons.com/</cref></see>.
    /// </summary>
    [MetaData("Pixelarticons", "https://pixelarticons.com/", "https://github.com/halfmage/pixelarticons?tab=MIT-1-ov-file#readme")]
    public class PackIconPixelartIcons : PackIconControlBase
    {
        public PackIconPixelartIcons()
        {
            UpdateIconPseudoClasses(true, false, false);
        }

        public static readonly StyledProperty<PackIconPixelartIconsKind> KindProperty
            = AvaloniaProperty.Register<PackIconPixelartIcons, PackIconPixelartIconsKind>(nameof(Kind));

        /// <summary>
        /// Gets or sets the icon to display.
        /// </summary>
        public PackIconPixelartIconsKind Kind
        {
            get { return GetValue(KindProperty); }
            set { SetValue(KindProperty, value); }
        }

        // We override OnPropertyChanged of the base class. That way we can react on property changes
        protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
        {
            base.OnPropertyChanged(change);

            // if the changed property is the KindProperty, we need to update the stars
            if (change.Property == KindProperty)
            {
                UpdateData();
            }
        }

        protected override void SetKind<TKind>(TKind iconKind)
        {
            this.SetCurrentValue(KindProperty, iconKind);
        }

        protected override void UpdateData()
        {
            if (Kind != default)
            {
                string data = null;
                PackIconDataFactory<PackIconPixelartIconsKind>.DataIndex.Value?.TryGetValue(Kind, out data);
                this.Data = data != null ? StreamGeometry.Parse(data) : null;
            }
            else
            {
                this.Data = null;
            }
        }
    }
}
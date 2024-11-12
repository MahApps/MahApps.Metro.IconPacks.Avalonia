using Avalonia;
using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Attributes;

namespace IconPacks.Avalonia.RadixIcons
{
    /// <summary>
    /// RadixIcons licensed under the MIT License <see><cref>https://github.com/radix-ui/icons?tab=MIT-1-ov-file#readme</cref></see>
    /// Contributions, corrections and requests can be made on GitHub <see><cref>https://github.com/radix-ui/icons</cref></see>.
    /// </summary>
    [MetaData("Radix Icons", "https://github.com/radix-ui/icons", "https://github.com/radix-ui/icons?tab=MIT-1-ov-file#readme")]
    public class PackIconRadixIcons : PackIconControlBase
    {
        public PackIconRadixIcons()
        {
            UpdateIconPseudoClasses(true, false, false);
        }

        public static readonly StyledProperty<PackIconRadixIconsKind> KindProperty
            = AvaloniaProperty.Register<PackIconRadixIcons, PackIconRadixIconsKind>(nameof(Kind));

        /// <summary>
        /// Gets or sets the icon to display.
        /// </summary>
        public PackIconRadixIconsKind Kind
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
                PackIconDataFactory<PackIconRadixIconsKind>.DataIndex.Value?.TryGetValue(Kind, out data);
                this.Data = data != null ? StreamGeometry.Parse(data) : null;
            }
            else
            {
                this.Data = null;
            }
        }
    }
}
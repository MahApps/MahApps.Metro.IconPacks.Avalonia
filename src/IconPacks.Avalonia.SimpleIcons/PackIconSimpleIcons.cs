using Avalonia;
using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Attributes;

namespace IconPacks.Avalonia.SimpleIcons
{
    /// <summary>
    /// Simple Icons licensed under <see><cref>https://github.com/simple-icons/simple-icons?tab=CC0-1.0-1-ov-file#readme</cref></see>. Please read the legal disclaimer <see><cref>https://github.com/simple-icons/simple-icons/blob/master/DISCLAIMER.md</cref></see>.
    /// Contributions, corrections and requests can be made on GitHub <see><cref>https://github.com/simple-icons/simple-icons</cref></see>.
    /// </summary>
    [MetaData("Simple Icons", "https://github.com/simple-icons/simple-icons", "https://github.com/simple-icons/simple-icons?tab=CC0-1.0-1-ov-file#readme")]
    public class PackIconSimpleIcons : PackIconControlBase
    {
        public PackIconSimpleIcons()
        {
            UpdateIconPseudoClasses(true, false, false);
        }

        public static readonly StyledProperty<PackIconSimpleIconsKind> KindProperty
            = AvaloniaProperty.Register<PackIconSimpleIcons, PackIconSimpleIconsKind>(nameof(Kind));

        /// <summary>
        /// Gets or sets the icon to display.
        /// </summary>
        public PackIconSimpleIconsKind Kind
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
                PackIconDataFactory<PackIconSimpleIconsKind>.DataIndex.Value?.TryGetValue(Kind, out data);
                this.Data = data != null ? StreamGeometry.Parse(data) : null;
            }
            else
            {
                this.Data = null;
            }
        }
    }
}
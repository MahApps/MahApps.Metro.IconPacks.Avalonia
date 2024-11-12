using Avalonia;
using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Attributes;

namespace IconPacks.Avalonia.Fontisto
{
    /// <summary>
    /// The Fontisto font is licensed under the [SIL OFL 1.1](<see><cref>https://github.com/kenangundogan/fontisto?tab=readme-ov-file#license</cref></see>).
    /// Contributions, corrections and requests can be made on GitHub <see><cref>https://github.com/kenangundogan/fontisto</cref></see>.
    /// </summary>
    [MetaData("Fontisto", "https://github.com/kenangundogan/fontisto", "https://github.com/kenangundogan/fontisto?tab=readme-ov-file#license")]
    public class PackIconFontisto : PackIconControlBase
    {
        public PackIconFontisto()
        {
            UpdateIconPseudoClasses(true, false, true);
        }

        public static readonly StyledProperty<PackIconFontistoKind> KindProperty
            = AvaloniaProperty.Register<PackIconFontisto, PackIconFontistoKind>(nameof(Kind));

        /// <summary>
        /// Gets or sets the icon to display.
        /// </summary>
        public PackIconFontistoKind Kind
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
                PackIconDataFactory<PackIconFontistoKind>.DataIndex.Value?.TryGetValue(Kind, out data);
                this.Data = data != null ? StreamGeometry.Parse(data) : null;
            }
            else
            {
                this.Data = null;
            }
        }
    }
}
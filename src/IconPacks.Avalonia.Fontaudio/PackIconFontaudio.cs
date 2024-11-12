using Avalonia;
using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Attributes;

namespace IconPacks.Avalonia.Fontaudio
{
    /// <summary>
    /// Fontaudio by @fefanto <see><cref>https://github.com/fefanto</cref></see>. License: Icons: CC BY 4.0, Fonts: SIL OFL 1.1, Code: MIT License. <see><cref>https://github.com/fefanto/fontaudio#license</cref></see>
    /// Contributions, corrections and requests can be made on GitHub <see><cref>https://github.com/fefanto/fontaudio</cref></see>.
    /// </summary>
    [MetaData("Fontaudio", "https://github.com/fefanto/fontaudio", "https://github.com/fefanto/fontaudio#license")]
    public class PackIconFontaudio : PackIconControlBase
    {
        public PackIconFontaudio()
        {
            UpdateIconPseudoClasses(true, false, true);
        }

        public static readonly StyledProperty<PackIconFontaudioKind> KindProperty
            = AvaloniaProperty.Register<PackIconFontaudio, PackIconFontaudioKind>(nameof(Kind));

        /// <summary>
        /// Gets or sets the icon to display.
        /// </summary>
        public PackIconFontaudioKind Kind
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
                PackIconDataFactory<PackIconFontaudioKind>.DataIndex.Value?.TryGetValue(Kind, out data);
                this.Data = data != null ? StreamGeometry.Parse(data) : null;
            }
            else
            {
                this.Data = null;
            }
        }
    }
}
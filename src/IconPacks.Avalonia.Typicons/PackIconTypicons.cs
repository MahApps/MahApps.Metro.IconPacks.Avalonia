using Avalonia;
using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Attributes;

namespace IconPacks.Avalonia.Typicons
{
    /// <summary>
    /// Typicons Icons can be found at <see><cref>https://www.s-ings.com/typicons/</cref></see>.
    /// Font files are available under the SIL Open Font Licence. Artwork available under the CC BY-SA Licence. [License](<see><cref>https://github.com/stephenhutchings/typicons.font/blob/master/LICENCE.md</cref></see>).
    /// </summary>
    [MetaData("Typicons", "https://www.s-ings.com/typicons/", "https://github.com/stephenhutchings/typicons.font/blob/master/LICENCE.md")]
    public class PackIconTypicons : PackIconControlBase
    {
        public PackIconTypicons()
        {
            UpdateIconPseudoClasses(true, false, true);
        }

        public static readonly StyledProperty<PackIconTypiconsKind> KindProperty
            = AvaloniaProperty.Register<PackIconTypicons, PackIconTypiconsKind>(nameof(Kind));

        /// <summary>
        /// Gets or sets the icon to display.
        /// </summary>
        public PackIconTypiconsKind Kind
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
                PackIconDataFactory<PackIconTypiconsKind>.DataIndex.Value?.TryGetValue(Kind, out data);
                this.Data = data != null ? StreamGeometry.Parse(data) : null;
            }
            else
            {
                this.Data = null;
            }
        }
    }
}
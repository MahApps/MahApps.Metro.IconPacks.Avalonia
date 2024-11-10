using Avalonia;
using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Attributes;

namespace IconPacks.Avalonia.BoxIcons
{
    /// <summary>
    /// BoxIcons licensed under [SIL OFL 1.1](<see><cref>http://scripts.sil.org/OFL</cref></see>)
    /// Contributions, corrections and requests can be made on GitHub <see><cref>https://github.com/atisawd/boxicons</cref></see>.
    /// </summary>
    [MetaData("Boxicons", "https://boxicons.com/", "https://boxicons.com/usage/#license")]
    public class PackIconBoxIcons : PackIconControlBase
    {
        public PackIconBoxIcons()
        {
            base.UpdateIconPseudoClasses(true, false, true);
        }

        public static readonly StyledProperty<PackIconBoxIconsKind> KindProperty
            = AvaloniaProperty.Register<PackIconBoxIcons, PackIconBoxIconsKind>(nameof(Kind));

        /// <summary>
        /// Gets or sets the icon to display.
        /// </summary>
        public PackIconBoxIconsKind Kind
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
                PackIconDataFactory<PackIconBoxIconsKind>.DataIndex.Value?.TryGetValue(Kind, out data);
                this.Data = data != null ? StreamGeometry.Parse(data) : null;
            }
            else
            {
                this.Data = null;
            }
        }
    }
}
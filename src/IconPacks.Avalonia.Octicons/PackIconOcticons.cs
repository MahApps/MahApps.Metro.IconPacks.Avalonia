using Avalonia;
using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Attributes;

namespace IconPacks.Avalonia.Octicons
{
    /// <summary>
    /// All icons sourced from GitHub Octicons <see><cref>https://github.com/primer/octicons</cref></see>
    /// In accordance of <see><cref>https://github.com/primer/octicons?tab=MIT-1-ov-file#readme</cref></see>.
    /// </summary>
    [MetaData("Primer Octicons (GitHub)", "https://github.com/primer/octicons", "https://github.com/primer/octicons?tab=MIT-1-ov-file#readme")]
    public class PackIconOcticons : PackIconControlBase
    {
        public PackIconOcticons()
        {
            UpdateIconPseudoClasses(true, false, false);
        }

        public static readonly StyledProperty<PackIconOcticonsKind> KindProperty
            = AvaloniaProperty.Register<PackIconOcticons, PackIconOcticonsKind>(nameof(Kind));

        /// <summary>
        /// Gets or sets the icon to display.
        /// </summary>
        public PackIconOcticonsKind Kind
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
                PackIconDataFactory<PackIconOcticonsKind>.DataIndex.Value?.TryGetValue(Kind, out data);
                this.Data = data != null ? StreamGeometry.Parse(data) : null;
            }
            else
            {
                this.Data = null;
            }
        }
    }
}
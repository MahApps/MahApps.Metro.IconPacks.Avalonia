using Avalonia;
using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Attributes;

namespace IconPacks.Avalonia.FeatherIcons
{
    /// <summary>
    /// Feather is licensed under the MIT License <see><cref>https://github.com/feathericons/feather?tab=MIT-1-ov-file#readme</cref></see>
    /// Contributions, corrections and requests can be made on GitHub <see><cref>https://feathericons.com/</cref></see>.
    /// </summary>
    [MetaData("Feather Icons", "https://feathericons.com/", "https://github.com/feathericons/feather?tab=MIT-1-ov-file#readme")]
    public class PackIconFeatherIcons : PackIconControlBase
    {
        public PackIconFeatherIcons()
        {
            UpdateIconPseudoClasses(false, true, false);
        }

        public static readonly StyledProperty<PackIconFeatherIconsKind> KindProperty
            = AvaloniaProperty.Register<PackIconFeatherIcons, PackIconFeatherIconsKind>(nameof(Kind));

        /// <summary>
        /// Gets or sets the icon to display.
        /// </summary>
        public PackIconFeatherIconsKind Kind
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
                PackIconDataFactory<PackIconFeatherIconsKind>.DataIndex.Value?.TryGetValue(Kind, out data);
                this.Data = data != null ? StreamGeometry.Parse(data) : null;
            }
            else
            {
                this.Data = null;
            }
        }
    }
}
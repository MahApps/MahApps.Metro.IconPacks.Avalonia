using Avalonia;
using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Attributes;

namespace IconPacks.Avalonia.Coolicons
{
    /// <summary>
    /// Coolicons icons are licensed under [CC 4.0](<see><cref>https://github.com/krystonschwarze/coolicons/blob/master/README.md#license</cref></see>).
    /// Contributions, corrections and requests can be made on GitHub <see><cref>https://github.com/krystonschwarze/coolicons</cref></see>.
    /// </summary>
    [MetaData("Coolicons", "https://github.com/krystonschwarze/coolicons", "https://github.com/krystonschwarze/coolicons/blob/master/README.md#license")]
    public class PackIconCoolicons : PackIconControlBase
    {
        public PackIconCoolicons()
        {
            UpdateIconPseudoClasses(true, false, true);
        }

        public static readonly StyledProperty<PackIconCooliconsKind> KindProperty
            = AvaloniaProperty.Register<PackIconCoolicons, PackIconCooliconsKind>(nameof(Kind));

        /// <summary>
        /// Gets or sets the icon to display.
        /// </summary>
        public PackIconCooliconsKind Kind
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
                PackIconDataFactory<PackIconCooliconsKind>.DataIndex.Value?.TryGetValue(Kind, out data);
                this.Data = data != null ? StreamGeometry.Parse(data) : null;
            }
            else
            {
                this.Data = null;
            }
        }
    }
}
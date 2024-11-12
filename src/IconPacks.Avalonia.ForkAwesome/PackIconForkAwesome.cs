using Avalonia;
using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Attributes;

namespace IconPacks.Avalonia.ForkAwesome
{
    /// <summary>
    /// The Fork Awesome font is licensed under the SIL OFL 1.1 (<see><cref>http://scripts.sil.org/OFL</cref></see>). Fork Awesome is a fork based of off Font Awesome 4.7.0 by Dave Gandy.
    /// More info on licenses at <see><cref>https://forkawesome.github.io</cref></see>. Contributions, corrections and requests can be made on GitHub <see><cref>https://github.com/ForkAwesome/Fork-Awesome</cref></see>.
    /// </summary>
    [MetaData("Fork Awesome", "https://forkaweso.me/", "https://github.com/ForkAwesome/Fork-Awesome/blob/master/LICENSES")]
    public class PackIconForkAwesome : PackIconControlBase
    {
        public PackIconForkAwesome()
        {
            UpdateIconPseudoClasses(true, false, true);
        }

        public static readonly StyledProperty<PackIconForkAwesomeKind> KindProperty
            = AvaloniaProperty.Register<PackIconForkAwesome, PackIconForkAwesomeKind>(nameof(Kind));

        /// <summary>
        /// Gets or sets the icon to display.
        /// </summary>
        public PackIconForkAwesomeKind Kind
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
                PackIconDataFactory<PackIconForkAwesomeKind>.DataIndex.Value?.TryGetValue(Kind, out data);
                this.Data = data != null ? StreamGeometry.Parse(data) : null;
            }
            else
            {
                this.Data = null;
            }
        }
    }
}
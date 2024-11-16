using Avalonia;
using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Attributes;

namespace IconPacks.Avalonia.Entypo
{
    /// <summary>
    /// All icons sourced from Entypo+ Icons Font <see><cref>http://www.entypo.com</cref></see> by Daniel Bruce <see><cref>https://www.danielbruce.se/</cref></see>
    /// Licensed under [CC BY 4.0](<see><cref>http://creativecommons.org/licenses/by-sa/4.0/</cref></see>).
    /// </summary>
    [MetaData("Entypo+", "http://www.entypo.com/", "https://creativecommons.org/licenses/by-sa/4.0/")]
    public class PackIconEntypo : PackIconControlBase
    {
        public PackIconEntypo()
        {
            UpdateIconPseudoClasses(true, false, false);
        }

        public static readonly StyledProperty<PackIconEntypoKind> KindProperty
            = AvaloniaProperty.Register<PackIconEntypo, PackIconEntypoKind>(nameof(Kind));

        /// <summary>
        /// Gets or sets the icon to display.
        /// </summary>
        public PackIconEntypoKind Kind
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
                PackIconDataFactory<PackIconEntypoKind>.DataIndex.Value?.TryGetValue(Kind, out data);
                this.Data = data != null ? StreamGeometry.Parse(data) : null;
            }
            else
            {
                this.Data = null;
            }
        }
    }
}
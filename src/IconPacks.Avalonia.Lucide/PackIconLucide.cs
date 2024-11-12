using Avalonia;
using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Attributes;

namespace IconPacks.Avalonia.Lucide
{
    /// <summary>
    /// Lucide Icons are licensed under [ISC License](<see><cref>https://github.com/lucide-icons/lucide?tab=ISC-1-ov-file#readme</cref></see>).
    /// Contributions, corrections and requests can be made on GitHub <see><cref>https://github.com/lucide-icons/lucide</cref></see>.
    /// </summary>
    [MetaData("Lucide Icons", "https://github.com/lucide-icons/lucide", "https://github.com/lucide-icons/lucide?tab=ISC-1-ov-file#readme")]
    public class PackIconLucide : PackIconControlBase
    {
        public PackIconLucide()
        {
            UpdateIconPseudoClasses(true, false, true);
        }

        public static readonly StyledProperty<PackIconLucideKind> KindProperty
            = AvaloniaProperty.Register<PackIconLucide, PackIconLucideKind>(nameof(Kind));

        /// <summary>
        /// Gets or sets the icon to display.
        /// </summary>
        public PackIconLucideKind Kind
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
                PackIconDataFactory<PackIconLucideKind>.DataIndex.Value?.TryGetValue(Kind, out data);
                this.Data = data != null ? StreamGeometry.Parse(data) : null;
            }
            else
            {
                this.Data = null;
            }
        }
    }
}
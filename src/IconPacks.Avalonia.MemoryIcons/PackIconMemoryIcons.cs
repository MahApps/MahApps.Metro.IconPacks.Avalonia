using Avalonia;
using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Attributes;

namespace IconPacks.Avalonia.MemoryIcons
{
    /// <summary>
    /// All icons sourced from Memory Icons <see><cref>https://pictogrammers.com/library/memory/</cref></see>
    /// In accordance of <see><cref>https://github.com/Pictogrammers/Memory?tab=License-1-ov-file#readme</cref></see>.
    /// </summary>
    [MetaData("Memory Icons", "https://pictogrammers.com/library/memory/", "https://github.com/Pictogrammers/Memory?tab=License-1-ov-file#readme")]
    public class PackIconMemoryIcons : PackIconControlBase
    {
        public PackIconMemoryIcons()
        {
            UpdateIconPseudoClasses(true, false, false);
        }

        public static readonly StyledProperty<PackIconMemoryIconsKind> KindProperty
            = AvaloniaProperty.Register<PackIconMemoryIcons, PackIconMemoryIconsKind>(nameof(Kind));

        /// <summary>
        /// Gets or sets the icon to display.
        /// </summary>
        public PackIconMemoryIconsKind Kind
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
                PackIconDataFactory<PackIconMemoryIconsKind>.DataIndex.Value?.TryGetValue(Kind, out data);
                this.Data = data != null ? StreamGeometry.Parse(data) : null;
            }
            else
            {
                this.Data = null;
            }
        }
    }
}
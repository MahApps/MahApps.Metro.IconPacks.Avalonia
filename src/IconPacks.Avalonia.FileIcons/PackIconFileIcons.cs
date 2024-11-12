using Avalonia;
using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Attributes;

namespace IconPacks.Avalonia.FileIcons
{
    /// <summary>
    /// File Icons are licensed under the [MIT license](<see><cref>https://github.com/file-icons/atom/blob/master/LICENSE.md</cref></see>).
    /// Contributions, corrections and requests can be made on GitHub <see><cref>https://github.com/file-icons/icons</cref></see>.
    /// </summary>
    [MetaData("File Icons", "https://github.com/file-icons/icons", "https://github.com/file-icons/atom/blob/master/LICENSE.md")]
    public class PackIconFileIcons : PackIconControlBase
    {
        public PackIconFileIcons()
        {
            UpdateIconPseudoClasses(true, false, true);
        }

        public static readonly StyledProperty<PackIconFileIconsKind> KindProperty
            = AvaloniaProperty.Register<PackIconFileIcons, PackIconFileIconsKind>(nameof(Kind));

        /// <summary>
        /// Gets or sets the icon to display.
        /// </summary>
        public PackIconFileIconsKind Kind
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
                PackIconDataFactory<PackIconFileIconsKind>.DataIndex.Value?.TryGetValue(Kind, out data);
                this.Data = data != null ? StreamGeometry.Parse(data) : null;
            }
            else
            {
                this.Data = null;
            }
        }
    }
}
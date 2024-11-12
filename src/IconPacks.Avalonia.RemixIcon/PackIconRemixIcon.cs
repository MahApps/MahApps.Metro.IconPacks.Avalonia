using Avalonia;
using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Attributes;

namespace IconPacks.Avalonia.RemixIcon
{
    /// <summary>
    /// RemixIcon released under the [Apache License Version 2.0](<see><cref>https://github.com/Remix-Design/RemixIcon?tab=Apache-2.0-1-ov-file#readme</cref></see>)
    /// Contributions, corrections and requests can be made on GitHub <see><cref>https://github.com/Remix-Design/RemixIcon</cref></see>.
    /// </summary>
    [MetaData("Remix Icon", "https://remixicon.com/", "https://github.com/Remix-Design/RemixIcon/blob/master/License")]
    public class PackIconRemixIcon : PackIconControlBase
    {
        public PackIconRemixIcon()
        {
            UpdateIconPseudoClasses(true, false, false);
        }

        public static readonly StyledProperty<PackIconRemixIconKind> KindProperty
            = AvaloniaProperty.Register<PackIconRemixIcon, PackIconRemixIconKind>(nameof(Kind));

        /// <summary>
        /// Gets or sets the icon to display.
        /// </summary>
        public PackIconRemixIconKind Kind
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
                PackIconDataFactory<PackIconRemixIconKind>.DataIndex.Value?.TryGetValue(Kind, out data);
                this.Data = data != null ? StreamGeometry.Parse(data) : null;
            }
            else
            {
                this.Data = null;
            }
        }
    }
}
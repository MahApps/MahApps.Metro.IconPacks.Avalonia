using Avalonia;
using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Attributes;

namespace IconPacks.Avalonia.VaadinIcons
{
    /// <summary>
    /// Vaadin Icons are licensed under Creative Commons [CC-BY 4.0](<see><cref>https://github.com/vaadin/web-components/tree/main/packages/icons#license</cref></see>) license.
    /// Contributions, corrections and requests can be made on GitHub <see><cref>https://github.com/vaadin/vaadin-icons</cref></see>.
    /// </summary>
    [MetaData("Vaadin Icons", "https://vaadin.com/icons", "https://github.com/vaadin/web-components/tree/main/packages/icons#license")]
    public class PackIconVaadinIcons : PackIconControlBase
    {
        public PackIconVaadinIcons()
        {
            UpdateIconPseudoClasses(true, false, true);
        }

        public static readonly StyledProperty<PackIconVaadinIconsKind> KindProperty
            = AvaloniaProperty.Register<PackIconVaadinIcons, PackIconVaadinIconsKind>(nameof(Kind));

        /// <summary>
        /// Gets or sets the icon to display.
        /// </summary>
        public PackIconVaadinIconsKind Kind
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
                PackIconDataFactory<PackIconVaadinIconsKind>.DataIndex.Value?.TryGetValue(Kind, out data);
                this.Data = data != null ? StreamGeometry.Parse(data) : null;
            }
            else
            {
                this.Data = null;
            }
        }
    }
}
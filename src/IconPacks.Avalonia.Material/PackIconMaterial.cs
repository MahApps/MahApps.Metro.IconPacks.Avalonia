using Avalonia;
using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Attributes;

namespace IconPacks.Avalonia.Material
{
    /// <summary>
    /// All icons sourced from Material Design Icons Font <see><cref>https://pictogrammers.com/library/mdi/</cref></see>
    /// In accordance of <see><cref>https://github.com/Templarian/MaterialDesign?tab=License-1-ov-file#readme</cref></see>.
    /// </summary>
    [MetaData("Material Design Icons", "https://pictogrammers.com/library/mdi/", "https://github.com/Templarian/MaterialDesign?tab=License-1-ov-file#readme")]
    public class PackIconMaterial : PackIconControlBase
    {
        public PackIconMaterial()
        {
            UpdateIconPseudoClasses(true, false, false);
        }

        public static readonly StyledProperty<PackIconMaterialKind> KindProperty
            = AvaloniaProperty.Register<PackIconMaterial, PackIconMaterialKind>(nameof(Kind));

        /// <summary>
        /// Gets or sets the icon to display.
        /// </summary>
        public PackIconMaterialKind Kind
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
                PackIconDataFactory<PackIconMaterialKind>.DataIndex.Value?.TryGetValue(Kind, out data);
                this.Data = data != null ? StreamGeometry.Parse(data) : null;
            }
            else
            {
                this.Data = null;
            }
        }
    }
}
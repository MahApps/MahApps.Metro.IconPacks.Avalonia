using Avalonia;
using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Attributes;

namespace IconPacks.Avalonia.MaterialDesign
{
    /// <summary>
    /// All icons sourced from Google Material Design icon font - <see><cref>https://github.com/google/material-design-icons</cref></see>
    /// Google Material Design are licensed under the Apache License 2.0 <see><cref>https://github.com/google/material-design-icons?tab=Apache-2.0-1-ov-file#readme</cref></see>
    /// </summary>
    [MetaData("Material Icons (Google)", "https://github.com/google/material-design-icons", "https://github.com/google/material-design-icons?tab=Apache-2.0-1-ov-file#readme")]
    public class PackIconMaterialDesign : PackIconControlBase
    {
        public PackIconMaterialDesign()
        {
            UpdateIconPseudoClasses(true, false, false);
        }

        public static readonly StyledProperty<PackIconMaterialDesignKind> KindProperty
            = AvaloniaProperty.Register<PackIconMaterialDesign, PackIconMaterialDesignKind>(nameof(Kind));

        /// <summary>
        /// Gets or sets the icon to display.
        /// </summary>
        public PackIconMaterialDesignKind Kind
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
                PackIconDataFactory<PackIconMaterialDesignKind>.DataIndex.Value?.TryGetValue(Kind, out data);
                this.Data = data != null ? StreamGeometry.Parse(data) : null;
            }
            else
            {
                this.Data = null;
            }
        }
    }
}
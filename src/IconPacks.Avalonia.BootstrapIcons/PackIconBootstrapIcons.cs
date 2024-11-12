﻿using Avalonia;
using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Attributes;

namespace IconPacks.Avalonia.BootstrapIcons
{
    /// <summary>
    /// Bootstrap Icons are licensed under the [MIT license](<see><cref>https://github.com/twbs/icons?tab=MIT-1-ov-file#readme</cref></see>).
    /// Contributions, corrections and requests can be made on GitHub <see><cref>https://github.com/twbs/icons</cref></see>.
    /// </summary>
    [MetaData("Bootstrap Icons", "https://icons.getbootstrap.com/", "https://github.com/twbs/icons?tab=MIT-1-ov-file#readme")]
    public class PackIconBootstrapIcons : PackIconControlBase
    {
        public PackIconBootstrapIcons()
        {
            UpdateIconPseudoClasses(true, false, true);
        }

        public static readonly StyledProperty<PackIconBootstrapIconsKind> KindProperty
            = AvaloniaProperty.Register<PackIconBootstrapIcons, PackIconBootstrapIconsKind>(nameof(Kind));

        /// <summary>
        /// Gets or sets the icon to display.
        /// </summary>
        public PackIconBootstrapIconsKind Kind
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
                PackIconDataFactory<PackIconBootstrapIconsKind>.DataIndex.Value?.TryGetValue(Kind, out data);
                this.Data = data != null ? StreamGeometry.Parse(data) : null;
            }
            else
            {
                this.Data = null;
            }
        }
    }
}
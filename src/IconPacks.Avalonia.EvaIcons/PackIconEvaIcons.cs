using Avalonia;
using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.Core.Attributes;

namespace IconPacks.Avalonia.EvaIcons
{
    /// <summary>
    /// eva-icons licensed under the MIT License <see><cref>https://github.com/akveo/eva-icons/blob/master/LICENSE.txt</cref></see>
    /// Contributions, corrections and requests can be made on GitHub <see><cref>https://github.com/akveo/eva-icons</cref></see>.
    /// </summary>
    [MetaData("Eva Icons", "https://akveo.github.io/eva-icons/", "https://github.com/akveo/eva-icons/blob/master/LICENSE.txt")]
    public class PackIconEvaIcons : PackIconControlBase
    {
        public PackIconEvaIcons()
        {
            UpdateIconPseudoClasses(true, false, true);
        }

        public static readonly StyledProperty<PackIconEvaIconsKind> KindProperty
            = AvaloniaProperty.Register<PackIconEvaIcons, PackIconEvaIconsKind>(nameof(Kind));

        /// <summary>
        /// Gets or sets the icon to display.
        /// </summary>
        public PackIconEvaIconsKind Kind
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
                PackIconDataFactory<PackIconEvaIconsKind>.DataIndex.Value?.TryGetValue(Kind, out data);
                this.Data = data != null ? StreamGeometry.Parse(data) : null;
            }
            else
            {
                this.Data = null;
            }
        }
    }
}
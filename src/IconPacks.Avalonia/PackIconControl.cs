using System;
using Avalonia;
using Avalonia.Media;
using IconPacks.Avalonia.Core;
using IconPacks.Avalonia.BootstrapIcons;
using IconPacks.Avalonia.BoxIcons;
using IconPacks.Avalonia.CircumIcons;
using IconPacks.Avalonia.Codicons;
using IconPacks.Avalonia.Coolicons;
using IconPacks.Avalonia.Entypo;
using IconPacks.Avalonia.EvaIcons;
using IconPacks.Avalonia.FeatherIcons;
using IconPacks.Avalonia.FileIcons;
using IconPacks.Avalonia.Fontaudio;
using IconPacks.Avalonia.FontAwesome;
using IconPacks.Avalonia.Fontisto;
using IconPacks.Avalonia.ForkAwesome;
using IconPacks.Avalonia.GameIcons;
using IconPacks.Avalonia.Ionicons;
using IconPacks.Avalonia.JamIcons;
using IconPacks.Avalonia.Lucide;
using IconPacks.Avalonia.Material;
using IconPacks.Avalonia.MaterialLight;
using IconPacks.Avalonia.MaterialDesign;
using IconPacks.Avalonia.MemoryIcons;
using IconPacks.Avalonia.Microns;
using IconPacks.Avalonia.Modern;
using IconPacks.Avalonia.Octicons;
using IconPacks.Avalonia.PhosphorIcons;
using IconPacks.Avalonia.PicolIcons;
using IconPacks.Avalonia.PixelartIcons;
using IconPacks.Avalonia.RadixIcons;
using IconPacks.Avalonia.RemixIcon;
using IconPacks.Avalonia.RPGAwesome;
using IconPacks.Avalonia.SimpleIcons;
using IconPacks.Avalonia.Typicons;
using IconPacks.Avalonia.Unicons;
using IconPacks.Avalonia.VaadinIcons;
using IconPacks.Avalonia.WeatherIcons;
using IconPacks.Avalonia.Zondicons;

namespace IconPacks.Avalonia
{
    /// <summary>
    /// </summary>
    public class PackIconControl : PackIconControlBase
    {
        public static readonly StyledProperty<Enum> KindProperty
            = AvaloniaProperty.Register<PackIconControl, Enum>(nameof(Kind));

        /// <summary>
        /// Gets or sets the icon to display.
        /// </summary>
        public Enum Kind
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
            switch (Kind)
            {
                case PackIconBootstrapIconsKind:
                    UpdateIconPseudoClasses(true, false, true);
                    break;

                case PackIconBoxIconsKind:
                    UpdateIconPseudoClasses(true, false, true);
                    break;

                case PackIconCircumIconsKind:
                    UpdateIconPseudoClasses(true, false, false);
                    break;

                case PackIconCodiconsKind:
                    UpdateIconPseudoClasses(true, false, true);
                    break;

                case PackIconCooliconsKind:
                    UpdateIconPseudoClasses(true, false, true);
                    break;

                case PackIconEntypoKind:
                    UpdateIconPseudoClasses(true, false, false);
                    break;

                case PackIconEvaIconsKind:
                    UpdateIconPseudoClasses(true, false, true);
                    break;

                case PackIconFeatherIconsKind:
                    UpdateIconPseudoClasses(false, true, false);
                    break;

                case PackIconFileIconsKind:
                    UpdateIconPseudoClasses(true, false, true);
                    break;

                case PackIconFontaudioKind:
                    UpdateIconPseudoClasses(true, false, true);
                    break;

                case PackIconFontAwesomeKind:
                    UpdateIconPseudoClasses(true, false, false);
                    break;

                case PackIconFontistoKind:
                    UpdateIconPseudoClasses(true, false, true);
                    break;

                case PackIconForkAwesomeKind:
                    UpdateIconPseudoClasses(true, false, true);
                    break;

                case PackIconGameIconsKind:
                    UpdateIconPseudoClasses(true, false, false);
                    break;

                case PackIconIoniconsKind:
                    UpdateIconPseudoClasses(true, false, false);
                    break;

                case PackIconJamIconsKind:
                    UpdateIconPseudoClasses(true, false, true);
                    break;

                case PackIconLucideKind:
                    UpdateIconPseudoClasses(true, false, true);
                    break;

                case PackIconMaterialKind:
                    UpdateIconPseudoClasses(true, false, false);
                    break;

                case PackIconMaterialLightKind:
                    UpdateIconPseudoClasses(true, false, false);
                    break;

                case PackIconMaterialDesignKind:
                    UpdateIconPseudoClasses(true, false, false);
                    break;

                case PackIconMemoryIconsKind:
                    UpdateIconPseudoClasses(true, false, false);
                    break;

                case PackIconMicronsKind:
                    UpdateIconPseudoClasses(true, false, false);
                    break;

                case PackIconModernKind:
                    UpdateIconPseudoClasses(true, false, false);
                    break;

                case PackIconOcticonsKind:
                    UpdateIconPseudoClasses(true, false, false);
                    break;

                case PackIconPhosphorIconsKind:
                    UpdateIconPseudoClasses(true, false, false);
                    break;

                case PackIconPicolIconsKind:
                    UpdateIconPseudoClasses(true, false, false);
                    break;

                case PackIconPixelartIconsKind:
                    UpdateIconPseudoClasses(true, false, false);
                    break;

                case PackIconRadixIconsKind:
                    UpdateIconPseudoClasses(true, false, false);
                    break;

                case PackIconRemixIconKind:
                    UpdateIconPseudoClasses(true, false, false);
                    break;

                case PackIconRPGAwesomeKind:
                    UpdateIconPseudoClasses(true, false, true);
                    break;

                case PackIconSimpleIconsKind:
                    UpdateIconPseudoClasses(true, false, false);
                    break;

                case PackIconTypiconsKind:
                    UpdateIconPseudoClasses(true, false, true);
                    break;

                case PackIconUniconsKind:
                    UpdateIconPseudoClasses(true, false, false);
                    break;

                case PackIconVaadinIconsKind:
                    UpdateIconPseudoClasses(true, false, true);
                    break;

                case PackIconWeatherIconsKind:
                    UpdateIconPseudoClasses(true, false, false);
                    break;

                case PackIconZondiconsKind:
                    UpdateIconPseudoClasses(true, false, false);
                    break;

                default:
                    UpdateIconPseudoClasses(true, false, false);
                    break;
            }

            if (Kind != default(Enum))
            {
                string data = null;
                PackIconControlDataFactory.DataIndex.Value?.TryGetValue(Kind, out data);
                this.Data = data != null ? StreamGeometry.Parse(data) : null;
            }
            else
            {
                this.Data = null;
            }
        }
    }
}
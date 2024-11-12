using System;
using Avalonia.Data;
using Avalonia.Markup.Xaml;
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
    public class PackIconExtension : BasePackIconExtension
    {
        public PackIconExtension()
        {
        }

        public PackIconExtension(Enum kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public Enum Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.Kind switch
            {
                PackIconBootstrapIconsKind kind => this.GetPackIcon<PackIconBootstrapIcons, PackIconBootstrapIconsKind>(kind),
                PackIconBoxIconsKind kind => this.GetPackIcon<PackIconBoxIcons, PackIconBoxIconsKind>(kind),
                PackIconCircumIconsKind kind => this.GetPackIcon<PackIconCircumIcons, PackIconCircumIconsKind>(kind),
                PackIconCodiconsKind kind => this.GetPackIcon<PackIconCodicons, PackIconCodiconsKind>(kind),
                PackIconCooliconsKind kind => this.GetPackIcon<PackIconCoolicons, PackIconCooliconsKind>(kind),
                PackIconEntypoKind kind => this.GetPackIcon<PackIconEntypo, PackIconEntypoKind>(kind),
                PackIconEvaIconsKind kind => this.GetPackIcon<PackIconEvaIcons, PackIconEvaIconsKind>(kind),
                PackIconFeatherIconsKind kind => this.GetPackIcon<PackIconFeatherIcons, PackIconFeatherIconsKind>(kind),
                PackIconFileIconsKind kind => this.GetPackIcon<PackIconFileIcons, PackIconFileIconsKind>(kind),
                PackIconFontaudioKind kind => this.GetPackIcon<PackIconFontaudio, PackIconFontaudioKind>(kind),
                PackIconFontAwesomeKind kind => this.GetPackIcon<PackIconFontAwesome, PackIconFontAwesomeKind>(kind),
                PackIconFontistoKind kind => this.GetPackIcon<PackIconFontisto, PackIconFontistoKind>(kind),
                PackIconForkAwesomeKind kind => this.GetPackIcon<PackIconForkAwesome, PackIconForkAwesomeKind>(kind),
                PackIconGameIconsKind kind => this.GetPackIcon<PackIconGameIcons, PackIconGameIconsKind>(kind),
                PackIconIoniconsKind kind => this.GetPackIcon<PackIconIonicons, PackIconIoniconsKind>(kind),
                PackIconJamIconsKind kind => this.GetPackIcon<PackIconJamIcons, PackIconJamIconsKind>(kind),
                PackIconLucideKind kind => this.GetPackIcon<PackIconLucide, PackIconLucideKind>(kind),
                PackIconMaterialKind kind => this.GetPackIcon<PackIconMaterial, PackIconMaterialKind>(kind),
                PackIconMaterialLightKind kind => this.GetPackIcon<PackIconMaterialLight, PackIconMaterialLightKind>(kind),
                PackIconMaterialDesignKind kind => this.GetPackIcon<PackIconMaterialDesign, PackIconMaterialDesignKind>(kind),
                PackIconMemoryIconsKind kind => this.GetPackIcon<PackIconMemoryIcons, PackIconMemoryIconsKind>(kind),
                PackIconMicronsKind kind => this.GetPackIcon<PackIconMicrons, PackIconMicronsKind>(kind),
                PackIconModernKind kind => this.GetPackIcon<PackIconModern, PackIconModernKind>(kind),
                PackIconOcticonsKind kind => this.GetPackIcon<PackIconOcticons, PackIconOcticonsKind>(kind),
                PackIconPhosphorIconsKind kind => this.GetPackIcon<PackIconPhosphorIcons, PackIconPhosphorIconsKind>(kind),
                PackIconPicolIconsKind kind => this.GetPackIcon<PackIconPicolIcons, PackIconPicolIconsKind>(kind),
                PackIconPixelartIconsKind kind => this.GetPackIcon<PackIconPixelartIcons, PackIconPixelartIconsKind>(kind),
                PackIconRadixIconsKind kind => this.GetPackIcon<PackIconRadixIcons, PackIconRadixIconsKind>(kind),
                PackIconRemixIconKind kind => this.GetPackIcon<PackIconRemixIcon, PackIconRemixIconKind>(kind),
                PackIconRPGAwesomeKind kind => this.GetPackIcon<PackIconRPGAwesome, PackIconRPGAwesomeKind>(kind),
                PackIconSimpleIconsKind kind => this.GetPackIcon<PackIconSimpleIcons, PackIconSimpleIconsKind>(kind),
                PackIconTypiconsKind kind => this.GetPackIcon<PackIconTypicons, PackIconTypiconsKind>(kind),
                PackIconUniconsKind kind => this.GetPackIcon<PackIconUnicons, PackIconUniconsKind>(kind),
                PackIconVaadinIconsKind kind => this.GetPackIcon<PackIconVaadinIcons, PackIconVaadinIconsKind>(kind),
                PackIconWeatherIconsKind kind => this.GetPackIcon<PackIconWeatherIcons, PackIconWeatherIconsKind>(kind),
                PackIconZondiconsKind kind => this.GetPackIcon<PackIconZondicons, PackIconZondiconsKind>(kind),
                _ => BindingNotification.UnsetValue
            };
        }
    }
}
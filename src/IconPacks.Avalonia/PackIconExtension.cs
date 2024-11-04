using System;
using Avalonia.Data;
using Avalonia.Markup.Xaml;

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
            // if (this.Kind is PackIconBootstrapIconsKind)
            // {
            // return this.GetPackIcon<PackIconBootstrapIcons, PackIconBootstrapIconsKind>((PackIconBootstrapIconsKind) this.Kind);
            // }
            if (this.Kind is PackIconBoxIconsKind)
            {
                return this.GetPackIcon<PackIconBoxIcons, PackIconBoxIconsKind>((PackIconBoxIconsKind)this.Kind);
            }

            // if (this.Kind is PackIconCircumIconsKind)
            // {
            // return this.GetPackIcon<PackIconCircumIcons, PackIconCircumIconsKind>((PackIconCircumIconsKind) this.Kind);
            // }
            // if (this.Kind is PackIconCodiconsKind)
            // {
            // return this.GetPackIcon<PackIconCodicons, PackIconCodiconsKind>((PackIconCodiconsKind) this.Kind);
            // }
            // if (this.Kind is PackIconCooliconsKind)
            // {
            // return this.GetPackIcon<PackIconCoolicons, PackIconCooliconsKind>((PackIconCooliconsKind) this.Kind);
            // }
            // if (this.Kind is PackIconEntypoKind)
            // {
            // return this.GetPackIcon<PackIconEntypo, PackIconEntypoKind>((PackIconEntypoKind) this.Kind);
            // }
            // if (this.Kind is PackIconEvaIconsKind)
            // {
            // return this.GetPackIcon<PackIconEvaIcons, PackIconEvaIconsKind>((PackIconEvaIconsKind) this.Kind);
            // }
            // if (this.Kind is PackIconFeatherIconsKind)
            // {
            // return this.GetPackIcon<PackIconFeatherIcons, PackIconFeatherIconsKind>((PackIconFeatherIconsKind) this.Kind);
            // }
            // if (this.Kind is PackIconFileIconsKind)
            // {
            // return this.GetPackIcon<PackIconFileIcons, PackIconFileIconsKind>((PackIconFileIconsKind) this.Kind);
            // }
            // if (this.Kind is PackIconFontaudioKind)
            // {
            // return this.GetPackIcon<PackIconFontaudio, PackIconFontaudioKind>((PackIconFontaudioKind) this.Kind);
            // }
            // if (this.Kind is PackIconFontAwesomeKind)
            // {
            // return this.GetPackIcon<PackIconFontAwesome, PackIconFontAwesomeKind>((PackIconFontAwesomeKind) this.Kind);
            // }
            // if (this.Kind is PackIconFontistoKind)
            // {
            // return this.GetPackIcon<PackIconFontisto, PackIconFontistoKind>((PackIconFontistoKind) this.Kind);
            // }
            // if (this.Kind is PackIconForkAwesomeKind)
            // {
            // return this.GetPackIcon<PackIconForkAwesome, PackIconForkAwesomeKind>((PackIconForkAwesomeKind) this.Kind);
            // }
            // if (this.Kind is PackIconGameIconsKind)
            // {
            // return this.GetPackIcon<PackIconGameIcons, PackIconGameIconsKind>((PackIconGameIconsKind) this.Kind);
            // }
            // if (this.Kind is PackIconIoniconsKind)
            // {
            // return this.GetPackIcon<PackIconIonicons, PackIconIoniconsKind>((PackIconIoniconsKind) this.Kind);
            // }
            // if (this.Kind is PackIconJamIconsKind)
            // {
            // return this.GetPackIcon<PackIconJamIcons, PackIconJamIconsKind>((PackIconJamIconsKind) this.Kind);
            // }
            // if (this.Kind is PackIconLucideKind)
            // {
            // return this.GetPackIcon<PackIconLucide, PackIconLucideKind>((PackIconLucideKind) this.Kind);
            // }
            // if (this.Kind is PackIconMaterialKind)
            // {
            // return this.GetPackIcon<PackIconMaterial, PackIconMaterialKind>((PackIconMaterialKind) this.Kind);
            // }
            // if (this.Kind is PackIconMaterialLightKind)
            // {
            // return this.GetPackIcon<PackIconMaterialLight, PackIconMaterialLightKind>((PackIconMaterialLightKind) this.Kind);
            // }
            // if (this.Kind is PackIconMaterialDesignKind)
            // {
            // return this.GetPackIcon<PackIconMaterialDesign, PackIconMaterialDesignKind>((PackIconMaterialDesignKind) this.Kind);
            // }
            // if (this.Kind is PackIconMemoryIconsKind)
            // {
            // return this.GetPackIcon<PackIconMemoryIcons, PackIconMemoryIconsKind>((PackIconMemoryIconsKind) this.Kind);
            // }
            // if (this.Kind is PackIconMicronsKind)
            // {
            // return this.GetPackIcon<PackIconMicrons, PackIconMicronsKind>((PackIconMicronsKind) this.Kind);
            // }
            // if (this.Kind is PackIconModernKind)
            // {
            // return this.GetPackIcon<PackIconModern, PackIconModernKind>((PackIconModernKind) this.Kind);
            // }
            // if (this.Kind is PackIconOcticonsKind)
            // {
            // return this.GetPackIcon<PackIconOcticons, PackIconOcticonsKind>((PackIconOcticonsKind) this.Kind);
            // }
            // if (this.Kind is PackIconPhosphorIconsKind)
            // {
            // return this.GetPackIcon<PackIconPhosphorIcons, PackIconPhosphorIconsKind>((PackIconPhosphorIconsKind) this.Kind);
            // }
            // if (this.Kind is PackIconPicolIconsKind)
            // {
            // return this.GetPackIcon<PackIconPicolIcons, PackIconPicolIconsKind>((PackIconPicolIconsKind) this.Kind);
            // }
            // if (this.Kind is PackIconPixelartIconsKind)
            // {
            // return this.GetPackIcon<PackIconPixelartIcons, PackIconPixelartIconsKind>((PackIconPixelartIconsKind) this.Kind);
            // }
            // if (this.Kind is PackIconRadixIconsKind)
            // {
            // return this.GetPackIcon<PackIconRadixIcons, PackIconRadixIconsKind>((PackIconRadixIconsKind) this.Kind);
            // }
            // if (this.Kind is PackIconRemixIconKind)
            // {
            // return this.GetPackIcon<PackIconRemixIcon, PackIconRemixIconKind>((PackIconRemixIconKind) this.Kind);
            // }
            // if (this.Kind is PackIconRPGAwesomeKind)
            // {
            // return this.GetPackIcon<PackIconRPGAwesome, PackIconRPGAwesomeKind>((PackIconRPGAwesomeKind) this.Kind);
            // }
            // if (this.Kind is PackIconSimpleIconsKind)
            // {
            // return this.GetPackIcon<PackIconSimpleIcons, PackIconSimpleIconsKind>((PackIconSimpleIconsKind) this.Kind);
            // }
            // if (this.Kind is PackIconTypiconsKind)
            // {
            // return this.GetPackIcon<PackIconTypicons, PackIconTypiconsKind>((PackIconTypiconsKind) this.Kind);
            // }
            // if (this.Kind is PackIconUniconsKind)
            // {
            // return this.GetPackIcon<PackIconUnicons, PackIconUniconsKind>((PackIconUniconsKind) this.Kind);
            // }
            // if (this.Kind is PackIconVaadinIconsKind)
            // {
            // return this.GetPackIcon<PackIconVaadinIcons, PackIconVaadinIconsKind>((PackIconVaadinIconsKind) this.Kind);
            // }
            // if (this.Kind is PackIconWeatherIconsKind)
            // {
            // return this.GetPackIcon<PackIconWeatherIcons, PackIconWeatherIconsKind>((PackIconWeatherIconsKind) this.Kind);
            // }
            // if (this.Kind is PackIconZondiconsKind)
            // {
            // return this.GetPackIcon<PackIconZondicons, PackIconZondiconsKind>((PackIconZondiconsKind) this.Kind);
            // }
            //return null;
            return BindingNotification.UnsetValue;
        }
    }
}
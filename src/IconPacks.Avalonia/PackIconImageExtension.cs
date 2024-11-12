using System;
using Avalonia.Markup.Xaml;
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
    public class PackIconImageExtension : BasePackIconImageExtension
    {
        public PackIconImageExtension()
        {
        }

        public PackIconImageExtension(Enum kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public Enum Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return CreateImageSource(this.Kind, this.Brush ?? Brushes.Black);
        }

        /// <inheritdoc />
        protected override string GetPathData(object iconKind)
        {
            string data = null;
            switch (iconKind)
            {
                case PackIconBootstrapIconsKind kind:
                    PackIconDataFactory<PackIconBootstrapIconsKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconBoxIconsKind kind:
                    PackIconDataFactory<PackIconBoxIconsKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconCircumIconsKind kind:
                    PackIconDataFactory<PackIconCircumIconsKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconCodiconsKind kind:
                    PackIconDataFactory<PackIconCodiconsKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconCooliconsKind kind:
                    PackIconDataFactory<PackIconCooliconsKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconEntypoKind kind:
                    PackIconDataFactory<PackIconEntypoKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconEvaIconsKind kind:
                    PackIconDataFactory<PackIconEvaIconsKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconFeatherIconsKind kind:
                    PackIconDataFactory<PackIconFeatherIconsKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconFileIconsKind kind:
                    PackIconDataFactory<PackIconFileIconsKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconFontaudioKind kind:
                    PackIconDataFactory<PackIconFontaudioKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconFontAwesomeKind kind:
                    PackIconDataFactory<PackIconFontAwesomeKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconFontistoKind kind:
                    PackIconDataFactory<PackIconFontistoKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconForkAwesomeKind kind:
                    PackIconDataFactory<PackIconForkAwesomeKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconGameIconsKind kind:
                    PackIconDataFactory<PackIconGameIconsKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconIoniconsKind kind:
                    PackIconDataFactory<PackIconIoniconsKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconJamIconsKind kind:
                    PackIconDataFactory<PackIconJamIconsKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconLucideKind kind:
                    PackIconDataFactory<PackIconLucideKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconMaterialKind kind:
                    PackIconDataFactory<PackIconMaterialKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconMaterialLightKind kind:
                    PackIconDataFactory<PackIconMaterialLightKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconMaterialDesignKind kind:
                    PackIconDataFactory<PackIconMaterialDesignKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconMemoryIconsKind kind:
                    PackIconDataFactory<PackIconMemoryIconsKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconMicronsKind kind:
                    PackIconDataFactory<PackIconMicronsKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconModernKind kind:
                    PackIconDataFactory<PackIconModernKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconOcticonsKind kind:
                    PackIconDataFactory<PackIconOcticonsKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconPhosphorIconsKind kind:
                    PackIconDataFactory<PackIconPhosphorIconsKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconPicolIconsKind kind:
                    PackIconDataFactory<PackIconPicolIconsKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconPixelartIconsKind kind:
                    PackIconDataFactory<PackIconPixelartIconsKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconRadixIconsKind kind:
                    PackIconDataFactory<PackIconRadixIconsKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconRemixIconKind kind:
                    PackIconDataFactory<PackIconRemixIconKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconRPGAwesomeKind kind:
                    PackIconDataFactory<PackIconRPGAwesomeKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconSimpleIconsKind kind:
                    PackIconDataFactory<PackIconSimpleIconsKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconTypiconsKind kind:
                    PackIconDataFactory<PackIconTypiconsKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconUniconsKind kind:
                    PackIconDataFactory<PackIconUniconsKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconVaadinIconsKind kind:
                    PackIconDataFactory<PackIconVaadinIconsKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconWeatherIconsKind kind:
                    PackIconDataFactory<PackIconWeatherIconsKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                case PackIconZondiconsKind kind:
                    PackIconDataFactory<PackIconZondiconsKind>.DataIndex.Value?.TryGetValue(kind, out data);
                    return data;
                default:
                    return null;
            }
        }

        /// <inheritdoc />
        protected override ScaleTransform GetScaleTransform(object iconKind)
        {
            switch (iconKind)
            {
                case PackIconBootstrapIconsKind:
                case PackIconBoxIconsKind:
                case PackIconCodiconsKind:
                case PackIconCooliconsKind:
                case PackIconEvaIconsKind:
                case PackIconFileIconsKind:
                case PackIconFontaudioKind:
                case PackIconFontistoKind:
                case PackIconForkAwesomeKind:
                case PackIconJamIconsKind:
                case PackIconLucideKind:
                case PackIconRPGAwesomeKind:
                case PackIconTypiconsKind:
                case PackIconVaadinIconsKind:
                    return new ScaleTransform(1, -1);
                default:
                    return new ScaleTransform(1, 1);
            }
        }

        /// <inheritdoc />
        protected override DrawingGroup GetDrawingGroup(object iconKind, IBrush foregroundBrush, string path)
        {
            var geometryDrawing = new GeometryDrawing
            {
                Geometry = StreamGeometry.Parse(path)
            };

            switch (iconKind)
            {
                case PackIconFeatherIconsKind:
                {
                    var pen = new Pen(foregroundBrush, 2d)
                    {
                        LineCap = PenLineCap.Round,
                        LineJoin = PenLineJoin.Round,
                    };
                    geometryDrawing.Pen = pen;
                    break;
                }
                default:
                    geometryDrawing.Brush = foregroundBrush;
                    break;
            }

            var drawingGroup = new DrawingGroup
            {
                Children = { geometryDrawing },
                Transform = this.GetScaleTransform(iconKind)
            };

            return drawingGroup;
        }
    }
}
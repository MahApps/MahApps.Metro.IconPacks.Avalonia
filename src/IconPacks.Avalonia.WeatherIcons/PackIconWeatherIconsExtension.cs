using System;
using Avalonia.Markup.Xaml;
using IconPacks.Avalonia.Core;

namespace IconPacks.Avalonia.WeatherIcons
{
    public class WeatherIconsExtension : BasePackIconExtension
    {
        public WeatherIconsExtension()
        {
        }

        public WeatherIconsExtension(PackIconWeatherIconsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")] public PackIconWeatherIconsKind Kind { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.GetPackIcon<PackIconWeatherIcons, PackIconWeatherIconsKind>(this.Kind);
        }
    }
}
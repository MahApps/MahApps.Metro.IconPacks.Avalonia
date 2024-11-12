using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
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
    /// ******************************************
    /// This code is auto generated. Do not amend.
    /// ******************************************
    public static class PackIconControlDataFactory
    {
        public static Lazy<ReadOnlyDictionary<Enum, string>> DataIndex { get; }

        static PackIconControlDataFactory()
        {
            DataIndex = new Lazy<ReadOnlyDictionary<Enum, string>>(() => new ReadOnlyDictionary<Enum, string>(GetAllIcons()));
        }

        internal static IDictionary<Enum, string> GetAllIcons()
        {
            var allIcons = new ConcurrentDictionary<Enum, string>();
            Parallel.ForEach(PackIconDataFactory<PackIconBootstrapIconsKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconBoxIconsKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconCircumIconsKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconCodiconsKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconCooliconsKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconEntypoKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconEvaIconsKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconFeatherIconsKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconFileIconsKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconFontaudioKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconFontAwesomeKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconFontistoKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconForkAwesomeKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconGameIconsKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconIoniconsKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconJamIconsKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconLucideKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconMaterialKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconMaterialLightKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconMaterialDesignKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconMemoryIconsKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconMicronsKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconModernKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconOcticonsKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconPhosphorIconsKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconPicolIconsKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconPixelartIconsKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconRadixIconsKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconRemixIconKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconRPGAwesomeKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconSimpleIconsKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconTypiconsKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconUniconsKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconVaadinIconsKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconWeatherIconsKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            Parallel.ForEach(PackIconDataFactory<PackIconZondiconsKind>.Create(), icon => { allIcons.TryAdd(icon.Key, icon.Value); });
            return allIcons;
        }
    }
}
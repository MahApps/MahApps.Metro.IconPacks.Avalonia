using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Platform;

namespace IconPacks.Avalonia.Core
{
    public static class PackIconDataFactory<TEnum> where TEnum : struct, Enum
    {
        public static Lazy<IDictionary<TEnum, string>> DataIndex { get; }

        static PackIconDataFactory()
        {
            DataIndex = new Lazy<IDictionary<TEnum, string>>(Create);
        }

        public static IDictionary<TEnum, string> Create()
        {
            using var iconJsonStream = AssetLoader.Open(new Uri($"avares://{typeof(TEnum).Assembly.GetName().Name}/Resources/Icons.json"));
#pragma warning disable IL2026
            return new ReadOnlyDictionary<TEnum, string>(System.Text.Json.JsonSerializer.Deserialize<Dictionary<TEnum, string>>(iconJsonStream) ?? new Dictionary<TEnum, string>());
#pragma warning restore IL2026
        }
    }
}
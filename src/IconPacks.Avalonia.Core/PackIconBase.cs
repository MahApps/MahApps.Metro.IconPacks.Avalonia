using Avalonia.Controls;

namespace IconPacks.Avalonia
{
    public abstract class PackIconBase : PathIcon
    {
        protected internal abstract void SetKind<TKind>(TKind iconKind);
        protected abstract void UpdateData();
    }
}
namespace Delegates
{
    public interface IModifier
    {
        IPhoto Apply(IPhoto photo);
    }
}
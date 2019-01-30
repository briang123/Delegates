namespace Delegates
{
    public interface IPhoto
    {
        IPhoto Load(string path);
        void Save(IPhoto photo);
    }
}
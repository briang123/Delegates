using System;

namespace Delegates
{
    public class Photo : IPhoto
    {
        public IPhoto Load(string path)
        {
            return new Photo();
        }

        public void Save(IPhoto photo)
        {
            Console.WriteLine("Save modified photo...");
        }
    }
}
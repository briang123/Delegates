using System;

namespace Delegates
{
    public class Resize : IModifier
    {
        public IPhoto Apply(IPhoto photo)
        {
            Console.WriteLine("Resize photo...");
            return photo;
        }
    }
}
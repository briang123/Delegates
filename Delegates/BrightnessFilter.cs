using System;

namespace Delegates
{
    public class BrightnessFilter : IModifier
    {
        public IPhoto Apply(IPhoto photo)
        {
            Console.WriteLine("Apply brightness...");
            return photo;
        }
    }
}
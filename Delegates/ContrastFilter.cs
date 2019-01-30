using System;

namespace Delegates
{
    public class ContrastFilter : IModifier
    {
        public IPhoto Apply(IPhoto photo)
        {
            Console.WriteLine("Apply contrast...");
            return photo;
        }
    }
}
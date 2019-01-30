using System;

namespace Delegates
{
    public class RemoveRedEyeFilter : IModifier
    {
        public IPhoto Apply(IPhoto photo)
        {
            Console.WriteLine("Remove redeye...");
            return photo;
        }
    }
}
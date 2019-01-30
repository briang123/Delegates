using System;

namespace Delegates
{
    public class Program
    {
        public static void Main()
        {
            // create filters(modifiers)
            var contrastFilter = new ContrastFilter();
            var brightnessFilter = new BrightnessFilter();
            var resizer = new Resize();
            var redeyeFilter = new RemoveRedEyeFilter();

            // reference filter(modifier) functions
            PhotoProcessor.PhotoModifyHandler modifyHandler = contrastFilter.Apply;
            modifyHandler += brightnessFilter.Apply;
            modifyHandler += resizer.Apply;
            modifyHandler += redeyeFilter.Apply;

            // process the image passing the image and reference to all the filters(modifiers)
            var path = @"c:\image.png";
            var processor = new PhotoProcessor();
            processor.Process(path, modifyHandler);

            Console.WriteLine(@"Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
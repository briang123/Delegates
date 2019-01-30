# Delegates
Working with delegates in C#

1. A delegate is an object that knows how to call a method (or group of methods), and is a reference to a function
2. We use delegates for designing extensible and flexible applications

We implement to interfaces so the application is loosely coupled and can therefore create unit tests and mock more easily.

# Implementation

This implementation is demonstrating the usage of delegates via a Console app and below is the code that kicks off the run process.

```c#
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
```


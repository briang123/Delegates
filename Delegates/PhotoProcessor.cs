namespace Delegates
{
    public class PhotoProcessor
    {
        // create delegate that will be called in Process
        public delegate IPhoto PhotoModifyHandler(IPhoto photo);

        // process the image modifier routines and save
        public void Process(string path, PhotoModifyHandler modifyHandler)
        {
            var photo = new Photo();

            // create new instance of photo
            var image = photo.Load(path);

            // modify the image
            var modifiedImage = modifyHandler(image);

            // save the modified image
            photo.Save(modifiedImage);
        }
    }
}
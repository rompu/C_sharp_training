using System;

namespace Delegates
{
    class PhotoProcessor
    {
        //Here we make our own delegate:
        //public delegate void PhotoFilterHandler(Photo photo);




        public void Process(string path, Action<Photo> photoFilter )
        {
            Photo photo = Photo.Load(path);
            var filter = new PhotoFilters();

            filter.ApplyBrightness(photo);
            filter.Resize(photo);

            photoFilter(photo); 
            //instead of calling the methods directly here like photofilters.ApplyBrightness photofilters.ApplyContrast etc. we can use the delegate
            //This makes the code extensible because we can add methods to PhotoFilters (or other locations) class and point to these in the main program.

            photo.Save();
        }
            
          
    }
}

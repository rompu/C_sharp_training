using System;

namespace Delegates
{
    class Delegates
    {
        static void Main(string[] args)
        {

            var photoProcessor = new PhotoProcessor();
            var photoFilters = new PhotoFilters();


            //PhotoProcessor.PhotoFilterHandler filterHandler = photoFilters.ApplyBrightness;
            Action<Photo> filterHandler = photoFilters.ApplyBrightness; //Func is another delegate that returns a parameter, Action returns void
            filterHandler += photoFilters.Resize;
            filterHandler += photoFilters.ApplyContrast;
            //The group of methods can now be called in one go using: filterHandler(new Photo()); 

            photoProcessor.Process("C:/Photo", filterHandler);

            
        }
    }

}

using System;

namespace Delegates
{
    class PhotoFilters
    {
        public void ApplyBrightness<T>(T photo)
        {
            Console.WriteLine("Applying brightness");
        }        
        
        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Applying contrast");
        }
        
        public void Resize(Photo photo)
        {
            Console.WriteLine("Resizing");
        }
    }
}

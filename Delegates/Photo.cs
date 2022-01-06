using System;

namespace Delegates
{
    public class Photo
    {

        public static Photo Load(string path)
        {
            Console.WriteLine("Loading photo");
            return new Photo();
            
        }

        public void Save()
        {
            Console.WriteLine("Saving photo");

        }

    }
}

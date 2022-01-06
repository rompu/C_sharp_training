using System;

namespace Extension_methods
{
    class ProgramExtnensionMethods
    {
        static void Main(string[] args)
        {
            var post = "This is supposed to be a very long blog post bla bla bla";

            Console.WriteLine(post.Shorten(5));

                
        }
    }
}

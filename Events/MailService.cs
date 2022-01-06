using System;

namespace Events
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Mailservice: sending an email. "+args.Video.Title);
        }

        public void OnVideoLoaded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Mailservice: video has loaded. " + args.Video.Title);
        }
    }
}

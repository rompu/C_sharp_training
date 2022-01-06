using System;
using System.Threading;

namespace Events
{
    public class VideoEventArgs :EventArgs
    {
        public Video Video { get; set; }
    }
    class VideoEncoder
    {

        //1- Define a delegate
        //2- Define an event based on delegate
        //3- Raise the event

        //1
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public delegate void VideoEncodedEventHandler(object source, EventArgs args); this does not return the name of the video

        //2
        //public event VideoEncodedEventHandler VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoded; //generic form

        //alternatively, without passing the object: public event EventHandler VideoEncoded;

        //3
        protected virtual void OnVideoEncoded(Video video)
        {
            //check if there are subscribers
            if (VideoEncoded != null) //if there are subscribers VideoEncoded is not null
                VideoEncoded(this, new VideoEventArgs() {Video = video});
        }

        public event EventHandler<VideoEventArgs> VideoLoaded;


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video "+ video.Title);
            Thread.Sleep(3000);

            OnVideoEncoded(video); //this call raises the eveent
        }


    }
}

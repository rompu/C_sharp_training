using System;

namespace Events
{//Testing if the events can be separated from class that raises them   
    public class EventContainer
    {
        public event EventHandler<VideoEventArgs> VideoLoaded;
        
        internal virtual void OnVideoLoaded(Video video)
        {
            if (VideoLoaded != null)
                VideoLoaded(this, new VideoEventArgs() { Video = video });
        }
    }
}

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {

            var videoEncoder = new VideoEncoder();//publisher
            var mailService = new MailService();//subscriber1
            var messageService = new MessageService();//subscriber2
            var eventContainer = new EventContainer();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.VideoLoaded += mailService.OnVideoLoaded;

            videoEncoder.Encode(new Video() { Title = "Hamilton" });


        }



    }
}

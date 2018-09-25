using System;

namespace DelegationSept2018
{
    class Program
    {
        //https://www.youtube.com/watch?v=jQgwEsJISy0

        static void Main(string[] args)
        {
            var video = new Video(){Title = "Video 1"};
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            //the last part of thsi routine is a metho, however no brackets are needed as we are not makign a call to 
            //it... instead we are saying this is a refernewce / pointer to that method... which will be called elsewhere in the interaction
            //these two lines below have to be done in that order, otherwise teh video encoder will not have a subscriber ready
            //up to 19:19 on video
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }
    }



}

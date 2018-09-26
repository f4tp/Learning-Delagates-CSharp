using System;

namespace DelegationSept2018
{
    class Program
    {
        #region
        //https://www.youtube.com/watch?v=jQgwEsJISy0
        //this video was used to write thsi program
        //it told me that you can add many method calls to the delegate object
        //and call it once to call many methods, which is where the benefit is (observer pattern)...
        //... when many subscribers need to be notified of changes
        //it also told me that they are important in calling events
        //~TODO retrace and follow the method call stack

        //https://www.youtube.com/watch?v=ifbYA8hyvjc&t=320s
        // a delegate is a pointer / reference to a method...
        //a delegate is an object which can hold a reference to call a method of your choice.
        //define delagate
        //create new delegate object
        //pass it the method name you want it to call
        //call it by saying delagateInstanceName.Invoke();
        //the above informe dme that teh benefit of delagates was in callbacks?
        #endregion

        static void Main(string[] args)
        {
            var video = new Video(){Title = "Video 1"};
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var messageService = new MessageService();//subscriber
            #region
            //the last part of thsi routine is a metho, however no brackets are needed as we are not makign a call to 
            //it... instead we are saying this is a refernewce / pointer to that method... which will be called elsewhere in the interaction
            //these two lines below have to be done in that order, otherwise teh video encoder will not have a subscriber ready
            //up to 19:19 on video
            #endregion
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }
    }

    



}

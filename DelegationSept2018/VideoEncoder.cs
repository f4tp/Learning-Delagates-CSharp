using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DelegationSept2018
{
    class VideoEncoder
    {
        #region
        //Delegate srequire that you do 3 things:
        //1 - Define the delegate
        //2 - define an event based on that delegate
        //3 - Call the event

        //events ar etypes of delgates
        //by convention, delegate will be named by appending the method that is calling it, with 'Event Handler'...
        //... a sit is a type of event
        //object contains the source of the event
        //Event args hold additional data about the event you may want to send
        //Question - what additional data may I want to send across? - answer - teh VideoEventArgs class generate sthese... take a look
        //the delegate then is just a reference to a method thatcan be added to the VideoEncoder.VideoEncoded += messageService.OnVideoEncoded 
        //public delegate void VideoEncodedEventHandler(object sourcein, EventArgs args);
        //the above code was a more vague type of EventArgs objetc, we have created a new one to send across teh data
        //about teh video / about teh event that is being called
        //also, the OnVideoEncoded method call now needs a video so it has been updated... and in teh method declaration below - OnVideoEncoded(Video videoin)
        #endregion
            
        #region
        //public delegate void VideoEncodedEventHandler(object sourcein, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;
        //the above two lines of code area literal declartion, but it can be done with an event declaration in anewer version of .net framework... line below 
        //so thsi single line uses generics to pass the type in... so both lines of code can be done in one line of code
        #endregion
        public EventHandler<VideoEventArgs> VideoEncoded;
        #region
        //below is an example of creating an event / delgate without send an eventargs object weith details about teh object / event
        //public EventHandler VideoEncoded;
        #endregion
            
        public void Encode(Video videoIn)
        {
            Console.WriteLine("Encoding Video");
            Thread.Sleep(3000);
            OnVideoEncoded(videoIn);
        }
        #region
        //as per convention / by .Net framework, the called event from stage 3 should be 
        //protected virtual void
        #endregion
        protected virtual void OnVideoEncoded(Video videoin)
        {
            #region
            //notify subscribers... as per observer pattern
            //if there are no subscribers, then do not do anything... this is where 
            //dependencies are cut
            #endregion
            if (VideoEncoded != null)
            {
                #region
                //use EventArgs.Empty when you do not wish to send any further data about the event
                //Event args changed from VideoEncoded(this, EventArgs.Empty); to below because the object is now not an event args but a VideoEventArgs
                //new VideoEventArgs(){Video = videoin}); thsi means there is no construcrtor that accepts a video, but there is a video property for the VideoEventArgs, it can be initialised for it like this
                #endregion
                VideoEncoded(this, new VideoEventArgs(){Video = videoin});
            }
        }
    }
}

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
        //Question - what additional data may I want to send across?
        #endregion
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(VideoEncoder videoIn)
        {
            Console.WriteLine("Encoding Video");
            Thread.Sleep(3000);
            OnVideoEncoded();
        }
        #region
        //as per convention / by .Net framework, the called event from stage 3 should be 
        //protected virtual void
        #endregion
        protected virtual void OnVideoEncoded()
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
                #endregion
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}

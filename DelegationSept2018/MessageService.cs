using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace DelegationSept2018
{
     class MessageService
    {

        public void OnVideoEncoded(object sourcein, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: Sending a text messaage..." + e.Video.Title);
            Console.WriteLine("press any key to continue...");
            Console.ReadLine();
        }
    }
}

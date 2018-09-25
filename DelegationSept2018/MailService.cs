using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationSept2018
{
    class MailService
    {

         public void OnVideoEncoded(object sourcein, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending an email..." + e.Video.Title);
            
        }
    }
}

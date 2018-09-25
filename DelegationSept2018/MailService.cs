using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationSept2018
{
    class MailService
    {

        public void OnVideoEncoded(object sourcein, EventArgs e)
        {
            Console.WriteLine("MailService: Sending an email...");
            Console.WriteLine("press any key to continue...");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace NapierBankMessage
{
    abstract class Message
    {
        public String Header { get; set; }
       
        public String Sender { get; set; }
        public String Body { get; set; }


        public Message()
        {
            
        }

    }
}

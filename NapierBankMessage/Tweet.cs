using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapierBankMessage
{
    class Tweet : Message
    {
        private string _header;
        private string _sender;
        private string _body;
        public string Header { get; set; }

        public string Sender { get; set; }
        
        public string Body { get; set; }

        public Tweet()
        {
            
        }
    }
}

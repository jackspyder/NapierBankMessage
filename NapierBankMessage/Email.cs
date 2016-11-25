using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NapierBankMessage
{
    class Email
    {
        private string _header;
        private string _sender;
        private string _subject;
        private string _sort;
        private string _incident;
        private string _body;
        public string Header { get; set; }

        public string Sender { get; set; }

        public string Subject { get; set; }

        public string Sort { get; set; }

        public string Incident { get; set; }

        public string Body { get; set; }
        
        public Email()
        {
            
        }
    }
}

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
    class Email: Message
    {
        private string _subject;
        private string _sort;
        private string _incident;
        
        public string Subject { get; set; }

        public string Sort { get; set; }

        public string Incident { get; set; }
        
        public Email()
        {
            
        }
    }
}

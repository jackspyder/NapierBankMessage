﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapierBankMessage
{
    abstract class Message
    {
        public string Header { get; set; }

        public string Sender { get; set; }

        public string Body { get; set; }
    }
}

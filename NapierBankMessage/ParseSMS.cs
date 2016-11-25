using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NapierBankMessage
{
    class ParseSMS
    {
        internal static void parseSMS(string input)
        {
            string fileName = "sms.json";

            SMS sms = new SMS();

            var lines = input.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            sms.Header = lines.First();
            sms.Sender = lines.ElementAt(1);
            sms.Body = lines.ElementAt(2);

            Save.saveJson(sms, fileName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NapierBankMessage
{
    class ParseEmail
    {
        internal static void parseEmail(string input)
        {
            string fileName = "emails.json";
            Email email = new Email();

            var lines = input.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            if (lines.ElementAt(2).Contains("SIR"))
            {
                email.Header = lines.First();
                email.Sender = lines.ElementAt(1);
                email.Subject = lines.ElementAt(2);
                email.Sort = lines.ElementAt(3).Substring(11);
                email.Incident = lines.ElementAt(4).Substring(20);
                email.Body = MailExtractor.ExtractEmails(lines.ElementAt(5));
            }
            else
            {
                email.Header = lines.First();
                email.Sender = lines.ElementAt(1);
                email.Subject = lines.ElementAt(2);
                email.Body = MailExtractor.ExtractEmails(lines.ElementAt(3));
            }

            
            Save.saveJson(email, fileName);
        }
    }
}

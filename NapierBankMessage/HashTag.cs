using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace NapierBankMessage
{
    class HashTag
    {

        

      

        internal static void getHashTags(string body)
        {
            //use regex to find hashtags and save them.
            List<string> tags = new List<string>();

            var regex = new Regex(@"(?<=#)\w+");
            var matches = regex.Matches(body);


            foreach (Match m in matches)
            {
                tags.Add(m.Value);
            }
            
        }
    }
}

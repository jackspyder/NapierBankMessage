using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NapierBankMessage
{
    class ParseTweet
    {
        internal static void parseTweet(string input)
        {
            string fileName = "tweets.json";
            Tweet tweet = new Tweet();

            var lines = input.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            tweet.Header = lines.First();
            tweet.Sender = lines.ElementAt(1);
            tweet.Body = lines.ElementAt(2);

            HashTag.getHashTags(tweet.Body);

            Save.saveJson(tweet, fileName);
        }
    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace NapierBankMessage
{
    class Reader
    {
        internal static void readJson(string fileName)
        {
           
            
            using (StreamReader file = File.OpenText(@fileName))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject o = (JObject)JToken.ReadFrom(reader);
                JsonSerializer serializer = new JsonSerializer();
                
                SMS p = (SMS)serializer.Deserialize(new JTokenReader(o), typeof(SMS));


                MessageBox.Show(p.ToString());
            }

            
        }
    }
}

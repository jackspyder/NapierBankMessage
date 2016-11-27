using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NapierBankMessage
{
    class Save
    {
        public static void saveJson(object incoming, string fileName)
        {
            var list = new List<object>();

            
                list = JsonConvert.DeserializeObject<List<object>>(File.ReadAllText(fileName));
                list.Add(incoming);
           



            //var jsonToOutput = JsonConvert.SerializeObject(array, Formatting.Indented);

            using (StreamWriter writer = File.CreateText(fileName))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(writer, list);
            }


        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NapierBankMessage
{
    class Save
    {
        public static void saveJson(object message, string fileName)
        {
            String output = JsonConvert.SerializeObject(message, Formatting.Indented);

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(fileName, true))
            {
                file.WriteLine(output);
            }
        }
    }
}

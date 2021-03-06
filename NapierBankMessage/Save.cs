﻿using System;
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
            using (FileStream fs = File.Open(fileName, FileMode.Append))
            using (StreamWriter sw = new StreamWriter(fs))
            using (JsonWriter jw = new JsonTextWriter(sw))
            {
                jw.Formatting = Formatting.Indented;
                
                JsonSerializer serializer = new JsonSerializer();
                
                serializer.Serialize(jw, incoming);
            }
        }

    }
}

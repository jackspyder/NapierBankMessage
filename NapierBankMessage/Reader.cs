using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms.VisualStyles;
using System.Windows.Navigation;

namespace NapierBankMessage
{
    class Reader
    {
        internal static string readFile(string fileName)
        {
            string name = "h";
            var array = JArray.Parse(File.ReadAllText(fileName));

            //IList<> objectsList = new List<>();
            JArray objectsList = new JArray();

            foreach (var item in array)
            {
                
                    // CorrectElements
                    objectsList.Add(item);
                    Console.WriteLine(item);
            }

            return objectsList;


            
        }
    }
}

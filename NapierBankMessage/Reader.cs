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
        
        internal static string readFile (string fileName)
        {
            string text = System.IO.File.ReadAllText(@fileName);

            
            return text;

        }
    }
}

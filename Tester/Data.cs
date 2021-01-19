using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tester.Properties;

namespace Tester
{
    class Data
    {
        public static string LocationCompiler { get => Settings.Default["LocationCompiler"].ToString(); 
            set {
                Settings.Default["LocationCompiler"] = value;
                Settings.Default.Save();
            }  
        }

        public string CURRENT_DERECTORY { get; set; }
        public string NAME_PART { get; set; }
        public string EXT_PART { get; set; }

        public static void ClearLocation(Data data)
        {
            data.CURRENT_DERECTORY = "";
            data.NAME_PART = "";
            data.EXT_PART = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Mixer_WinForms
{
    
    internal class Settings
    {
        public string srcFileName = "";
        public string orderFileName = "";
        public string outDirectory = "";

        public bool isReady()
        {
            if (!string.IsNullOrEmpty(srcFileName) && !string.IsNullOrEmpty(orderFileName))
            {
               return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Mixer_WinForms
{
    
    internal class Settings
    {
        public string mainFileName = "";
        public string unoFileName = "";
        public string mertzFileName = "";
        public string orderFileName = "";
        public string outDirectory = "";

        public IProgress<int> setMaxProgress;
        public IProgress<int> setProgress;
        public IProgress<int> addProgress;
        public IProgress<string> setLogMessage;
        public IProgress<string> logMessage;
        public IProgress<bool> enableDisableControlls;

        public bool IsMainReady()
        {
            if (!string.IsNullOrEmpty(mainFileName) && !string.IsNullOrEmpty(orderFileName))
            {
               return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsUnoReady()
        {
            if (!string.IsNullOrEmpty(unoFileName) && !string.IsNullOrEmpty(orderFileName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsMertzReady()
        {
            if (!string.IsNullOrEmpty(mertzFileName) && !string.IsNullOrEmpty(orderFileName))
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

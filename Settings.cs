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

        public IProgress<int> setMaxProgress = new Progress<int>();
        public IProgress<int> setProgress = new Progress<int>();
        public IProgress<int> addProgress = new Progress<int>();
        public IProgress<string> setLogMessage = new Progress<string>();
        public IProgress<string> logMessage = new Progress<string>();
        public IProgress<bool> enableDisableControlls = new Progress<bool>();

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

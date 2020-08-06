using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filewatcher
{
    public static class Logger
    {
        public static void Log(string message)
        {
            try
            {
                string _message = String.Format("{0} {1}", message, Environment.NewLine);
                File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "fileWatcherLogFile.log", _message);
            }
            catch (Exception ex)
            {

            }
        }
    }
}

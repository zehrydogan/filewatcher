using System;

using System.IO;

namespace log
{
    public static class Log
    {

        public static void Log(string message)
        {
            try
            {
                string _message = String.Format("{0} {1}", message, Environment.NewLine);
                File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "filewatcherFile.log", _message);
            }
            catch (Exception ex)
            {

            }
        }
    }
}


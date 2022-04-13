using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;

namespace EngineWPF.Service
{
    public static class ErrorLogger
    {
        public static void LogActivity(string message, string status = null, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = null, [CallerFilePath] string file = null)
        {
            try
            {
                string LogFolder = AppDomain.CurrentDomain.BaseDirectory + Resource1.LogPath;
                
                if(string.IsNullOrEmpty(LogFolder))
                    LogFolder = Environment.CurrentDirectory;
                
                if(!Directory.Exists(LogFolder))
                    _ = Directory.CreateDirectory(LogFolder);
                
                string date = DateTime.Now.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
                string dateFolder = Path.Combine(LogFolder, date);
                LogFolder = dateFolder+ ".sk";
                
                string Msg = "";
                Msg = "\n---------------------------- Start -----------------------------------\n" + Environment.NewLine;
                Msg += "Time : " + DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + Environment.NewLine;
                if(status != null)
                    Msg += "Status : " + status + Environment.NewLine;
                Msg += "Message : " + message + Environment.NewLine;
                Msg += "Aufrufer : " + string.Format("File {0}:{1} method: {2}", file, lineNumber, caller);
                Msg += "\n---------------------------- End -----------------------------------\n" + Environment.NewLine;
                
                Log(LogFolder, Msg);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Log(string sFilePath, string sErrMsg) {
            StreamWriter sw;
            try{
                sw = File.AppendText(sFilePath);
                sw.WriteLine(sErrMsg);
                sw.Flush();
                sw.Close();
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}

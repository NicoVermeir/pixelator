namespace Pixelator.Logging
{
    internal class Param
    {
        internal enum LogType { Info, Warning, Error, SimpleError };

        internal LogType Logtype { get; set; }
        internal string Message { get; set; }   
        internal string Action { get; set; }
        internal string Obj { get; set; }   

        internal Param()
        {
            Logtype = LogType.Info;
            Message = "";
        }

        internal Param(LogType logType, string logMsg)
        {
            Logtype = logType;
            Message = logMsg;
        }

        internal Param(LogType logType, string logMsg, string logAction, string logObj)
        {
            Logtype = logType;
            Message = logMsg;
            Action = logAction;
            Obj = logObj;
        }
    }
}
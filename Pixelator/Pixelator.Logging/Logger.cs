using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Pixelator.Logging
{
    public class Logger : ILogger
    {
        private BlockingCollection<Param> _logs;

        public Logger()
        {
            _logs = new BlockingCollection<Param>();

            Task.Factory.StartNew(() =>
            {
                foreach (Param parameter in _logs.GetConsumingEnumerable())
                {
                    switch (parameter.Logtype)
                    {
                        case Param.LogType.Info:
                            Console.WriteLine($"[{LogTimeStamp()}] { parameter.Message}");
                            break;
                        case Param.LogType.Warning:
                            Console.WriteLine($"[{LogTimeStamp()}] * Warning {parameter.Message} (Action {parameter.Action} on {parameter.Obj})");
                            break;
                        case Param.LogType.Error:
                            Console.WriteLine($"[{LogTimeStamp()}] *** Error {parameter.Message} (Action {parameter.Action} on {parameter.Obj})");
                            break;
                        case Param.LogType.SimpleError:
                            Console.WriteLine($"[{LogTimeStamp()}] *** Error {parameter.Message}");
                            break;
                        default:
                            Console.WriteLine($"[{LogTimeStamp()}] { parameter.Message}");
                            break;
                    }
                }
            });
        }

        ~Logger()
        {
            // Free the writing thread
            _logs.CompleteAdding();
        }

        // Just call this method to log something (it will return quickly because it just queue the work with bc.Add(p))
        public void WriteLine(string msg)
        {
            _logs.Add(new Param(Param.LogType.Info, msg));
        }

        public void WriteError(string errorMsg)
        {
            _logs.Add(new Param(Param.LogType.SimpleError, errorMsg));
        }

        public void WriteError(string errorObject, string errorAction, string errorMsg)
        {
            _logs.Add(new Param(Param.LogType.Error, errorMsg, errorAction, errorObject));
        }

        public void WriteWarning(string errorObject, string errorAction, string errorMsg)
        {
            _logs.Add(new Param(Param.LogType.Warning, errorMsg, errorAction, errorObject));
        }

        string LogTimeStamp()
        {
            return DateTime.Now.ToShortTimeString();
        }
    }
}
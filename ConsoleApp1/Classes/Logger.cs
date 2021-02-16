using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_1.Classes
{
    public class Logger
    {
        private static Logger _logger;

        private static List<string> _logs;

        private Logger()
        {
        }

        public static List<string> Logs
        {
            get
            {
                if (_logs == null)
                {
                    _logs = new List<string>();
                }

                return _logs;
            }

            set
            {
                _logs = value;
            }
        }

        public static Logger GetLogger()
        {
            if (_logger == null)
            {
                _logger = new Logger();
            }

            return _logger;
        }

        public void Warning()
        {
            var text = DateTime.UtcNow + ": {Warning} :" + "{Skipped logic in method}";
            Console.WriteLine(text);
            Logs.Add(text);
            File.AppendAllText("log.txt", text + "\n");
        }

        public void Info()
        {
            var text = DateTime.UtcNow + ": {Info} :" + "{Start method}";
            Logs.Add(text);
            Console.WriteLine(text);
            File.AppendAllText("log.txt", text + "\n");
        }

        public void Error()
        {
            var text = DateTime.UtcNow + ": {Error} : " + "{I broke a logic}";
            Logs.Add(text);
            Console.WriteLine(text);
            File.AppendAllText("log.txt", text + "\n");
        }
    }
}
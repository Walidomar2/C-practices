namespace SingletonApp_NotThreadSafe
{
    public class MemoryLogger
    {
        private int _InfoCount;
        private int _WarnCount;
        private int _ErrorCount;

        private static MemoryLogger _instance = null!;

        private List<LogMessages> _logs = new List<LogMessages>();
        public IReadOnlyCollection<LogMessages> Logs => _logs;

        private MemoryLogger() { }

        public static MemoryLogger GetLogger
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MemoryLogger();
                }

                return _instance;
            }
        }

        private void Log(string message, LogType logType)
        {
            _logs.Add(new LogMessages
            {
                Message = message,
                LogType = logType,
                CreateAt = DateTime.Now
            });
        }

        public void LogInfo(string message)
        {
            ++_InfoCount;
            Log(message, LogType.INFO);
        }
        public void LogError(string message)
        {
            ++_ErrorCount;
            Log(message, LogType.ERROR);
        }
        public void LogWarning(string message)
        {
            ++_WarnCount;
            Log(message, LogType.WARNING);
        }

        public void ShowLog()
        {

            _logs.ForEach(x => Console.WriteLine(x));
            Console.WriteLine($"-------------------------------");

            Console.WriteLine($"Info ({_InfoCount}), Warning ({_WarnCount}), Error ({_ErrorCount})");
        }
    }
}
    
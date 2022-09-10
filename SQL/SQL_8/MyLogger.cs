namespace SQL_8
{
    public enum LogLevel
    {
        Information,
        Warning,
        Error
    }
    public static class MyLogger
    {
        private static string path { get; set; }
        static MyLogger() => path = "log.log";

        public static void SetPath(string pathToLogFile) => path = pathToLogFile;
        public static void Log(string? msg, LogLevel logLevel = LogLevel.Error) =>
            File.AppendAllText(path, $"{DateTime.Now.ToString()}:{DateTime.Now.Millisecond} | {logLevel} | {msg}\n");
    }
}
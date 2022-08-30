namespace SQL_7
{
    public enum AnalysisLevel
    {
        AllEvents,
        JustInformation,
        JustWarning,
        JustError
    }
    public enum DataOrder
    {
        Normal,
        Reverse
    }
    public static class MyAnalyzer
    {
        private static string path { get; set; }
        static MyAnalyzer() => path = "log.log";

        public static void SetPath(string pathToLogFile) => path = pathToLogFile;
        public static void Analyze(AnalysisLevel analysisLevel = AnalysisLevel.AllEvents, DataOrder dataOrder = DataOrder.Normal)
        {
            string[] readText = File.ReadAllLines(path);
            if (dataOrder == DataOrder.Reverse)
                Array.Reverse(readText);
            if (analysisLevel == AnalysisLevel.AllEvents)
                readText.ToList().ForEach(Console.WriteLine);
            else if (analysisLevel == AnalysisLevel.JustInformation)
            {
                var strings = readText.Where(s => s.Contains("| Information |"));
                strings.ToList().ForEach(Console.WriteLine);
            }
            else if (analysisLevel == AnalysisLevel.JustWarning)
            {
                var strings = readText.Where(s => s.Contains("| Warning |"));
                strings.ToList().ForEach(Console.WriteLine);
            }
            else if (analysisLevel == AnalysisLevel.JustError)
            {
                var strings = readText.Where(s => s.Contains("| Error |"));
                strings.ToList().ForEach(Console.WriteLine);
            }
        }
        public static void SearchByWord(string word, DataOrder dataOrder = DataOrder.Normal)
        {
            string[] readText = File.ReadAllLines(path);
            if (dataOrder == DataOrder.Reverse)
                Array.Reverse(readText);
            var strings = readText.Where(s => s.ToLower().Contains(word.ToLower()));
            strings.ToList().ForEach(Console.WriteLine);
        }
    }
}

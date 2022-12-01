using System.Diagnostics;

namespace EshopAPIEndpoint.specs.Performance
{
    public static class StopWatchHelper
    {
        static Stopwatch stopwatch = null;
        public static void StartStopwatch()
        {
            stopwatch = GetStopwatch();
            stopwatch.Start();
        }
        public static decimal StopStopwatch()
        {
            stopwatch.Stop();
            var timeSpan = stopwatch.ElapsedMilliseconds;
            stopwatch.Reset();
            return timeSpan;
        }
        private static Stopwatch GetStopwatch()
        {
            return new Stopwatch();
        }
    }
}

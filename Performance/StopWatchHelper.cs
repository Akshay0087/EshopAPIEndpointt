using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EshopAPIEndpoint.specs.Performance
{
    public class StopWatchHelper
    {
        Stopwatch stopwatch=new Stopwatch();

        public void StartStopwatch()
        {
            stopwatch.Start();
        }

        public int StopStopwatch()
        {
            stopwatch.Stop();
            var timeSpan = stopwatch.Elapsed;
            stopwatch.Reset();
            return Convert.ToInt32(timeSpan);
        }
    }
}

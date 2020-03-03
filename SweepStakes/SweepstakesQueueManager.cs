using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        //Members
        Queue<SweepStakes> queue;

        //Constructor
        public SweepstakesQueueManager()
        {
            queue = new Queue<SweepStakes>();
        }

        //Methods
        public SweepStakes GetSweepStakes()
        {
            SweepStakes sweepStakes = queue.Dequeue();
            return sweepStakes;
        }

        public void InsertSweepstakes(SweepStakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
    }
}

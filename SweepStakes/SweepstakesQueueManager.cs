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

        //Constructor
        public SweepstakesQueueManager()
        {

        }

        //Methods
        public SweepStakes GetSweepStakes()
        {
            string name = Console.ReadLine();
            SweepStakes newSweepStakes = new SweepStakes(name);
            return newSweepStakes;
        }

        public void InsertSweepstakes(SweepStakes sweepstakes)
        {

        }
    }
}
